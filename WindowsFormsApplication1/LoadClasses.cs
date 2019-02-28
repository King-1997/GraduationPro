﻿using CCWin;
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
    public partial class LoadClasses : CCSkinMain
    {
        public static String c_name = null;
        public static List<string> question = new List<string>();
        public LoadClasses()
        {
            InitializeComponent();
            LC_cbb_ifExam.Items.AddRange(new object[] { "是", "否" });
            LC_cbb_ifExam.SelectedIndex = 0;

            if (c_name != null)
            {
                Lal_windowname.Text = "课程信息修改";
                btn_upload.Text = "确定";
                Console.WriteLine("ClassesInfo里的课程名：" + c_name);
                DataBaseConnection dc = new DataBaseConnection();
                String sql = "select c.c_name,u.u_name,c.c_introduction,c.c_file,c.c_credit,c.c_recommendTime,c.c_ifExam,c_minTime,c_maxTime from [User] u,Classes c where c.u_id = u.u_id and c_name = N'" + c_name + "'";
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
                }else if (ds.Tables["user"].Rows[0][6].ToString().Equals("否"))
                {
                    LC_cbb_ifExam.SelectedIndex = 1;
                }
                txtBx_classMinTime.Text = ds.Tables["user"].Rows[0][7].ToString();
                txtBx_classMaxTime.Text = ds.Tables["user"].Rows[0][8].ToString();
            }
        }
        
        private void ClassChoose_Load(object sender, EventArgs e)
        {
            this.lbl_classhanded_show.Text = User.userName;
           
        }
        //取消操作，返回上一界面
        private void btn_return_Click(object sender, EventArgs e)
        {
            
            this.Owner.Show();
            this.Dispose();
        }
       
        //上传课程
        private void btn_upload_Click(object sender, EventArgs e)
        {
            String c_name1 = txtBx_classname.Text;
            String c_introdution = txtBxIntroduce.Text;
            String c_file = lc_txtBxFileName.Text;
            String c_credit = txtBx_grade.Text;
            String c_time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            String c_recommendTime = txtBx_classTime.Text;
            String c_ifExam = LC_cbb_ifExam.SelectedItem.ToString();
            String c_maxTime = txtBx_classMaxTime.Text;
            String c_minTime = txtBx_classMinTime.Text;
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
            else if(string.IsNullOrEmpty(c_maxTime) || string.IsNullOrEmpty(c_minTime))
                MessageBox.Show("请输入最大或最小学习时间！！！");
            else
            {
                //修改课程信息
                if (btn_upload.Text.Equals("确定"))
                {
                    String select_c_id = "select c_id from Classes where c_name =N'" + c_name+"'";
                    DataSet ds = dc.ExecuteQuery(select_c_id);
                    int c_id = (int)ds.Tables["user"].Rows[0][0];
                    String update_sql = "update Classes set c_name = N'" + c_name1 + "',c_introduction = N'" + c_introdution + "',c_file = N'" + c_file + "',c_credit = '"+ c_credit + "',c_recommendTime = '"+ c_recommendTime + "',c_ifExam = N'" + c_ifExam + "',c_maxTime = "+c_maxTime+",c_minTime = "+c_minTime+" where c_id = "+c_id+"";
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
                        //用户选择确认上传考题的操作
                        ExamShow.className = c_name;
                        ExamShow.className = txtBx_classname.Text;
                        ExamShow examShow = new ExamShow();
                        examShow.Owner = this;
                        this.Hide();
                        examShow.Show();
                    }
                    else
                    {
                        this.Owner.Show();
                        this.Dispose();
                    }
                }else if (btn_upload.Text.Equals("上传"))
                {
                    //将课程信息保存到数据库
                    //选择考题信息               
                    String insert_sql = "insert into Classes values (" + User.userId + ",N'" + c_name1 + "'," + c_credit + ",N'" + c_file + "','" + c_time + "',N'" + c_introdution + "',N'" + c_ifExam + "'," + c_recommendTime + ",0,"+c_minTime+","+c_maxTime+")";
                    Console.WriteLine("SQL:"+insert_sql);
                    int flag = dc.ExecuteUpdate(insert_sql);
                    if (flag == 1)
                    {
                        MessageBox.Show("上传课程成功！");
                        if (c_ifExam.Equals("是"))
                        {
                            //用户选择确认上传考题的操作
                            ExamShow.className = c_name;
                            ExamShow.className = txtBx_classname.Text;
                            ExamShow examShow = new ExamShow();
                            examShow.Owner = this;
                            this.Hide();
                            examShow.Show();
                        }
                        else
                        {
                            this.Owner.Show();
                            this.Dispose();
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
            ofd.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";//设置打开文件类型
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = ofd.FileName;//FileName就是要打开的文件路径
                                               //下边可以添加用户代码
                this.lc_txtBxFileName.Visible = true;
                lc_txtBxFileName.Text = FileName;               
            }            
        }

    }
}