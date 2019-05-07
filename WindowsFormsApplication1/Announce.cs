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
    public partial class Announce : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public static int a_id = -1;
        public Announce()
        {
            InitializeComponent();
        }

        private void Announce_Load(object sender, EventArgs e)
        {
            string sql = "select u.u_name,a.a_datetime,a.a_text,a.a_prompt,a.a_id from [User] u,announcement a where  a.a_id = " + a_id+" and u.u_id = a.u_id";
            showAnnounce(sql);
        }
        private void showAnnounce(string sql)
        {
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            a_lbl_releaseName.Text = ds.Tables["user"].Rows[0][0].ToString();
            a_lbl_releaseTime.Text = ds.Tables["user"].Rows[0][1].ToString();
            a_tbx_title.Text = ds.Tables["user"].Rows[0][2].ToString();
            a_tBx_announcement.Text = ds.Tables["user"].Rows[0][3].ToString();
        }

        private void a_btn_return_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Dispose();
        }
    }
}
