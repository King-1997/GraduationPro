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
    public partial class ExamForm : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public static int c_id = -1;
        public static int up_line_id = -1;
        public static int exam_p_id = -1;
        private List<string> answer = new List<string>();
        private List<string> selected = new List<string>();
        private List<int> goal = new List<int>();
        private int real_goal = 0;
        private int totalGoal = 0;
        private int passGoal = 0;
        private int exam_time = 0;
        private int credit = 0;
        public ExamForm()
        {
            InitializeComponent();
        }
        //提交答案
        private void btn_hand_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认提交？", "判断", MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (Control CBx in fLP_ExamShow.Controls)
                {
                    //查找到用户选择的答案
                    if (CBx is ComboBox)
                    {
                        if (CBx.Text == "" || CBx.Text == null)
                        {
                            MessageBox.Show("请完成所有题目！");
                            break;
                        }
                        else
                        {
                            //保存用户的答案，然后与数据库中的做对比
                            selected.Add(CBx.Text);
                        }
                    }
                }
                //foreach (string option in answer)
                //{
                //    Console.WriteLine(option);
                //}
                //foreach (string option2 in selected)
                //{
                //    Console.WriteLine(option2);
                //}
                //判断是否通过考试
                if (selected != null)
                {
                    int realCount = 0;//保存对比之后实际通过题数
                    for (int i = 0; i < answer.Count; i++)
                    {
                        if (selected[i].Equals(answer[i]))
                        {
                            realCount++;
                            real_goal += goal[i];//员工真实得分
                        }
                    }
                    DataBaseConnection dc = new DataBaseConnection();
                    if (exam_time <= 3)//考试次数不能大于3次
                    {
                        string insert_sql = "insert into employee_exam values(next value for employee_exam_s," + Model.User.userId + "," + exam_p_id + "," + real_goal + ")";
                        int flag = dc.ExecuteUpdate(insert_sql);
                        if (real_goal >= passGoal)
                        {
                            //通过，课程状态设置为已完成
                            MessageBox.Show("恭喜您已完成该课程！");
                            string update_sql = "update user_plan_lines set study_status_id = 2 where up_line_id = " + up_line_id;
                            dc.ExecuteUpdate(update_sql);
                            string update_user = "update [User] set u_credit = u_credit + " + credit + " where u_id = " + Model.User.userId;
                            dc.ExecuteUpdate(update_user);
                        }
                        else
                        {
                            //没有通过，重新学习该课程
                            MessageBox.Show("您未通过本次考试，分数为：" + real_goal + "，请重新考试！");
                        }
                    }
                    else
                    {
                        //考试次数过多
                        MessageBox.Show("您已达到本次考试最大允许次数，请重新学习本课程！");
                    }
                    Learn.learn = true;
                    Learn.open = true;
                    Learn learn = (Learn)Owner;
                    Owner.Show();
                    Dispose();
                }
            }
        }
        //初始化界面，显示考题
        private void ExamForm_Load(object sender, EventArgs e)
        {
            //启动定时器
            ef_timer.Start();
            ef_timer.Interval = 1000;
            ef_lbl_curTime.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");//显示当前时间    
            DataBaseConnection dc = new DataBaseConnection();
            string sql_goal = "select distinct ep.total_goal,ep.pass_goal,ep.exam_p_name,ep.exam_p_id from exam_paper ep,exam_detail ed,question q where ep.exam_p_type = '考试' and ep.exam_p_id = ed.exam_p_id and ed.q_id = q.q_id and q.c_id = " + c_id;
            DataSet ds = dc.ExecuteQuery(sql_goal);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                totalGoal = (int)ds.Tables["user"].Rows[0][0];//读取该门考试总分数
                passGoal = (int)ds.Tables["user"].Rows[0][1];//读取该门考试通过分数
                int.TryParse(ds.Tables["user"].Rows[0][2].ToString(), out exam_p_id);//读取该门考试id
                ef_lbl_totalGoal.Text += totalGoal;
                ef_lbl_passGoal.Text += passGoal;
                ef_lbl_exam_name.Text += ds.Tables["user"].Rows[0][2].ToString();
            }
            string select_c_credit = "select c_credit from classes where c_id = " + c_id;
            DataSet ds2 = dc.ExecuteQuery(select_c_credit);
            int.TryParse(ds2.Tables["user"].Rows[0][0].ToString(), out credit);
            //查询当前用户考试次数
            string select_time = "select count(1) from employee_exam where u_id = " + Model.User.userId + " and exam_p_id = " + exam_p_id;
            DataSet ds1 = dc.ExecuteQuery(select_time);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                int.TryParse(ds1.Tables["user"].Rows[0][0].ToString(), out exam_time);
            }
            string sql = "select q.q_title,q.q_option1,q.q_option2,q.q_option3,q.q_option4,q.q_answer,q.q_goal from question q,exam_detail ed,exam_paper ep where ep.exam_p_type = '考试' and ep.exam_p_id = ed.exam_p_id and ed.q_id = q.q_id and q.c_id =" + c_id;
            SingleExamShow(sql);
        }
        //单个考题的显示
        private void SingleExamShow(string sql)
        {
            fLP_ExamShow.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    int q_num = i + 1;
                    //考题
                    var que = new Label();
                    que.Font = font;
                    que.Text = q_num + "、" + ds.Tables["user"].Rows[i][0].ToString();
                    que.Width = 200;
                    fLP_ExamShow.Controls.Add(que);
                    fLP_ExamShow.SetFlowBreak(que, true);
                    //选项ABCD
                    var lbl_A = new Label();
                    lbl_A.Font = font;
                    lbl_A.Text = "A：" + ds.Tables["user"].Rows[i][1].ToString();
                    fLP_ExamShow.Controls.Add(lbl_A);
                    var lbl_B = new Label();
                    lbl_B.Font = font;
                    lbl_B.Text = "B：" + ds.Tables["user"].Rows[i][2].ToString();
                    fLP_ExamShow.Controls.Add(lbl_B);
                    var lbl_C = new Label();
                    lbl_C.Font = font;
                    lbl_C.Text = "C：" + ds.Tables["user"].Rows[i][3].ToString();
                    fLP_ExamShow.Controls.Add(lbl_C);
                    var lbl_D = new Label();
                    lbl_D.Font = font;
                    lbl_D.Text = "D：" + ds.Tables["user"].Rows[i][4].ToString();
                    fLP_ExamShow.Controls.Add(lbl_D);
                    fLP_ExamShow.SetFlowBreak(lbl_D, true);

                    answer.Add(ds.Tables["user"].Rows[i][5].ToString());
                    goal.Add((int)ds.Tables["user"].Rows[i][6]);
                    //答案 
                    var ans = new ComboBox();
                    ans.Font = font;
                    ans.Items.Add("A");
                    ans.Items.Add("B");
                    ans.Items.Add("C");
                    ans.Items.Add("D");
                    fLP_ExamShow.Controls.Add(ans);
                    fLP_ExamShow.SetFlowBreak(ans, true);
                }
            }
            else
            {
                //查询不到数据时提示无数据
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 550;
                lbl_no_data.Height = 100;
                fLP_ExamShow.Controls.Add(lbl_no_data);
            }
        }
        //取消考试，返回学习页面
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (exam_p_id != -1)
            {
                if (MessageBox.Show("还没完成考试，您确定要返回吗", "判断", MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Learn.learn = true;
                    Learn.open = true;
                    Learn learn = (Learn)Owner;
                    learn.l_btn_play_Click(sender, e);
                    Owner.Show();
                    Dispose();
                }
            }
            else
            {
                Learn.learn = true;
                Learn.open = true;
                Learn learn = (Learn)Owner;
                learn.l_btn_play_Click(sender, e);
                Owner.Show();
                Dispose();
            }
        }
        //定时器
        private void ef_timer_Tick(object sender, EventArgs e)
        {
            ef_lbl_curTime.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");//显示当前时间
        }
    }
}
