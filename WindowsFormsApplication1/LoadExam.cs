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
    public partial class LoadExam : CCSkinMain
    {
        public static String Question_index = null;
        public LoadExam()
        {
            InitializeComponent();
        }
        private string questions;
        private string answer;
        private string A;
        private string B;
        private string C;
        private string D;
        
        //新增考题
        private void btn_load_Click(object sender, EventArgs e)
        {
            //判断题目输入是否成功
            if(tbx_questions==null || tbx_questions.Text=="")
            {
                MessageBox.Show("请输入题目！！！");

            }
            //判断答案
            else if (cBx_answer.Text == "")
            {
                MessageBox.Show("请输入答案！！！");
            }
            //判断选项A
            else if (tbx_A == null || tbx_A.Text == "")
            {
                MessageBox.Show("请输入选项A！！！");

            }
            //判断选项B
            else if (tbx_B == null || tbx_B.Text == "")
            {
                MessageBox.Show("请输入选项B！！！");
            }
            //判断选项C
            else if (tbx_C == null || tbx_C.Text == "")
            {
                MessageBox.Show("请输入选项C！！！");
            }
            //判断选项D
            else if (tbx_D == null || tbx_D.Text == "")
            {
                MessageBox.Show("请输入选项D！！！");
            }
            else
            {
                //赋值
                questions = tbx_questions.Text;
                answer = cBx_answer.Text;
                A = tbx_A.Text;
                B = tbx_B.Text;
                C = tbx_C.Text;
                D = tbx_D.Text;
                //传递
                ExamShow.questions.Add(questions);
                ExamShow.answer.Add(answer);
                ExamShow.A.Add(A);
                ExamShow.B.Add(B);
                ExamShow.C.Add(C);
                ExamShow.D.Add(D);
                //关闭该界面，刷新考题 
                ExamShow examShow = (ExamShow)Owner;               
                examShow.ShowQuestions();
                examShow.Show();
                Dispose();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //关闭该界面
            Owner.Show();
            Dispose();
        }

        private void LoadExam_Load(object sender, EventArgs e)
        {
            cBx_answer.SelectedIndex = 0;
            int i = 0;
            if (Question_index != null)
            {
                int.TryParse(Question_index, out i);
                tbx_questions.Text = ExamShow.questions[i];
                cBx_answer.Text = ExamShow.answer[i];
                tbx_A.Text = ExamShow.A[i];
                tbx_B.Text = ExamShow.B[i];
                tbx_C.Text = ExamShow.C[i];
                tbx_D.Text = ExamShow.D[i];
            }
        }
    }
}
