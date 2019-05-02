using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CCWin;

namespace WindowsFormsApplication1
{
    public partial class Login : CCSkinMain
    {
        public Login()
        {
            InitializeComponent();
            //skinEngine1.SkinFile = "DeepCyan.ssk";
            DataBaseConnection dc = new DataBaseConnection();
            String select_user_type = "select ut_type from UserType";
            DataSet ds = dc.ExecuteQuery(select_user_type);
            for(int i = 0;i<ds.Tables["user"].Rows.Count;i++)
            {
                comboBox1.Items.Add(ds.Tables["user"].Rows[i][0]);
            }
            //comboBox1.Items.AddRange(new object[] { "系统管理员", "管理员", "员工" });
            comboBox1.SelectedIndex = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. 获取数据
            //从TextBox中获取用户输入信息
            string userName = textUserName.Text;
            string userPassword = textPassword.Text;
            string userType = comboBox1.SelectedItem.ToString();
            Console.WriteLine("下拉框中的值:" + userType);
            //2. 验证数据
            // 验证用户输入是否为空，若为空，提示用户信息
            if (userName.Equals("") || userPassword.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            // 若不为空，验证用户名和密码是否与数据库匹配
            else
            {
                //3. 处理数据                               
                try
                {
                    DataBaseConnection sqlCommend = new DataBaseConnection();
                    String sql = "select u.u_account,u.u_password,u_name,ut.ut_type,u.u_id,u.g_id,u.u_email from [User] u,usertype ut where u.ut_id = ut.ut_id and u_account = N'" + userName + "'";//查询语句                    
                    //Console.WriteLine(sql);                    
                    DataSet ds = new DataSet();
                    ds = sqlCommend.ExecuteQuery(sql);
                    if (ds != null || (ds.Tables.Count == 0) || (ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0))
                    {

                        String u_account = ds.Tables["user"].Rows[0][0].ToString();
                        String u_password = ds.Tables["user"].Rows[0][1].ToString();
                        String u_name = ds.Tables["user"].Rows[0][2].ToString();
                        String u_type = ds.Tables["user"].Rows[0][3].ToString();
                        int u_id = (int)ds.Tables["user"].Rows[0][4];
                        int g_id = (int)ds.Tables["user"].Rows[0][5];
                        String u_email = ds.Tables["user"].Rows[0][6].ToString();
                        //用户名和密码验证正确，提示成功，并执行跳转界面。
                        if (userName.Equals(u_account) && userPassword.Equals(u_password) && userType.Equals(u_type))
                        {
                            MessageBox.Show("登录成功！");
                            //跳转主界面
                            Mainmenu main1 = new Mainmenu();
                            Model.User.userName = u_name;//记录用户名
                            Model.User.userType = u_type;
                            Model.User.userId = u_id;
                            Model.User.groupId = g_id;
                            Model.User.email = u_email;
                            main1.Owner = this;
                            main1.Show();
                            Hide();
                        }
                        //用户类型选择错误，提示错误。
                        else if (userName.Equals(u_account) && userPassword.Equals(u_password) && !userType.Equals(u_type))
                        {
                            MessageBox.Show("用户类型错误！");
                        }
                        //用户名和密码验证错误，提示错误。
                        else
                        {
                            MessageBox.Show("用户名或密码错误！");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("用户不存在！");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.isValidUser = false;

            Dispose();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
