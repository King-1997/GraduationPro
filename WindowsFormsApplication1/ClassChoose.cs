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
//课程安排页面的课程选择
namespace WindowsFormsApplication1
{
    public partial class ClassChoose : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public ClassChoose()
        {
            InitializeComponent();
            cbB_findKey.Items.AddRange(new object[] { "按课程名", "按学分", "按上传人" ,"按推荐学时"});
            cbB_findKey.SelectedIndex = 0;
        }
        public string lessonId = null;//保存选择的课程id信息
        public string lessonName = null;//保存选择的课程名信息
        public string lessonTime = null;//保存选择的课程学时信息

        private void btn_allClasses_Click(object sender, EventArgs e)
        {
            this.tBx_findkeywords.Text = null;
            ClassChoose_Load(sender,e);
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            //刷新窗口
            fLP_lessons.Controls.Clear();
            //获取查询条件：tBx_findkeywords，cbB_findKey
            String KeyWord = tBx_findkeywords.Text;
            String KeyType = cbB_findKey.SelectedItem.ToString();
            //从数据库查找数据
            
            String sql = "";            
            Console.WriteLine("查询条件：" + KeyType);
            if (KeyType.Equals("按课程名"))
            {
                sql += "select c.c_name,u.u_name,c.c_introduction,c.c_credit,c.c_recommendTime,c.c_ifExam,c.c_id from classes c ,[User] u where c.u_id = u.u_id and c.c_name like N'%" + KeyWord + "%'";
            }
            else if (KeyType.Equals("按学分"))
            {
                sql += "select c.c_name,u.u_name,c.c_introduction,c.c_credit,c.c_recommendTime,c.c_ifExam,c.c_id from classes c ,[User] u where c.u_id = u.u_id and c.c_credit = " + KeyWord;
            }
            else if (KeyType.Equals("按上传人"))
            {
                sql += "select c.c_name,u.u_name,c.c_introduction,c.c_credit,c.c_recommendTime,c.c_ifExam,c.c_id from classes c ,[User] u where c.u_id = u.u_id and u.u_name like N'%" + KeyWord + "%'";
            }
            else if (KeyType.Equals("按推荐学时"))
            {
                sql += "select c.c_name,u.u_name,c.c_introduction,c.c_credit,c.c_recommendTime,c.c_ifExam,c.c_id from classes c ,[User] u where c.u_id = u.u_id and c.c_recommendTime = " + KeyWord;
            }
            Console.WriteLine("查询语句："+ sql);

            showClassesInfo(sql);
        }
        private void showClassesInfo(string sql)
        {
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            //在窗口添加课程信息
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //课程名标签
                var lbl_rb = new Label { Text = "课程名称" };
                lbl_rb.Font = font;
                lbl_rb.Width = 100;
                lbl_rb.TextAlign = ContentAlignment.MiddleCenter;
                //上传人标签
                var lbl_Loadman = new Label { Text = "上传人" };
                lbl_Loadman.Font = font;
                lbl_Loadman.Width = 50;
                lbl_Loadman.TextAlign = ContentAlignment.MiddleCenter;
                //课程简介标签
                var lbl_introducation = new Label { Text = "课程简介" };
                lbl_introducation.Font = font;
                lbl_introducation.Width = 100;
                lbl_introducation.TextAlign = ContentAlignment.MiddleCenter;
                //课程学分标签
                var lbl_credit = new Label { Text = "课程学分" };
                lbl_credit.Font = font;
                lbl_credit.Width = 65;
                lbl_credit.TextAlign = ContentAlignment.MiddleCenter;
                //课程学时标签
                var lbl_recommendTime = new Label { Text = "课程学时" };
                lbl_recommendTime.Font = font;
                lbl_recommendTime.Width = 65;
                lbl_recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                //是否考试标签
                var lbl_ifExam = new Label { Text = "是否考试" };
                lbl_ifExam.Font = font;
                lbl_ifExam.Width = 65;
                lbl_ifExam.TextAlign = ContentAlignment.MiddleCenter;
                //查看课程信息标签
                var lbl_btn_check = new Label { Text = "" };
                lbl_btn_check.Width = 50;
                lbl_btn_check.TextAlign = ContentAlignment.MiddleCenter;

                fLP_lessons.Controls.Add(lbl_rb);
                fLP_lessons.Controls.Add(lbl_Loadman);
                fLP_lessons.Controls.Add(lbl_introducation);
                fLP_lessons.Controls.Add(lbl_credit);
                fLP_lessons.Controls.Add(lbl_recommendTime);
                fLP_lessons.Controls.Add(lbl_ifExam);
                fLP_lessons.Controls.Add(lbl_btn_check);
                fLP_lessons.SetFlowBreak(lbl_btn_check, true);
                for (var count = 0; count < ds.Tables["user"].Rows.Count; count++)
                {
                    //课程名
                    var rb = new CheckBox { Text = ds.Tables["user"].Rows[count][0].ToString() };
                    rb.Font = font;
                    rb.Width = 100;
                    rb.Name = ds.Tables["user"].Rows[count][6].ToString();
                    rb.TextAlign = ContentAlignment.MiddleCenter;
                    rb.Click += new EventHandler(btn_oK_Click);
                    //上传人
                    var Loadman = new Label { Text = ds.Tables["user"].Rows[count][1].ToString() };
                    Loadman.Font = font;
                    Loadman.Width = 50;
                    Loadman.TextAlign = ContentAlignment.MiddleCenter;
                    //课程简介
                    var introducation = new Label { Text = ds.Tables["user"].Rows[count][2].ToString() };
                    introducation.Font = font;
                    introducation.Width = 100;
                    introducation.TextAlign = ContentAlignment.MiddleCenter;
                    //课程学分
                    var credit = new Label { Text = ds.Tables["user"].Rows[count][3].ToString() };
                    credit.Font = font;
                    credit.Width = 65;
                    credit.TextAlign = ContentAlignment.MiddleCenter;
                    //课程学时
                    var recommendTime = new Label { Text = ds.Tables["user"].Rows[count][4].ToString() };
                    recommendTime.Font = font;
                    recommendTime.Width = 65;
                    recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                    //是否考试
                    var ifExam = new Label { Text = ds.Tables["user"].Rows[count][5].ToString() };
                    ifExam.Font = font;
                    ifExam.Width = 65;
                    ifExam.TextAlign = ContentAlignment.MiddleCenter;
                    //查看课程信息
                    var btn_check = new Button { Text = "查看" };
                    btn_check.Width = 50;
                    btn_check.TextAlign = ContentAlignment.MiddleCenter;
                    btn_check.Name = ds.Tables["user"].Rows[count][6].ToString();
                    //Console.WriteLine("button中的c_name："+ btn_check.Name);
                    btn_check.Click += new EventHandler(CheckClassesInfo);

                    fLP_lessons.Controls.Add(rb);
                    fLP_lessons.Controls.Add(Loadman);
                    fLP_lessons.Controls.Add(introducation);
                    fLP_lessons.Controls.Add(credit);
                    fLP_lessons.Controls.Add(recommendTime);
                    fLP_lessons.Controls.Add(ifExam);
                    fLP_lessons.Controls.Add(btn_check);
                    fLP_lessons.SetFlowBreak(btn_check, true);
                }
            }
            else
            {
                //查询不到数据时提示无数据
                var lbl_no_data = new Label { Text = string.Concat("抱歉，当前没有查询到任何数据！") };
                lbl_no_data.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 579;
                lbl_no_data.Height = 150;
                fLP_lessons.Controls.Add(lbl_no_data);
            }
        }
        private void CheckClassesInfo(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int.TryParse(button.Name, out ClaeeesInfo.c_id);
            ClaeeesInfo classesInfo = new ClaeeesInfo();
            classesInfo.Owner = this;
            this.Hide();
            classesInfo.Show();
        }
        //复选框选中事件（设置只选一个）
        private void btn_oK_Click(object sender, EventArgs e)
        {
            //遍历 
            foreach (Control ctl in fLP_lessons.Controls)
            {
                if (ctl is CheckBox)
                {
                    if ((ctl as CheckBox).Checked == true)
                    {
                        //处理代码
                        lessonName = ctl.Text;
                        lessonId = ctl.Name;
                    }
                }
            }
            //传递选定的课程
            EditPeriod.lesson_name = lessonName;
            EditPeriod.c_id = lessonId;            
            //获取上一界面的已选课程窗口
            EditPeriod editperoid = (EditPeriod)this.Owner;
            editperoid.showClass_Exam_Info();
            this.Owner.Show();
            this.Dispose();
        }

        private void ClassChoose_Load(object sender, EventArgs e)
        {
            //刷新窗口
            fLP_lessons.Controls.Clear();
            String sql = "select c.c_name,u.u_name,c.c_introduction,c.c_credit,c.c_recommendTime,c.c_ifExam,c.c_id from classes c ,[User] u where c.u_id = u.u_id";
            showClassesInfo(sql);  
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }
    }
}
