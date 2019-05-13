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
    public partial class PlanArrangement : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public static string plan_name = null;
        public static string plan_id = null;
        public static List<string> people = null;
        public static List<string> user_id = null;
        private int sp_line_id = -1;
        //private TextBox tbx_cd_time = new TextBox();
        public PlanArrangement()
        {
            InitializeComponent();
        }

        private void PlanArrangement_Load(object sender, EventArgs e)
        {
            plan_name = null;
            plan_id = null;
            if (people != null)
            {
                people.Clear();
            }
            if (user_id != null)
            {
                user_id.Clear();
            }
            sp_line_id = -1;
        }
        private void btn_addLesson_Click(object sender, EventArgs e)
        {
            //打开选择学习计划界面StudyPlan，隐藏本界面
            StudyPlan studyPlan = new StudyPlan();
            studyPlan.Owner = this;
            Hide();
            studyPlan.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            PlanArrangement_Load(sender, e);
            Owner.Show();
            Dispose();
        }
        //确认按钮，选择好学习计划和员工之后的确认事件
        private void btn_sure_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (plan_name == null || plan_id == null)
            {
                MessageBox.Show("未选择学习计划!");
            }
            else if (people == null || user_id == null)
            {
                MessageBox.Show("未选择员工！");
            }
            else
            {
                int sps_id = 0, sp_head_id, flag1 = 0, flag2 = 0, flag3 = 0;
                int.TryParse(plan_id, out sps_id);

                //将数据存储于数据库
                DataBaseConnection dc = new DataBaseConnection();
                string select_head = "select sp_head_id from study_plan_header where sps_id =" + sps_id;
                DataSet dst = dc.ExecuteQuery(select_head);
                if (dst.Tables["user"].Rows.Count > 0)
                {
                    for (int k = 0; k < dst.Tables["user"].Rows.Count; k++)
                    {
                        int.TryParse(dst.Tables["user"].Rows[k][0].ToString(), out sp_head_id);
                        for (i = 0; i < user_id.Count; i++)
                        {
                            //获取出选择的员工id
                            int u_id = 0;
                            //Console.WriteLine("user_id中的值为：" + user_id[i]);
                            int.TryParse(user_id[i], out u_id);
                            string select_sp_head_id = "select sp_head_id from plan_destribute where pd_id in (select pd_id from user_plan_header where u_id = " + u_id + ") and sp_head_id = " + sp_head_id;
                            DataSet dss = dc.ExecuteQuery(select_sp_head_id);
                            if (dss.Tables["user"].Rows.Count == 0)
                            {
                                //查询学习计划行信息id
                                string select_line_id = "select sp_line_id from study_plan_lines where sp_head_id = " + sp_head_id;
                                DataSet ds2 = dc.ExecuteQuery(select_line_id);
                                if (ds2.Tables["user"].Rows.Count > 0)
                                {
                                    //查询plan_destribute_s序列的下一个值，作为cd_id
                                    string select_cd_id = "select next value for plan_destribute_s";
                                    DataSet ds = dc.ExecuteQuery(select_cd_id);
                                    int pd_id = 0;
                                    int.TryParse(ds.Tables["user"].Rows[0][0].ToString(), out pd_id);
                                    //查询plan_destribute_s序列的下一个值，作为cd_id
                                    string select_up_head_id = "select next value for user_plan_header_s";
                                    DataSet ds1 = dc.ExecuteQuery(select_up_head_id);
                                    int up_head_id = 0;
                                    int.TryParse(ds1.Tables["user"].Rows[0][0].ToString(), out up_head_id);
                                    //插入学习计划分配表
                                    string insert_cd_sql = "insert into plan_destribute values (" + pd_id + "," + u_id + "," + sp_head_id + ",N'" + Model.User.userId + "',CONVERT(varchar(100), GETDATE(), 20))";
                                    flag1 = dc.ExecuteUpdate(insert_cd_sql);
                                    //插入用户学习计划头表
                                    string insert_uc_sql = "insert into user_plan_header values (" + up_head_id + "," + u_id + "," + pd_id + ",0,0,1)";
                                    flag2 = dc.ExecuteUpdate(insert_uc_sql);

                                    for (int j = 0; j < ds2.Tables["user"].Rows.Count; j++)
                                    {
                                        int.TryParse(ds2.Tables["user"].Rows[j][0].ToString(), out sp_line_id);
                                        //插入用户学习计划行表
                                        string insert_up_lines = "insert into user_plan_lines values(next value for user_plan_lines_s," + sp_line_id + "," + up_head_id + ",0,'100%',0,null)";
                                        flag3 = dc.ExecuteUpdate(insert_up_lines);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("该学习计划中没有阶段内容，请联系系统管理员！");
                                }
                            }
                            else
                            {
                                MessageBox.Show("该学习计划已被安排给员工，请核对！");
                            }
                        }
                    }
                }
                if (i == user_id.Count && flag1 == 1 && flag2 == 1 && flag3 == 1)
                {
                    MessageBox.Show("安排学习计划成功！");
                }
                else
                {
                    MessageBox.Show("安排学习计划失败，请联系系统管理员！");
                }
                //返回上一页面
                PlanArrangement_Load(sender, e);
                Owner.Show();
                Dispose();
            }
        }

        private void btn_peopleAdd_Click(object sender, EventArgs e)
        {
            PeopleChoose PeopleChoose = new PeopleChoose();
            PeopleChoose.Owner = this;
            Hide();
            PeopleChoose.Show();
        }
        public void PlanShow()
        {
            //刷新窗口
            fLP_lessonesAdd.Controls.Clear();
            //标签栏目
            var lblname = new Label { Text = "学习计划名" };
            lblname.Font = font;
            //var lbltime = new Label { Text = "学时" };
            //lbltime.Font = font;
            lblname.TextAlign = ContentAlignment.MiddleCenter;
            //lbltime.TextAlign = ContentAlignment.MiddleCenter;
            fLP_lessonesAdd.Controls.Add(lblname);
            //fLP_lessonesAdd.Controls.Add(lbltime);
            fLP_lessonesAdd.SetFlowBreak(lblname, true);
            //课程
            if (string.IsNullOrEmpty(plan_name))
            {
                Label label = new Label();
                label.Text = "未选择学习计划";
                label.TextAlign = ContentAlignment.MiddleCenter;
                fLP_lessonesAdd.Controls.Add(label);
            }
            else
            {
                //fLP_lessonesAdd显示已选择的课程
                //课程名
                var rb = new CheckBox { Text = plan_name };
                rb.Checked = true;
                rb.TextAlign = ContentAlignment.MiddleCenter;
                rb.CheckedChanged += new EventHandler(Lessons_delete_CheckedChanged);
                fLP_lessonesAdd.Controls.Add(rb);
                ////学时
                //var tBx = new TextBox { Text = lesson_time.ToString()};
                //tBx.Font = font;
                //tBx.Name = "tbx_ClassesTime";
                //fLP_lessonesAdd.Controls.Add(tBx);
                //tBx.KeyPress += new KeyPressEventHandler(tBx_KeyPress);
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
        public void EmpsShow()
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
            if (MessageBox.Show("您确定要删除吗", "判断", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                //用户选择确认删除的操作
                DeletePlan();
                PlanShow();
            }
        }

        private void Works_delete_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要删除吗", "判断", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                //用户选择确认删除的操作
                DeleteEmps();
                EmpsShow();
            }
            //else
            //{
            //    //在flowlayoutPanel中遍历出复选框
            //    foreach (Control ctl in fLP_lessonesAdd.Controls)
            //    {
            //        if (ctl is CheckBox)
            //        {

            //        }
            //    }
            //}
        }

        private void DeletePlan()
        {
            //在flowlayoutPanel中遍历出复选框
            foreach (Control ctl in fLP_lessonesAdd.Controls)
            {
                if (ctl is CheckBox)
                {
                    if ((ctl as CheckBox).Checked == false)
                    {
                        //将计划名置为null
                        plan_name = null;
                    }
                }
            }
        }
        private void DeleteEmps()
        {
            //在flowlayoutPanel中遍历出复选框
            foreach (Control ctl in fLP_peopleChoosed.Controls)
            {
                if (ctl is CheckBox)
                {
                    if ((ctl as CheckBox).Checked == false)
                    {
                        //在list中移除该节点
                        people.Remove(ctl.Text);
                    }
                }
            }
        }
    }
}
