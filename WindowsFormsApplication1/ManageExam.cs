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
    public partial class ManageExam : CCSkinMain
    {
        public static int exam_p_id = -1;
        public ManageExam()
        {
            InitializeComponent();
        }

        private void me_btn_back_Click(object sender, EventArgs e)
        {
            string select_sql = "select q.q_title ,q.q_answer,q.q_goal,q.q_id,q.c_id,(select c_name from classes where c_id = q.c_id) from question q where q.exam_p_id is null";
            //showQuesInfo(select_sql);
        }
        private void showQuesInfo(string sql)
        {
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
        }

        private void ManageExam_Load(object sender, EventArgs e)
        {
            exam_p_id = -1;
            this.Owner.Show();
            this.Dispose();
        }
    }
}
