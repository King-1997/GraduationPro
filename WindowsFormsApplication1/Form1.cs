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
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new object[] { "系统管理员","管理员", "员工" });

            comboBox1.SelectedIndex = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. 获取数据
            //从TextBox中获取用户输入信息
            string userName = this.textUserName.Text;
            string userPassword = this.textPassword.Text;

            //2. 验证数据
            // 验证用户输入是否为空，若为空，提示用户信息
            if (userName.Equals("") || userPassword.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            // 若不为空，验证用户名和密码是否与数据库匹配
            // 这里只做字符串对比验证
            else
            {
                //用户名和密码验证正确，提示成功，并执行跳转界面。
                if (userName.Equals("admin") && userPassword.Equals("admin"))
                {
                    MessageBox.Show("登录成功！");

                    //跳转主界面
                    Main main1 = new Main(this);
                    main1.Show();
                    this.Hide();//父窗口隐藏
                }
                //用户名和密码验证错误，提示错误。
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
            }

            //3. 处理数据
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.isValidUser = false;

            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
