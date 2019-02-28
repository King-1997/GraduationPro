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
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "请选择一个文件夹";
            //openFileDialog1.Filter = "(mp3,wav,mp4,mov,wmv,mpg,pdf)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg;*.pdf";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tBx_fileadd.Text = folderBrowserDialog1.SelectedPath;
                
            }
        }

        private void btn_Y_Click(object sender, EventArgs e)
        {
            string fileadd = tBx_fileadd.Text;
            if (!string.IsNullOrEmpty(fileadd))
            {               
                string fileName = tBx_fileName.Text;
                DataBaseConnection dc = new DataBaseConnection();
                string sql = "select u.u_name'员工姓名',u.u_account'员工工号',uc.uc_status'课程状态（已完成为1/未完成为0）',uc.uc_property'课程属性（必修为1/选修为2）',c.c_name'课程名' from UserClasses uc,[User] u,Classes c,ClassesDestribute cd " +
                    "where u.u_id = uc.u_id and uc.cd_id = cd.cd_id and cd.c_id = c.c_id " +
                    "order by u.u_id; ";
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
            this.Owner.Show();
            this.Dispose();
        }

        private void tBx_fileName_Click(object sender, EventArgs e)
        {
            if (tBx_fileName.Text == "请输入文件名：")
            {
                tBx_fileName.Text = "";
            }
        } 

        private void ExcelOutput_Load(object sender, EventArgs e)
        {

        }
    }
}
