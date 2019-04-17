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
        public Manage()
        {
            InitializeComponent();
        }

        private void p_btnHome_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        public void UsernameC()
        {

        }

        private void btn_uploadclasses_Click(object sender, EventArgs e)
        {
            LoadClasses classChoose = new LoadClasses();
            classChoose.Owner = this;
            this.Hide();
            classChoose.Show();
            
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            this.p_lblCurPerson.Text = Model.User.userName;
        }

        private void m_btnClasses_Click(object sender, EventArgs e)
        {
            //安排课程,打开课程安排页面
            LessonArrangement lessonArrangement = new LessonArrangement();
            lessonArrangement.Owner = this;
            this.Hide();
            lessonArrangement.Show();
        }
        //跳转到人员管理界面Man-ManageMent
        private void m_btnHR_Click(object sender, EventArgs e)
        {
            Man_Management man_ManageMent = new Man_Management();
            man_ManageMent.Owner = this;
            man_ManageMent.Show();
            this.Hide();
        }        

        private void btn_avgTime_Click(object sender, EventArgs e)
        {

        }
        //打开导出学时界面
        private void btn_allTime_Click(object sender, EventArgs e)
        {
            ExcelOutput excelOutput = new ExcelOutput();
            excelOutput.Owner = this;
            excelOutput.Show();
            this.Hide();
        }

        private void p_btnQuit_Click(object sender, EventArgs e)//注销
        {
            this.Owner.Owner.Show();
            this.Owner.Dispose();
        }
    }
}
