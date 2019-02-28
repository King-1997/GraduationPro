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
        public static String c_name;
        private List<String> answer = new List<string>();
        private List<String> selected = new List<string>();
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
                if(CBx is ComboBox)
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
            //判断是否通过考试
            if(selected!=null)
            {
                int realCount = 0;//保存对比之后实际通过题数
                for (int i = 0;i< answer.Count; i++)
                {
                    if (selected[i].Equals(answer[i]))
                    {
                        realCount++;
                    }
                }
            
                DataBaseConnection dc = new DataBaseConnection();
                String sql = "select c_count from Classes where c_name = N'" + c_name+"'";
                DataSet ds = dc.ExecuteQuery(sql);

                int passCount = (int)ds.Tables["user"].Rows[0][0];//读取通过题数
                if (realCount>=passCount)
                {
                    //通过，课程状态设置为已完成
                    MessageBox.Show("恭喜您已完成该课程！");
                    String update_sql = "update UserClasses set uc_status = 1 where cd_id in (select cd_id from ClassesDestribute where c_id in (select c_id from Classes where c_name =  N'" + c_name+"'))";
                    dc.ExecuteUpdate(update_sql);
                }
                else
                {
                    //没有通过，重新学习该课程
                    MessageBox.Show("您未通过考试，请重新学习本课程！");
                }
            }

        }
        //初始化界面，显示考题
        private void ExamForm_Load(object sender, EventArgs e)
        {
            DataBaseConnection dc = new DataBaseConnection();
            String sql = "select * from question where c_id in (select c_id from Classes where c_name =N'" + c_name+"')";
            DataSet ds = dc.ExecuteQuery(sql);
            if (ds.Tables["user"].Rows.Count>0)
            {
                for(int i = 0;i< ds.Tables["user"].Rows.Count; i++)
                {
                    int q_num = i + 1;
                    SingleExamShow(q_num+"、" + ds.Tables["user"].Rows[i][2].ToString(), ds.Tables["user"].Rows[i][4].ToString(), ds.Tables["user"].Rows[i][5].ToString(), ds.Tables["user"].Rows[i][6].ToString(), ds.Tables["user"].Rows[i][7].ToString());
                    answer.Add(ds.Tables["user"].Rows[i][3].ToString());
                }
                
            }
            
        }
        //单个考题的显示
        private void SingleExamShow(String title,String option1,String option2,String option3,String option4)
        {
            //考题
            var que= new Label();
            que.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //questinos = 数据库语句
            que.Text = title;
            fLP_ExamShow.Controls.Add(que);
            fLP_ExamShow.SetFlowBreak(que, true);

            //选项ABCD
            var A = new Label();
            A.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //数据库语句 optionA=...
            A.Text = "A："+option1;
            fLP_ExamShow.Controls.Add(A);

            var B = new Label();
            B.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //数据库语句 optionB=...
            B.Text = "B：" + option2;
            fLP_ExamShow.Controls.Add(B);

            var C = new Label();
            C.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //数据库语句 optionC=...
            C.Text = "C：" + option3;
            fLP_ExamShow.Controls.Add(C);

            var D = new Label();
            D.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //数据库语句 optionD=...
            D.Text = "D：" + option4;
            fLP_ExamShow.Controls.Add(D);
            fLP_ExamShow.SetFlowBreak(D, true);

            //答案 
            var ans = new ComboBox();
            ans.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //数据库语句 answer=。。。
            ans.Items.Add("A");
            ans.Items.Add("B");
            ans.Items.Add("C");
            ans.Items.Add("D");
            fLP_ExamShow.Controls.Add(ans);
        }
        //取消考试
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Learn.learn = true;
            Learn.open = true;
            this.Owner.Show();
            this.Close();
        }
    }
}
