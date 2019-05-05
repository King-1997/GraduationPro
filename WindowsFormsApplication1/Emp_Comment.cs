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
    public partial class Emp_Comment : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public static int c_id = -1;
        public static int ed_id = -1;
        public Emp_Comment()
        {
            InitializeComponent();
            ec_lbl_user_name.Text = Model.User.userName;
        }
        //窗体加载方法
        private void Emp_Comment_Load(object sender, EventArgs e)
        {
            ed_id = -1;
            ec_tbx_comment.Text = null;
            string select_sql = "select (select u_name from [User] where u_id = ed.u_id),ed.ed_time,ed.ed_id,ed.u_id,ed.ed_text from emp_discuss ed where c_id = " + c_id;
            loadInfo(select_sql);
        }
        private void loadInfo(string sql)
        {
            ec_flp_comment.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            //在窗口添加学习计划信息
            if (ds.Tables["user"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //评论楼层
                    var comment_floor = new Label { Text = "#"+(i+1)+"楼" };
                    comment_floor.Font = font;
                    comment_floor.Width = 100;
                    comment_floor.TextAlign = ContentAlignment.MiddleCenter;
                    ec_flp_comment.Controls.Add(comment_floor);
                    //用户名
                    var user_name = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    user_name.Font = font;
                    user_name.Width = 100;
                    //user_name.TextAlign = ContentAlignment.MiddleCenter;
                    ec_flp_comment.Controls.Add(user_name);
                    //评论时间
                    var comment_time = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    comment_time.Font = font;
                    comment_time.Width = 200;
                    comment_time.TextAlign = ContentAlignment.MiddleCenter;
                    ec_flp_comment.Controls.Add(comment_time);
                    //当该条评论为自己的时，添加删除按钮
                    if((int)ds.Tables["user"].Rows[i][3] == Model.User.userId)
                    {
                        //删除评论按钮
                        var btn_delete = new Button { Text = "删除" };
                        //btn_delete.Font = font;
                        btn_delete.Width = 50;
                        btn_delete.TextAlign = ContentAlignment.MiddleCenter;
                        btn_delete.Name = ds.Tables["user"].Rows[i][2].ToString();
                        btn_delete.Click += new EventHandler(deleteComment);
                        ec_flp_comment.Controls.Add(btn_delete);
                    }
                    //评论按钮
                    var btn_comment = new Button { Text = "回复" };
                    //btn_comment.Font = font;
                    btn_comment.Width = 50;
                    btn_comment.TextAlign = ContentAlignment.MiddleCenter;
                    btn_comment.Name = ds.Tables["user"].Rows[i][2].ToString();
                    btn_comment.Click += new EventHandler(replyComment);
                    ec_flp_comment.Controls.Add(btn_comment);
                    ec_flp_comment.SetFlowBreak(btn_comment, true);

                    //占位符
                    var lbl_false = new Label { Text = "" };
                    lbl_false.Font = font;
                    lbl_false.Width = 110;
                    ec_flp_comment.Controls.Add(lbl_false);
                    //评论内容
                    var comment_text = new Label { Text = ds.Tables["user"].Rows[i][4].ToString() };
                    comment_text.Font = font;
                    comment_text.Width = 400;
                    //comment_text.TextAlign = ContentAlignment.MiddleCenter;
                    ec_flp_comment.Controls.Add(comment_text);
                    ec_flp_comment.SetFlowBreak(comment_text, true);
                }
            }else
            {
                //查询不到数据时提示无数据
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 579;
                lbl_no_data.Height = 150;
                ec_flp_comment.Controls.Add(lbl_no_data);
            }
        }
        //回复某一评论
        private void replyComment(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int.TryParse(button.Name,out ed_id);
            ec_btn_submit_Click(sender,e);
        }
        //删除评论按钮事件处理
        private void deleteComment(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            int.TryParse(button.Name, out ed_id);
            DataBaseConnection dc = new DataBaseConnection();
            string delete_comment = "delete from emp_discuss where ed_id = "+ed_id;
            int flag = dc.ExecuteUpdate(delete_comment);
            if (flag == 1)
            {
                MessageBox.Show("删除评论成功！");
            }else
            {
                MessageBox.Show("删除评论失败，请重试！");
            }
            Emp_Comment_Load(sender, e);
        }
        //显示或隐藏评论区域
        //private void showOrHide(Boolean flag)
        //{
        //    ec_lbl_create_comm.Visible = flag;
        //    ec_lbl_userName.Visible = flag;
        //    ec_lbl_user_name.Visible = flag;
        //    ec_lbl_user_name.Text = Model.User.userName;
        //    ec_lbl_Comment.Visible = flag;
        //    ec_tbx_comment.Visible = flag;
        //    ec_btn_submit.Visible = flag;
        //    ec_btn_cancel.Visible = flag;
        //}
        //提交评论按钮事件处理
        private void ec_btn_submit_Click(object sender, EventArgs e)
        {
            string user_name = ec_lbl_user_name.Text;
            string comment = ec_tbx_comment.Text;
            DataBaseConnection dc = new DataBaseConnection();
            if (string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("请输入评论内容！");
            }else
            {
                string insert_sql = "insert into emp_discuss values(next value for emp_discuss_s,"+Model.User.userId+","+c_id+",'"+comment+ "',CONVERT(varchar(100), GETDATE(), 120),"+ed_id+")";
                int flag = dc.ExecuteUpdate(insert_sql);
                if(flag == 1)
                {
                    MessageBox.Show("评论成功！");
                }
                Emp_Comment_Load(sender,e);
            }            
        }

        private void ec_btn_return_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Dispose();
        }
    }
}
