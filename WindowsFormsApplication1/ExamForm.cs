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
        private List<string> answer = new List<string>();
        private List<string> selected = new List<string>();
        private List<int> goal = new List<int>();
        public ExamForm()
        {
            InitializeComponent();
        }
        //提交答案
        private void btn_hand_Click(object sender, EventArgs e)
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
                        //判断是否通过考试
                        if (selected != null)
                        {
                            int realCount = 0;//保存对比之后实际通过题数
                            for (int i = 0; i < answer.Count; i++)
                            {
                                if (selected[i].Equals(answer[i]))
                                {
                                    realCount++;
                                }
                            }
                            DataBaseConnection dc = new DataBaseConnection();
                            String sql = "select c_count from Classes where c_id = " + c_id;
                            DataSet ds = dc.ExecuteQuery(sql);
                            int passCount = (int)ds.Tables["user"].Rows[0][0];//读取该门课程通过题数
                            if (realCount >= passCount)
                            {
                                //通过，课程状态设置为已完成
                                MessageBox.Show("恭喜您已完成该课程！");
                                String update_sql = "update UserClasses set uc_status = 1 where cd_id in (select cd_id from ClassesDestribute where c_id in (select c_id from Classes where c_id =  " + c_id + "))";
                                dc.ExecuteUpdate(update_sql);
                            }
                            else
                            {
                                //没有通过，重新学习该课程
                                MessageBox.Show("您未通过本次考试，请重新学习本课程！");
                            }
                        }
                    }
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
            string sql = "select * from question where c_id =" + c_id;
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
                    que.Text = q_num + "、" + ds.Tables["user"].Rows[i][3].ToString();
                    que.Width = 200;
                    fLP_ExamShow.Controls.Add(que);
                    fLP_ExamShow.SetFlowBreak(que, true);
                    //选项ABCD
                    var lbl_A = new Label();
                    lbl_A.Font = font;
                    lbl_A.Text = "A：" + ds.Tables["user"].Rows[i][5].ToString();
                    fLP_ExamShow.Controls.Add(lbl_A);
                    var lbl_B = new Label();
                    lbl_B.Font = font;
                    lbl_B.Text = "B：" + ds.Tables["user"].Rows[i][6].ToString();
                    fLP_ExamShow.Controls.Add(lbl_B);
                    var lbl_C = new Label();
                    lbl_C.Font = font;
                    lbl_C.Text = "C：" + ds.Tables["user"].Rows[i][7].ToString();
                    fLP_ExamShow.Controls.Add(lbl_C);
                    var lbl_D = new Label();
                    lbl_D.Font = font;
                    lbl_D.Text = "D：" + ds.Tables["user"].Rows[i][8].ToString();
                    fLP_ExamShow.Controls.Add(lbl_D);
                    fLP_ExamShow.SetFlowBreak(lbl_D, true);
                    answer.Add(ds.Tables["user"].Rows[i][4].ToString());
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
        //定时器
        private void ef_timer_Tick(object sender, EventArgs e)
        {
            ef_lbl_curTime.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");//显示当前时间
        }
    }
}
