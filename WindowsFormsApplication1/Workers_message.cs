using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Workers_message : CCSkinMain
    {
        public static String u_account = null;
        public static int u_id = -1;
        public Workers_message()
        {
            InitializeComponent();
            DataBaseConnection dc = new DataBaseConnection();
            String select_user_type = "select ut_type from UserType";
            DataSet ds = dc.ExecuteQuery(select_user_type);
            for (int i = 0; i < ds.Tables["user"].Rows.Count; i++)
            {
                Wm_cbBUserType.Items.Add(ds.Tables["user"].Rows[i][0]);
            }
            //Wm_cbBUserType.Items.AddRange(new object[] { "系统管理员", "管理员", "员工" });
            Wm_cbBUserType.SelectedIndex = 0;

            String select_emp_station = "select station_name from employee_station";
            DataSet ds1 = dc.ExecuteQuery(select_emp_station);
            Wm_cbBEmpStation.Items.AddRange(new object[] {"无" });
            for (int i = 0; i < ds1.Tables["user"].Rows.Count; i++)
            {
                Wm_cbBEmpStation.Items.Add(ds1.Tables["user"].Rows[i][0]);
            }
            //Wm_cbBUserType.Items.AddRange(new object[] { "系统管理员", "管理员", "员工" });
            Wm_cbBEmpStation.SelectedIndex = 0;

            String sql = "select g_group from [group]";
            DataSet ds2 = dc.ExecuteQuery(sql);
            for (int i = 0; i < ds2.Tables["user"].Rows.Count; i++)
            {
                Wm_cbBGroup.Items.Add(ds2.Tables["user"].Rows[i][0]);
            }
            //Wm_cbBGroup.Items.AddRange(new object[] { "涂装", "花洒", "人力资源","拉丝"});
            Wm_cbBGroup.SelectedIndex = 0;

            Wm_cbBSex.Items.AddRange(new object[] { "男", "女"});
            Wm_cbBSex.SelectedIndex = 0;
        }
        //返回上一界面
        private void Mw_btnReturn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
        //修改员工信息
        private void btn_alter_Click(object sender, EventArgs e)
        {
            //读取信息

            //数据库操作

            //刷新显示
        }
        //删除员工
        private void Wm_btnDelete_Click(object sender, EventArgs e)
        {
            if (Wm_btnDelete.Text.Equals("删除"))
            {
                if (MessageBox.Show("您确定要删除吗", "判断", MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //确认删除
                    //数据库操作
                    DataBaseConnection dc = new DataBaseConnection();
                    String sql = "delete from [User] where u_id = "+u_id;
                    int flag = dc.ExecuteUpdate(sql);
                    if(flag == 1)
                    {
                        MessageBox.Show("删除员工成功！");
                        //返回员工选择界面
                        Man_Management man_ManageMent = (Man_Management)this.Owner;
                        man_ManageMent.btn_find_Click(sender,e);
                        this.Owner.Show();
                        this.Dispose();
                    }else
                    {
                        MessageBox.Show("系统错误！");
                    }
                    
                }
            }else if (Wm_btnDelete.Text.Equals("确定"))
            {               
                    DataBaseConnection dc = new DataBaseConnection();

                    int ut_id = Wm_cbBUserType.SelectedIndex + 1;
                    int g_id = Wm_cbBGroup.SelectedIndex + 1;

                //验证输入的省份证号码是否有误
                //CheckChinaIDCardNumberFormat(Wm_tbxIDNum.Text);
                //验证输入的电话号码是否有误
                //CheckPhoneIsAble(Wm_tbxPhone.Text);

                //默认状态下，DateTimePicker控件只显示日期，如果想更改为显示时间，或日期+时间，需要做以下设置：
                //控制日期或时间的显示格式
                this.Wm_dtpEntryTime.CustomFormat = "yyyy-MM-dd";//显示时间则格式为"yyyy-MM-dd HH:mm:ss"，HH表示24小时制，hh则为12小时制
                //使用自定义格式
                this.Wm_dtpEntryTime.Format = DateTimePickerFormat.Custom;
                //时间控件的启用
                //this.Wm_dtpEntryTime.ShowUpDown = true;
                if (Wm_tbxAccount.Text == null)
                {

                }
                    String insert_sql = "insert into [User] values (next value for User_s," + ut_id + "," + g_id + ",'" + Wm_tbxAccount.Text + "','" + Wm_tbxAccount.Text + "',N'" + Wm_tbxUserName.Text + "',N'" + Wm_cbBSex.SelectedItem.ToString() + "',0,'" + Wm_tbxIDNum.Text + "','" + Wm_tbxPhone.Text + "','"+ this.Wm_dtpEntryTime.Value + "')";
                    Console.WriteLine("新增语句："+insert_sql);
                    int flag = dc.ExecuteUpdate(insert_sql);
                    if (flag != 0)
                    {
                        MessageBox.Show("新增员工成功！");
                        Mw_btnReturn_Click(sender, e);
                    }                
            }                          
        }

        //判断身份证号码是否输入合法
        public static bool CheckChinaIDCardNumberFormat(string idCardNumber)
        {
            string idNumber = idCardNumber;
            bool result = true;
            try
            {
                if (idNumber.Length != 18)
                {
                    return false;
                }
                long n = 0;
                if (long.TryParse(idNumber.Remove(17), out n) == false
                    || n < Math.Pow(10, 16) || long.TryParse(idNumber.Replace('x', '0').Replace('X', '0'), out n) == false)
                {
                    return false;//数字验证  
                }
                string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
                if (address.IndexOf(idNumber.Remove(2)) == -1)
                {
                    return false;//省份验证  
                }
                string birth = idNumber.Substring(6, 8).Insert(6, "-").Insert(4, "-");
                DateTime time = new DateTime();
                if (DateTime.TryParse(birth, out time) == false)
                {
                    return false;//生日验证  
                }
                string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
                string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
                char[] Ai = idNumber.Remove(17).ToCharArray();
                int sum = 0;
                for (int i = 0; i < 17; i++)
                {
                    sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
                }
                int y = -1;
                Math.DivRem(sum, 11, out y);
                if (arrVarifyCode[y] != idNumber.Substring(17, 1).ToLower())
                {
                    return false;//校验码验证  
                }
                return true;//符合GB11643-1999标准 

            }
            catch (Exception ex)
            {
                Console.WriteLine("CheckChinaIDCardNumber 身份证校验失败  号码:" + idNumber, ex);
                result = false;
            }
            return result;
        }

        //检测手机号码是否合法
        private bool CheckPhoneIsAble(string input)
        {
            if (input.Length < 11)
            {
                return false;
            }
            //电信手机号码正则
            string dianxin = @"^1[3578][01379]\d{8}$";
            Regex regexDX = new Regex(dianxin);
            //联通手机号码正则
            string liantong = @"^1[34578][01256]\d{8}";
            Regex regexLT = new Regex(liantong);
            //移动手机号码正则
            string yidong = @"^(1[012345678]\d{8}|1[345678][012356789]\d{8})$";
            Regex regexYD = new Regex(yidong);
            if (regexDX.IsMatch(input) || regexLT.IsMatch(input) || regexYD.IsMatch(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //电话号码输入控制，只允许数字
        private void tBx_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }
        //界面初始化
        private void Workers_message_Load(object sender, EventArgs e)
        {
            Wm_tbxPhone.KeyPress += new KeyPressEventHandler(tBx_KeyPress);
            if(u_id == -1)
            {
                Wm_btnUpDate.Visible = false;
                Wm_btnDelete.Text = "确定";
                Wm_dtpEntryTime.Value = DateTime.Now.Date;
            }
            else
            {
                //从数据库读取员工信息
                DataBaseConnection dc = new DataBaseConnection();
                String sql = "select * from [User] where u_id = " + u_id;
                //Console.WriteLine("查询员工信息的sql语句：" + sql);
                DataSet ds = dc.ExecuteQuery(sql);
                //Console.WriteLine("查询出来的信息条数：" + ds.Tables["user"].Rows.Count);
                //修改界面的控件的信息
                Wm_tbxUserName.Text = ds.Tables["user"].Rows[0][5].ToString();
                Wm_cbBUserType.SelectedIndex = ((int)ds.Tables["user"].Rows[0][1]) - 1;
                Wm_cbBGroup.SelectedIndex = ((int)ds.Tables["user"].Rows[0][2]) - 1;
                Wm_tbxAccount.Text = ds.Tables["user"].Rows[0][3].ToString();
                if (ds.Tables["user"].Rows[0][6].Equals("男"))
                {
                    Wm_cbBSex.SelectedIndex = 0;
                }
                else if (ds.Tables["user"].Rows[0][6].Equals("女"))
                {
                    Wm_cbBSex.SelectedIndex = 1;
                }
                Wm_tbxIDNum.Text = ds.Tables["user"].Rows[0][8].ToString();
                Wm_tbxPhone.Text = ds.Tables["user"].Rows[0][9].ToString();
                Wm_dtpEntryTime.Value = Convert.ToDateTime(ds.Tables["user"].Rows[0][10]);
            }            
        }

        private void Wm_btnUpDate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要修改该员工信息吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
            {
                    DataBaseConnection dc = new DataBaseConnection();
                    int ut_id = Wm_cbBUserType.SelectedIndex + 1;
                    int g_id = Wm_cbBGroup.SelectedIndex + 1;
                    String sex = Wm_cbBSex.SelectedItem.ToString();
                    //Console.WriteLine("时间选择器里的值："+ Wm_dtpEntryTime.Value);

                    ////验证输入的省份证号码是否有误
                    //CheckChinaIDCardNumberFormat(Wm_tbxIDNum.Text);
                    ////验证输入的电话号码是否有误
                    //CheckPhoneIsAble(Wm_tbxPhone.Text);
                    String sql = "update [User] set u_name = N'" + Wm_tbxUserName.Text + "',ut_id =" + ut_id + " ,g_id = " + g_id + ",u_account = '" + Wm_tbxAccount.Text + "',u_sex = N'" + sex + "',u_idNum = '" + Wm_tbxIDNum.Text + "',u_phone = '" + Wm_tbxPhone.Text + "', u_entryTime = '"+ Wm_dtpEntryTime.Value + "' where u_id = " + u_id;
                    Console.WriteLine("更新操作的sql语句：" + sql);
                    int flag = dc.ExecuteUpdate(sql);
                    if (flag != 0)
                    {
                        MessageBox.Show("修改用户信息成功！");
                        Mw_btnReturn_Click(sender,e);
                    }
            }
        }
    }
}
