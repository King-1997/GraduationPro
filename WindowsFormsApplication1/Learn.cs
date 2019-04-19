using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Learn : CCSkinMain
    {
        public static int c_id = -1;
        private string c_file = null;
        private string c_ifExam = null;
        private int c_maxTime = 30;
        private int c_minTime = 20;
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public Learn()
        {
            InitializeComponent();
        }
        
        private void Learn_Load(object sender, EventArgs e)
        {
            this.timer1.Start();    //启动定时器
            timer1.Interval = 1000;
            L_lblTime.Text = DateTime.Now.ToString("YYYY/MM/DD H24:mm:ss");
            //地址输入
            DirectoryInfo theFolder = new DirectoryInfo(@"D:\01 SQL培训\2.0视频");
            scan(theFolder);
            //根据课程名字查出文件所在地址
            DataBaseConnection dc = new DataBaseConnection();
            String select_c_file = "select c_file,c_ifExam,c_maxTime,c_minTime from Classes where c_id = " + c_id;
            DataSet ds = dc.ExecuteQuery(select_c_file);
            //将文件路径赋值给全局变量c_file
            c_file = ds.Tables["user"].Rows[0][0].ToString();
            //将课程是否考试赋值给全局变量c_ifExam
            c_ifExam = ds.Tables["user"].Rows[0][1].ToString();
            //将课程最大学习时间赋值给全局变量c_maxTime
            c_maxTime = (int)ds.Tables["user"].Rows[0][2];
            //将课程最大学习时间赋值给全局变量c_minTime
            c_minTime = (int)ds.Tables["user"].Rows[0][3];

            L_btnExam.Visible = true;
            if (c_ifExam.Equals("是"))
            {
                L_btnExam.Visible = true;
            }
            else
            {
                L_btnExam.Visible = false;
            }
            L_btnExam.Enabled = false;

        }
        private void L_btnReturn_Click(object sender, EventArgs e)
        {
            timer1.Stop();//关闭计时器
            this.Owner.Show();
            this.Dispose();
        }
        //计时器
        private int openingtime = 0;//记录页面打开时间
        private int learningtime = 0;//记录学习时间
        public static bool learn = true;//记录当前学习状态
        public static bool open = true;//记录打开页面的时间
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (open == true)
            {
                openingtime++;//计时：秒
            }
            else if (learn == true)//如果当前学习状态为学习，则学习时间增加
            {
                learningtime++;
            }             
            //显示当前时间和打开时间
            lbl_timecount.Text = (openingtime / 60).ToString() + "分" + (openingtime % 60).ToString() + "秒";//显示已打开时间
            lbl_learnTime.Text = (learningtime / 60).ToString() + "分" + (learningtime % 60).ToString() + "秒";//显示已学时间
            DateTime dt = System.DateTime.Now;//获取当前时间
            L_lblTime.Font = font;  //设置label1显示字体
            L_lblTime.Text = dt.ToString();//显示当前时间

            //判断学习状态
            if (learningtime % 30 == 0)//每隔一段时间进行弹窗确认学习状态
            {
                learningtime++;
                learn = false;//未回应则设置为不在学习
                lbl_learningState.Text = "不在学习";
                MessageBox.Show("请确认您当前的学习状况！");
                learn = true;//回应成功修改成正在学习
                lbl_learningState.Text = "正在学习";
            }
            if (learningtime > c_minTime)
                L_btnExam.Enabled = true;
            if (openingtime > c_maxTime)
            {
                timer1.Stop();
                MessageBox.Show("您已超过学习时间,请重新学习");
                openingtime = 0;
                learningtime = 0;
                //L_btnReturn_Click(sender, e);
            }

        }
        private void btn_preview_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(mp3,wav,mp4,mov,wmv,mpg,pdf)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg;*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //System.Diagnostics.Process.Start(openFileDialog1.FileName);//用外部程序打开
                string fileExtension = Path.GetExtension(openFileDialog1.FileName);//文件路径及扩展名
                if (fileExtension == ".pdf")//打开pdf文件
                {
                    //this.axAcroPDF1.LoadFile(fileExtension);
                }
                else if(fileExtension == ".mp3" || fileExtension == ".wav" || fileExtension == ".mp4" ||
                    fileExtension == ".mov" || fileExtension == ".wmv" || fileExtension == ".mpg")//打开视频文件
                {
                    Video video = new Video(fileExtension);
                    video.Owner = this;
                    video.ShowDialog();
                    //axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                }
            }
        }
        //遍历文件夹    
        private void scan(FileSystemInfo info)
        {
            if (!info.Exists) return;
            DirectoryInfo dir = info as DirectoryInfo;
            //不是目录
            if (dir == null) return;
            FileSystemInfo[] files = dir.GetFileSystemInfos();
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = files[i] as FileInfo;
                //是文件
                if (file != null)
                {
                    string lblname = file.Name;
                    var lbl = new Label {Text = lblname};
                    lbl.AutoSize = true;
                    lbl.Font = font;
                    lbl.Anchor = AnchorStyles.None;
                    var button = new Button {Name=lblname,Text = "打开" };
                    button.Click += new EventHandler(Filesopen);
                    fLP_filesPreview.Controls.Add(lbl);fLP_filesPreview.Controls.Add(button);
                    fLP_filesPreview.SetFlowBreak(button, true);
                    //listBox.Items.Add("名字: " + file.Name + ", 创建时间: " + file.CreationTime
                    //    + ", 扩展名: " + file.Extension + ", 上次访问时间: " + file.LastAccessTime);

                }
            }
        }
        //打开指定路径的文件
        private void Filesopen(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string fileroad = "D:\\01 SQL培训\\2.0视频\\第1单元_Select" + button.Name;//文件路径
            string fileExtension = Path.GetExtension(fileroad);//即扩展名 
            if(fileExtension==".pdf")//打开pdf文件
            {
                System.Diagnostics.Process.Start(fileroad);
            }
            else if(fileExtension== ".mp3"||fileExtension==".wav"||fileExtension==".mp4"||
                    fileExtension==".mov"||fileExtension==".wmv"||fileExtension==".mpg")//打开视频文件
            {
                Video video = new Video(fileroad);
                video.Owner = this;
                video.ShowDialog();
            }
            else
            {
                MessageBox.Show("不支持该文件类型！");
            }
        }

        private void L_btnExam_Click(object sender, EventArgs e)
        {
            learn = false;
            open = false;
            ExamForm.c_id = c_id;
            ExamForm examForm = new ExamForm();
            examForm.Owner = this;
            this.Hide();
            examForm.Show();
        }
    }
}
