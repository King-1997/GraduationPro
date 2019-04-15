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
        public PersonalForm()
        {
            InitializeComponent();
        }

        private void PersonalForm_Load(object sender, EventArgs e)
        {
            if (!User.userType.Equals("主管") || !User.userType.Equals("系统管理员"))
            {
                Btn_ApplyUndisposed.Enabled = false;
            }
            this.p_lblCurPerson.Text = User.userName;
            this.p_lblName.Text = User.userName;

            DataBaseConnection dc = new DataBaseConnection();
            try
            {                
                String sql = "select u.u_account,g.g_group,u.u_credit,u.u_entryTime,u.u_phone from [user] u,[group] g where u.u_id = " + User.userId + " and u.g_id = g.g_id";
                DataSet ds = dc.ExecuteQuery(sql);
                if (ds != null || (ds.Tables.Count == 0) || (ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0))
                {
                    this.p_lblAccount.Text = ds.Tables["user"].Rows[0][0].ToString();
                    this.p_lblGroup.Text = ds.Tables["user"].Rows[0][1].ToString();
                    this.p_lblCredit.Text = ds.Tables["user"].Rows[0][2].ToString();
                    this.p_lblEntryTime.Text = ds.Tables["user"].Rows[0][3].ToString();
                    this.p_lblPhone.Text = ds.Tables["user"].Rows[0][4].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误信息：" + ex.Message);
            }
        }

        private void p_btnHome_Click(object sender, EventArgs e)
        {
            this.Owner.Show();//打开父界面
            this.Dispose();
        }

        private void p_btnQuit_Click(object sender, EventArgs e)
        {
            this.Owner.Owner.Show();//注销，返回登陆界面
            this.Owner.Dispose();
        }

        private void Btn_classfinished_Click(object sender, EventArgs e)
        {
            String sql = "select c.c_name,c.c_credit,u.u_name,c.c_recommendTime from Classes c, ClassesDestribute cd, UserClasses uc,[User] u where c.c_id in (select cd.c_id from ClassesDestribute cd, UserClasses uc where uc.cd_id = cd.cd_id and uc.uc_status = 1) and uc.cd_id = cd.cd_id and cd.c_id = c.c_id and c.u_id = u.u_id and uc.u_id in (select u_id from [User] where u.u_id = " + User.userId + ")";
            displayClasses(sql);
        }
        private void btn_classunfinished_Click(object sender, EventArgs e)
        {
            String sql = "select c.c_name,c.c_credit,u.u_name,c.c_recommendTime from Classes c, ClassesDestribute cd, UserClasses uc,[User] u where c.c_id in (select cd.c_id from ClassesDestribute cd, UserClasses uc where uc.cd_id = cd.cd_id and uc.uc_status = 0) and uc.cd_id = cd.cd_id and cd.c_id = c.c_id and c.u_id = u.u_id and uc.u_id in (select u_id from [User] where u.u_id = " + User.userId + ")";
            displayClasses(sql);

        }
        private void displayClasses(String sql)
        {
            //刷新页面显示
            p_flpClasses.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();            
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //标签栏目
                var lblname = new Label { Text = "课程名" };
                lblname.Width = 100;
                lblname.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                var lblcredit = new Label { Text = "学分" };
                lblcredit.Width = 80;
                lblcredit.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                var lblu_name = new Label { Text = "上传人" };
                lblu_name.Width = 60;
                lblu_name.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                var lbltime = new Label { Text = "学时" };
                lbltime.Width = 80;
                lbltime.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                var lbl_false = new Label { Text = "" };
                lbl_false.Width = 50;
                lbl_false.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                lblname.TextAlign = ContentAlignment.MiddleCenter;
                lblcredit.TextAlign = ContentAlignment.MiddleCenter;
                lblu_name.TextAlign = ContentAlignment.MiddleCenter;
                lbltime.TextAlign = ContentAlignment.MiddleCenter;
                lbl_false.TextAlign = ContentAlignment.MiddleCenter;
                p_flpClasses.Controls.Add(lblname);
                p_flpClasses.Controls.Add(lblcredit);
                p_flpClasses.Controls.Add(lblu_name);
                p_flpClasses.Controls.Add(lbltime);
                p_flpClasses.Controls.Add(lbl_false);
                p_flpClasses.SetFlowBreak(lbl_false, true);

                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //课程名
                    var lblUFClasses_name = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][0].ToString()) };
                    lblUFClasses_name.Width = 100;
                    lblUFClasses_name.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    lblUFClasses_name.TextAlign = ContentAlignment.MiddleCenter;
                    //学分
                    var lblUFClasses_credit = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][1].ToString()) };
                    lblUFClasses_credit.Width = 80;
                    lblUFClasses_credit.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    lblUFClasses_credit.TextAlign = ContentAlignment.MiddleCenter;
                    //上传人
                    var lblUFClasses_u_name = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][2].ToString()) };
                    lblUFClasses_u_name.Width = 60;
                    lblUFClasses_u_name.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    lblUFClasses_u_name.TextAlign = ContentAlignment.MiddleCenter;
                    //推荐学时
                    var lblUFClasses_recommendTime = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][3].ToString()) };
                    lblUFClasses_recommendTime.Width = 80;
                    lblUFClasses_recommendTime.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    lblUFClasses_recommendTime.TextAlign = ContentAlignment.MiddleCenter;

                    var btnCom = new Button { Text = string.Concat("学习") };
                    btnCom.Width = 50;
                    btnCom.Name = ds.Tables["user"].Rows[i][0].ToString();
                    btnCom.Click += new EventHandler(btn_studyClass_Click);
                    btnCom.TextAlign = ContentAlignment.MiddleCenter;

                    p_flpClasses.Controls.Add(lblUFClasses_name);
                    p_flpClasses.Controls.Add(lblUFClasses_credit);
                    p_flpClasses.Controls.Add(lblUFClasses_u_name);
                    p_flpClasses.Controls.Add(lblUFClasses_recommendTime);
                    p_flpClasses.Controls.Add(btnCom);
                    p_flpClasses.SetFlowBreak(btnCom, true);
                }
            }
            else
            {
                MessageBox.Show("您当前还没有未完成的课程！");
            }
        }
        private void btn_studyClass_Click(object sender, EventArgs e)
        {
            //选择课程，跳转到学习页面
            Button button = (Button)sender;
            Learn.c_name = button.Name;
            Learn learn = new Learn();
            learn.Owner = this;
            this.Hide();
            learn.Show();
        }


        private void Btn_ApplyUndisposed_Click(object sender, EventArgs e)
        {
            //从数据库中查找未处理的申请
            string u_type = User.userType;
            string sql = "";

                if (u_type.Equals("主管"))
                {
                    sql = "select sr.sr_id,u.u_name,sr.sr_type,sr.sr_time from SignRecord sr,[User] u where sr.u_id = u.u_id and sr.sr_person1 is null and  sr.u_id in (select u_id from  [User] where g_id = " + User.groupId + ")";
                }
                else if (u_type.Equals("系统管理员"))
                {
                    sql = "select sr.sr_id,u.u_name,sr.sr_type,sr.sr_time from SignRecord sr,[User] u where sr.u_id = u.u_id and sr.sr_person1 is not null and sr.sr_person2 is null and sr.u_id in (select u_id from  [User] where g_id = " + User.groupId + ")";
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
                lblname.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                //申请类型标签
                var lbltype = new Label { Text = "申请类型" };
                lbltype.Width = 80;
                lbltype.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                //申请时间标签
                var lbldatetime = new Label { Text = "申请时间" };
                lbldatetime.Width = 160;
                lbldatetime.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                //处理按钮标签
                var lbl_false = new Label { Text = "" };
                lbl_false.Width = 50;
                lbl_false.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

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
                    var lblUFClasses_name = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][1].ToString()) };
                    lblUFClasses_name.Width = 100;
                    lblUFClasses_name.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    lblUFClasses_name.TextAlign = ContentAlignment.MiddleCenter;
                    //申请类型
                    var lblUFClasses_credit = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][2].ToString()) };
                    lblUFClasses_credit.Width = 80;
                    lblUFClasses_credit.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    lblUFClasses_credit.TextAlign = ContentAlignment.MiddleCenter;
                    //申请时间
                    var lblUFClasses_u_name = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][3].ToString()) };
                    lblUFClasses_u_name.Width = 160;
                    lblUFClasses_u_name.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    lblUFClasses_u_name.TextAlign = ContentAlignment.MiddleCenter;                    
                    //处理按钮
                    var btnHandle = new Button { Text = string.Concat("处理") };
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
                MessageBox.Show("您当前还没有未处理的申请！");
            }
        }

        private void btn_handle_Click(object sender, EventArgs e)
        {
            //选择消息，跳转到消息中心
            Button button = (Button)sender;
            News.sr_id = button.Name;
            News news = new News();
            news.Owner = this;
            this.Hide();
            news.Show();
        }

        private void Btn_MyApply_Click(object sender, EventArgs e)
        {
            String sql = "select sr_type,sr_time,sr_person1,sr_result1,sr_handleTime1 from SignRecord where u_id  = " + User.userId;
            displayMyApplication(sql);
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
                lblname.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));              
                //申请时间标签
                var lbldatetime = new Label { Text = "申请时间" };
                lbldatetime.Width = 150;
                lbldatetime.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                //处理人标签
                var lbl_handleName = new Label { Text = "处理人" };
                lbl_handleName.Width = 60;
                lbl_handleName.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                //处理结果标签
                var lbl_result = new Label { Text = "处理结果" };
                lbl_result.Width = 70;
                lbl_result.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                //处理时间标签
                var lbl_handletime = new Label { Text = "处理时间" };
                lbl_handletime.Width = 150;
                lbl_handletime.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));               

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
                    //申请类型标签
                    var name = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][0].ToString()) };
                    name.Width = 80;
                    name.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    //申请时间标签
                    var datetime = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][1].ToString()) };
                    datetime.Width = 150;
                    datetime.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    //处理人标签
                    var handleName = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][2].ToString()) };
                    handleName.Width = 60;
                    handleName.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    //处理结果标签
                    var result = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][3].ToString()) };
                    result.Width = 70;
                    result.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    //处理时间标签
                    var handletime = new Label { Text = string.Concat(ds.Tables["user"].Rows[i][4].ToString()) };
                    handletime.Width = 150;
                    handletime.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

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
                MessageBox.Show("您当前还没有申请！");
            }
        }
    }
}
