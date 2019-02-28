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
            this.p_lblCurPerson.Text = User.userName;
        }

        private void p_btnQuit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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
            if (User.userType.Equals("系统管理员") || User.userType.Equals("管理员"))
            {
                Console.WriteLine("用户类型:" + User.userType);
                Manage manage = new Manage();

                manage.Owner = this;
                this.Hide();
                manage.Show();//跳转到管理中心
            }
            else
            {
                MessageBox.Show("您没有权限访问此页面！");
            }
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
