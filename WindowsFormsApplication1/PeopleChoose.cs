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
    public partial class PeopleChoose : CCSkinMain
    {
        private string preboxname = null;//保存当前输入框的Name，当下拉框改变时更改

        public PeopleChoose()
        {
            //查询下拉框
            InitializeComponent();
            preboxname = tBx_findkeywords.Name;
            cbB_findKey.Items.AddRange(new object[] { "按组别", "按工号", "按性别", "按电话号码","按入职时间" });
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
            cBx_workertype.Size = tBx_findkeywords.Size;
            cBx_workertype.Location = tBx_findkeywords.Location;

            String sql_entryTime = "select max(u_entryTime),min(u_entryTime) from [User]";
            DataSet ds2 = dc.ExecuteQuery(sql_entryTime);
            String maxTime = ds2.Tables["user"].Rows[0][0].ToString();
            String minTime = ds2.Tables["user"].Rows[0][1].ToString();
            /*Console.WriteLine("最大入职时间：" + maxTime);
            Console.WriteLine("最小入职时间：" + minTime);*/
            int maxYear = 0;
            int.TryParse(maxTime.Substring(0, 4), out maxYear);
            int minYear = 0;
            int.TryParse(minTime.Substring(0, 4), out minYear);
            for (int i = minYear; i <= maxYear; i++)
            {
                cBx_workerEntryYear.Items.Add(i);
            }
            cBx_workerEntryYear.SelectedIndex = 0;
            cBx_workerEntryYear.Location = tBx_findkeywords.Location;

            for (int j = 1; j < 13; j++)
            {
                String month = "";
                if (j < 10)
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
            cBx_workerEntryMonth.Location = new Point(213, 98);
        }
        public List<string> people = new List<string>();//保存选择的员工信息
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            //刷新窗口
            fLP_people.Controls.Clear();
            //获取查询条件：tBx_findkeywords，cbB_findKey
            String KeyWord = tBx_findkeywords.Text;
            String KeyType = cbB_findKey.SelectedItem.ToString();
            if (!cbB_findKey.Text.Equals("按组别") && string.IsNullOrEmpty(KeyWord))
            {
                MessageBox.Show("请输入关键字！");
            }
            //从数据库查找数据
            DataBaseConnection dc = new DataBaseConnection();
            String sql = "";
            Console.WriteLine("查询条件：" + KeyType);
            if (KeyType.Equals("按组别"))
            {
                String KeyWord1 = cBx_workertype.SelectedItem.ToString();
                sql += "select u.u_name,g.g_group,u.u_sex,u_phone,u_entryTime from [User] u,[group] g where u.g_id = g.g_id and g.g_group = N'" + KeyWord1 + "'";
            }
            else if (KeyType.Equals("按工号"))
            {
                sql += "select u.u_name,g.g_group,u.u_sex,u_phone,u_entryTime from [User] u,[group] g where u.g_id = g.g_id and u.u_account = '" + KeyWord + "'";
            }
            else if (KeyType.Equals("按性别"))
            {
                sql += "select u.u_name,g.g_group,u.u_sex,u_phone,u_entryTime from [User] u,[group] g where u.g_id = g.g_id and u.u_sex = N'" + KeyWord + "'";
            }
            else if (KeyType.Equals("按电话号码"))
            {
                sql += "select u.u_name,g.g_group,u.u_sex,u_phone,u_entryTime from [User] u,[group] g where u.g_id = g.g_id and u.u_phone = " + KeyWord;
            }
            else if (KeyType.Equals("按入职时间"))
            {
                DateTime entryTime1 = new DateTime(2018, 8, 25);
                DateTime entryTime2 = new DateTime(2018, 8, 26);
                int year = 0;
                int.TryParse(cBx_workerEntryYear.SelectedItem.ToString(), out year);

                int month = 0;
                int.TryParse(cBx_workerEntryMonth.SelectedItem.ToString(), out month);
                if (month == 02)//当月份为2时判断是否为闰年
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
                sql += "select u.u_name,g.g_group,u.u_sex,u_phone,u_entryTime from [User] u,[group] g where u.g_id = g.g_id and u.u_entryTime >= '" + entryTime1 + "' and u.u_entryTime <= '" + entryTime2 + "'";
            }
                Console.WriteLine("查询语句：" + sql);
                WorkerShow(sql);           
        }
        private void WorkerShow(string sql)
        {
            //刷新显示窗口
            fLP_people.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            //从数据库中提取数据
            DataSet ds = dc.ExecuteQuery(sql);
            //在窗口添加员工信息
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //姓名标签
                var u_name_lbl = new Label { Text = string.Concat("姓名") };
                u_name_lbl.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                u_name_lbl.TextAlign = ContentAlignment.MiddleCenter;

                //所在分组标签
                var u_group_lbl = new Label { Text = string.Concat("所在分组") };
                u_group_lbl.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                u_group_lbl.TextAlign = ContentAlignment.MiddleCenter;

                //性别标签
                var u_sex_lbl = new Label { Text = string.Concat("性别") };
                u_sex_lbl.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                u_sex_lbl.TextAlign = ContentAlignment.MiddleCenter;

                //电话号码标签
                var u_phone_lbl = new Label { Text = string.Concat("电话号码") };
                u_phone_lbl.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                u_phone_lbl.TextAlign = ContentAlignment.MiddleCenter;

                //入职时间标签
                var u_entryTime_lbl = new Label { Text = string.Concat("入职时间") };
                u_entryTime_lbl.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                u_entryTime_lbl.TextAlign = ContentAlignment.MiddleCenter;

                fLP_people.Controls.Add(u_name_lbl);
                fLP_people.Controls.Add(u_group_lbl);
                fLP_people.Controls.Add(u_sex_lbl);
                fLP_people.Controls.Add(u_phone_lbl);
                fLP_people.Controls.Add(u_entryTime_lbl);
                fLP_people.SetFlowBreak(u_entryTime_lbl, true);
                for (var count = 0; count < ds.Tables["user"].Rows.Count; count++)
                {
                    //姓名
                    var u_name = new CheckBox { Text = string.Concat(ds.Tables["user"].Rows[count][0].ToString()) };
                    u_name.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    u_name.TextAlign = ContentAlignment.MiddleCenter;

                    //所在分组
                    var u_group = new Label { Text = string.Concat(ds.Tables["user"].Rows[count][1].ToString()) };
                    u_group.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    u_group.TextAlign = ContentAlignment.MiddleCenter;

                    //性别
                    var u_sex = new Label { Text = string.Concat(ds.Tables["user"].Rows[count][2].ToString()) };
                    u_sex.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    u_sex.TextAlign = ContentAlignment.MiddleCenter;

                    //电话号码
                    var u_phone = new Label { Text = string.Concat(ds.Tables["user"].Rows[count][3].ToString()) };
                    u_phone.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    u_phone.TextAlign = ContentAlignment.MiddleCenter;

                    //入职时间
                    var u_entryTime = new Label { Text = string.Concat(ds.Tables["user"].Rows[count][4].ToString()) };
                    u_entryTime.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    u_entryTime.TextAlign = ContentAlignment.MiddleCenter;

                    fLP_people.Controls.Add(u_name);
                    fLP_people.Controls.Add(u_group);
                    fLP_people.Controls.Add(u_sex);
                    fLP_people.Controls.Add(u_phone);
                    fLP_people.Controls.Add(u_entryTime);
                    fLP_people.SetFlowBreak(u_entryTime, true);
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
                fLP_people.Controls.Add(lbl_no_user);
            }
        }
        private void btn_oK_Click(object sender, EventArgs e)
        {
            //遍历 
            foreach (Control ctl in fLP_people.Controls)
            {
                if (ctl is CheckBox)
                {
                    if ((ctl as CheckBox).Checked == true)
                    {
                        //处理代码
                        people.Add(ctl.Text);
                    }
                }
            }
            //传递选定的员工
            if (LessonArrangement.people == null || people == null)
                LessonArrangement.people = people;
            else
                LessonArrangement.people.AddRange(people);
            //获取上一界面的已选员工窗口
            LessonArrangement lesson = (LessonArrangement)this.Owner;
            lesson.PeopleShow();

            this.Owner.Show();
            this.Dispose();

        }

        private void PeopleChoose_Load(object sender, EventArgs e)
        {
            fLP_people.Controls.Clear();

            DataBaseConnection dc = new DataBaseConnection();
            String sql = "select u.u_name,g.g_group,u.u_sex,u_phone,u_entryTime from [User] u,[group] g where u.g_id = g.g_id";
            WorkerShow(sql);
        }
        //cbB_findKey当下拉框值改变时  
        //生成新的下拉框
        private void cbB_findKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (preboxname == "cBx_workertype")
            {
                this.Controls.Remove(cBx_workertype);
            }
            else if (preboxname == "cBx_workerentryTime")
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
            else if (cbB_findKey.Text == "按入职时间")
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

        private void cBx_allSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (cBx_allSelect.Checked ==true )
            {
                foreach (Control peo in fLP_people.Controls)
                {
                    if (peo is CheckBox )
                    {
                        CheckBox ple = (CheckBox)peo;
                        ple.Checked = true;
                    }
                }
            }
            else
            {
                foreach (Control peo in fLP_people.Controls)
                {
                    if (peo is CheckBox)
                    {
                        CheckBox ple = (CheckBox)peo;
                        ple.Checked = false;
                    }
                }
            }
        }
    }
}
