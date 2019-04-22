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
    public partial class Classes : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));

        public Classes()
        {
            InitializeComponent();
        }

        private void p_btnQuit_Click(object sender, EventArgs e)
        {
            this.Owner.Owner.Show();
            this.Owner.Dispose();
        }

        private void p_btnHome_Click(object sender, EventArgs e)
        {
            
            this.Owner.Show();
            this.Dispose();
        }

        private void c_btnMine_Click(object sender, EventArgs e)
        {
            //刷新显示区域，显示我上传的课程
            c_lblOwner.Text = "是否考试";
            c_lblPeriod.Text = "推荐学时";
            c_flpClasses.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            String sql = "select c.c_name,c.c_credit,c_ifExam,c.c_recommendTime,c.c_id from classes c,[user] u where u.u_id = c.u_id and u.u_name =N'" + Model.User.userName + "' order by c.c_time desc";
            DataSet ds = dc.ExecuteQuery(sql);
            for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
            {
                //课程名
                var lblMineClasses_name = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                lblMineClasses_name.Width = 100;
                lblMineClasses_name.Font = font;
                lblMineClasses_name.TextAlign = ContentAlignment.MiddleCenter;
                //学分
                var lblMineClasses_credit = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                lblMineClasses_credit.Width = 80;
                lblMineClasses_credit.Font = font;
                lblMineClasses_credit.TextAlign = ContentAlignment.MiddleCenter;
                //上传人
                var lblMineClasses_ifExam = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                lblMineClasses_ifExam.Width = 60;
                lblMineClasses_ifExam.Font = font;
                lblMineClasses_ifExam.TextAlign = ContentAlignment.MiddleCenter;
                //推荐学时
                var lblMineClasses_recommendTime = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                lblMineClasses_recommendTime.Width = 80;
                lblMineClasses_recommendTime.Font = font;
                lblMineClasses_recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                //编辑按钮，点击之后跳转到课程信息编辑页面
                var btnCom = new Button { Text = "编辑" };
                btnCom.Width = 50;
                btnCom.Name = ds.Tables["user"].Rows[i][4].ToString();
                btnCom.Click += new EventHandler(Edit_ClassesInfo);
                btnCom.TextAlign = ContentAlignment.MiddleCenter;

                c_flpClasses.Controls.Add(lblMineClasses_name);
                c_flpClasses.Controls.Add(lblMineClasses_credit);
                c_flpClasses.Controls.Add(lblMineClasses_ifExam);
                c_flpClasses.Controls.Add(lblMineClasses_recommendTime);
                c_flpClasses.Controls.Add(btnCom);
                c_flpClasses.SetFlowBreak(btnCom, true);
            }
        }
        private void Edit_ClassesInfo(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int.TryParse(button.Name, out LoadClasses.c_id);            
            Console.WriteLine("button里的课程id：" + button.Name);
            //选择课程，跳转到课程信息修改页面
            LoadClasses loadClasses = new LoadClasses();
            loadClasses.Owner = this;
            this.Hide();
            loadClasses.Show();
        }
        private void Check_ClassesInfo(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int.TryParse(button.Name, out ClaeeesInfo.c_id);
            Console.WriteLine("button里的课程id："+ button.Name);
            //选择课程，跳转到课程详细信息页面
            ClaeeesInfo classesInfo = new ClaeeesInfo();
            classesInfo.Owner = this;
            this.Hide();
            classesInfo.Show();
        }
        private void Classes_Load(object sender, EventArgs e)
        {
            this.p_lblCurPerson.Text = Model.User.userName;//给界面的用户名字段赋值
            
            if (!Model.User.userType.Equals("员工"))
            {
            //权限控制：显示上传按钮loadClasses
                btn_loadClasses.Visible = true;
            //权限控制：显示我上传的课程按钮c_btnMine
                c_btnMine.Visible = true;
            //权限控制：显示课程安排按钮btn_lessonArrangement
                btn_CreatePlan.Visible = true;
            //权限控制：显示课程安排按钮btn_lessonArrangement
                btn_PlanArrangement.Visible = true;
               
            }
            c_btnAll_Click(sender,e);
        }
                

        private void btn_loadClasses_Click(object sender, EventArgs e)
        {
            LoadClasses.c_id = -1;
            LoadClasses loadClasses = new LoadClasses();
            loadClasses.Owner = this;
            this.Hide();
            loadClasses.Show();
        }

        private void c_btnNecessary_Click(object sender, EventArgs e)
        {
            //刷新显示区域，显示必修课程
            c_lblOwner.Text = "课程上传人";
            c_lblPeriod.Text = "课程学时";
            c_flpClasses.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            String sql = "select c.c_name,c.c_credit,u.u_name,c.c_recommendTime,c.c_id from Classes c, ClassesDestribute cd, UserClasses uc,[User] u where c.c_id in (select cd.c_id from ClassesDestribute cd, UserClasses uc where uc.cd_id = cd.cd_id and uc.uc_property = 1) and uc.cd_id = cd.cd_id and cd.c_id = c.c_id and c.u_id = u.u_id and uc.u_id in (select u_id from [User] where u_name = N'" + Model.User.userName+ "') order by c.c_time desc; ";
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count>0)
            {
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //课程名
                    var lblNecClasses_name = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    lblNecClasses_name.Width = 100;
                    lblNecClasses_name.Font = font;
                    lblNecClasses_name.TextAlign = ContentAlignment.MiddleCenter;
                    //学分
                    var lblNecClasses_credit = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    lblNecClasses_credit.Width = 80;
                    lblNecClasses_credit.Font = font;
                    lblNecClasses_credit.TextAlign = ContentAlignment.MiddleCenter;
                    //上传人
                    var lblNecClasses_u_name = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    lblNecClasses_u_name.Width = 60;
                    lblNecClasses_u_name.Font = font;
                    lblNecClasses_u_name.TextAlign = ContentAlignment.MiddleCenter;
                    //推荐学时
                    var lblNecClasses_recommendTime = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    lblNecClasses_recommendTime.Width = 80;
                    lblNecClasses_recommendTime.Font = font;
                    lblNecClasses_recommendTime.TextAlign = ContentAlignment.MiddleCenter;

                    var btnLearnClasses = new Button { Text = "学习" };
                    btnLearnClasses.Width = 50;
                    btnLearnClasses.Name = ds.Tables["user"].Rows[i][4].ToString();
                    //给“学习”按钮添加点击事件，跳转到学习页面
                    btnLearnClasses.Click += new EventHandler(btn_studyClass_Click);

                    btnLearnClasses.TextAlign = ContentAlignment.MiddleCenter;
                    c_flpClasses.Controls.Add(lblNecClasses_name);
                    c_flpClasses.Controls.Add(lblNecClasses_credit);
                    c_flpClasses.Controls.Add(lblNecClasses_u_name);
                    c_flpClasses.Controls.Add(lblNecClasses_recommendTime);
                    c_flpClasses.Controls.Add(btnLearnClasses);
                    c_flpClasses.SetFlowBreak(btnLearnClasses, true);
                }
            }
            else
            {
                MessageBox.Show("您当前还没有必修课程！");
            }
            
        }

        private void c_btnOptional_Click(object sender, EventArgs e)
        {
            
            //刷新显示区域，显示选修课程
            c_lblOwner.Text = "课程上传人";
            c_lblPeriod.Text = "课程学时";
            c_flpClasses.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            String sql = "select c.c_name,c.c_credit,u.u_name,c.c_recommendTime,c.c_id from Classes c, ClassesDestribute cd, UserClasses uc,[User] u where c.c_id in (select cd.c_id from ClassesDestribute cd, UserClasses uc where uc.cd_id = cd.cd_id and uc.uc_property = 2) and uc.cd_id = cd.cd_id and cd.c_id = c.c_id and c.u_id = u.u_id and uc.u_id in (select u_id from [User] where u_name = N'" + Model.User.userName+ "') order by c.c_time desc;";
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //课程名

                    var lblSelectClasses_name = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    lblSelectClasses_name.Width = 100;
                    lblSelectClasses_name.Font = font;
                    lblSelectClasses_name.TextAlign = ContentAlignment.MiddleCenter;

                    //学分
                    var lblSelectClasses_credit = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    lblSelectClasses_credit.Width = 80;
                    lblSelectClasses_credit.Font = font;
                    lblSelectClasses_credit.TextAlign = ContentAlignment.MiddleCenter;

                    //上传人
                    var lblSelectClasses_u_name = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    lblSelectClasses_u_name.Width = 70;
                    lblSelectClasses_u_name.Font = font;
                    lblSelectClasses_u_name.TextAlign = ContentAlignment.MiddleCenter;

                    //推荐学时
                    var lblSelectClasses_recommendTime = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    lblSelectClasses_recommendTime.Width = 50;
                    lblSelectClasses_recommendTime.Font = font;
                    lblSelectClasses_recommendTime.TextAlign = ContentAlignment.MiddleCenter;

                    var btnSelectClasses = new Button { Text = "学习" };
                    btnSelectClasses.Width = 40;
                    btnSelectClasses.Name = ds.Tables["user"].Rows[i][4].ToString();
                    btnSelectClasses.Click += new EventHandler(btn_studyClass_Click);

                    var btnDeleteClasses = new Button { Text = "退选" };
                    btnDeleteClasses.Width = 40;
                    btnDeleteClasses.Name = ds.Tables["user"].Rows[i][0].ToString();
                    Console.WriteLine(btnDeleteClasses.Name);
                    btnDeleteClasses.Click += new EventHandler(btnDeleteClasses_Click);
                    c_flpClasses.Controls.Add(lblSelectClasses_name);
                    c_flpClasses.Controls.Add(lblSelectClasses_credit);
                    c_flpClasses.Controls.Add(lblSelectClasses_u_name);
                    c_flpClasses.Controls.Add(lblSelectClasses_recommendTime);
                    c_flpClasses.Controls.Add(btnSelectClasses);
                    c_flpClasses.Controls.Add(btnDeleteClasses);
                    c_flpClasses.SetFlowBreak(btnDeleteClasses, true);
                }
            }
            else {
                MessageBox.Show("您当前还未选修任何课程！");
            }
            
        }
        private void btnDeleteClasses_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要退选吗", "判断", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Button button = (Button)sender;
                int c_id =0;
                int.TryParse(button.Name, out c_id);
                Console.WriteLine("按钮里的课程id："+ c_id);
                DataBaseConnection dc = new DataBaseConnection();
                //在用户课程表中查询出相应的记录并删除
                String select_uc_id = "select uc_id from UserClasses where cd_id in (select cd_id from ClassesDestribute where c_id  = " + c_id + " and u_id =" + Model.User.userId+")";
                DataSet ds1 = dc.ExecuteQuery(select_uc_id);
                int uc_id = (int)ds1.Tables["user"].Rows[0][0];
                String delete_uc_sql = "delete from UserClasses where uc_id =" + uc_id;
                int flag1 = dc.ExecuteUpdate(delete_uc_sql);
                //在课程分配表中查询出相应的记录并删除
                String select_cd_id = "select cd_id from ClassesDestribute where c_id  = " + c_id + " and u_id =" + Model.User.userId;
                DataSet ds = dc.ExecuteQuery(select_cd_id);
                int cd_id = (int)ds.Tables["user"].Rows[0][0];

                String delete_cd_sql = "delete from ClassesDestribute where cd_id ="+ cd_id;
                int flag = dc.ExecuteUpdate(delete_cd_sql);
                
                if(flag1 != 0 && flag != 0)
                {
                    MessageBox.Show("退选成功！");
                    //刷新选修课程列表
                    c_btnOptional_Click(sender, e);
                }
            }
            } 
        private void c_btnAll_Click(object sender, EventArgs e)
        {
            c_lblOwner.Text = "课程上传人";
            c_lblPeriod.Text = "课程学时";
            //刷新显示区域，显示全部课程
            c_flpClasses.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            String sql = "select c.c_name,c.c_credit,u.u_name,c.c_recommendTime,c.c_id from classes c,[user] u where u.u_id = c.u_id order by c.c_time desc";
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //课程名
                    var lblAllClasses_name = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    lblAllClasses_name.Width = 100;
                    lblAllClasses_name.Font = font;
                    lblAllClasses_name.TextAlign = ContentAlignment.MiddleCenter;
                    //学分
                    var lblAllClasses_credit = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    lblAllClasses_credit.Width = 80;
                    lblAllClasses_credit.Font = font;
                    lblAllClasses_credit.TextAlign = ContentAlignment.MiddleCenter;
                    //上传人
                    var lblAllClasses_u_name = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    lblAllClasses_u_name.Width = 60;
                    lblAllClasses_u_name.Font = font;
                    lblAllClasses_u_name.TextAlign = ContentAlignment.MiddleCenter;
                    //推荐学时
                    var lblAllClasses_recommendTime = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    lblAllClasses_recommendTime.Width = 80;
                    lblAllClasses_recommendTime.Font = font;
                    lblAllClasses_recommendTime.TextAlign = ContentAlignment.MiddleCenter;

                    var btnAllClasses = new Button { Text = "查看" };
                    btnAllClasses.Width = 50;
                    btnAllClasses.Name = ds.Tables["user"].Rows[i][4].ToString();
                    btnAllClasses.Click += new EventHandler(Check_ClassesInfo);

                    btnAllClasses.TextAlign = ContentAlignment.MiddleCenter;
                    c_flpClasses.Controls.Add(lblAllClasses_name);
                    c_flpClasses.Controls.Add(lblAllClasses_credit);
                    c_flpClasses.Controls.Add(lblAllClasses_u_name);
                    c_flpClasses.Controls.Add(lblAllClasses_recommendTime);
                    c_flpClasses.Controls.Add(btnAllClasses);
                    c_flpClasses.SetFlowBreak(btnAllClasses, true);

                }
            }            
        }

        private void btn_studyClass_Click(object sender, EventArgs e)
        {
            //选择课程，跳转到学习页面
            Button button = (Button)sender;
            int.TryParse(button.Name, out Learn.c_id);
            Learn learn = new Learn();
            learn.Owner = this;
            this.Hide();
            learn.Show();
        }

        private void btn_chooseLesson_Click(object sender, EventArgs e)
        {
            ChooseLesson chooseLesson = new ChooseLesson();
            chooseLesson.Owner = this;           
            chooseLesson.Show();
            this.Hide();
        }

        private void btn_lessonArrangement_Click(object sender, EventArgs e)
        {
            //给组员安排课程，打开课程安排页面
            LessonArrangement lessonArrangement = new LessonArrangement();
            lessonArrangement.Owner = this;
            this.Hide();
            lessonArrangement.Show();
        }

        private void btn_CreatePlan_Click(object sender, EventArgs e)
        {
            //给组员安排课程，打开课程安排页面
            CreatePlan createPlan = new CreatePlan();
            createPlan.Owner = this;
            this.Hide();
            createPlan.Show();
        }
    }
}
