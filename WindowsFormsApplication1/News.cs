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
    public partial class News : CCSkinMain
    {

        public static string sr_id = null;
        public News()
        {
            InitializeComponent();
        }

        private void N_btn_confirm_Click(object sender, EventArgs e)
        {
            //先将处理结果存入申请记录表中
            String result = N_cbx_IfAgree.SelectedItem.ToString();
            String reason = N_tbx_DisAgree.ToString();
            String handleTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            DataBaseConnection dc = new DataBaseConnection();
            String sql = "update SignRecord set sr_reason = '"+reason+"',sr_person1 = '"+User.userName+"',sr_result1 = '"+result+"',sr_handleTime1 = '"+ handleTime + "' where sr_id = "+sr_id+"";
            int flag = dc.ExecuteUpdate(sql);
            if(flag != 0)
            {
                MessageBox.Show("处理申请成功，正在发送通知邮件！");
                //再判断是否需要上级签批，若需要上级签批，则发送邮件给上级，若无后续处理，则给申请人发送反馈邮件
                String select_sql = "select sr_startTime,sr_endTime from SignRecord where sr_id = " + sr_id + "";
                DataSet ds = dc.ExecuteQuery(select_sql);
                DateTime startTime = Convert.ToDateTime(ds.Tables["user"].Rows[0][0].ToString());
                DateTime endTime = Convert.ToDateTime(ds.Tables["user"].Rows[0][1].ToString());
                //将申请的开始和结束时间做计算，来判断是否需要进行下一步处理
                int i = (int)((endTime.Subtract(startTime).TotalMilliseconds) / 43200000) + 1;
                Console.WriteLine(i);
                String select_sql1 = ""; 
                if (i > 1)
                {
                    select_sql1 += "select u_email from [User] where g_id in (select g_id from [group] where g_group = '经理')";
                }
                else if (i <= 1)
                {
                    select_sql1 = "select u_email from [User] where u_id in (select u_id from SignRecord where sr_id = " + sr_id + ")";
                }

                DataSet ds1 = dc.ExecuteQuery(select_sql);
                EmailSend es = new EmailSend();
                String mailAddress = ds1.Tables["user"].Rows[0][0].ToString();
                es.sendFeedBackEmail(User.userName);
                N_btn_cancel_Click(sender,e);
            }
            else
            {
                MessageBox.Show("系统错误！");
            }
            
        }

        private void N_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void News_Load(object sender, EventArgs e)
        {
            DataBaseConnection dc = new DataBaseConnection();
            String select_sql = "select u.u_name,g.g_group,sr.sr_type,sr.sr_reason from [User] u,[group] g,SignRecord sr where sr.sr_id = "+sr_id+" and sr.u_id = u.u_id and u.g_id = g.g_id";
            DataSet ds = dc.ExecuteQuery(select_sql);
            N_lbl_Name.Text = ds.Tables["user"].Rows[0][0].ToString();
            N_lbl_Group.Text = ds.Tables["user"].Rows[0][1].ToString();
            N_lbl_Type.Text = ds.Tables["user"].Rows[0][2].ToString();            
            N_tbx_Reason.Text = ds.Tables["user"].Rows[0][3].ToString();
        }

        private void N_cbx_IfAgree_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (N_cbx_IfAgree.Text == "同意")
            {
                N_lbl_DisAgreeLbl.Visible = false;
                N_tbx_DisAgree.Visible = false;
            }
            else if (N_cbx_IfAgree.Text == "驳回")
            {
                N_lbl_DisAgreeLbl.Visible = true;
                N_tbx_DisAgree.Visible = true;
            }
            else
            {
                MessageBox.Show("系统错误！");
            }
        }
    }
}
