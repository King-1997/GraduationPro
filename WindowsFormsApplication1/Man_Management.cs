using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Man_Management : CCSkinMain
    {
        private string preboxname = null;//保存当前输入框的Name，当下拉框改变时更改
        private void Man_Management_Load(object sender, EventArgs e)
        {
            String sql = "select u.u_name,g.g_group,ut.ut_type,u.u_sex,u.u_account,u.u_credit, u.u_phone from [User] u, [group] g, userType ut where u.g_id = g.g_id and u.ut_id = ut.ut_id and u.ut_id != 1";
            WorkerShow(sql);
        }
        public Man_Management()
        {
            //查询下拉框
            InitializeComponent();
            cbB_findKey.Items.AddRange(new object[] { "按组别", "按姓名", "按工号","按入职时间" });
            cbB_findKey.SelectedIndex = 0;
            //查询组别下拉框

            DataBaseConnection dc = new DataBaseConnection();
            String sql = "select g_group from [group]";
            DataSet ds1 = dc.ExecuteQuery(sql);
            for (int i = 0; i < ds1.Tables["user"].Rows.Count; i++)
            {
                cBx_workertype.Items.Add(ds1.Tables["user"].Rows[i][0]);
            }
            cBx_workertype.SelectedIndex = 0;
            cBx_workertype.Location = tBx_findkeywords.Location;

            String sql_entryTime = "select max(u_entryTime),min(u_entryTime) from [User]";
            DataSet ds2 = dc.ExecuteQuery(sql_entryTime);
            String maxTime = ds2.Tables["user"].Rows[0][0].ToString();
            String minTime = ds2.Tables["user"].Rows[0][1].ToString();
            //Console.WriteLine("最大入职时间：" + maxTime);
            //Console.WriteLine("最小入职时间：" + minTime);
            int maxYear = 0;
            int.TryParse(maxTime.Substring(0,4), out maxYear);
            int minYear = 0;
            int.TryParse(minTime.Substring(0, 4), out minYear);
            for (int i = minYear;i<=maxYear;i++)
            {
                cBx_workerEntryYear.Items.Add(i);
            }            
            cBx_workerEntryYear.SelectedIndex = 0;
            cBx_workerEntryYear.Location = tBx_findkeywords.Location;

            for(int j = 1; j < 13; j++)
            {
                String month = "";
                if (j<10)
                {
                    month = "0" + j;
                }
                else
                {
                    month = j.ToString();
                }
                cBx_workerEntryMonth.Items.Add(month);
            }
            cBx_workerEntryMonth.SelectedIndex = 0;
            cBx_workerEntryMonth.Location = new Point(241, 74);
        }
        //查询
        public void btn_find_Click(object sender, EventArgs e)
        {
            //显示查询的员工
            //从tBx_findkeywords，cbB_findKey中获得查询关键词
            
            String keyword = tBx_findkeywords.Text;
            if (!cbB_findKey.Text.Equals("按组别") && !cbB_findKey.Text.Equals("按入职时间") && string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("请输入关键字！");
            }
            String KeyType = cbB_findKey.SelectedItem.ToString();
            String sql = "";
            Console.WriteLine("查询条件：" + KeyType);
            if (KeyType.Equals("按姓名"))
            {
                sql += "select u.u_name,g.g_group,ut.ut_type,u.u_sex,u.u_account,u.u_credit, u.u_phone from [User] u, [group] g, userType ut where u.g_id = g.g_id and u.ut_id = ut.ut_id and u.ut_id != 1 and u.u_name like N'%" + keyword + "%'";
            }
            else if (KeyType.Equals("按组别"))
            {
               String keyword1 = cBx_workertype.SelectedItem.ToString();
                sql += "select u.u_name,g.g_group,ut.ut_type,u.u_sex,u.u_account,u.u_credit, u.u_phone from [User] u, [group] g, userType ut where u.g_id = g.g_id and u.ut_id = ut.ut_id and u.ut_id != 1 and g.g_group = N'" + keyword1 + "'";
            }
            else if (KeyType.Equals("按工号"))
            {
                sql += "select u.u_name,g.g_group,ut.ut_type,u.u_sex,u.u_account,u.u_credit, u.u_phone from [User] u, [group] g, userType ut where u.g_id = g.g_id and u.ut_id = ut.ut_id and u.ut_id != 1 and u.u_account = '" + keyword + "'";
            }else if (KeyType.Equals("按入职时间"))
            {
                DateTime entryTime1 = new DateTime(2018,8,25);
                DateTime entryTime2 = new DateTime(2018,8,26);
                int year = 0;
                int.TryParse(cBx_workerEntryYear.SelectedItem.ToString(), out year);

                int month = 0;
                int.TryParse(cBx_workerEntryMonth.SelectedItem.ToString(), out month);
                if(month == 02)//当月份为2时判断是否为闰年
                {
                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                    {

                        entryTime1 = Convert.ToDateTime(year + "-" + month + "-01");
                        entryTime2 = Convert.ToDateTime(year + "-" + month + "-29");
                    }
                    else
                    {
                        entryTime1 = Convert.ToDateTime(year + "-" + month + "-01");
                        entryTime2 = Convert.ToDateTime(year + "-" + month + "-28");
                    }
                }
                //当月份不为2时，判断当前月份是否有31号
                if (month == 01 || month == 03 || month == 05 || month == 07 || month == 08 || month == 10 || month == 12)
                {
                    entryTime1 = Convert.ToDateTime(year + "-" + month + "-01");
                    entryTime2 = Convert.ToDateTime(year + "-" + month + "-31");
                }
                else
                {
                    entryTime1 = Convert.ToDateTime(year + "-" + month + "-01");
                    entryTime2 = Convert.ToDateTime(year + "-" + month + "-30");
                }

                sql += "select u.u_name,g.g_group,ut.ut_type,u.u_sex,u.u_account,u.u_credit, u.u_phone from [User] u, [group] g, userType ut where u.g_id = g.g_id and u.ut_id = ut.ut_id and u.ut_id != 1 and u.u_entryTime >= '" + entryTime1+ "' and u.u_entryTime <= '"+ entryTime2+ "'";
            }
            Console.WriteLine("查询语句：" + sql);
            WorkerShow(sql);
        }
        //返回上一界面
        private void btn_add_Click(object sender, EventArgs e)
        {
            //打开员工信息界面Workers'mwssage，隐藏本界面
            Workers_message.u_account = null;
            Workers_message.u_id = 0;
            Workers_message workers_message = new Workers_message();
            workers_message.Owner = this;
            workers_message.Show();
            this.Hide();
        }
        //界面初始化

        //当界面跳转回来时，刷新显示界面fLP_workers
        public void WorkerShow(String sql)
        {
            //刷新显示窗口
            fLP_workers.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            //从数据库中提取数据
            DataSet ds = dc.ExecuteQuery(sql);
            //显示在fLP_workers上
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //员工姓名标签
                var lbl_name = new Label { Text = string.Concat("姓名") };
                lbl_name.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lbl_name.TextAlign = ContentAlignment.MiddleCenter;
                lbl_name.Width = 60;
                //所在分组标签
                var lbl_group = new Label { Text = string.Concat("所在分组") };
                lbl_group.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lbl_group.TextAlign = ContentAlignment.MiddleCenter;
                lbl_group.Width = 70;
                //员工类型标签
                var lbl_ut = new Label { Text = string.Concat("员工类型") };
                lbl_ut.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lbl_ut.TextAlign = ContentAlignment.MiddleCenter;
                lbl_ut.Width = 60;
                //性别标签
                var lbl_sex = new Label { Text = string.Concat("性别") };
                lbl_sex.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lbl_sex.TextAlign = ContentAlignment.MiddleCenter;
                lbl_sex.Width = 30;
                //工号标签
                var lbl_account = new Label { Text = string.Concat("工号") };
                lbl_account.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lbl_account.Width = 100;
                lbl_account.TextAlign = ContentAlignment.MiddleCenter;
                //学分标签
                var lbl_credit = new Label { Text = string.Concat("学分") };
                lbl_credit.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lbl_credit.TextAlign = ContentAlignment.MiddleCenter;
                lbl_credit.Width = 30;
                //电话号码标签
                var lbl_phone = new Label { Text = string.Concat("电话号码") };
                lbl_phone.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lbl_phone.TextAlign = ContentAlignment.MiddleCenter;
                lbl_phone.Width = 80;
                //编辑按钮标签
                var lbl_btn_edit = new Label { Text = "" };
                lbl_btn_edit.Width = 40;
                lbl_btn_edit.Click += new EventHandler(Edit_Click);
                //删除按钮标签
                var lbl_btn_delete = new Label { Text = "" };
                lbl_btn_delete.Width = 40;

                fLP_workers.Controls.Add(lbl_name);
                fLP_workers.Controls.Add(lbl_group);
                fLP_workers.Controls.Add(lbl_ut);
                fLP_workers.Controls.Add(lbl_sex);
                fLP_workers.Controls.Add(lbl_account);
                fLP_workers.Controls.Add(lbl_credit);
                fLP_workers.Controls.Add(lbl_phone);
                fLP_workers.Controls.Add(lbl_btn_edit);
                fLP_workers.Controls.Add(lbl_btn_delete);
                fLP_workers.SetFlowBreak(lbl_btn_delete, true);

                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //员工姓名
                    var u_name = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][0].ToString()) };
                    u_name.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    u_name.TextAlign = ContentAlignment.MiddleCenter;
                    u_name.Width = 60;
                    //所在分组
                    var u_group = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][1].ToString()) };
                    u_group.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    u_group.TextAlign = ContentAlignment.MiddleCenter;
                    u_group.Width = 70;
                    //员工类型
                    var u_ut = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][2].ToString()) };
                    u_ut.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    u_ut.TextAlign = ContentAlignment.MiddleCenter;
                    u_ut.Width = 60;
                    //性别
                    var u_sex = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][3].ToString()) };
                    u_sex.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    u_sex.TextAlign = ContentAlignment.MiddleCenter;
                    u_sex.Width = 30;
                    //工号
                    var u_account = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][4].ToString()) };
                    u_account.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    u_account.Width = 100;
                    u_account.TextAlign = ContentAlignment.MiddleCenter;
                    //学分
                    var u_credit = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][5].ToString()) };
                    u_credit.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    u_credit.TextAlign = ContentAlignment.MiddleCenter;
                    u_credit.Width = 30;
                    //电话号码
                    var u_phone = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][6].ToString()) };
                    u_phone.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    u_phone.TextAlign = ContentAlignment.MiddleCenter;
                    u_phone.Width = 80;
                    //编辑按钮
                    var btn_edit = new Button { Text = "编辑" };                   
                    btn_edit.Name = u_account.Text;
                    btn_edit.Width = 40;
                    btn_edit.Click += new EventHandler(Edit_Click);
                    //删除按钮
                    var btn_delete = new Button { Text = "删除" };                   
                    btn_delete.Name = u_account.Text;
                    btn_delete.Width = 40;
                    btn_delete.Click += new EventHandler(Delete_Click);
                    fLP_workers.Controls.Add(u_name);
                    fLP_workers.Controls.Add(u_group);
                    fLP_workers.Controls.Add(u_ut); 
                    fLP_workers.Controls.Add(u_sex);
                    fLP_workers.Controls.Add(u_account);
                    fLP_workers.Controls.Add(u_credit);
                    fLP_workers.Controls.Add(u_phone);
                    fLP_workers.Controls.Add(btn_edit);
                    fLP_workers.Controls.Add(btn_delete);
                    fLP_workers.SetFlowBreak(btn_delete, true);
                }
            }
            else
            {
                //员工姓名
                var lbl_no_user = new Label { Text = string.Concat("抱歉，当前没有查询到任何数据！") };
                lbl_no_user.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lbl_no_user.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_user.Width = 579;
                lbl_no_user.Height = 150;
                fLP_workers.Controls.Add(lbl_no_user);
            }         
        }
        //编辑员工信息
        private void Edit_Click(object sender, EventArgs e)
        {
            //数据库操作
            Button button = (Button)sender;
            String u_account = button.Name;
            Console.WriteLine("按钮里的员工工号：" + u_account);
            Workers_message.u_account = u_account;
            Workers_message workers_message = new Workers_message();
            workers_message.Owner = this;
            workers_message.Show();
            this.Hide();
        }

        //删除员工信息
        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要删除该员工吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
            {
                //数据库操作
                Button button = (Button)sender;
                String u_account = button.Name;
                Console.WriteLine("按钮里的员工工号：" + u_account);
                //确认删除
                //数据库操作
                DataBaseConnection dc = new DataBaseConnection();
                String sql = "delete from [User] where u_account = '" + u_account + "'";
                int flag = dc.ExecuteUpdate(sql);
                if (flag == 1)
                {
                    MessageBox.Show("删除员工成功！");
                    //刷新员工信息
                    if (string.IsNullOrEmpty(tBx_findkeywords.Text))
                    {
                        Man_Management_Load(sender, e);
                    }else
                    {
                        btn_find_Click(sender,e);
                    }
                    
                }
                else
                {
                    MessageBox.Show("系统错误！");
                }
            }
        }

        private void MM_btnReturn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
        //cbB_findKey当下拉框值改变时  
        //生成新的下拉框
        private void cbB_findKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (preboxname == "cBx_workertype")
            {
                this.Controls.Remove(cBx_workertype);
            }                
            else if(preboxname == "cBx_workerentryTime")
            {
                this.Controls.Remove(cBx_workerEntryYear);
                this.Controls.Remove(cBx_workerEntryMonth);
            }
            else
            {
                this.Controls.Remove(tBx_findkeywords);
            }
                
            //当下拉框选为“按组别”选择时，输入框变为组别下拉框
            if (cbB_findKey.Text == "按组别")
            {
                //生成新的下拉框
                preboxname = "cBx_workertype";
                this.Controls.Add(cBx_workertype);
                this.Controls.Remove(cBx_workerEntryYear);
                this.Controls.Remove(cBx_workerEntryMonth);
            }
            else if(cbB_findKey.Text == "按入职时间")
            {
                //生成新的下拉框
                preboxname = "cBx_workerentryTime";
                this.Controls.Remove(cBx_workertype);
                this.Controls.Add(cBx_workerEntryYear);
                this.Controls.Add(cBx_workerEntryMonth);
            }
            else
            {
                preboxname = "tBx_findkeywords";
                this.Controls.Add(tBx_findkeywords);
            }
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//新建打开文件对话框
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//设置初始文件目录
            ofd.Filter = "Excel文件（*.xls；*.xlsx）|*.xls;*.xlsx|所有文件|*.*";//设置打开文件类型
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = ofd.FileName;//FileName就是要打开的文件路径
                                               //下边可以添加用户代码
                this.MM_lblFileName.Visible = true;
                MM_lblFileName.Text = FileName;
            }
        }

        private void MM_btnInput_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataBaseConnection dc = new DataBaseConnection();
            String usertype = "",usergroup = "",u_account,u_password,u_name,u_sex,u_idNum,u_phone;
            DateTime u_entryTime = new DateTime(2018, 8, 25);
            int ut_id = 0,g_id = 0,count=0;
            String select_ut_id, select_g_id, insert_user;
            String fileAdd = this.MM_lblFileName.Text;
            Console.WriteLine("文件路径" + fileAdd);
            if (!string.IsNullOrEmpty(fileAdd))
            {
                dt = Excel.ImportExcelFile(fileAdd);

                //遍历datatable
                if (dt.Rows.Count>0)
                {
                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        usertype = dt.Rows[i][1].ToString();
                        select_ut_id = "select ut_id from usertype where ut_type ='" + usertype + "'";
                        Console.WriteLine(select_ut_id);
                        DataSet ds = dc.ExecuteQuery(select_ut_id);
                        //ut_id = Convert.ToInt32(ds.Tables["user"].Rows[0][0].ToString());
                        int.TryParse(ds.Tables["user"].Rows[0][0].ToString(), out ut_id);//将查出来的ut_id转换成int类型


                        usergroup = dt.Rows[i][2].ToString();
                        select_g_id = "select g_id from [group] where g_group = '" + usergroup + "'";
                        Console.WriteLine(select_g_id);
                        DataSet ds1 = dc.ExecuteQuery(select_g_id);
                        Console.WriteLine("g_id的值：" + ds1.Tables["user"].Rows[0][0].ToString());
                        //g_id = Convert.ToInt32(ds1.Tables["user"].Rows[0][0].ToString());
                        int.TryParse(ds1.Tables["user"].Rows[0][0].ToString(), out g_id);


                        u_account = dt.Rows[i][3].ToString();
                        u_password = dt.Rows[i][4].ToString();
                        u_name = dt.Rows[i][5].ToString();
                        u_sex = dt.Rows[i][6].ToString();
                        u_idNum = dt.Rows[i][7].ToString();
                        u_phone = dt.Rows[i][8].ToString();
                        u_entryTime = Convert.ToDateTime(dt.Rows[i][9].ToString());
                        //Console.WriteLine("u_entryTime:"+u_entryTime);

                        insert_user = "insert into [User] values (" + ut_id + "," + g_id + ",'" + u_account + "','" + u_password + "','" + u_name + "','" + u_sex + "',0,'" + u_idNum + "','" + u_phone + "','" + u_entryTime + "')";
                        Console.WriteLine(insert_user);
                        int flag = dc.ExecuteUpdate(insert_user);
                        if (flag != 0)
                        {
                            count++;
                        }
                        usertype = "";
                        usergroup = "";
                        ut_id = 0;
                        g_id = 0;
                    }
                    if (count == dt.Rows.Count - 1)
                    {
                        MessageBox.Show("批量导入成功！");
                        //刷新员工信息
                        if (string.IsNullOrEmpty(tBx_findkeywords.Text))
                        {
                            Man_Management_Load(sender, e);
                        }
                        else
                        {
                            btn_find_Click(sender, e);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Excel表中无数据！");
                }
                
            }
            else
            {
                MessageBox.Show("请选择文件！");
            }
        }
    }
}
