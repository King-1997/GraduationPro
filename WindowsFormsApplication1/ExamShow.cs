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
    public partial class ExamShow : CCSkinMain
    {
        //考题对应的课程id
        public static int c_id = -1;
        public ExamShow()
        {
            InitializeComponent();
        }       
        //考题数组
        public static List<string> questions = new List<string>();
        public static List<string> answer = new List<string>();
        public static List<string> A = new List<string>();
        public static List<string> B = new List<string>();
        public static List<string> C = new List<string>();
        public static List<string> D = new List<string>();
        //增加考题，跳转到上传考题界面，返回后显示在窗口fLP_showQuestions上
        private void btn_addQuestions_Click(object sender, EventArgs e)
        {
            LoadExam.Question_index = null;
            LoadExam loadExam = new LoadExam();
            loadExam.Owner = this;
            loadExam.ShowDialog();
        }
        public void ShowQuestions()
        {
            //去除重复数据
            List<string> vs = questions.Distinct().ToList();
            questions = vs;
            //清屏
            fLP_showQuestions.Controls.Clear();
            //预览
            for(int i=0; i<questions.Count; i++)
            {
                var label = new TextBox { Text=questions[i]};
                label.Font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
                label.TextAlign = HorizontalAlignment.Center;
                label.ReadOnly=true;
                label.Size = new Size(350,60);
                //删除button的name为对应label的Text，实现对应
                var btn_delete = new Button { Text = "删除", Name = label.Text };
                btn_delete.Width = 50;
                btn_delete.Click += new EventHandler(Deletequestion);

                var btn_Edit = new Button { Text = "编辑", Name = i.ToString() };
                btn_Edit.Width = 50;
                btn_Edit.Click += new EventHandler(EditQuestion);

                fLP_showQuestions.Controls.Add(label);
                fLP_showQuestions.Controls.Add(btn_delete);
                fLP_showQuestions.Controls.Add(btn_Edit);
                fLP_showQuestions.SetFlowBreak(btn_Edit, true);
            }
            
        }
        private void Deletequestion(object sender,EventArgs e)
        {
            if (MessageBox.Show("您确定要删除该试题吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
            {
                Button button = (Button)sender;
            string words = button.Name;
            //找到删除位置下标
            int Index = questions.FindIndex(questions => questions.Equals(words));
            //删除该下标位置的值
            questions.RemoveAt(Index);
            //刷新显示窗口
            ShowQuestions();
            }
        }
        //编辑已添加的试题信息
        private void EditQuestion(object sender, EventArgs e)
        {            
                Button button = (Button)sender;
                LoadExam.Question_index = button.Name;

                LoadExam loadExam = new LoadExam();
                loadExam.Owner = this;
                loadExam.ShowDialog();
        }
        //确定试题信息上传
        private void btn_choose_Click(object sender, EventArgs e)
        {
            //修改数据库
            DataBaseConnection dc = new DataBaseConnection();
            int i = 0;
            for (i = 0;i < questions.Count;i++)
            {
                String q_title = questions[i];
                String q_answer = answer[i];
                String q_option1 = A[i];
                String q_option2 = B[i];
                String q_option3 = C[i];
                String q_option4 = D[i];

                String insert_sql = "insert into question values("+c_id+",N'"+q_title+ "',N'" + q_answer+ "',N'" + q_option1+ "',N'" + q_option2+ "',N'" + q_option3+ "',N'" + q_option4+"')";
                dc.ExecuteUpdate(insert_sql);
            }
            String update_sql = "update Classes set c_count = " + cBx_passCount.SelectedItem.ToString() + " where c_id = '"+c_id+"'";
            int flag = dc.ExecuteUpdate(update_sql);
            if (i == questions.Count && flag != 0)
            {
                MessageBox.Show("上传课程试题成功！");
            }

            //返回上一界面
            questions = null;
            this.Owner.Owner.Show();
            this.Owner.Dispose();
        }
        //取消操作
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回上一界面
            questions = null;
            this.Owner.Show();
            this.Dispose();
        }
        //更新下拉框的选项
        private void click(object sender,EventArgs e)
        {
            cBx_passCount.Items.Clear();
            for (int i=1;i<= questions.Count;i++)
            {
                cBx_passCount.Items.Add(i);
            }
        }
        private void ExamShow_Load(object sender, EventArgs e)
        {
            cBx_passCount.Click += new EventHandler(click);
            DataBaseConnection dc = new DataBaseConnection();
            String select_question = "select q.c_id,q.c_id,q.q_title,q.q_answer,q.q_option1,q.q_option2,q.q_option2,q.q_option3,q.q_option4 from question q where c_id = " + c_id+"";
            DataSet ds = dc.ExecuteQuery(select_question);
            if(ds.Tables["user"].Rows.Count != 0)
            {
                for(int i =0;i< ds.Tables["user"].Rows.Count; i++)
                {
                    questions.Add(ds.Tables["user"].Rows[i][2].ToString());
                    answer.Add(ds.Tables["user"].Rows[i][3].ToString());
                    A.Add(ds.Tables["user"].Rows[0][4].ToString());
                    B.Add(ds.Tables["user"].Rows[0][5].ToString());
                    C.Add(ds.Tables["user"].Rows[0][6].ToString());
                    D.Add(ds.Tables["user"].Rows[0][7].ToString());
                }

                ShowQuestions();

            }
            else
            {

            }
        }
    }
}
