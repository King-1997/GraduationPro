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
        public static int c_id = -1;
        private string c_annex = null;
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
            DataBaseConnection dc = new DataBaseConnection();
            String sql = "select c.c_name,u.u_name,c.c_introduction,c.c_file,c.c_credit,c.c_recommendTime,c.c_ifExam,c.c_annex from [User] u,Classes c where c.u_id = u.u_id and c_id = " + c_id +"";
            DataSet ds = dc.ExecuteQuery(sql);
            CI_lbl_Classes_Name.Text = ds.Tables["user"].Rows[0][0].ToString();
            CI_lbl_Classes_Owner.Text = ds.Tables["user"].Rows[0][1].ToString();
            CI_lbl_Classes_Intrudition.Text = ds.Tables["user"].Rows[0][2].ToString();
            string c_file = ds.Tables["user"].Rows[0][3].ToString();
            CI_lbl_Classes_File.Text = c_file.Substring(c_file.LastIndexOf("\\") + 1);
            CI_lbl_Classes_Credit.Text = ds.Tables["user"].Rows[0][4].ToString();
            CI_lbl_Classes_Time.Text = ds.Tables["user"].Rows[0][5].ToString();
            CI_lbl_Classes_IfExam.Text = ds.Tables["user"].Rows[0][6].ToString();            
            c_annex = ds.Tables["user"].Rows[0][7].ToString();
            CI_lbl_Annex.Text = c_annex.Substring(c_annex.LastIndexOf("\\") + 1);
        }

        private void CI_btn_download_Click(object sender, EventArgs e)
        {
            string foldPath, filename;
            FolderBrowserDialog dialog = new FolderBrowserDialog();//新建选择文件夹对话框
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foldPath = dialog.SelectedPath;
                filename = foldPath + "123.pdf";
                Tools.Download.DownloadFile(c_annex, filename, CI_progressBar, CI_lbl_pcb);
            }
            CI_progressBar.Visible = true;
            CI_lbl_pcb.Visible = true;
        }
    }
}
