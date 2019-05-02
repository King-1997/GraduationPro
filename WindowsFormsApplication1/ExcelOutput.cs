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
    public partial class ExcelOutput : CCSkinMain
    {
        public ExcelOutput()
        {
            InitializeComponent();
            preload();
        }
        private void preload()
        {
            eo_ccb_group.Items.Add( "不选择部门");
            DataBaseConnection dc = new DataBaseConnection();
            String select_user_type = "select g_group from [group]";
            DataSet ds = dc.ExecuteQuery(select_user_type);
            for (int i = 0; i < ds.Tables["user"].Rows.Count; i++)
            {
                eo_ccb_group.Items.Add(ds.Tables["user"].Rows[i][0].ToString());
            }
            eo_ccb_group.SelectedIndex = 0;
        }
        private void btn_preview_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "请选择一个文件夹";
            //openFileDialog1.Filter = "(mp3,wav,mp4,mov,wmv,mpg,pdf)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg;*.pdf";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                eo_tBx_fileadd.Text = folderBrowserDialog1.SelectedPath;
                
            }
        }

        private void btn_Y_Click(object sender, EventArgs e)
        {
            string group_name = eo_ccb_group.SelectedItem.ToString();
            string fileadd = eo_tBx_fileadd.Text;
            DataBaseConnection dc = new DataBaseConnection();
            
            if (!string.IsNullOrEmpty(fileadd))
            {
                string sql = "select u.u_name'员工姓名',u.u_account'员工工号',uph.study_status_id'课程状态（已完成为1/未完成为0）',uph.up_property'课程属性（必修为1/选修为2）',c.c_name'课程名' from user_plan_header uph,user_plan_lines upl,[User] u,Classes c,study_plan_lines spl where uph.up_head_id = upl.up_head_id and uph.u_id = uph.u_id and upl.sp_line_id = spl.sp_line_id and spl.c_id = c.c_id";
                if (group_name != "不选择部门")
                {
                    sql += "and u.g_id = (select g_id from [group] where g_group = '" + group_name + "') order by u.u_id";
                }else
                {
                    sql += " order by u.u_id";
                }
                string fileName = eo_tBx_fileName.Text;                               
                DataSet ds = dc.ExecuteQuery(sql);
                Excel.OutputExcel(ds.Tables["user"],fileadd,fileName);
            }
            else
            {
                MessageBox.Show("请选择导出路径");
            }
        }

        private void EO_btnRetnru_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Dispose();
        }

        private void tBx_fileName_Click(object sender, EventArgs e)
        {
            if (eo_tBx_fileName.Text == "请输入文件名：")
            {
                eo_tBx_fileName.Text = "";
            }
        } 

        private void ExcelOutput_Load(object sender, EventArgs e)
        {

        }
    }
}
