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
        private List<string> classes_id = new List<string>();//保存选择的课程id信息
        private List<string> classes_name = new List<string>();//保存选择的课程Name信息
        private void btn_Finding_Click(object sender, EventArgs e)
        {
            //查找对应的课程，默认搜索所有课程
            String lesson_name = tBx_lessonName.Text;
            String lesson_owner = tBx_lessonOwner.Text;

            String select_sql = "";
            if (string.IsNullOrEmpty(lesson_owner) && string.IsNullOrEmpty(lesson_name))
            {
                //MessageBox.Show("请输入关键字！");
                ChooseLesson_Load(sender, e);
            }
            else
            {
                if (string.IsNullOrEmpty(lesson_name) && !string.IsNullOrEmpty(lesson_owner))
                {
                    select_sql += "select c.c_name,u.u_name,c.c_introduction,c.c_credit,c.c_recommendTime,c.c_ifExam,c.c_id from classes c,[User] u where c.u_id = u.u_id and u.u_name like N'%" + lesson_owner + "%' and c_id in (select c_id from study_plan_lines where sp_head_id = (select sp_head_id from study_plan_header where sp_head_name = N'可选修课程')) and c_id not in(select c_id from study_plan_lines where sp_line_id in(select sp_line_id from user_plan_lines where up_head_id in (select up_head_id from user_plan_header where u_id = " + Model.User.userId + ")))";
                }
                else if (string.IsNullOrEmpty(lesson_owner) && !string.IsNullOrEmpty(lesson_name))
                {
                    select_sql += "select c.c_name,u.u_name,c.c_introduction,c.c_credit,c.c_recommendTime,c.c_ifExam,c.c_id from classes c,[User] u where c.u_id = u.u_id and c.c_name like N'%" + lesson_name + "%' and c_id in (select c_id from study_plan_lines where sp_head_id = (select sp_head_id from study_plan_header where sp_head_name = N'可选修课程')) and c_id not in(select c_id from study_plan_lines where sp_line_id in(select sp_line_id from user_plan_lines where up_head_id in (select up_head_id from user_plan_header where u_id = " + Model.User.userId + ")))";
                }
                else if (!string.IsNullOrEmpty(lesson_owner) && !string.IsNullOrEmpty(lesson_name))
                {
                    select_sql += "select c.c_name,u.u_name,c.c_introduction,c.c_credit,c.c_recommendTime,c.c_ifExam,c.c_id from classes c,[User] u where c.u_id = u.u_id and c.c_name like N'%" + lesson_name + "%' and u.u_name like '%" + lesson_owner + "%' and c_id in (select c_id from study_plan_lines where sp_head_id = (select sp_head_id from study_plan_header where sp_head_name = N'可选修课程')) and c_id not in(select c_id from study_plan_lines where sp_line_id in(select sp_line_id from user_plan_lines where up_head_id in (select up_head_id from user_plan_header where u_id = " + Model.User.userId + ")))";
                }
                //Console.WriteLine("查询语句：" + select_sql);
                ShowLessons(select_sql);
                //在窗口添加课程信息                
            }
        }
        private void ShowLessons(String sql)
        {
            //在新增数据时先将原有数据清空
            CL_flpClasses.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //课程名标签
                var lbl_rb = new Label { Text = "课程名称" };
                lbl_rb.Font = font;
                lbl_rb.Width = 100;
                lbl_rb.TextAlign = ContentAlignment.MiddleCenter;
                //上传人标签
                var lbl_Loadman = new Label { Text = "上传人" };
                lbl_Loadman.Font = font;
                lbl_Loadman.Width = 50;
                lbl_Loadman.TextAlign = ContentAlignment.MiddleCenter;
                //课程简介标签
                var lbl_introducation = new Label { Text = "课程简介" };
                lbl_introducation.Font = font;
                lbl_introducation.Width = 100;
                lbl_introducation.TextAlign = ContentAlignment.MiddleCenter;
                //课程学分标签
                var lbl_credit = new Label { Text = "课程学分" };
                lbl_credit.Font = font;
                lbl_credit.Width = 65;
                lbl_credit.TextAlign = ContentAlignment.MiddleCenter;
                //课程学时标签
                var lbl_recommendTime = new Label { Text = "课程学时" };
                lbl_recommendTime.Font = font;
                lbl_recommendTime.Width = 65;
                lbl_recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                //是否考试标签
                var lbl_ifExam = new Label { Text = "是否考试" };
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
                    var rb = new CheckBox { Text = ds.Tables["user"].Rows[count][0].ToString() };
                    rb.Font = font;
                    rb.Width = 100;
                    rb.Name = ds.Tables["user"].Rows[count][6].ToString();
                    rb.TextAlign = ContentAlignment.MiddleCenter;
                    //上传人
                    var Loadman = new Label { Text = ds.Tables["user"].Rows[count][1].ToString() };
                    Loadman.Font = font;
                    Loadman.Width = 50;
                    Loadman.TextAlign = ContentAlignment.MiddleCenter;
                    //课程简介
                    var introducation = new Label { Text = ds.Tables["user"].Rows[count][2].ToString() };
                    introducation.Font = font;
                    introducation.Width = 100;
                    introducation.TextAlign = ContentAlignment.MiddleCenter;
                    //课程学分
                    var credit = new Label { Text = ds.Tables["user"].Rows[count][3].ToString() };
                    credit.Font = font;
                    credit.Width = 65;
                    credit.TextAlign = ContentAlignment.MiddleCenter;
                    //课程学时
                    var recommendTime = new Label { Text = ds.Tables["user"].Rows[count][4].ToString() };
                    recommendTime.Font = font;
                    recommendTime.Width = 65;
                    recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                    //是否考试
                    var ifExam = new Label { Text = ds.Tables["user"].Rows[count][5].ToString() };
                    ifExam.Font = font;
                    ifExam.Width = 65;
                    ifExam.TextAlign = ContentAlignment.MiddleCenter;
                    //查看课程信息
                    var btn_check = new Button { Text = "查看" };
                    btn_check.Width = 50;
                    ifExam.TextAlign = ContentAlignment.MiddleCenter;
                    btn_check.Name = ds.Tables["user"].Rows[count][6].ToString();
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
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 579;
                lbl_no_data.Height = 150;
                CL_flpClasses.Controls.Add(lbl_no_data);
            }
        }
        private void CheckClassesInfo(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //Console.WriteLine("button里的classesname："+button.Name);
            int.TryParse(button.Name, out ClaeeesInfo.c_id);
            ClaeeesInfo classesInfo = new ClaeeesInfo();
            classesInfo.Owner = this;
            Hide();
            classesInfo.Show();
        }
        private void btn_return_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Dispose();
        }

        private void ChooseLesson_Load(object sender, EventArgs e)
        {
            classes_id.Clear();
            classes_name.Clear();
            btn_AllClasses_Click(sender, e);
            showRecommendInfo();
        }
        private void showRecommendInfo()
        {
            string u_id = Model.User.userId.ToString();
            //运行推荐算法文件，获取推荐课程id
            string c_ids = Tools.ConnectLongDistanceDesk.RunCmd(u_id);
            if (c_ids.Length > 0)
            {
                c_ids = c_ids.Substring(0, c_ids.Length - 1);
                string[] res = c_ids.Split(',');
                DataBaseConnection dc = new DataBaseConnection();
                foreach (string id in res)
                {
                    string select_c_id = "select spl.c_id from user_plan_header uph,user_plan_lines upl,study_plan_lines spl where uph.up_head_id = upl.up_head_id and upl.sp_line_id = spl.sp_line_id and uph.u_id = " + Model.User.userId + " and spl.c_id = " + id;
                    DataSet ds = dc.ExecuteQuery(select_c_id);
                    if (ds.Tables["user"].Rows.Count == 0)
                    {
                        //Console.WriteLine("推荐课程的id:" + id);
                        string select_c_info = "select c.c_name, u.u_name, c.c_introduction, c.c_credit, c.c_recommendTime, c.c_ifExam, c.c_id from classes c,[User] u where c.u_id = u.u_id and c_id = " + id;
                        ShowRecInfo(select_c_info);
                    }
                }
            }
            else
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 450;
                lbl_no_data.Height = 100;
                cl_flp_recommend_c.Controls.Add(lbl_no_data);
            }
        }
        private void ShowRecInfo(String sql)
        {
            cl_flp_recommend_c.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                ////课程名标签
                //var lbl_rb = new Label { Text = "课程名称" };
                //lbl_rb.Font = font;
                //lbl_rb.Width = 100;
                //lbl_rb.TextAlign = ContentAlignment.MiddleCenter;
                ////上传人标签
                //var lbl_Loadman = new Label { Text = "上传人" };
                //lbl_Loadman.Font = font;
                //lbl_Loadman.Width = 50;
                //lbl_Loadman.TextAlign = ContentAlignment.MiddleCenter;
                ////课程简介标签
                //var lbl_introducation = new Label { Text = "课程简介" };
                //lbl_introducation.Font = font;
                //lbl_introducation.Width = 100;
                //lbl_introducation.TextAlign = ContentAlignment.MiddleCenter;
                ////课程学分标签
                //var lbl_credit = new Label { Text = "课程学分" };
                //lbl_credit.Font = font;
                //lbl_credit.Width = 65;
                //lbl_credit.TextAlign = ContentAlignment.MiddleCenter;
                ////课程学时标签
                //var lbl_recommendTime = new Label { Text = "课程学时" };
                //lbl_recommendTime.Font = font;
                //lbl_recommendTime.Width = 65;
                //lbl_recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                ////是否考试标签
                //var lbl_ifExam = new Label { Text = "是否考试" };
                //lbl_ifExam.Font = font;
                //lbl_ifExam.Width = 65;
                //lbl_ifExam.TextAlign = ContentAlignment.MiddleCenter;
                ////查看课程信息标签
                //var lbl_btn_check = new Label { Text = "" };
                //lbl_btn_check.Width = 50;
                //lbl_btn_check.TextAlign = ContentAlignment.MiddleCenter;

                //cl_flp_recommend_c.Controls.Add(lbl_rb);
                //cl_flp_recommend_c.Controls.Add(lbl_Loadman);
                //cl_flp_recommend_c.Controls.Add(lbl_introducation);
                //cl_flp_recommend_c.Controls.Add(lbl_credit);
                //cl_flp_recommend_c.Controls.Add(lbl_recommendTime);
                //cl_flp_recommend_c.Controls.Add(lbl_ifExam);
                //cl_flp_recommend_c.Controls.Add(lbl_btn_check);
                //cl_flp_recommend_c.SetFlowBreak(lbl_btn_check, true);

                for (var count = 0; count < ds.Tables["user"].Rows.Count; count++)
                {
                    //课程名
                    var rb = new CheckBox { Text = ds.Tables["user"].Rows[count][0].ToString() };
                    rb.Font = font;
                    rb.Width = 100;
                    rb.Name = ds.Tables["user"].Rows[count][6].ToString();
                    rb.TextAlign = ContentAlignment.MiddleCenter;
                    //上传人
                    var Loadman = new Label { Text = ds.Tables["user"].Rows[count][1].ToString() };
                    Loadman.Font = font;
                    Loadman.Width = 50;
                    Loadman.TextAlign = ContentAlignment.MiddleCenter;
                    //课程简介
                    var introducation = new Label { Text = ds.Tables["user"].Rows[count][2].ToString() };
                    introducation.Font = font;
                    introducation.Width = 100;
                    introducation.TextAlign = ContentAlignment.MiddleCenter;
                    //课程学分
                    var credit = new Label { Text = ds.Tables["user"].Rows[count][3].ToString() };
                    credit.Font = font;
                    credit.Width = 65;
                    credit.TextAlign = ContentAlignment.MiddleCenter;
                    //课程学时
                    var recommendTime = new Label { Text = ds.Tables["user"].Rows[count][4].ToString() };
                    recommendTime.Font = font;
                    recommendTime.Width = 65;
                    recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                    //是否考试
                    var ifExam = new Label { Text = ds.Tables["user"].Rows[count][5].ToString() };
                    ifExam.Font = font;
                    ifExam.Width = 65;
                    ifExam.TextAlign = ContentAlignment.MiddleCenter;
                    //查看课程信息
                    var btn_check = new Button { Text = "查看" };
                    btn_check.Width = 50;
                    ifExam.TextAlign = ContentAlignment.MiddleCenter;
                    btn_check.Name = ds.Tables["user"].Rows[count][6].ToString();
                    //Console.WriteLine("button中的c_name：" + btn_check.Name);
                    btn_check.Click += new EventHandler(CheckClassesInfo);

                    cl_flp_recommend_c.Controls.Add(rb);
                    cl_flp_recommend_c.Controls.Add(Loadman);
                    cl_flp_recommend_c.Controls.Add(introducation);
                    cl_flp_recommend_c.Controls.Add(credit);
                    cl_flp_recommend_c.Controls.Add(recommendTime);
                    cl_flp_recommend_c.Controls.Add(ifExam);
                    cl_flp_recommend_c.Controls.Add(btn_check);
                    cl_flp_recommend_c.SetFlowBreak(btn_check, true);
                }
            }
            else
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 579;
                lbl_no_data.Height = 150;
                cl_flp_recommend_c.Controls.Add(lbl_no_data);
            }
        }
        private void btn_AllClasses_Click(object sender, EventArgs e)
        {
            //CL_flpClasses.Controls.Clear();
            String sql = "SELECT c.c_name, u.u_name, c.c_introduction, c.c_credit, c.c_recommendTime, c.c_ifExam, c.c_id FROM Classes AS c INNER JOIN [User] AS u ON c.u_id = u.u_id where c_id in (select c_id from study_plan_lines where sp_head_id = (select sp_head_id from study_plan_header where sp_head_name = N'可选修课程')) and c_id not in(select c_id from study_plan_lines where sp_line_id in(select sp_line_id from user_plan_lines where up_head_id in (select up_head_id from user_plan_header where u_id = " + Model.User.userId + ")))";
            ShowLessons(sql);
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
                        classes_id.Add(ctl.Name);
                        classes_name.Add(ctl.Text);
                    }
                }
            }
            classes_id = classes_id.Distinct().ToList();
            classes_name = classes_name.Distinct().ToList();
            DataBaseConnection dc = new DataBaseConnection();
            if (classes_id.Count > 0)
            {
                int i, flag1 = 0, flag2 = 0, flag3 = 0;
                for (i = 0; i < classes_id.Count; i++)
                {
                    int c_id = 0;
                    int.TryParse(classes_id[i], out c_id);

                    //在可选修课程中查找所勾选课程的计划id
                    string select_dc_sql = "select sp_line_id from study_plan_lines where c_id =" + c_id + " and sp_head_id in (select sp_head_id from study_plan_header where sp_head_name = N'可选修课程')";
                    DataSet ds1 = dc.ExecuteQuery(select_dc_sql);
                    int sp_line_id = (int)ds1.Tables["user"].Rows[0][0];
                    if (ds1.Tables["user"].Rows.Count > 0)
                    {
                        //使用序列查询出pd_id的下一个值
                        string select_pd_id = "select next value for plan_destribute_s";
                        DataSet ds2 = dc.ExecuteQuery(select_pd_id);
                        int pd_id = 0;
                        int.TryParse(ds2.Tables["user"].Rows[0][0].ToString(), out pd_id);
                        //使用序列查询出up_head_id的下一个值
                        string select_up_head_id = "select next value for user_plan_header_s";
                        DataSet ds3 = dc.ExecuteQuery(select_up_head_id);
                        int up_head_id = 0;
                        int.TryParse(ds3.Tables["user"].Rows[0][0].ToString(), out up_head_id);
                        //执行insert语句插入到学习计划分配表
                        string insert_pd_sql = "insert into plan_destribute values(" + pd_id + "," + Model.User.userId + ",(select sp_head_id from study_plan_header where sp_head_name = '可选修课程'),N'" + Model.User.userId + "',CONVERT(varchar(100),GETDATE(),20))";
                        flag1 = dc.ExecuteUpdate(insert_pd_sql);
                        //执行insert语句插入到用户学习计划头表
                        string insert_up_head_sql = "insert into user_plan_header values (" + up_head_id + "," + Model.User.userId + "," + pd_id + ",0,0,2)";
                        flag2 = dc.ExecuteUpdate(insert_up_head_sql);
                        //执行insert语句插入到用户学习计划从表
                        string insert_up_line_sql = "insert into user_plan_lines values (next value for user_plan_lines_s," + sp_line_id + "," + up_head_id + ",0,null,0,null)";
                        flag3 = dc.ExecuteUpdate(insert_up_line_sql);
                    }
                }
                if (flag1 == 1 && flag2 == 1 && flag3 == 1 && i == classes_id.Count)
                {
                    MessageBox.Show("选课成功！");
                    Owner.Show();
                    Dispose();
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
            ChooseLesson_Load(sender, e);
        }
    }
}
