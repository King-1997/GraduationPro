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
    public partial class LessonArrangement : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public static String lesson_name = null;
        public static String lesson_time = null;
        public static List<string> people = null;

        private int classes_id = Model.ClassesInfo.class_id;
        private List<int> user_id = new List<int>{1};

        private TextBox tbx_cd_time = new TextBox();
        public LessonArrangement()
        {
            InitializeComponent();
        }

        private void LessonArrangement_Load(object sender, EventArgs e)
        {
                                   
        }
        private void Find_Id()
        {
            DataBaseConnection dc = new DataBaseConnection();
            if (lesson_name != null)
            {

                String select_c_id = "select c_id from Classes where c_name = N'" + lesson_name + "'";
                DataSet ds = dc.ExecuteQuery(select_c_id);
                int.TryParse(ds.Tables["user"].Rows[0][0].ToString(),out classes_id);
            }
            if (people != null)
            {
                for (int i = 0; i < people.Count; i++)
                {
                    String select_u_id = "select u_id from [User] where u_name = N'" + people[i] + "'";
                    DataSet ds = dc.ExecuteQuery(select_u_id);
                    int u_id = -1;
                    int.TryParse(ds.Tables["user"].Rows[0][0].ToString(), out u_id);
                    user_id.Add(u_id);
                    
                }
            }            
        }
        private void btn_addLesson_Click(object sender, EventArgs e)
        {
            //打开选择课程界面classChoose，隐藏本界面
            ClassChoose classChoose = new ClassChoose();
            classChoose.Owner = this;
            classChoose.Show();
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            int i = 0;
            Find_Id();
            find_cd_time();
            if (lesson_name == null || people == null)
            {
                MessageBox.Show("未安排课程或员工");
            }else if (tbx_cd_time.Text == null || tbx_cd_time.Text == "")
            {
                MessageBox.Show("请输入学时！");
                tbx_cd_time.Focus();
            } 
            else
            {                    
                    Console.WriteLine("安排学时为：" + tbx_cd_time.Text);
                    int cd_time1 = 0;
                    cd_time1 = int.Parse(tbx_cd_time.Text);
                    Console.WriteLine("int值的安排学时为：" + cd_time1);
                    //将数据存储于数据库                
                    DataBaseConnection dc = new DataBaseConnection();
                    for (i = 1; i < user_id.Count; i++)
                    {
                        int u_id = user_id[i];
                        String insert_cd_sql = "insert into ClassesDestribute values (" + classes_id + "," + u_id + "," + cd_time1 + ",N'" + Model.User.userName + "')";
                        dc.ExecuteUpdate(insert_cd_sql);
                        String select_cd_id = "select cd_id from ClassesDestribute where c_id =" + classes_id + " and u_id = " + u_id + " and cd_time = " + cd_time1 + " and cd_name = N'" + Model.User.userName + "'";
                        DataSet ds = dc.ExecuteQuery(select_cd_id);
                        int cd_id = (int)ds.Tables["user"].Rows[0][0];
                        Console.WriteLine("cd_id为：" + cd_id);
                        String insert_uc_sql = "insert into UserClasses values (" + u_id + "," + cd_id + ",0,0,1)";
                        dc.ExecuteUpdate(insert_uc_sql);
                    }
                    if (i == user_id.Count)
                    {
                        MessageBox.Show("安排课程成功！");
                    }
                    else
                    {
                        MessageBox.Show("系统错误！");
                    }
                    //返回上一页面
                    this.Owner.Show();
                    this.Dispose();
                }                                                          
        }

        private void find_cd_time()
        {
            //遍历 
            foreach (Control tbx in fLP_lessonesAdd.Controls)
            {
                if (tbx is TextBox)
                {
                    if (!string.IsNullOrEmpty(tbx.Text))
                    {
                        Console.WriteLine("输入框中的学时："+ tbx.Text);
                        //处理代码
                        tbx_cd_time = (TextBox)tbx;
                    }
                }
            }
        }
        private void btn_peopleAdd_Click(object sender, EventArgs e)
        {
            PeopleChoose PeopleChoose = new PeopleChoose();
            PeopleChoose.Owner = this;

            this.Hide();
            PeopleChoose.Show();
        }
        public void LessonsShow()
        {            
            //刷新窗口
            fLP_lessonesAdd.Controls.Clear();
            //标签栏目
            var lblname = new Label { Text = "课程名" };
            lblname.Font = font;
            var lbltime = new Label { Text = "学时" };
            lbltime.Font = font;
            lblname.TextAlign = ContentAlignment.MiddleCenter;
            lbltime.TextAlign = ContentAlignment.MiddleCenter;
            fLP_lessonesAdd.Controls.Add(lblname);
            fLP_lessonesAdd.Controls.Add(lbltime);
            fLP_lessonesAdd.SetFlowBreak(lbltime,true);
            //课程
            if (string.IsNullOrEmpty(lesson_name))
            {
                Label label = new Label();
                label.Text = "未选择课程";
                label.TextAlign = ContentAlignment.MiddleCenter;
                fLP_lessonesAdd.Controls.Add(label);
            }
            else
            {
                //fLP_lessonesAdd显示已选择的课程
                    //课程名
                    var rb = new CheckBox { Text = lesson_name };
                    rb.Checked = true;
                    //rb.TextAlign = ContentAlignment.MiddleCenter;
                    rb.CheckedChanged += new EventHandler(Lessons_delete_CheckedChanged);                    
                    fLP_lessonesAdd.Controls.Add(rb);
                    //学时
                    var tBx = new TextBox { Text = lesson_time.ToString()};
                    tBx.Font = font;
                    tBx.Name = "tbx_ClassesTime";
                    fLP_lessonesAdd.Controls.Add(tBx);
                    tBx.KeyPress += new KeyPressEventHandler(tBx_KeyPress);
            }
        }
        //学时输入控制，只允许数字
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

        //人员显示
        public void PeopleShow()
        {
            //去除重复数据
            List<string> vs = people.Distinct().ToList();
            people = vs;
            //刷新窗口
            fLP_peopleChoosed.Controls.Clear();

            if (people.Count == 0)
            {
                Label label = new Label();
                label.Text = "未选择员工";
                label.TextAlign = ContentAlignment.MiddleCenter;
                fLP_peopleChoosed.Controls.Add(label);
            }
            else
            {
                //fLP_peopleChoosed显示已选择的员工
                for (int i = 0; i < people.Count; i++)
                {
                    //员工
                    var rb = new CheckBox { Text = people[i] };
                    rb.Font = font;
                    rb.Checked = true;
                    rb.CheckedChanged += new EventHandler(Works_delete_CheckedChanged);
                    fLP_peopleChoosed.Controls.Add(rb);
                }
            }
        }

        private void Lessons_delete_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要删除吗","判断", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                //用户选择确认删除的操作

                DeleteLessons();
                LessonsShow();
            }
        }

        private void Works_delete_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要删除吗", "判断", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                //用户选择确认删除的操作
                DeleteWorks();
                PeopleShow();
            }
        }

        private void DeleteLessons()
        {
            //遍历 
            foreach (Control ctl in fLP_lessonesAdd.Controls)
            {
                if (ctl is CheckBox)
                {
                    if ((ctl as CheckBox).Checked == false)
                    {
                        //处理代码
                        lesson_name =  null;
                    }
                }
            }
        }
        private void DeleteWorks()
        {
            //遍历 
            foreach (Control ctl in fLP_peopleChoosed.Controls)
            {
                if (ctl is CheckBox)
                {
                    if ((ctl as CheckBox).Checked == false)
                    {
                        //处理代码
                        people.Remove(ctl.Text);
                    }
                }
            }
        }
    }
}
