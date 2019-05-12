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
    public partial class LoadClasses : CCSkinMain
    {
        public static int c_id = -1;
        public static List<string> question = new List<string>();
        public LoadClasses()
        {
            InitializeComponent();
            LC_cbb_ifExam.Items.AddRange(new object[] { "是", "否" });
            LC_cbb_ifExam.SelectedIndex = 0;

            if (c_id != -1)
            {
                Lal_windowname.Text = "课程信息修改";
                btn_upload.Text = "确定";
                //Console.WriteLine("ClassesInfo里的课程id：" + c_id);
                DataBaseConnection dc = new DataBaseConnection();
                String sql = "select c.c_name,g.g_group,c.c_introduction,c.c_file,c.c_credit,c.c_recommendTime,c.c_ifExam,c_minTime,c_maxTime,c_annex from [group] g,Classes c where c.u_id = g.g_id and c_id = " + c_id + "";
                DataSet ds = dc.ExecuteQuery(sql);
                lbl_classhanded_show.Text = ds.Tables["user"].Rows[0][1].ToString();
                txtBx_classname.Text = ds.Tables["user"].Rows[0][0].ToString();
                txtBxIntroduce.Text = ds.Tables["user"].Rows[0][2].ToString();
                lc_txtBxFileName.Text = ds.Tables["user"].Rows[0][3].ToString();
                txtBx_grade.Text = ds.Tables["user"].Rows[0][4].ToString();
                txtBx_classTime.Text = ds.Tables["user"].Rows[0][5].ToString();
                if (ds.Tables["user"].Rows[0][6].ToString().Equals("是"))
                {
                    LC_cbb_ifExam.SelectedIndex = 0;
                }
                else if (ds.Tables["user"].Rows[0][6].ToString().Equals("否"))
                {
                    LC_cbb_ifExam.SelectedIndex = 1;
                }
                txtBx_classMinTime.Text = ds.Tables["user"].Rows[0][7].ToString();
                txtBx_classMaxTime.Text = ds.Tables["user"].Rows[0][8].ToString();
                lc_txtBxAnnexName.Text = ds.Tables["user"].Rows[0][9].ToString();
            }
        }

        private void ClassChoose_Load(object sender, EventArgs e)
        {
            lbl_classhanded_show.Text = Model.User.userName;

        }
        //取消操作，返回上一界面
        private void btn_return_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Dispose();
        }

        //上传课程
        private void btn_upload_Click(object sender, EventArgs e)
        {
            string c_name1 = txtBx_classname.Text;
            string c_introdution = txtBxIntroduce.Text;
            string c_file = lc_txtBxFileName.Text;
            string c_credit = txtBx_grade.Text;
            //string c_time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string c_recommendTime = txtBx_classTime.Text;
            string c_ifExam = LC_cbb_ifExam.SelectedItem.ToString();
            string c_maxTime = txtBx_classMaxTime.Text;
            string c_minTime = txtBx_classMinTime.Text;
            string c_axxex = lc_txtBxAnnexName.Text;
            DataBaseConnection dc = new DataBaseConnection();
            //判断输入是否正确
            if (string.IsNullOrEmpty(c_name1))
                MessageBox.Show("请输入课程名称！！！");
            else if (string.IsNullOrEmpty(c_introdution))
                MessageBox.Show("请输入课程简介！！！");
            else if (string.IsNullOrEmpty(c_recommendTime))
                MessageBox.Show("请选择课程推荐学时！！！");
            else if (string.IsNullOrEmpty(c_file))
                MessageBox.Show("请选择要上传的课件！！！");
            else if (string.IsNullOrEmpty(c_credit))
                MessageBox.Show("请选择该课程具有的学分！！！");
            else if (string.IsNullOrEmpty(c_maxTime) || string.IsNullOrEmpty(c_minTime))
                MessageBox.Show("请输入最大或最小学习时间！！！");
            else
            {
                //修改课程信息
                if (btn_upload.Text.Equals("确定"))
                {
                    String update_sql = "update Classes set c_name = N'" + c_name1 + "',c_introduction = N'" + c_introdution + "',c_file = N'" + c_file + "',c_credit = '" + c_credit + "',c_recommendTime = '" + c_recommendTime + "',c_ifExam = N'" + c_ifExam + "',c_maxTime = " + c_maxTime + ",c_minTime = " + c_minTime + ",c_annex = N'" + c_axxex + "' where c_id = " + c_id + "";
                    Console.WriteLine("更新操作的sql语句：" + update_sql);
                    if (dc.ExecuteUpdate(update_sql) != 0)
                    {
                        MessageBox.Show("修改课程信息成功！");
                    }
                    else
                    {
                        MessageBox.Show("系统错误！");
                    }
                    if (c_ifExam.Equals("是"))
                    {
                        MessageBox.Show("将进入试题界面继续修改数据！");
                        //用户选择确认上传考题的操作
                        ExamShow.c_id = c_id;
                        ExamShow examShow = new ExamShow();
                        examShow.Owner = this;
                        Hide();
                        examShow.Show();
                    }
                    else
                    {
                        Owner.Show();
                        Dispose();
                    }
                }
                else if (btn_upload.Text.Equals("上传"))
                {
                    //将课程信息保存到数据库
                    //选择考题信息
                    string select_c_id = "select next value for Classes_s";
                    DataSet ds = dc.ExecuteQuery(select_c_id);
                    int.TryParse(ds.Tables["user"].Rows[0][0].ToString(), out c_id);
                    string insert_sql = "insert into Classes values (" + c_id + "," + Model.User.groupId + ",N'" + c_name1 + "'," + c_credit + ",N'" + c_file + "',convert(char(10),GetDate(),120),N'" + c_introdution + "',N'" + c_ifExam + "'," + c_recommendTime + ",0," + c_minTime + "," + c_maxTime + ",N'" + c_axxex + "')";
                    //Console.WriteLine("SQL:" + insert_sql);
                    int flag = dc.ExecuteUpdate(insert_sql);
                    if (flag != 0)
                    {
                        MessageBox.Show("上传课程成功！");
                        if (c_ifExam.Equals("是"))
                        {
                            //用户选择确认上传考题的操作
                            ExamShow.c_id = c_id;
                            ExamShow examShow = new ExamShow();
                            examShow.Owner = this;
                            Hide();
                            examShow.Show();
                        }
                        else
                        {
                            Owner.Show();
                            Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("系统错误！");
                    }
                }
            }
        }
        //选择上传文件，获取其路径
        private void lc_btnChooceFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//新建打开文件对话框
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//设置初始文件目录
            ofd.Filter = "所有文件(*.*)|*.*";//设置打开文件类型
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = ofd.FileName;//FileName就是要打开的文件路径
                                               //下边可以添加用户代码
                lc_txtBxFileName.Visible = true;
                lc_txtBxFileName.Text = FileName;
            }
        }

        private void lc_btn_upload_Click(object sender, EventArgs e)
        {
            //Tools.Upload upload = new Tools.Upload();
            //upload.Upload_Request(lc_txtBxFileName.Text, Path.GetFileName(lc_txtBxFileName.Text), lc_pro_file,lc_lbl_time,lc_lbl_speed,lc_lbl_state,lc_lbl_size);
        }

        private void lc_btnChooceAnnex_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//新建打开文件对话框
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//设置初始文件目录
            ofd.Filter = "所有文件(*.*)|*.*";//设置打开文件类型
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = ofd.FileName;//FileName就是要打开的文件路径
                                               //下边可以添加用户代码
                lc_txtBxAnnexName.Visible = true;
                lc_txtBxAnnexName.Text = FileName;
            }
        }
    }
}