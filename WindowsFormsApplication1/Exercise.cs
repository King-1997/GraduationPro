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
    public partial class Exercise : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public static int c_id = -1;
        public static int exam_p_id = -1;
        private List<string> answer = new List<string>();
        private List<string> selected = new List<string>();
        private List<int> goal = new List<int>();
        int real_goal = 0;
        int totalGoal = 0;
        int passGoal = 0;
        public Exercise()
        {
            InitializeComponent();
        }

        private void ef_timer_Tick(object sender, EventArgs e)
        {
            ef_lbl_curTime.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");//显示当前时间
        }

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
                    string insert_sql = "insert into employee_exam values(next value for employee_exam_s," + Model.User.userId + "," + exam_p_id + "," + real_goal + ")";
                    int flag = dc.ExecuteUpdate(insert_sql);
                    MessageBox.Show("提交成功！");
                }
            }
            Learn.learn = true;
            Learn.open = true;
            Learn learn = (Learn)Owner;
            Owner.Show();
            Dispose();
        }

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

        private void Exercise_Load(object sender, EventArgs e)
        {
            //启动定时器
            ef_timer.Start();
            ef_timer.Interval = 1000;
            ef_lbl_curTime.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");//显示当前时间    
            DataBaseConnection dc = new DataBaseConnection();
            string sql_goal = "select distinct ep.total_goal,ep.pass_goal,ep.exam_p_name,ep.exam_p_id from exam_paper ep,exam_detail ed,question q where ep.exam_p_type = '课后测试' and ep.exam_p_id = ed.exam_p_id and ed.q_id = q.q_id and q.c_id = " + c_id;
            DataSet ds = dc.ExecuteQuery(sql_goal);
            if (ds.Tables["user"].Rows.Count > 0)
            {
                totalGoal = (int)ds.Tables["user"].Rows[0][0];//读取课后测试总分数
                passGoal = (int)ds.Tables["user"].Rows[0][1];//读取课后测试通过分数
                int.TryParse(ds.Tables["user"].Rows[0][3].ToString(), out exam_p_id);//读取课后测试id
                ef_lbl_totalGoal.Text += totalGoal;
                ef_lbl_exam_name.Text += ds.Tables["user"].Rows[0][2].ToString();
            }
            string sql = "select q.q_title,q.q_option1,q.q_option2,q.q_option3,q.q_option4,q.q_answer,q.q_goal from question q,exam_detail ed,exam_paper ep where ep.exam_p_type = '课后测试' and ep.exam_p_id = ed.exam_p_id and ed.q_id = q.q_id and q.c_id =" + c_id;
            SingleExamShow(sql);
        }
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
    }
}
