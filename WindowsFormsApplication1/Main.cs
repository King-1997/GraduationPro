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
    
    public partial class Main : Form
    {
        Login parlogin;//声明父窗口
        public Main(Login login)
        {
            parlogin = login;//父窗口
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)//南昌科勒学习系统
        {
            
        }
        public PersonalForm personalForm=new PersonalForm();//个人中心
        public Classes classes = new Classes();//课程中心
        public Manage manage = new Manage();//管理中心
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            personalForm.Show();//跳转到个人中心
        }

        private void p_btnQuit_Click(object sender, EventArgs e)
        {
            parlogin.Show();//重新显示父窗口
            this.Close();
        }

        private void m_btnClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            classes.Show();//跳转到课程中心
        }

        private void m_btnManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            manage.Show();//跳转到管理中心
        }
    }
}
