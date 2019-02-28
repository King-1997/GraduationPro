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
    public partial class Video : CCSkinMain
    {
        private string fileName;
        public Video(string FileName)
        {
            fileName = FileName;
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Video_Load(object sender, EventArgs e)
        {
            player.URL = fileName;
        }
    }
}
