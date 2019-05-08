using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Learn : CCSkinMain
    {
        public static int c_id = -1;
        private string c_file = null;
        private string v_time = null;//获取当前视频文件时长string
        private double v_time_d = 0;//获取当前视频文件时长double
        private string v_position = null;
        private double v_position_d = 0;
        private string c_name = null;
        private string c_ifExam = null;
        private int c_maxTime = 30;
        private int c_minTime = 10;
        private string c_credit = null;
        private string c_annex = null;
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public Learn()
        {
            InitializeComponent();
        }
        
        private void Learn_Load(object sender, EventArgs e)
        {
            L_lblTime.Font = font;  //设置label1显示字体
            L_lblTime.Text = DateTime.Now.ToString("YYYY/MM/DD HH:mm:ss");
            //地址输入
            //DirectoryInfo theFolder = new DirectoryInfo(@"D:\01 SQL培训\2.0视频\第1单元_Select");
            //scan(theFolder);
            //根据课程名字查出文件所在地址
            DataBaseConnection dc = new DataBaseConnection();
            String select_c_file = "select c_file,c_ifExam,c_maxTime,c_minTime,c_name,c_credit,c_annex from Classes where c_id = " + c_id;
            DataSet ds = dc.ExecuteQuery(select_c_file);
            //将文件路径赋值给全局变量c_file
            c_file = ds.Tables["user"].Rows[0][0].ToString();
            Console.WriteLine("文件路径："+c_file);
            L_lblClassesFile.Text = c_file.Substring(c_file.LastIndexOf("\\") + 1);
            //将课程是否考试赋值给全局变量c_ifExam
            c_ifExam = ds.Tables["user"].Rows[0][1].ToString();
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
            //将课程最大学习时间赋值给全局变量c_maxTime
            c_maxTime = (int)ds.Tables["user"].Rows[0][2];
            //将课程最大学习时间赋值给全局变量c_minTime
            c_minTime = (int)ds.Tables["user"].Rows[0][3];
            //测试考试界面
            c_minTime = 0;
            c_name = ds.Tables["user"].Rows[0][4].ToString();
            L_lblClassesName.Text = c_name;
            c_credit = ds.Tables["user"].Rows[0][5].ToString();
            L_lblClassesCredit.Text = c_credit;

            //将附件名赋值给全局变量c_annex
            c_annex = ds.Tables["user"].Rows[0][6].ToString();
            Console.WriteLine("附件路径："+c_annex);
            Console.WriteLine(c_annex.LastIndexOf("\\")+1);
            Console.WriteLine("附件名："+c_annex.Substring(c_annex.LastIndexOf("\\")+1));
            L_lblClassesAnnex.Text = c_annex.Substring(c_annex.LastIndexOf("\\")+1);
        }
        private void L_btnReturn_Click(object sender, EventArgs e)
        {
            timer1.Stop();//关闭计时器
            Owner.Show();
            Dispose();
        }
        //计时器
        private int openingtime = 0;//记录页面打开时间
        private int learningtime = 0;//记录学习时间
        public static bool learn = false;//记录当前学习状态
        public static bool open = false;//记录打开页面的时间
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (open == true)
            {
                openingtime++;//计时：秒
            }
            if (learn == true)//如果当前学习状态为学习，则学习时间增加
            {
                learningtime++;
            }
            v_time = L_player.currentMedia.durationString;
            L_lbl_v_time.Text = v_time;
            v_time_d = L_player.currentMedia.duration;
            //实时刷新当前进度
            v_position = L_player.Ctlcontrols.currentPositionString;
            v_position_d = L_player.Ctlcontrols.currentPosition;
            l_lbl_position.Text = "当前视频进度为：" + v_position;
            //显示当前时间和打开时间
            lbl_timecount.Text = (openingtime / 60).ToString() + "分" + (openingtime % 60).ToString() + "秒";//显示已打开时间
            lbl_learnTime.Text = (learningtime / 60).ToString() + "分" + (learningtime % 60).ToString() + "秒";//显示已学时间
            DateTime dt = System.DateTime.Now;//获取当前时间            
            L_lblTime.Text = dt.ToString("yyyy-MM-dd HH:mm:ss");//显示当前时间
            //判断学习状态
            if (learningtime % 30 == 0)//每隔一段时间进行弹窗确认学习状态
            {
                l_btn_pause_Click(sender,e);
                learningtime++;
                learn = false;//未回应则设置为不在学习
                lbl_learningState.Text = "不在学习";
                MessageBox.Show("请确认您当前的学习状况！");
                learn = true;//回应成功修改成正在学习
                lbl_learningState.Text = "正在学习";
                l_btn_play_Click(sender,e);
            }
            if (learningtime > c_minTime * 60)
                L_btnExam.Enabled = true;
            if (openingtime > c_maxTime * 60)
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
            string fileExtension = Path.GetExtension(c_file);//文件路径及扩展名
            if (fileExtension == ".pdf")//打开pdf文件
            {
                System.Diagnostics.Process.Start(c_file);//使用第三方软件打开文件
                //axAcroPDF1.LoadFile(fileExtension);
            }
            else if (fileExtension == ".mp3" || fileExtension == ".wav" || fileExtension == ".mp4" ||
                fileExtension == ".mov" || fileExtension == ".wmv" || fileExtension == ".mpg")//打开视频文件
            {
                L_player.URL = c_file;
                open = true;
                L_player.Ctlcontrols.play();
                //v_time = L_player.currentMedia.durationString;
                //v_time_d = L_player.currentMedia.duration;
                //v_position = L_player.Ctlcontrols.currentPosition;
                //Console.WriteLine("视频播放进度：" + v_position);
                //Console.WriteLine("视频文件时长string："+v_time);
                //Console.WriteLine("视频文件时长double：" + v_time_d);
                //L_lbl_v_time.Text = v_time;
                //启动定时器
                timer1.Start();
                timer1.Interval = 1000;
                //将学习状态设置为正在学习
                learn = true;
                lbl_learningState.Text = "正在学习";
                //L_player.fullScreen = true;//全屏打开文件
            }
            else
            {
                MessageBox.Show("文件已损坏或者不存在，请联系相关管理人员！");
            }
        }
        //暂停按钮事件处理
        private void l_btn_pause_Click(object sender, EventArgs e)
        {
            L_player.Ctlcontrols.pause();
            learn = false;//未回应则设置为不在学习
            lbl_learningState.Text = "不在学习";
            //v_time = L_player.currentMedia.durationString;
            //v_position = L_player.Ctlcontrols.currentPosition;
            //l_lbl_position.Text = "当前视频进度为：" + v_position;
        }
        //播放按钮事件处理
        public void l_btn_play_Click(object sender, EventArgs e)
        {
            L_player.Ctlcontrols.play();
            learn = true;//回应成功修改成正在学习
            lbl_learningState.Text = "正在学习";
            //v_time = L_player.currentMedia.durationString;
            //v_position = L_player.Ctlcontrols.currentPosition;
            //l_lbl_position.Text = "当前视频进度为：" + v_position;
            //Console.WriteLine("视频播放进度：" + v_position);
            //Console.WriteLine("视频文件时长：" + v_time);
            //L_lbl_v_time.Text = v_time;
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
                    //button.Click += new EventHandler(Filesopen);
                    //fLP_filesPreview.Controls.Add(lbl);fLP_filesPreview.Controls.Add(button);
                    //fLP_filesPreview.SetFlowBreak(button, true);
                    //listBox.Items.Add("名字: " + file.Name + ", 创建时间: " + file.CreationTime
                    //    + ", 扩展名: " + file.Extension + ", 上次访问时间: " + file.LastAccessTime);
                }
            }
        }
        //打开指定路径的文件
        private void Filesopen(string fileroad)
        {
            //Button button = (Button)sender;
            //string fileroad = "D:\\01 SQL培训\\2.0视频\\第1单元_Select" + button.Name;//文件路径
            string fileExtension = Path.GetExtension(fileroad);//即扩展名 
            if(fileExtension==".pdf")//打开pdf文件
            {
                System.Diagnostics.Process.Start(fileroad);
            }
            else if(fileExtension== ".mp3"||fileExtension==".wav"||fileExtension==".mp4"||
                    fileExtension==".mov"||fileExtension==".wmv"||fileExtension==".mpg")//打开视频文件
            {
                L_player.URL = c_file;
                open = true;
            }
            else
            {
                MessageBox.Show("不支持该文件类型！");
            }
        }
        //考试按钮事件处理
        private void L_btnExam_Click(object sender, EventArgs e)
        {
            if (v_position_d < v_time_d)//将当前视频进度与视频总长度进行对比
            {
                if (MessageBox.Show("检测到您未完成该视频的学习，确定直接进入考试吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //learn = false;
                    open = false;
                    l_btn_pause_Click(sender, e);
                    ExamForm.c_id = c_id;
                    ExamForm examForm = new ExamForm();
                    examForm.Owner = this;
                    Hide();
                    examForm.Show();
                }
            }else//当前视频播放进度等于视频总长度时也可以直接进入考试界面进入
            {
                //learn = false;
                open = false;
                l_btn_pause_Click(sender, e);
                ExamForm.c_id = c_id;
                ExamForm examForm = new ExamForm();
                examForm.Owner = this;
                Hide();
                examForm.Show();
            }
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            string foldPath, filename;
            FolderBrowserDialog dialog = new FolderBrowserDialog();//新建选择文件夹对话框
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foldPath = dialog.SelectedPath;
                filename = foldPath + "123.pdf";
                //Tools.Download.DownloadFile(c_annex, filename, L_progressBar, L_lbl_pcb);
            }
            //L_progressBar.Visible = true;
            //L_lbl_pcb.Visible = true;
        }

        private void L_btn_discuss_Click(object sender, EventArgs e)
        {
            //learn = false;
            open = false;
            l_btn_pause_Click(sender,e);
            Emp_Comment.c_id = c_id;
            Emp_Comment emp_comment = new Emp_Comment();
            emp_comment.Owner = this;
            Hide();
            emp_comment.Show();
        } 
    }
}
