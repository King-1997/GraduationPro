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
    public partial class ChooseLesson : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public ChooseLesson()
        {
            InitializeComponent();
        }
        private List<string> classes = new List<string>();//保存选择的课程信息
        private void btn_Finding_Click(object sender, EventArgs e)
        {
            CL_flpClasses.Controls.Clear();
            //查找对应的课程，默认搜索所有课程
            String lesson_name = tBx_lessonName.Text;
            String lesson_owner = tBx_lessonOwner.Text;
            DataBaseConnection dc = new DataBaseConnection();
            String select_sql = "";
            if (string.IsNullOrEmpty(lesson_owner) && string.IsNullOrEmpty(lesson_name))
            {
                MessageBox.Show("请输入关键字！");
            }else
            {
                if (string.IsNullOrEmpty(lesson_name) && !string.IsNullOrEmpty(lesson_owner))
                {
                    select_sql += "select c.c_name,u.u_name,c.c_introduction,c.c_credit,c.c_recommendTime,c.c_ifExam,c.c_id from classes c,[User] u where c.u_id = u.u_id and u.u_name = N'" + lesson_owner + "' and c.c_id not in(select cd.c_id from ClassesDestribute cd where cd.cd_id in (select uc.cd_id from UserClasses uc, [User] u1 where u1.u_id = uc.u_id and u1.u_name =N'" + User.userName + "'))";
                }
                else if (string.IsNullOrEmpty(lesson_owner) && !string.IsNullOrEmpty(lesson_name))
                {
                    select_sql += "select c.c_name,u.u_name,c.c_introduction,c.c_credit,c.c_recommendTime,c.c_ifExam,c.c_id from classes c,[User] u where c.u_id = u.u_id and c.c_name like N'%" + lesson_name + "%' and c.c_id not in(select cd.c_id from ClassesDestribute cd where cd.cd_id in (select uc.cd_id from UserClasses uc, [User] u1 where u1.u_id = uc.u_id and u1.u_name =N'" + User.userName + "'))";
                }
                else if (!string.IsNullOrEmpty(lesson_owner) && !string.IsNullOrEmpty(lesson_name))
                {
                    select_sql += "select c.c_name,u.u_name,c.c_introduction,c.c_credit,c.c_recommendTime,c.c_ifExam,c.c_id from classes c,[User] u where c.u_id = u.u_id and c.c_name like N'%" + lesson_name + "%' and u.u_name = '" + lesson_owner + "' and c.c_id not in(select cd.c_id from ClassesDestribute cd where cd.cd_id in (select uc.cd_id from UserClasses uc, [User] u1 where u1.u_id = uc.u_id and u1.u_name =N'" + User.userName + "'))";
                }
                Console.WriteLine("查询语句：" + select_sql);
                DataSet ds = dc.ExecuteQuery(select_sql);
                //在窗口添加课程信息
                if (ds.Tables["user"].Rows.Count > 0)
                {
                    //课程名标签
                    var lbl_rb = new Label { Text = string.Concat("课程名称") };
                    lbl_rb.Font = font;
                    lbl_rb.Width = 100;
                    lbl_rb.TextAlign = ContentAlignment.MiddleCenter;
                    //上传人标签
                    var lbl_Loadman = new Label { Text = string.Concat("上传人") };
                    lbl_Loadman.Font = font;
                    lbl_Loadman.Width = 50;
                    lbl_Loadman.TextAlign = ContentAlignment.MiddleCenter;
                    //课程简介标签
                    var lbl_introducation = new Label { Text = string.Concat("课程简介") };
                    lbl_introducation.Font = font;
                    lbl_introducation.Width = 100;
                    lbl_introducation.TextAlign = ContentAlignment.MiddleCenter;
                    //课程学分标签
                    var lbl_credit = new Label { Text = string.Concat("课程学分") };
                    lbl_credit.Font = font;
                    lbl_credit.Width = 65;
                    lbl_credit.TextAlign = ContentAlignment.MiddleCenter;
                    //课程学时标签
                    var lbl_recommendTime = new Label { Text = string.Concat("课程学时") };
                    lbl_recommendTime.Font = font;
                    lbl_recommendTime.Width = 65;
                    lbl_recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                    //是否考试标签
                    var lbl_ifExam = new Label { Text = string.Concat("是否考试") };
                    lbl_ifExam.Font = font;
                    lbl_ifExam.Width = 65;
                    lbl_ifExam.TextAlign = ContentAlignment.MiddleCenter;
                    //查看课程信息标签
                    var lbl_btn_check = new Label { Text = "" };
                    lbl_btn_check.Width = 50;
                    lbl_btn_check.TextAlign = ContentAlignment.MiddleCenter;

                    CL_flpClasses.Controls.Add(lbl_rb);
                    CL_flpClasses.Controls.Add(lbl_Loadman);
                    CL_flpClasses.Controls.Add(lbl_introducation);
                    CL_flpClasses.Controls.Add(lbl_credit);
                    CL_flpClasses.Controls.Add(lbl_recommendTime);
                    CL_flpClasses.Controls.Add(lbl_ifExam);
                    CL_flpClasses.Controls.Add(lbl_btn_check);
                    CL_flpClasses.SetFlowBreak(lbl_btn_check, true);

                    for (var count = 0; count < ds.Tables["user"].Rows.Count; count++)
                    {
                        //课程名
                        var rb = new CheckBox { Text = string.Concat(ds.Tables["user"].Rows[count][0].ToString()) };
                        rb.Font = font;
                        rb.Width = 100;
                        rb.TextAlign = ContentAlignment.MiddleCenter;
                        //上传人
                        var Loadman = new Label { Text = string.Concat(ds.Tables["user"].Rows[count][1].ToString()) };
                        Loadman.Font = font;
                        Loadman.Width = 50;
                        Loadman.TextAlign = ContentAlignment.MiddleCenter;
                        //课程简介
                        var introducation = new Label { Text = string.Concat(ds.Tables["user"].Rows[count][2].ToString()) };
                        introducation.Font = font;
                        introducation.Width = 100;
                        introducation.TextAlign = ContentAlignment.MiddleCenter;
                        //课程学分
                        var credit = new Label { Text = string.Concat(ds.Tables["user"].Rows[count][3].ToString()) };
                        credit.Font = font;
                        credit.Width = 65;
                        credit.TextAlign = ContentAlignment.MiddleCenter;
                        //课程学时
                        var recommendTime = new Label { Text = string.Concat(ds.Tables["user"].Rows[count][4].ToString()) };
                        recommendTime.Font = font;
                        recommendTime.Width = 65;
                        recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                        //是否考试
                        var ifExam = new Label { Text = string.Concat(ds.Tables["user"].Rows[count][5].ToString()) };
                        ifExam.Font = font;
                        ifExam.Width = 65;
                        ifExam.TextAlign = ContentAlignment.MiddleCenter;
                        //查看课程信息
                        var btn_check = new Button { Text = "查看" };
                        btn_check.Width = 50;
                        ifExam.TextAlign = ContentAlignment.MiddleCenter;
                        btn_check.Name = ds.Tables["user"].Rows[count][6].ToString();
                        Console.WriteLine("button中的c_name："+ btn_check.Name);
                        btn_check.Click += new EventHandler(CheckClassesInfo);

                        CL_flpClasses.Controls.Add(rb);
                        CL_flpClasses.Controls.Add(Loadman);
                        CL_flpClasses.Controls.Add(introducation);
                        CL_flpClasses.Controls.Add(credit);
                        CL_flpClasses.Controls.Add(recommendTime);
                        CL_flpClasses.Controls.Add(ifExam);
                        CL_flpClasses.Controls.Add(btn_check);
                        CL_flpClasses.SetFlowBreak(btn_check, true);
                    }
                }
                else
                {
                    MessageBox.Show("未查询到相应的结果！");
                }
            }            
           }

        private void CheckClassesInfo(object sender , EventArgs e)
        {
            Button button = (Button)sender;
            Console.WriteLine("button里的classesname："+button.Name);
            int.TryParse(button.Name, out ClaeeesInfo.c_id);
            ClaeeesInfo classesInfo = new ClaeeesInfo();
            classesInfo.Owner = this;
            this.Hide();
            classesInfo.Show();
        }

        private void CheckClasses()
        {

        }
        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
            
        }

        private void ChooseLesson_Load(object sender, EventArgs e)
        {
            btn_AllClasses_Click(sender,e);
        }

        private void btn_AllClasses_Click(object sender, EventArgs e)
        {
            CL_flpClasses.Controls.Clear();

            DataBaseConnection dc = new DataBaseConnection();
            String sql = "select c.c_name,u.u_name,c.c_introduction,c.c_credit,c.c_recommendTime,c.c_ifExam from classes c ,[User] u where c.u_id = u.u_id and c.c_id not in(select cd.c_id from ClassesDestribute cd where cd.cd_id in (select uc.cd_id from UserClasses uc, [User] u1 where u1.u_id = uc.u_id and u1.u_name =N'" + User.userName + "'))";
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //课程名标签
                var lbl_rb = new Label { Text = string.Concat("课程名称") };
                lbl_rb.Font = font;
                lbl_rb.Width = 100;
                lbl_rb.TextAlign = ContentAlignment.MiddleCenter;
                //上传人标签
                var lbl_Loadman = new Label { Text = string.Concat("上传人") };
                lbl_Loadman.Font = font;
                lbl_Loadman.Width = 50;
                lbl_Loadman.TextAlign = ContentAlignment.MiddleCenter;
                //课程简介标签
                var lbl_introducation = new Label { Text = string.Concat("课程简介") };
                lbl_introducation.Font = font;
                lbl_introducation.Width = 100;
                lbl_introducation.TextAlign = ContentAlignment.MiddleCenter;
                //课程学分标签
                var lbl_credit = new Label { Text = string.Concat("课程学分") };
                lbl_credit.Font = font;
                lbl_credit.Width = 65;
                lbl_credit.TextAlign = ContentAlignment.MiddleCenter;
                //课程学时标签
                var lbl_recommendTime = new Label { Text = string.Concat("课程学时") };
                lbl_recommendTime.Font = font;
                lbl_recommendTime.Width = 65;
                lbl_recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                //是否考试标签
                var lbl_ifExam = new Label { Text = string.Concat("是否考试") };
                lbl_ifExam.Font = font;
                lbl_ifExam.Width = 65;
                lbl_ifExam.TextAlign = ContentAlignment.MiddleCenter;
                //查看课程信息标签
                var lbl_btn_check = new Label { Text = "" };
                lbl_btn_check.Width = 50;
                lbl_btn_check.TextAlign = ContentAlignment.MiddleCenter;

                CL_flpClasses.Controls.Add(lbl_rb);
                CL_flpClasses.Controls.Add(lbl_Loadman);
                CL_flpClasses.Controls.Add(lbl_introducation);
                CL_flpClasses.Controls.Add(lbl_credit);
                CL_flpClasses.Controls.Add(lbl_recommendTime);
                CL_flpClasses.Controls.Add(lbl_ifExam);
                CL_flpClasses.Controls.Add(lbl_btn_check);
                CL_flpClasses.SetFlowBreak(lbl_btn_check, true);
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //课程名
                    var rb = new CheckBox { Text = string.Concat(ds.Tables["user"].Rows[i][0].ToString()) };
                    rb.Font = font;
                    rb.Width = 100;
                    rb.TextAlign = ContentAlignment.MiddleCenter;
                    //上传人
                    var Loadman = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][1].ToString()) };
                    Loadman.Font = font;
                    Loadman.Width = 50;
                    Loadman.TextAlign = ContentAlignment.MiddleCenter;
                    //课程简介
                    var introducation = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][2].ToString()) };
                    introducation.Font = font;
                    introducation.Width = 100;
                    introducation.TextAlign = ContentAlignment.MiddleCenter;
                    //课程学分
                    var credit = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][3].ToString()) };
                    credit.Font = font;
                    credit.Width = 65;
                    credit.TextAlign = ContentAlignment.MiddleCenter;
                    //课程学分
                    var recommendTime = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][4].ToString()) };
                    recommendTime.Font = font;
                    recommendTime.Width = 65;
                    recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                    //是否考试
                    var ifExam = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][5].ToString()) };
                    ifExam.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                    ifExam.Width = 65;
                    ifExam.TextAlign = ContentAlignment.MiddleCenter;
                    //查看课程信息
                    var btn_check = new Button { Text = "查看" };                   
                    btn_check.Width = 50;
                    btn_check.Name = ds.Tables["user"].Rows[i][0].ToString();
                    btn_check.Click += new EventHandler(CheckClassesInfo);

                    CL_flpClasses.Controls.Add(rb);
                    CL_flpClasses.Controls.Add(Loadman);
                    CL_flpClasses.Controls.Add(introducation);
                    CL_flpClasses.Controls.Add(credit);
                    CL_flpClasses.Controls.Add(recommendTime);
                    CL_flpClasses.Controls.Add(ifExam);
                    CL_flpClasses.Controls.Add(btn_check);
                    CL_flpClasses.SetFlowBreak(btn_check, true);
                }
            }else
            {
                MessageBox.Show("数据库中没有课程信息！");
            }
        }

        private void btn_deteminal_Click(object sender, EventArgs e)
        {
            //遍历 
            foreach (Control ctl in CL_flpClasses.Controls)
            {
                if (ctl is CheckBox)
                {
                    if ((ctl as CheckBox).Checked == true)
                    {
                        //处理代码
                        classes.Add(ctl.Text);
                    }
                }
            }
            if (classes.Count > 0)
            {
                int i = 0;
                for (i = 0; i < classes.Count; i++)
                {
                    DataBaseConnection dc = new DataBaseConnection();
                    String select_sql = "select c_id ,c_recommendTime from Classes where c_name =N'" + classes[i] + "'";
                    DataSet ds = dc.ExecuteQuery(select_sql);
                    int c_id = (int)ds.Tables["user"].Rows[0][0];
                    int c_recommendTime = (int)ds.Tables["user"].Rows[0][1];
                    Console.WriteLine("C_id为：" + c_id + "\n 推荐学时为：" + c_recommendTime);
                    //String selectUser_sql = "select u_id from [User] where u_name =N'" + User.userName + "'";
                    //DataSet ds2 = dc.ExecuteQuery(selectUser_sql);
                    //int u_id = (int)ds2.Tables["user"].Rows[0][0];
                    Console.WriteLine("u_id为：" + User.userId);
                    String insert_dc_sql = "insert into ClassesDestribute values(" + c_id + "," + User.userId + "," + c_recommendTime + ",N'" + User.userName + "')";
                    dc.ExecuteUpdate(insert_dc_sql);
                    String select_cd_id = "select cd_id from ClassesDestribute where c_id =" + c_id + " and u_id = " + User.userId + " and cd_time = " + c_recommendTime + " and cd_name = N'" + User.userName + "'";
                    DataSet ds3 = dc.ExecuteQuery(select_cd_id);
                    int cd_id = (int)ds3.Tables["user"].Rows[0][0];
                    Console.WriteLine("cd_id为：" + cd_id);
                    String insert_uc_sql = "insert into UserClasses values (" + User.userId + "," + cd_id + ",0,0,2)";
                    dc.ExecuteUpdate(insert_uc_sql);                    
                }
                if (i == classes.Count)
                {
                    MessageBox.Show("选课成功！");
                    this.Owner.Show();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("系统错误！");
                }
            }
            else
            {
                MessageBox.Show("您当前未选课！");
            }           
        }
    }
}
