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
    public partial class Classes : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public Classes()
        {
            InitializeComponent();
        }
        private void p_btnQuit_Click(object sender, EventArgs e)
        {
            Owner.Owner.Show();
            Owner.Dispose();
        }
        private void p_btnHome_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Dispose();
        }
        private void c_btnMine_Click(object sender, EventArgs e)
        {
            //刷新显示区域，显示我上传的课程
            c_lblOwner.Text = "是否考试";
            c_lblPeriod.Text = "推荐学时";
            c_flpClasses.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            string sql = "select c.c_name,c.c_credit,c_ifExam,c.c_recommendTime,c.c_id from Classes c,[user] u where u.u_id = c.u_id and u.u_id =" + Model.User.groupId + " order by c.c_time desc";
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //课程名
                    var lblMineClasses_name = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    lblMineClasses_name.Width = 100;
                    lblMineClasses_name.Font = font;
                    lblMineClasses_name.TextAlign = ContentAlignment.MiddleCenter;
                    //学分
                    var lblMineClasses_credit = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    lblMineClasses_credit.Width = 80;
                    lblMineClasses_credit.Font = font;
                    lblMineClasses_credit.TextAlign = ContentAlignment.MiddleCenter;
                    //开课部门
                    var lblMineClasses_ifExam = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    lblMineClasses_ifExam.Width = 80;
                    lblMineClasses_ifExam.Font = font;
                    lblMineClasses_ifExam.TextAlign = ContentAlignment.MiddleCenter;
                    //推荐学时
                    var lblMineClasses_recommendTime = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    lblMineClasses_recommendTime.Width = 80;
                    lblMineClasses_recommendTime.Font = font;
                    lblMineClasses_recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                    //编辑按钮，点击之后跳转到课程信息编辑页面
                    var btnCom = new Button { Text = "编辑" };
                    btnCom.Width = 50;
                    btnCom.Name = ds.Tables["user"].Rows[i][4].ToString();
                    btnCom.Click += new EventHandler(Edit_ClassesInfo);
                    btnCom.TextAlign = ContentAlignment.MiddleCenter;

                    c_flpClasses.Controls.Add(lblMineClasses_name);
                    c_flpClasses.Controls.Add(lblMineClasses_credit);
                    c_flpClasses.Controls.Add(lblMineClasses_ifExam);
                    c_flpClasses.Controls.Add(lblMineClasses_recommendTime);
                    c_flpClasses.Controls.Add(btnCom);
                    c_flpClasses.SetFlowBreak(btnCom, true);
                }
            }
            else
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 420;
                lbl_no_data.Height = 150;
                c_flpClasses.Controls.Add(lbl_no_data);
            }
        }
        private void Edit_ClassesInfo(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int.TryParse(button.Name, out LoadClasses.c_id);
            //Console.WriteLine("button里的课程id：" + button.Name);
            //选择课程，跳转到课程信息修改页面
            LoadClasses loadClasses = new LoadClasses();
            loadClasses.Owner = this;
            Hide();
            loadClasses.Show();
        }
        private void Check_ClassesInfo(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int.TryParse(button.Name, out ClaeeesInfo.c_id);
            //Console.WriteLine("button里的课程id：" + button.Name);
            //选择课程，跳转到课程详细信息页面
            ClaeeesInfo classesInfo = new ClaeeesInfo();
            classesInfo.Owner = this;
            Hide();
            classesInfo.Show();
        }
        private void Classes_Load(object sender, EventArgs e)
        {
            p_lblCurPerson.Text = Model.User.userName;//给界面的用户名字段赋值

            if (!Model.User.userType.Equals("员工"))
            {
                //权限控制：显示上传按钮loadClasses
                btn_loadClasses.Visible = true;
                //权限控制：显示我上传的课程按钮c_btnMine
                c_btnMine.Visible = true;
                //权限控制：显示课程安排按钮btn_lessonArrangement
                btn_ManagePlan.Visible = true;
                //权限控制：显示课程安排按钮btn_lessonArrangement
                btn_PlanArrangement.Visible = true;
            }
            c_btnAll_Click(sender, e);
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
                        string select_c_info = "select c.c_name,c.c_credit,g.g_group,c.c_recommendTime,c.c_id from classes c,[group] g where c.u_id = g.g_id and c_id = " + id;
                        showRecClassInfo(select_c_info);
                    }
                }
            }
            else
            {
                c_flp_recommend_c.Controls.Clear();
                string select_c_info = "select c.c_name,c.c_credit,g.g_group,c.c_recommendTime,c.c_id from classes c,[group] g where c.u_id = g.g_id and c_id in (select top 4 spl.c_id from user_plan_lines upl,study_plan_lines spl where upl.sp_line_id = spl.sp_line_id order by upl.up_line_score desc)";
                showRecClassInfo(select_c_info);
            }
        }
        private void showRecClassInfo(string sql)
        {
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                ////课程名
                //var lbl_c_name = new Label { Text = "课程名" };
                //lbl_c_name.Width = 100;
                //lbl_c_name.Font = font;
                //lbl_c_name.TextAlign = ContentAlignment.MiddleCenter;
                ////学分
                //var lbl_c_credit = new Label { Text = "学分" };
                //lbl_c_credit.Width = 80;
                //lbl_c_credit.Font = font;
                //lbl_c_credit.TextAlign = ContentAlignment.MiddleCenter;
                ////开课部门
                //var lbl_load_name = new Label { Text = "开课部门" };
                //lbl_load_name.Width = 80;
                //lbl_load_name.Font = font;
                //lbl_load_name.TextAlign = ContentAlignment.MiddleCenter;
                ////推荐学时
                //var lbl_c_recommendTime = new Label { Text = "推荐学时" };
                //lbl_c_recommendTime.Width = 80;
                //lbl_c_recommendTime.Font = font;
                //lbl_c_recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                ////推荐学时
                //var lbl_false = new Label { Text = "" };
                //lbl_false.Width = 50;
                //lbl_false.Font = font;
                //lbl_false.TextAlign = ContentAlignment.MiddleCenter;

                //c_flp_recommend_c.Controls.Add(lbl_c_name);
                //c_flp_recommend_c.Controls.Add(lbl_c_credit);
                //c_flp_recommend_c.Controls.Add(lbl_load_name);
                //c_flp_recommend_c.Controls.Add(lbl_c_recommendTime);
                //c_flp_recommend_c.Controls.Add(lbl_false);
                //c_flp_recommend_c.SetFlowBreak(lbl_false, true);
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //课程名
                    var c_name = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    c_name.Width = 100;
                    c_name.Font = font;
                    c_name.TextAlign = ContentAlignment.MiddleCenter;
                    //学分
                    var c_credit = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    c_credit.Width = 80;
                    c_credit.Font = font;
                    c_credit.TextAlign = ContentAlignment.MiddleCenter;
                    //开课人
                    var load_name = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    load_name.Width = 80;
                    load_name.Font = font;
                    load_name.TextAlign = ContentAlignment.MiddleCenter;
                    //推荐学时
                    var c_recommendTime = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    c_recommendTime.Width = 80;
                    c_recommendTime.Font = font;
                    c_recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                    //查看课程详细信息
                    var check_c_info = new Button { Text = "查看" };
                    check_c_info.Width = 50;
                    check_c_info.Name = ds.Tables["user"].Rows[i][4].ToString();
                    check_c_info.Click += new EventHandler(Check_ClassesInfo);

                    c_flp_recommend_c.Controls.Add(c_name);
                    c_flp_recommend_c.Controls.Add(c_credit);
                    c_flp_recommend_c.Controls.Add(load_name);
                    c_flp_recommend_c.Controls.Add(c_recommendTime);
                    c_flp_recommend_c.Controls.Add(check_c_info);
                    c_flp_recommend_c.SetFlowBreak(check_c_info, true);
                }
            }
            else
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 420;
                lbl_no_data.Height = 100;
                c_flp_recommend_c.Controls.Add(lbl_no_data);
            }
        }
        private void btn_loadClasses_Click(object sender, EventArgs e)
        {
            LoadClasses.c_id = -1;
            LoadClasses loadClasses = new LoadClasses();
            loadClasses.Owner = this;
            Hide();
            loadClasses.Show();
        }

        private void c_btnNecessary_Click(object sender, EventArgs e)
        {
            //刷新显示区域，显示必修学习计划
            c_lblOwner.Text = "开课部门";
            c_lblPeriod.Text = "课程学时";
            c_flpClasses.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            string sql = "select c.c_name,c.c_credit,(select g_group from [group] where g_id = c.u_id) AS g_name,c.c_recommendTime,c.c_id from Classes c where c_id in (select c_id from study_plan_lines where sp_line_id in (select sp_line_id from user_plan_lines where up_head_id in (select up_head_id from user_plan_header where up_property = 1 and u_id = " + Model.User.userId + "))) order by c.c_time desc";
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //课程名
                    var lblNecClasses_name = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    lblNecClasses_name.Width = 100;
                    lblNecClasses_name.Font = font;
                    lblNecClasses_name.TextAlign = ContentAlignment.MiddleCenter;
                    //学分
                    var lblNecClasses_credit = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    lblNecClasses_credit.Width = 80;
                    lblNecClasses_credit.Font = font;
                    lblNecClasses_credit.TextAlign = ContentAlignment.MiddleCenter;
                    //开课人
                    var lblNecClasses_u_name = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    lblNecClasses_u_name.Width = 80;
                    lblNecClasses_u_name.Font = font;
                    lblNecClasses_u_name.TextAlign = ContentAlignment.MiddleCenter;
                    //推荐学时
                    var lblNecClasses_recommendTime = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    lblNecClasses_recommendTime.Width = 80;
                    lblNecClasses_recommendTime.Font = font;
                    lblNecClasses_recommendTime.TextAlign = ContentAlignment.MiddleCenter;

                    var btnLearnClasses = new Button { Text = "学习" };
                    btnLearnClasses.Width = 50;
                    btnLearnClasses.Name = ds.Tables["user"].Rows[i][4].ToString();
                    //给“学习”按钮添加点击事件，跳转到学习页面
                    btnLearnClasses.Click += new EventHandler(btn_studyClass_Click);
                    btnLearnClasses.TextAlign = ContentAlignment.MiddleCenter;

                    c_flpClasses.Controls.Add(lblNecClasses_name);
                    c_flpClasses.Controls.Add(lblNecClasses_credit);
                    c_flpClasses.Controls.Add(lblNecClasses_u_name);
                    c_flpClasses.Controls.Add(lblNecClasses_recommendTime);
                    c_flpClasses.Controls.Add(btnLearnClasses);
                    c_flpClasses.SetFlowBreak(btnLearnClasses, true);
                }
            }
            else
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 420;
                lbl_no_data.Height = 100;
                c_flpClasses.Controls.Add(lbl_no_data);
            }

        }

        private void c_btnOptional_Click(object sender, EventArgs e)
        {
            //刷新显示区域，显示选修课程
            c_lblOwner.Text = "开课部门";
            c_lblPeriod.Text = "课程学时";
            c_flpClasses.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            string sql = "select c.c_name,c.c_credit,(select g_group from [group] where g_id = c.u_id) AS u_name,c.c_recommendTime,c.c_id from Classes c where c_id in (select c_id from study_plan_lines where sp_line_id in (select sp_line_id from user_plan_lines where up_head_id in (select up_head_id from user_plan_header where up_property = 2 and u_id = " + Model.User.userId + "))) order by c.c_time desc";
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //课程名
                    var lblSelectClasses_name = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    lblSelectClasses_name.Width = 100;
                    lblSelectClasses_name.Font = font;
                    lblSelectClasses_name.TextAlign = ContentAlignment.MiddleCenter;

                    //学分
                    var lblSelectClasses_credit = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    lblSelectClasses_credit.Width = 80;
                    lblSelectClasses_credit.Font = font;
                    lblSelectClasses_credit.TextAlign = ContentAlignment.MiddleCenter;

                    //开课部门
                    var lblSelectClasses_u_name = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    lblSelectClasses_u_name.Width = 80;
                    lblSelectClasses_u_name.Font = font;
                    lblSelectClasses_u_name.TextAlign = ContentAlignment.MiddleCenter;

                    //推荐学时
                    var lblSelectClasses_recommendTime = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    lblSelectClasses_recommendTime.Width = 50;
                    lblSelectClasses_recommendTime.Font = font;
                    lblSelectClasses_recommendTime.TextAlign = ContentAlignment.MiddleCenter;

                    var btnSelectClasses = new Button { Text = "学习" };
                    btnSelectClasses.Width = 40;
                    btnSelectClasses.Name = ds.Tables["user"].Rows[i][4].ToString();
                    btnSelectClasses.Click += new EventHandler(btn_studyClass_Click);

                    var btnDeleteClasses = new Button { Text = "退选" };
                    btnDeleteClasses.Width = 40;
                    btnDeleteClasses.Name = ds.Tables["user"].Rows[i][4].ToString();
                    //Console.WriteLine(btnDeleteClasses.Name);
                    btnDeleteClasses.Click += new EventHandler(btnDeleteClasses_Click);

                    c_flpClasses.Controls.Add(lblSelectClasses_name);
                    c_flpClasses.Controls.Add(lblSelectClasses_credit);
                    c_flpClasses.Controls.Add(lblSelectClasses_u_name);
                    c_flpClasses.Controls.Add(lblSelectClasses_recommendTime);
                    c_flpClasses.Controls.Add(btnSelectClasses);
                    c_flpClasses.Controls.Add(btnDeleteClasses);
                    c_flpClasses.SetFlowBreak(btnDeleteClasses, true);
                }
            }
            else
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 420;
                lbl_no_data.Height = 100;
                c_flpClasses.Controls.Add(lbl_no_data);
            }

        }
        private void btnDeleteClasses_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要退选吗", "判断", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Button button = (Button)sender;
                int c_id = -1;
                int.TryParse(button.Name, out c_id);
                //Console.WriteLine("按钮里的课程id："+ c_id);
                DataBaseConnection dc = new DataBaseConnection();
                //删除用户学习计划从表数据
                string delete_up_line_sql = "delete from user_plan_lines where sp_line_id in (select sp_line_id from study_plan_lines where c_id  = " + c_id + " and sp_head_id in (select sp_head_id from study_plan_header where sp_head_name = N'可选修课程')) and up_head_id in (select up_head_id from user_plan_header where u_id = " + Model.User.userId + ")";
                int flag1 = dc.ExecuteUpdate(delete_up_line_sql);

                //在用户学习计划头表中查询出相应的记录
                string select_up_head_id = "select up_head_id,pd_id from user_plan_header where not exists (select up_head_id from user_plan_lines where up_head_id in (select up_head_id from user_plan_header where u_id = " + Model.User.userId + "))";
                DataSet ds1 = dc.ExecuteQuery(select_up_head_id);
                //当用户学习计划行表中删除完之后再删除头表记录
                if (ds1.Tables["user"].Rows.Count > 0)
                {
                    int up_head_id = (int)ds1.Tables["user"].Rows[0][0];
                    int pd_id = (int)ds1.Tables["user"].Rows[0][1];
                    //删除用户学习计划头表数据
                    string delete_up_head_id = "delete from user_plan_header where up_head_id =" + up_head_id + " and u_id = " + Model.User.userId;
                    int flag2 = dc.ExecuteUpdate(delete_up_head_id);

                    //删除学习计划分配表数据
                    string delete_pd_sql = "delete from plan_destribute where pd_id =" + pd_id;
                    int flag3 = dc.ExecuteUpdate(delete_pd_sql);
                }
                if (flag1 == 1)
                {
                    MessageBox.Show("退选成功！");
                    //刷新选修课程列表
                    c_btnOptional_Click(sender, e);
                }
            }
        }
        private void c_btnAll_Click(object sender, EventArgs e)
        {
            c_lblOwner.Text = "开课部门";
            c_lblPeriod.Text = "课程学时";
            //刷新显示区域，显示全部课程
            c_flpClasses.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            string sql = "select c.c_name,c.c_credit,g.g_group,c.c_recommendTime,c.c_id from classes c,[group] g where g.g_id = c.u_id order by g.g_group, c.c_time desc";
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //课程名
                    var lblAllClasses_name = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    lblAllClasses_name.Width = 100;
                    lblAllClasses_name.Font = font;
                    lblAllClasses_name.TextAlign = ContentAlignment.MiddleCenter;
                    //学分
                    var lblAllClasses_credit = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    lblAllClasses_credit.Width = 80;
                    lblAllClasses_credit.Font = font;
                    lblAllClasses_credit.TextAlign = ContentAlignment.MiddleCenter;
                    //开课部门
                    var lblAllClasses_u_name = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    lblAllClasses_u_name.Width = 80;
                    lblAllClasses_u_name.Font = font;
                    lblAllClasses_u_name.TextAlign = ContentAlignment.MiddleCenter;
                    //推荐学时
                    var lblAllClasses_recommendTime = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    lblAllClasses_recommendTime.Width = 80;
                    lblAllClasses_recommendTime.Font = font;
                    lblAllClasses_recommendTime.TextAlign = ContentAlignment.MiddleCenter;

                    var btnAllClasses = new Button { Text = "查看" };
                    btnAllClasses.Width = 50;
                    btnAllClasses.Name = ds.Tables["user"].Rows[i][4].ToString();
                    btnAllClasses.Click += new EventHandler(Check_ClassesInfo);

                    btnAllClasses.TextAlign = ContentAlignment.MiddleCenter;
                    c_flpClasses.Controls.Add(lblAllClasses_name);
                    c_flpClasses.Controls.Add(lblAllClasses_credit);
                    c_flpClasses.Controls.Add(lblAllClasses_u_name);
                    c_flpClasses.Controls.Add(lblAllClasses_recommendTime);
                    c_flpClasses.Controls.Add(btnAllClasses);
                    c_flpClasses.SetFlowBreak(btnAllClasses, true);
                }
            }
            else
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 420;
                lbl_no_data.Height = 100;
                c_flpClasses.Controls.Add(lbl_no_data);
            }
        }
        private void btn_studyClass_Click(object sender, EventArgs e)
        {
            //选择课程，跳转到学习页面
            Button button = (Button)sender;
            int.TryParse(button.Name, out Learn.c_id);
            Learn learn = new Learn();
            learn.Owner = this;
            Hide();
            learn.Show();
        }
        private void btn_chooseLesson_Click(object sender, EventArgs e)
        {
            ChooseLesson chooseLesson = new ChooseLesson();
            chooseLesson.Owner = this;
            chooseLesson.Show();
            Hide();
        }
        private void btn_lessonArrangement_Click(object sender, EventArgs e)
        {
            //给组员安排课程，打开课程安排页面
            PlanArrangement lessonArrangement = new PlanArrangement();
            lessonArrangement.Owner = this;
            Hide();
            lessonArrangement.Show();
        }
        private void btn_ManagePlan_Click(object sender, EventArgs e)
        {
            //管理学习计划，打开学习计划页面
            StudyPlan studyPlan = new StudyPlan();
            studyPlan.Owner = this;
            Hide();
            studyPlan.Show();
        }
    }
}
