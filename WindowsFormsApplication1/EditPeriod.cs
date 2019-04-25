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
    public partial class EditPeriod : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public static int sp_head_id = -1;
        public EditPeriod()
        {
            InitializeComponent();
            this.ep_tBx_Plan_Name.Font = font;
            this.ep_tBx_Head_Summary.Font = font;
            this.ep_tBx_Emp_type.Font = font;
        }
        private void EditPeriod_Load(object sender, EventArgs e)
        {
            string select_head_info = "select sp_head_name,sp_head_summary,sp_emp_type from study_plan_header where sp_head_id = "+sp_head_id;
            showHeaderInfo(select_head_info);
            //根据学习计划界面传head_id过来进行行信息操作
            string select_line_info = "select isnull((select c_name from Classes where c_id = spl.c_id),'无') AS c_name,isnull((select exam_p_name from exam_paper where exam_p_id = spl.exam_p_id),'无') AS exam_p_name,spl.sp_period,spl.sp_startTime,spl.sp_endTime from study_plan_lines spl where spl.sp_head_id = " + sp_head_id;
            showLinesInfo(select_line_info);
        }
        //查询学习计划头信息
        private void showHeaderInfo(string sql)
        {
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            this.ep_tBx_Plan_Name.Text = ds.Tables["user"].Rows[0][0].ToString();
            this.ep_tBx_Head_Summary.Text = ds.Tables["user"].Rows[0][1].ToString();
            this.ep_tBx_Emp_type.Text = ds.Tables["user"].Rows[0][2].ToString();
        }
        //查询学习计划行（各个阶段）信息
        private void showLinesInfo(string sql)
        {
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
        }
        private void ep_btn_confirm_Click(object sender, EventArgs e)
        {
            string plan_name = this.ep_tBx_Plan_Name.Text;
            string head_summary = this.ep_tBx_Head_Summary.Text;
            string emp_type = this.ep_tBx_Emp_type.Text;
            DataBaseConnection dc = new DataBaseConnection();
            
            
        }
        private void ep_btn_back_Click(object sender, EventArgs e)
        {
            sp_head_id = -1;
            this.Owner.Show();
            this.Dispose();
        }

        private void ep_btn_addPeroid_Click(object sender, EventArgs e)
        {

        }
    }
}
