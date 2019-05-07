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
    
    public partial class Mainmenu : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void p_btnQuit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();  //返回父界面登陆界面
            this.Dispose();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.p_lblCurPerson.Text = Model.User.userName;
            if (!Model.User.userType.Equals("员工"))
            {
                this.m_btnManage.Visible = true;
            }else
            {
                this.m_btnSign.Location = this.m_btnManage.Location;
                this.Width = 900;
            }
            string select_announcement = "select a.a_text,a.a_datetime,a.a_id from [User] u,announcement a where u.u_id = a.u_id order by a_datetime desc";
            showAnnouncement(select_announcement);
        }
        private void showAnnouncement(string sql)
        {
            mm_flp_announcement.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                ////公告正文标签
                //var lbl_text = new Label { Text = "公告正文" };
                //lbl_text.Font = font;
                //lbl_text.Width = 200;
                //lbl_text.TextAlign = ContentAlignment.MiddleCenter;
                ////发布时间标签
                //var lbl_time = new Label { Text = "发布时间" };
                //lbl_time.Font = font;
                //lbl_time.Width = 80;
                //lbl_time.TextAlign = ContentAlignment.MiddleCenter;

                //mm_flp_announcement.Controls.Add(lbl_text);
                //mm_flp_announcement.Controls.Add(lbl_time);
                //mm_flp_announcement.SetFlowBreak(lbl_time, true);
                for (int i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //公告正文
                    var ann_text = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    ann_text.Font = font;
                    ann_text.Width = 200;
                    ann_text.Name = ds.Tables["user"].Rows[i][2].ToString();
                    ann_text.Click += new System.EventHandler(lb_Click);
                    //ann_text.TextAlign = ContentAlignment.MiddleCenter;
                    //发布时间
                    var create_time = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    create_time.Font = font;
                    create_time.Width = 80;
                    //create_time.TextAlign = ContentAlignment.MiddleCenter;

                    mm_flp_announcement.Controls.Add(ann_text);
                    mm_flp_announcement.Controls.Add(create_time);
                    mm_flp_announcement.SetFlowBreak(create_time, true);
                }
            }
            else
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 380;
                lbl_no_data.Height = 80;
                mm_flp_announcement.Controls.Add(lbl_no_data);
            }
        }
        private void lb_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            int a_id = -1;
            int.TryParse(lbl.Name, out a_id);
            Announce.a_id = a_id;
            Announce announce = new Announce();
            announce.Owner = this;
            Hide();
            announce.Show();
        }
        private void p_btnQuit_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();//注销，返回登陆界面
            this.Dispose();
        }

        private void m_btnPersonal_Click(object sender, EventArgs e)
        {
            PersonalForm personalForm = new PersonalForm();
            personalForm.Owner = this;
            this.Hide();
            personalForm.Show();//跳转到个人中心
        }

        private void m_btnClass_Click(object sender, EventArgs e)
        {
            Classes classes = new Classes();

            classes.Owner = this;
            this.Hide();
            classes.Show();//跳转到课程中心
        }

        private void m_btnManage_Click(object sender, EventArgs e)
        {
            //if (Model.User.userType.Equals("系统管理员") || Model.User.userType.Equals("管理员"))
            //{
                //Console.WriteLine("用户类型:" + Model.User.userType);
                Manage manage = new Manage();

                manage.Owner = this;
                this.Hide();
                manage.Show();//跳转到管理中心
            //}
            //else
            //{
            //    MessageBox.Show("您没有权限访问此页面！");
            //}
        }

        private void m_btnSign_Click(object sender, EventArgs e)
        {
            ApplyView applyView = new ApplyView();

            applyView.Owner = this;
            this.Hide();
            applyView.Show();//跳转到申请中心
        }
    }
}
