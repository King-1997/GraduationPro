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
    public partial class ClaeeesInfo : CCSkinMain
    {
        public static String c_name = null;
        public ClaeeesInfo()
        {
            InitializeComponent();
        }

        private void CI_btnReturn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();            
        }

        private void ClaeeesInfo_Load(object sender, EventArgs e)
        {
            Console.WriteLine("ClassesInfo里的课程名：" + c_name);
            DataBaseConnection dc = new DataBaseConnection();
            String sql = "select c.c_name,u.u_name,c.c_introduction,c.c_file,c.c_credit,c.c_recommendTime,c.c_ifExam from [User] u,Classes c where c.u_id = u.u_id and c_name = N'" + c_name+"'";
            DataSet ds = dc.ExecuteQuery(sql);
            CI_lbl_Classes_Name.Text = ds.Tables["user"].Rows[0][0].ToString();
            CI_lbl_Classes_Owner.Text = ds.Tables["user"].Rows[0][1].ToString();
            CI_lbl_Classes_Intrudition.Text = ds.Tables["user"].Rows[0][2].ToString();
            CI_lbl_Classes_File.Text = ds.Tables["user"].Rows[0][3].ToString();
            CI_lbl_Classes_Credit.Text = ds.Tables["user"].Rows[0][4].ToString();
            CI_lbl_Classes_Time.Text = ds.Tables["user"].Rows[0][5].ToString();
            CI_lbl_Classes_IfExam.Text = ds.Tables["user"].Rows[0][6].ToString();
        }
    }
}
