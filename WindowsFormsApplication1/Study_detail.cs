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
    public partial class Study_detail : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        DataBaseConnection dc = new DataBaseConnection();
        public Study_detail()
        {
            InitializeComponent();
            cbB_findKey.Items.AddRange(new object[] { "按部门", "按姓名" });
            cbB_findKey.SelectedIndex = 0;
            string sql = "select g_group from [group]";
            DataSet ds = dc.ExecuteQuery(sql);
            for (int i = 0; i < ds.Tables["user"].Rows.Count; i++)
            {
                sd_ccb_group.Items.Add(ds.Tables["user"].Rows[i][0]);
            }
            sd_ccb_group.SelectedIndex = 1;
        }
        private void btn_classunfinished_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (Model.User.groupId == 0)
            {
                sql += "select (select u_name from [User] where u_id = sph.u_id), sph.sp_head_name,spl,c.c_name,c.c_credit,(select u.u_name from [User] u where u.u_id = c.u_id) as u_name,c.c_recommendTime,upl.up_line_schedule,c.c_id,upl.up_line_id from user_plan_header uph,user_plan_lines upl,study_plan_lines spl,study_plan_header sph,Classes c where uph.up_head_id = upl.up_head_id and upl.sp_line_id = spl.sp_line_id and spl.sp_head_id = sph.sp_head_id and spl.c_id = c.c_id";
            }else
            {
                sql += "select (select u_name from [User] where u_id = sph.u_id), sph.sp_head_name,spl,c.c_name,c.c_credit,(select u.u_name from [User] u where u.u_id = c.u_id) as u_name,c.c_recommendTime,upl.up_line_schedule,c.c_id,upl.up_line_id from user_plan_header uph,user_plan_lines upl,study_plan_lines spl,study_plan_header sph,Classes c where sph.sp_emp_dpt = " + Model.User.groupId + " and uph.up_head_id = upl.up_head_id and upl.sp_line_id = spl.sp_line_id and spl.sp_head_id = sph.sp_head_id and spl.c_id = c.c_id";
            }             
            displayClasses(sql);
        }
        private void displayClasses(string sql)
        {
            //刷新页面显示
            sd_flp_detail.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //标签栏目
                var lbl_emp_name = new Label { Text = "员工" };
                lbl_emp_name.Width = 80;
                lbl_emp_name.Font = font;
                lbl_emp_name.TextAlign = ContentAlignment.MiddleCenter;
                //标签栏目
                var lbl_plan_name = new Label { Text = "计划名" };
                lbl_plan_name.Width = 80;
                lbl_plan_name.Font = font;
                lbl_plan_name.TextAlign = ContentAlignment.MiddleCenter;
                //标签栏目
                var lbl_peroid_name = new Label { Text = "阶段名" };
                lbl_peroid_name.Width = 80;
                lbl_peroid_name.Font = font;
                lbl_peroid_name.TextAlign = ContentAlignment.MiddleCenter;
                //标签栏目
                var lblname = new Label { Text = "课程名" };
                lblname.Width = 80;
                lblname.Font = font;
                lblname.TextAlign = ContentAlignment.MiddleCenter;
                var lblcredit = new Label { Text = "学分" };
                lblcredit.Width = 80;
                lblcredit.Font = font;
                lblcredit.TextAlign = ContentAlignment.MiddleCenter;
                var lblu_name = new Label { Text = "开课部门" };
                lblu_name.Width = 80;
                lblu_name.Font = font;
                lblu_name.TextAlign = ContentAlignment.MiddleCenter;
                var lbltime = new Label { Text = "学时" };
                lbltime.Width = 80;
                lbltime.Font = font;
                lbltime.TextAlign = ContentAlignment.MiddleCenter;
                var lblschedule = new Label { Text = "剩余进度" };
                lblschedule.Width = 80;
                lblschedule.Font = font;
                lblschedule.TextAlign = ContentAlignment.MiddleCenter;
                //var lbl_false = new Label { Text = "" };
                //lbl_false.Width = 50;
                //lbl_false.Font = font;
                //lbl_false.TextAlign = ContentAlignment.MiddleCenter;
                var lbl_Eva = new Label { Text = "" };
                lbl_Eva.Width = 50;
                lbl_Eva.Font = font;
                lbl_Eva.TextAlign = ContentAlignment.MiddleCenter;

                sd_flp_detail.Controls.Add(lbl_emp_name);
                sd_flp_detail.Controls.Add(lbl_plan_name);
                sd_flp_detail.Controls.Add(lbl_peroid_name);
                sd_flp_detail.Controls.Add(lblname);
                sd_flp_detail.Controls.Add(lblcredit);
                sd_flp_detail.Controls.Add(lblu_name);
                sd_flp_detail.Controls.Add(lbltime);
                sd_flp_detail.Controls.Add(lblschedule);
                //sd_flp_detail.Controls.Add(lbl_false);
                sd_flp_detail.Controls.Add(lbl_Eva);
                sd_flp_detail.SetFlowBreak(lbl_Eva, true);

                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //员工名
                    var lbl_empname = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    lbl_empname.Width = 80;
                    lbl_empname.Font = font;
                    lbl_empname.TextAlign = ContentAlignment.MiddleCenter;
                    //学习计划名
                    var lbl_planname = new Label { Text = ds.Tables["user"].Rows[i][9].ToString() };
                    lbl_planname.Width = 80;
                    lbl_planname.Font = font;
                    lbl_planname.TextAlign = ContentAlignment.MiddleCenter;
                    //学习阶段名
                    var lbl_peroidname = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    lbl_peroidname.Width = 80;
                    lbl_peroidname.Font = font;
                    lbl_peroidname.TextAlign = ContentAlignment.MiddleCenter;
                    //课程名
                    var lblUFClasses_name = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    lblUFClasses_name.Width = 80;
                    lblUFClasses_name.Font = font;
                    lblUFClasses_name.TextAlign = ContentAlignment.MiddleCenter;
                    //学分
                    var lblUFClasses_credit = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    lblUFClasses_credit.Width = 80;
                    lblUFClasses_credit.Font = font;
                    lblUFClasses_credit.TextAlign = ContentAlignment.MiddleCenter;
                    //开课部门
                    var lblUFClasses_u_name = new Label { Text = ds.Tables["user"].Rows[i][4].ToString() };
                    lblUFClasses_u_name.Width = 80;
                    lblUFClasses_u_name.Font = font;
                    lblUFClasses_u_name.TextAlign = ContentAlignment.MiddleCenter;
                    //推荐学时
                    var lblUFClasses_recommendTime = new Label { Text = ds.Tables["user"].Rows[i][5].ToString() };
                    lblUFClasses_recommendTime.Width = 80;
                    lblUFClasses_recommendTime.Font = font;
                    lblUFClasses_recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                    //剩余进度
                    var lbl_schedule = new Label { Text = ds.Tables["user"].Rows[i][6].ToString() };
                    lbl_schedule.Width = 80;
                    lbl_schedule.Font = font;
                    lbl_schedule.TextAlign = ContentAlignment.MiddleCenter;

                    //var btn_learn = new Button { Text = "学习" };
                    //btn_learn.Width = 50;
                    //btn_learn.Name = ds.Tables["user"].Rows[i][7].ToString();
                    //btn_learn.TextAlign = ContentAlignment.MiddleCenter;
                    ////btn_learn.Click += new EventHandler(btn_studyClass_Click);

                    var btnEvaluation = new Button { Text = "通知" };
                    btnEvaluation.Width = 50;
                    btnEvaluation.Name = ds.Tables["user"].Rows[i][8].ToString();
                    btnEvaluation.TextAlign = ContentAlignment.MiddleCenter;
                    btnEvaluation.Click += new EventHandler(btn_Notice);
                    
                    sd_flp_detail.Controls.Add(lbl_empname);
                    sd_flp_detail.Controls.Add(lbl_planname);
                    sd_flp_detail.Controls.Add(lbl_peroidname);
                    sd_flp_detail.Controls.Add(lblUFClasses_name);
                    sd_flp_detail.Controls.Add(lblUFClasses_credit);
                    sd_flp_detail.Controls.Add(lblUFClasses_u_name);
                    sd_flp_detail.Controls.Add(lblUFClasses_recommendTime);
                    sd_flp_detail.Controls.Add(lbl_schedule);
                    //sd_flp_detail.Controls.Add(btn_learn);
                    sd_flp_detail.Controls.Add(btnEvaluation);
                    sd_flp_detail.SetFlowBreak(btnEvaluation, true);
                }
            }
            else
            {
                //查询不到数据时提示无数据
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 550;
                lbl_no_data.Height = 100;
                sd_flp_detail.Controls.Add(lbl_no_data);
            }
        }
        private void btn_Notice(object sender,EventArgs e)
        {
            int line_id = -1;
            Button button = (Button)sender;
            int.TryParse(button.Name,out line_id);
            DataBaseConnection dc = new DataBaseConnection();
            string select_email = "select u_email,c.c_name from [User] u,user_plan_header uph,user_plan_lines upl,study_plan_lines spl,classes c where u.u_id = uph.u_id and uph.up_head_id = upl.up_head_id and upl.sp_line_id = spl.sp_line_id and spl.c_id = c.c_id and upl.up_line_id = " + line_id;
            DataSet ds = dc.ExecuteQuery(select_email);
            string email = ds.Tables["user"].Rows[0][0].ToString();
            string c_name = ds.Tables["user"].Rows[0][1].ToString();
            EmailSend es = new EmailSend();
            es.sendNoticeEmail(c_name, email);
        }
        private void sd_btn_Return_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Dispose();
        }

        private void Study_detail_Load(object sender, EventArgs e)
        {
            string sql = "";
            if (Model.User.groupId == 0)
            {
                sql += "select (select u.u_name from [User] u where u.u_id = uph.u_id), sph.sp_head_name,c.c_name,c.c_credit,(select g.g_group from [group] g where g.g_id = c.u_id) as u_name,c.c_recommendTime,upl.up_line_schedule,c.c_id,upl.up_line_id,(select sps_name from study_plans where sps_id = sph.sps_id) from user_plan_header uph,user_plan_lines upl,study_plan_lines spl,study_plan_header sph,Classes c where uph.up_head_id = upl.up_head_id and upl.sp_line_id = spl.sp_line_id and spl.sp_head_id = sph.sp_head_id and spl.c_id = c.c_id order by sph.sp_head_name,upl.up_line_schedule ";
            }
            else
            {
                sql += "select (select u.u_name from [User] u where u.u_id = uph.u_id), sph.sp_head_name,c.c_name,c.c_credit,(select g.g_group from [group] g where g.g_id = c.u_id) as u_name,c.c_recommendTime,upl.up_line_schedule,c.c_id,upl.up_line_id,(select sps_name from study_plans where sps_id = sph.sps_id) from user_plan_header uph,user_plan_lines upl,study_plan_lines spl,study_plan_header sph,Classes c where sph.sp_emp_dpt = " + Model.User.groupId + " and uph.up_head_id = upl.up_head_id and upl.sp_line_id = spl.sp_line_id and spl.sp_head_id = sph.sp_head_id and spl.c_id = c.c_id order by sph.sp_head_name,upl.up_line_schedule ";
            }
            displayClasses(sql);
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            int g_id = sd_ccb_group.SelectedIndex;
            string sql = "select (select u.u_name from [User] u where u.u_id = uph.u_id), sph.sp_head_name,c.c_name,c.c_credit,(select g.g_group from [group] g where g.g_id = c.u_id) as u_name,c.c_recommendTime,upl.up_line_schedule,c.c_id,upl.up_line_id,(select sps_name from study_plans where sps_id = sph.sps_id) from user_plan_header uph,user_plan_lines upl,study_plan_lines spl,study_plan_header sph,Classes c where sph.sp_emp_dpt = " + g_id + " and uph.up_head_id = upl.up_head_id and upl.sp_line_id = spl.sp_line_id and spl.sp_head_id = sph.sp_head_id and spl.c_id = c.c_id order by sph.sp_head_name,upl.up_line_schedule ";
            displayClasses(sql);
        }

        private void mm_btn_all_Click(object sender, EventArgs e)
        {
            Study_detail_Load(sender,e);
        }
    }
}
