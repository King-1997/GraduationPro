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
    public partial class Manage : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        private int a_id = -1;
        public Manage()
        {
            InitializeComponent();
            p_lblCurPerson.Text = Model.User.userName;
            showOrHide(false);
        }

        private void p_btnHome_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Dispose();
        }
        private void btn_uploadclasses_Click(object sender, EventArgs e)
        {
            LoadClasses classChoose = new LoadClasses();
            classChoose.Owner = this;
            Hide();
            classChoose.Show();
            
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            a_id = -1;
            showOrHide(false);
            string select_announcement = "select u.u_name,a.a_text,a.a_datetime,a.a_id from [User] u,announcement a  where u.u_id = a.u_id";
            if (Model.User.userType == "系统管理员")
            {

            }else
            {
                select_announcement += " and a.u_id = "+Model.User.userId;
            }           
            showAnnouncement(select_announcement);
        }

        private void showAnnouncement(string sql)
        {
            m_flp_announcement.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //发布人标签
                var lbl_user_name = new Label { Text = "发布人" };
                lbl_user_name.Font = font;
                lbl_user_name.Width = 60;
                lbl_user_name.TextAlign = ContentAlignment.MiddleCenter;
                //公告正文标签
                var lbl_text = new Label { Text = "公告正文" };
                lbl_text.Font = font;
                lbl_text.Width = 200;
                lbl_text.TextAlign = ContentAlignment.MiddleCenter;
                //发布时间标签
                var lbl_time = new Label { Text = "发布时间" };
                lbl_time.Font = font;
                lbl_time.Width = 80;
                lbl_time.TextAlign = ContentAlignment.MiddleCenter;

                m_flp_announcement.Controls.Add(lbl_user_name);
                m_flp_announcement.Controls.Add(lbl_text);
                m_flp_announcement.Controls.Add(lbl_time);
                m_flp_announcement.SetFlowBreak(lbl_time, true);
                for (int i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //发布人
                    var ann_user = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    ann_user.Font = font;
                    ann_user.Width = 60;
                    ann_user.TextAlign = ContentAlignment.MiddleCenter;
                    //公告正文
                    var ann_text = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    ann_text.Font = font;
                    ann_text.Width = 200;
                    ann_text.TextAlign = ContentAlignment.MiddleCenter;
                    //发布时间
                    var create_time = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    create_time.Font = font;
                    create_time.Width = 80;
                    create_time.TextAlign = ContentAlignment.MiddleCenter;
                    //编辑公告信息
                    var btn_check = new Button { Text = "编辑" };
                    btn_check.Width = 50;
                    btn_check.TextAlign = ContentAlignment.MiddleCenter;
                    btn_check.Name = ds.Tables["user"].Rows[i][3].ToString();
                    btn_check.Click += new EventHandler(editAnnInfo);
                    //删除公告
                    var btn_delete = new Button { Text = "删除" };
                    btn_delete.Width = 50;
                    btn_delete.TextAlign = ContentAlignment.MiddleCenter;
                    btn_delete.Name = ds.Tables["user"].Rows[i][3].ToString();
                    btn_delete.Click += new EventHandler(deleteAnn);

                    m_flp_announcement.Controls.Add(ann_user);
                    m_flp_announcement.Controls.Add(ann_text);
                    m_flp_announcement.Controls.Add(create_time);
                    m_flp_announcement.Controls.Add(btn_check);
                    m_flp_announcement.Controls.Add(btn_delete);
                    m_flp_announcement.SetFlowBreak(btn_delete, true);
                }
            }
            else
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 400;
                lbl_no_data.Height = 150;
                m_flp_announcement.Controls.Add(lbl_no_data);
            }
        }
        private void editAnnInfo(object sender,EventArgs e)
        {
            showOrHide(true);
            Button button = (Button)sender;
            int.TryParse(button.Name,out a_id);
            DataBaseConnection dc = new DataBaseConnection();
            string select_ann = "select a_text from announcement where a_id = "+a_id;
            DataSet ds = dc.ExecuteQuery(select_ann);
            m_tBx_announcement.Text = ds.Tables["user"].Rows[0][0].ToString();
        }        
        private void deleteAnn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int.TryParse(button.Name, out a_id);
            DataBaseConnection dc = new DataBaseConnection();
            if (MessageBox.Show("您确定要删除该条公告吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
            {
                string delete_ann = "delete from announcement where a_id = " + a_id;
                int flag = dc.ExecuteUpdate(delete_ann);
                if (flag == 1)
                {
                    MessageBox.Show("删除公告信息成功！");
                }
                else
                {
                    MessageBox.Show("操作失败，请联系系统管理员！");
                }
            }                
        }
        private void m_btnClasses_Click(object sender, EventArgs e)
        {
            //安排课程,打开课程安排页面
            PlanArrangement planArrangement = new PlanArrangement();
            planArrangement.Owner = this;
            Hide();
            planArrangement.Show();
        }
        //跳转到人员管理界面Man-ManageMent
        private void m_btnHR_Click(object sender, EventArgs e)
        {
            Man_Management man_ManageMent = new Man_Management();
            man_ManageMent.Owner = this;
            Hide();
            man_ManageMent.Show();
        }        
        //打开导出学时界面
        private void btn_allTime_Click(object sender, EventArgs e)
        {
            ExcelOutput excelOutput = new ExcelOutput();
            excelOutput.Owner = this;
            Hide();
            excelOutput.Show();
        }
        private void p_btnQuit_Click(object sender, EventArgs e)//注销
        {
            Owner.Owner.Show();
            Owner.Dispose();
        }
        private void m_btn_plan_manage_Click(object sender, EventArgs e)
        {
            //给组员安排课程，打开课程安排页面
            ManagePlan createPlan = new ManagePlan();
            createPlan.Owner = this;
            Hide();
            createPlan.Show();
        }
        private void m_btn_Announce_Click(object sender, EventArgs e)
        {
            showOrHide(true);            
        }
        private void showOrHide(Boolean flag)
        {
            m_lbl_announcement.Visible = flag;
            m_tBx_announcement.Visible = flag;
            m_btn_release.Visible = flag;
        }
        //发布按钮事件处理
        private void m_btn_release_Click(object sender, EventArgs e)
        {
            string announcement = m_tBx_announcement.Text;
            DataBaseConnection dc = new DataBaseConnection();
            int flag = 0;
            if(a_id == -1)
            {
                string insert_sql = "insert into announcement values(next value for announcement_s,"+Model.User.userId+",'"+announcement+ "',CONVERT(varchar(100), GETDATE(), 20))";
                flag = dc.ExecuteUpdate(insert_sql);
            }else
            {
                if (MessageBox.Show("您确定要修改吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string update_sql = "update announcement set a_text = N'" + announcement + "' where a_id = " + a_id;
                    flag = dc.ExecuteUpdate(update_sql);
                }                    
            }
            if (flag == 1)
            {
                MessageBox.Show("公告信息发布/修改成功！");
                Manage_Load(sender,e);
            }else
            {
                MessageBox.Show("操作失败，请联系系统管理员！");
            }
        }

        private void m_btn_load_question_Click(object sender, EventArgs e)
        {
            ExamShow examShow = new ExamShow();
            examShow.Owner = this;
            Hide();
            examShow.Show();
        }
    }
}
