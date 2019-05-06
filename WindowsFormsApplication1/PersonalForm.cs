using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PersonalForm : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        private int up_line_id = 0;
        public PersonalForm()
        {
            InitializeComponent();
        }
        private void PersonalForm_Load(object sender, EventArgs e)
        {
            up_line_id = 0;
            HideControls();
            if (Model.User.userType.Equals("员工"))
            {
                Btn_ApplyUndisposed.Enabled = false;
            }else
            {
                Btn_ApplyUndisposed.Enabled = true;
            }
            p_lblCurPerson.Text = Model.User.userName;
            p_lblName.Text = Model.User.userName;
            p_txtBxPhone.ReadOnly = true;
            p_txtBxEmail.ReadOnly = true;

            DataBaseConnection dc = new DataBaseConnection();
            try
            {
                string sql = "select u.u_account,g.g_group,u.u_credit,convert(varchar(100),u.u_entryTime,120) as u_entryTime,u.u_phone,u.u_email from [user] u,[group] g where u.u_id = " + Model.User.userId + " and u.g_id = g.g_id";
                DataSet ds = dc.ExecuteQuery(sql);
                if (ds != null || (ds.Tables.Count == 0) || (ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0))
                {
                    p_lblAccount.Text = ds.Tables["user"].Rows[0][0].ToString();
                    p_lblGroup.Text = ds.Tables["user"].Rows[0][1].ToString();
                    p_lblCredit.Text = ds.Tables["user"].Rows[0][2].ToString();
                    p_lblEntryTime.Text = ds.Tables["user"].Rows[0][3].ToString();
                    p_txtBxPhone.Text = ds.Tables["user"].Rows[0][4].ToString();
                    p_txtBxPhone.Font = font;
                    p_txtBxEmail.Text = ds.Tables["user"].Rows[0][5].ToString();
                    p_txtBxEmail.Font = font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误信息：" + ex.Message);
            }
        }
        private void p_btnHome_Click(object sender, EventArgs e)
        {
            Owner.Show();//打开父界面
            Dispose();
        }

        private void p_btnQuit_Click(object sender, EventArgs e)
        {
            Owner.Owner.Show();//注销，返回登陆界面
            Owner.Dispose();
        }

        private void Btn_classfinished_Click(object sender, EventArgs e)
        {
            string sql = "select sph.sp_head_name,c.c_name,c.c_credit,(select u.u_name from [User] u where u.u_id = c.u_id) as u_name,c.c_recommendTime,c.c_id,upl.up_line_id from user_plan_header uph,user_plan_lines upl,study_plan_lines spl,study_plan_header sph,Classes c where uph.u_id = "+Model.User.userId+" and uph.up_head_id = upl.up_head_id and upl.sp_line_id = spl.sp_line_id and spl.sp_head_id = sph.sp_head_id and spl.c_id = c.c_id and uph.study_status_id = 2";
            displayClasses(sql);
        }
        private void btn_classunfinished_Click(object sender, EventArgs e)
        {
            string sql = "select sph.sp_head_name,c.c_name,c.c_credit,(select u.u_name from [User] u where u.u_id = c.u_id) as u_name,c.c_recommendTime,c.c_id,upl.up_line_id from user_plan_header uph,user_plan_lines upl,study_plan_lines spl,study_plan_header sph,Classes c where uph.u_id = " + Model.User.userId + " and uph.up_head_id = upl.up_head_id and upl.sp_line_id = spl.sp_line_id and spl.sp_head_id = sph.sp_head_id and spl.c_id = c.c_id and uph.study_status_id = 0 or uph.study_status_id = 1";
            displayClasses(sql);

        }
        private void displayClasses(string sql)
        {
            //刷新页面显示
            p_flpClasses.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();            
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //标签栏目
                var lbl_plan_name = new Label { Text = "所属学习计划" };
                lbl_plan_name.Width = 100;
                lbl_plan_name.Font = font;
                //标签栏目
                var lblname = new Label { Text = "课程名" };
                lblname.Width = 100;
                lblname.Font = font;
                lblname.TextAlign = ContentAlignment.MiddleCenter;
                var lblcredit = new Label { Text = "学分" };
                lblcredit.Width = 80;
                lblcredit.Font = font;
                lblcredit.TextAlign = ContentAlignment.MiddleCenter;
                var lblu_name = new Label { Text = "上传人" };
                lblu_name.Width = 60;
                lblu_name.Font = font;
                lblu_name.TextAlign = ContentAlignment.MiddleCenter;
                var lbltime = new Label { Text = "学时" };
                lbltime.Width = 80;
                lbltime.Font = font;
                lbltime.TextAlign = ContentAlignment.MiddleCenter;
                var lbl_false = new Label { Text = "" };
                lbl_false.Width = 50;
                lbl_false.Font = font;
                lbl_false.TextAlign = ContentAlignment.MiddleCenter;
                var lbl_Eva = new Label { Text = "" };
                lbl_Eva.Width = 50;
                lbl_Eva.Font = font;
                lbl_Eva.TextAlign = ContentAlignment.MiddleCenter;                
                p_flpClasses.Controls.Add(lbl_plan_name);
                p_flpClasses.Controls.Add(lblname);
                p_flpClasses.Controls.Add(lblcredit);
                p_flpClasses.Controls.Add(lblu_name);
                p_flpClasses.Controls.Add(lbltime);
                p_flpClasses.Controls.Add(lbl_false);
                p_flpClasses.Controls.Add(lbl_Eva);                
                p_flpClasses.SetFlowBreak(lbl_Eva, true);

                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //课程名
                    var lbl_planname = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    lbl_planname.Width = 100;
                    lbl_planname.Font = font;
                    lbl_planname.TextAlign = ContentAlignment.MiddleCenter;
                    //课程名
                    var lblUFClasses_name = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    lblUFClasses_name.Width = 100;
                    lblUFClasses_name.Font = font;
                    lblUFClasses_name.TextAlign = ContentAlignment.MiddleCenter;
                    //学分
                    var lblUFClasses_credit = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    lblUFClasses_credit.Width = 80;
                    lblUFClasses_credit.Font = font;
                    lblUFClasses_credit.TextAlign = ContentAlignment.MiddleCenter;
                    //上传人
                    var lblUFClasses_u_name = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    lblUFClasses_u_name.Width = 60;
                    lblUFClasses_u_name.Font = font;
                    lblUFClasses_u_name.TextAlign = ContentAlignment.MiddleCenter;
                    //推荐学时
                    var lblUFClasses_recommendTime = new Label { Text = ds.Tables["user"].Rows[i][4].ToString() };
                    lblUFClasses_recommendTime.Width = 80;
                    lblUFClasses_recommendTime.Font = font;
                    lblUFClasses_recommendTime.TextAlign = ContentAlignment.MiddleCenter;

                    var btn_learn = new Button { Text = "学习" };
                    btn_learn.Width = 50;
                    btn_learn.Name = ds.Tables["user"].Rows[i][5].ToString();
                    btn_learn.TextAlign = ContentAlignment.MiddleCenter;
                    btn_learn.Click += new EventHandler(btn_studyClass_Click);                    

                    var btnEvaluation = new Button { Text = "评价" };
                    btnEvaluation.Width = 50;
                    btnEvaluation.Name = ds.Tables["user"].Rows[i][6].ToString();
                    btnEvaluation.TextAlign = ContentAlignment.MiddleCenter;
                    btnEvaluation.Click += new EventHandler(btn_Evaluation_Click);
                    
                    p_flpClasses.Controls.Add(lbl_planname);
                    p_flpClasses.Controls.Add(lblUFClasses_name);
                    p_flpClasses.Controls.Add(lblUFClasses_credit);
                    p_flpClasses.Controls.Add(lblUFClasses_u_name);
                    p_flpClasses.Controls.Add(lblUFClasses_recommendTime);
                    p_flpClasses.Controls.Add(btn_learn);
                    p_flpClasses.Controls.Add(btnEvaluation);                    
                    p_flpClasses.SetFlowBreak(btnEvaluation, true);
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
                p_flpClasses.Controls.Add(lbl_no_data);
            }
        }

        private void btn_Evaluation_Click(object sender, EventArgs e)
        {
            //显示评分控件
            ShowControls();
            Button button = (Button)sender;            
            int.TryParse(button.Name, out up_line_id);
            DataBaseConnection dc = new DataBaseConnection();
            string select_info = "select up_line_score,up_line_prompt from user_plan_lines where up_line_id = "+ up_line_id;
            DataSet ds = dc.ExecuteQuery(select_info);
            p_tbx_Score.Text = ds.Tables["user"].Rows[0][0].ToString();
            p_tbx_prompt.Text = ds.Tables["user"].Rows[0][1].ToString();
        }
        private void p_btn_Submit_Click(object sender, EventArgs e)
        {
            //获取页面控件输入的值
            int score = 0;
            int.TryParse(p_tbx_Score.Text, out score);
            string prompt = p_tbx_prompt.Text;
            DataBaseConnection dc = new DataBaseConnection();
            string update_up_line = "update user_plan_lines set up_line_score = " + score + ",up_line_prompt = N'" + prompt + "' where up_line_id = " + up_line_id;
            int flag = dc.ExecuteUpdate(update_up_line);
            if (flag == 1)
            {
                MessageBox.Show("评价课程成功！");
            }
            else
            {
                MessageBox.Show("评价课程失败，请联系系统管理员！");
            }
            up_line_id = 0;
            HideControls();
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
        private void Btn_ApplyUndisposed_Click(object sender, EventArgs e)
        {
            //从数据库中查找未处理的申请
            string u_type = Model.User.userType;
            string sql = "";

                if (u_type.Equals("主管"))
                {
                    sql = "select sr.sr_id,u.u_name,sr.sr_type,sr.sr_time from SignRecord sr,[User] u where sr.u_id = u.u_id and sr.sr_person1 is null and  sr.u_id in (select u_id from  [User] where g_id = " + Model.User.groupId + ")";
                }
                else if (u_type.Equals("系统管理员"))
                {
                    sql = "select sr.sr_id,u.u_name,sr.sr_type,sr.sr_time from SignRecord sr,[User] u where sr.u_id = u.u_id and sr.sr_person1 is not null and sr.sr_person2 is null and sr.u_id in (select u_id from  [User] where g_id = " + Model.User.groupId + ")";
                }
                displayNews(sql);
            
        }

        private void displayNews(string sql)
        {
            //刷新页面显示
            p_flpClasses.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //申请人标签
                var lblname = new Label { Text = "申请人" };
                lblname.Width = 100;
                lblname.Font = font;
                //申请类型标签
                var lbltype = new Label { Text = "申请类型" };
                lbltype.Width = 80;
                lbltype.Font = font;
                //申请时间标签
                var lbldatetime = new Label { Text = "申请时间" };
                lbldatetime.Width = 160;
                lbldatetime.Font = font;
                //处理按钮标签
                var lbl_false = new Label { Text = "" };
                lbl_false.Width = 50;
                lbl_false.Font = font;

                lblname.TextAlign = ContentAlignment.MiddleCenter;
                lbltype.TextAlign = ContentAlignment.MiddleCenter;
                lbldatetime.TextAlign = ContentAlignment.MiddleCenter;
                lbl_false.TextAlign = ContentAlignment.MiddleCenter;
                p_flpClasses.Controls.Add(lblname);
                p_flpClasses.Controls.Add(lbltype);
                p_flpClasses.Controls.Add(lbldatetime);
                p_flpClasses.Controls.Add(lbl_false);
                p_flpClasses.SetFlowBreak(lbl_false, true);

                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //申请人
                    var lblUFClasses_name = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    lblUFClasses_name.Width = 100;
                    lblUFClasses_name.Font = font;
                    lblUFClasses_name.TextAlign = ContentAlignment.MiddleCenter;
                    //申请类型
                    var lblUFClasses_credit = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    lblUFClasses_credit.Width = 80;
                    lblUFClasses_credit.Font = font;
                    lblUFClasses_credit.TextAlign = ContentAlignment.MiddleCenter;
                    //申请时间
                    var lblUFClasses_u_name = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    lblUFClasses_u_name.Width = 160;
                    lblUFClasses_u_name.Font = font;
                    lblUFClasses_u_name.TextAlign = ContentAlignment.MiddleCenter;                    
                    //处理按钮
                    var btnHandle = new Button { Text = "处理" };
                    btnHandle.Width = 50;
                    btnHandle.Name = ds.Tables["user"].Rows[i][0].ToString();
                    btnHandle.Click += new EventHandler(btn_handle_Click);
                    btnHandle.TextAlign = ContentAlignment.MiddleCenter;

                    p_flpClasses.Controls.Add(lblUFClasses_name);
                    p_flpClasses.Controls.Add(lblUFClasses_credit);
                    p_flpClasses.Controls.Add(lblUFClasses_u_name);
                    p_flpClasses.Controls.Add(btnHandle);
                    p_flpClasses.SetFlowBreak(btnHandle, true);
                }
            }
            else
            {
                //查询不到数据时提示无数据
                var lbl_no_data = new Label { Text = string.Concat("抱歉，当前没有查询到任何数据！") };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 550;
                lbl_no_data.Height = 100;
                p_flpClasses.Controls.Add(lbl_no_data);
            }
        }

        private void btn_handle_Click(object sender, EventArgs e)
        {
            //选择消息，跳转到消息中心
            Button button = (Button)sender;
            News.sr_id = button.Name;
            News news = new News();
            news.Owner = this;
            Hide();
            news.Show();
        }

        private void Btn_MyApply_Click(object sender, EventArgs e)
        {
            String sql = "select sr_type,sr_time,isnull(sr_person1,'无'),isnull(sr_result1,'无'),isnull(convert(varchar(100),sr_handleTime1,120),'无') from SignRecord where u_id  = " + Model.User.userId;
            displayMyApplication(sql);
        }

        //隐藏评分相关控件
        private void HideControls()
        {            
            p_lbl_Score.Visible = false;
            p_tbx_Score.Visible = false;
            p_lbl_Prompt.Visible = false;
            p_tbx_prompt.Visible = false;
            p_btn_Submit.Visible = false;
            p_flpClasses.Height = 260;
        }
        //显示评分相关控件
        private void ShowControls()
        {
            p_flpClasses.Height = 150;
            p_lbl_Score.Visible = true;
            p_tbx_Score.Visible = true;
            p_lbl_Prompt.Visible = true;
            p_tbx_prompt.Visible = true;
            p_btn_Submit.Visible = true;
        }
        private void displayMyApplication(string sql)
        {
            //刷新页面显示
            p_flpClasses.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //申请类型标签
                var lblname = new Label { Text = "申请类型" };
                lblname.Width = 80;
                lblname.Font = font;              
                //申请时间标签
                var lbldatetime = new Label { Text = "申请时间" };
                lbldatetime.Width = 150;
                lbldatetime.Font = font;
                //处理人标签
                var lbl_handleName = new Label { Text = "处理人" };
                lbl_handleName.Width = 60;
                lbl_handleName.Font = font;
                //处理结果标签
                var lbl_result = new Label { Text = "处理结果" };
                lbl_result.Width = 70;
                lbl_result.Font = font;
                //处理时间标签
                var lbl_handletime = new Label { Text = "处理时间" };
                lbl_handletime.Width = 150;
                lbl_handletime.Font = font;               

                lblname.TextAlign = ContentAlignment.MiddleCenter;
                lbldatetime.TextAlign = ContentAlignment.MiddleCenter;
                lbl_handleName.TextAlign = ContentAlignment.MiddleCenter;
                lbl_result.TextAlign = ContentAlignment.MiddleCenter;
                lbl_handletime.TextAlign = ContentAlignment.MiddleCenter;

                p_flpClasses.Controls.Add(lblname);
                p_flpClasses.Controls.Add(lbldatetime);
                p_flpClasses.Controls.Add(lbl_handleName);
                p_flpClasses.Controls.Add(lbl_result);
                p_flpClasses.Controls.Add(lbl_handletime);
                p_flpClasses.SetFlowBreak(lbl_handletime, true);

                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //申请类型
                    var name = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    name.Width = 80;
                    name.Font = font;
                    //申请时间
                    var datetime = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    datetime.Width = 150;
                    datetime.Font = font;
                    //处理人
                    var handleName = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    handleName.Width = 60;
                    handleName.Font = font;
                    //处理结果
                    var result = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    result.Width = 70;
                    result.Font = font;
                    //处理时间
                    var handletime = new Label { Text = ds.Tables["user"].Rows[i][4].ToString() };
                    handletime.Width = 150;
                    handletime.Font = font;

                    name.TextAlign = ContentAlignment.MiddleCenter;
                    datetime.TextAlign = ContentAlignment.MiddleCenter;
                    handleName.TextAlign = ContentAlignment.MiddleCenter;
                    result.TextAlign = ContentAlignment.MiddleCenter;
                    handletime.TextAlign = ContentAlignment.MiddleCenter;

                    p_flpClasses.Controls.Add(name);
                    p_flpClasses.Controls.Add(datetime);
                    p_flpClasses.Controls.Add(handleName);
                    p_flpClasses.Controls.Add(result);
                    p_flpClasses.Controls.Add(handletime);
                    p_flpClasses.SetFlowBreak(handletime, true);
                }
            }
            else
            {
                //查询不到数据时提示无数据
                var lbl_no_data = new Label { Text = string.Concat("抱歉，当前没有查询到任何数据！") };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 550;
                lbl_no_data.Height = 100;
                p_flpClasses.Controls.Add(lbl_no_data);
            }
        }

        private void p_btnEdit_Click(object sender, EventArgs e)
        {
            p_txtBxPhone.ReadOnly = false;
            p_txtBxEmail.ReadOnly = false;
        }

        private void p_btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要修改吗", "判断", MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Question) == DialogResult.OK)
            {
                string phone_number = p_txtBxPhone.Text;
                string email = p_txtBxEmail.Text;
                DataBaseConnection dc = new DataBaseConnection();
                string update_sql = "update [User] set u_phone = '" + phone_number + "',u_email = '" + email + "' where u_id = "+Model.User.userId+"";
                int flag = dc.ExecuteUpdate(update_sql);
                if (flag != 0)
                {
                    MessageBox.Show("修改个人信息成功！");                   
                }
            }else
            {
                MessageBox.Show("修改个人信息失败，请重试！");
            }
            PersonalForm_Load(sender, e);
        }

    }
}
