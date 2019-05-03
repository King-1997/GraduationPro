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
    public partial class ApplyView : CCSkinMain
    {
        public ApplyView()
        {
            InitializeComponent();
            //AV_Combx_category.Items.Add(new object[] { "请假", "加班" });
        }
        //注销返回登陆界面
        private void Logout_button_Click(object sender, EventArgs e)
        {
            this.Owner.Owner.Show();//打开登陆界面
            this.Owner.Dispose();
        }
        //返回上一界面
        private void Return_button_Click(object sender, EventArgs e)
        {
            this.Owner.Show();//打开父界面
            this.Dispose();
        }

        private void ApplyView_Load(object sender, EventArgs e)
        {
            AV_lbl_User.Text = Model.User.userName;
            AV_dtp_StartTime.MinDate = DateTime.Now;
            //AV_dtp_EndTime.MinDate = this.AV_dtp_StartTime.Value;
            AV_dtp_EndTime.MinDate = DateTime.Parse(AV_dtp_StartTime.Value.ToString());
            AV_Combx_category.Items.AddRange(new object[] { "事假", "病假", "产假/陪产假","丧假","其他" });
            AV_Combx_category.SelectedIndex = 0;
            AV_Combx_Prove.Items.AddRange(new object[] { "未提交", "已提交并通过", "已提交并未通过" });
            AV_Combx_Prove.SelectedIndex = 0;
        }

        private void AV_btn_Submit_Click(object sender, EventArgs e)
        {
            //获取控件中输入的值
            String type = this.AV_Combx_category.SelectedItem.ToString();
            String reason = this.AV_txtBx_Reason.Text;
            DateTime startTime = this.AV_dtp_StartTime.Value;
            //Console.WriteLine("开始时间的格式："+startTime);
            DateTime endTime = this.AV_dtp_EndTime.Value;
            //Console.WriteLine("结束时间的格式：" + endTime);
            //Console.WriteLine(endTime.Subtract(startTime).TotalMilliseconds);
            int i = (int)((endTime.Subtract(startTime).TotalMilliseconds) / 43200000)+1;
            //Console.WriteLine(i);
            DateTime nowTime = DateTime.Now;
            if(endTime > startTime)
            {
                //连接数据库
                DataBaseConnection dc = new DataBaseConnection();
                String insert_sql = "insert into SignRecord values (next value for SignRecord_s," + Model.User.userId+",'"+type+"','"+nowTime+"','"+startTime+"','"+endTime+"','"+reason+ "',null,null,null,null,null,null,null,null,null,null,null,null)";
                int flag = dc.ExecuteUpdate(insert_sql);
                //查询当前分组主管邮箱地址
                String select_sql = "select u_email from [User] where ut_id in (select g_id from [UserType] where ut_type = '主管')";
                DataSet ds = dc.ExecuteQuery(select_sql);
                String email = ds.Tables["user"].Rows[0][0].ToString();
                Console.WriteLine("主管的email地址：" + email);
                if (flag != 0)
                {
                    MessageBox.Show("申请成功！");
                    EmailSend es = new EmailSend();
                    es.Sendemail(type, Model.User.userName,email);
                    Return_button_Click(sender,e);
                }
                else
                {
                    MessageBox.Show("系统错误！");
                }
            }
            else
            {
                MessageBox.Show("结束时间不能小于开始时间！");
            }                       
        }

        private void AV_btn_Logout_Click(object sender, EventArgs e)
        {
            this.Owner.Owner.Show();//打开登陆界面
            this.Owner.Dispose();
        }

        private void AV_btn_Return_Click(object sender, EventArgs e)
        {
            this.Owner.Show();//打开父界面
            this.Dispose();
        }
    }
}
