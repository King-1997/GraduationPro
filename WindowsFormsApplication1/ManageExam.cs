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
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public static int exam_p_id = -1;
        DataBaseConnection dc = new DataBaseConnection();
        public ManageExam()
        {
            InitializeComponent();
        }
        private void ManageExam_Load(object sender, EventArgs e)
        {
            if (exam_p_id != -1)
            {
                string select_exam_info = "select exam_p_name,start_time,end_time from exam_paper where exam_p_id = " + exam_p_id;
                DataSet ds = dc.ExecuteQuery(select_exam_info);
                me_lbl_ExamName.Text = ds.Tables["user"].Rows[0][0].ToString();
                me_lbl_StartTime.Text = ds.Tables["user"].Rows[0][1].ToString();
                me_lbl_EndTime.Text = ds.Tables["user"].Rows[0][2].ToString();
                string select_sql = "select q.q_title ,q.q_answer,q.q_goal,q.q_id,q.c_id,isnull(c.c_name,'无') as c_name from question q,classes c where c.c_id = q.c_id and q.exam_p_id =" + exam_p_id;
                showQuesInfo(select_sql);
            }            
        }
        private void showQuesInfo(string sql)
        {
            me_flp_q_info.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            //在窗口添加学习计划信息
            if (ds.Tables["user"].Rows.Count > 0)
            {
            }else
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 400;
                lbl_no_data.Height = 150;
                me_flp_q_info.Controls.Add(lbl_no_data);
            }
        }
        private void me_btn_back_Click(object sender, EventArgs e)
        {
            exam_p_id = -1;
            Owner.Show();
            Dispose();
        }

        private void ep_btn_All_Peroid_Click(object sender, EventArgs e)
        {
            ManageExam_Load(sender, e);
        }

        private void me_btn_addQues_Click(object sender, EventArgs e)
        {

        }
    }
}
