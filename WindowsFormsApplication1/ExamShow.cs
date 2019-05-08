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
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        //考题对应的课程id
        public static int c_id = -1;
        public ExamShow()
        {
            InitializeComponent();
        }
        //考题数组
        public static List<int> q_id = new List<int>();
        public static List<string> questions = new List<string>();
        public static List<string> answer = new List<string>();
        public static List<string> A = new List<string>();
        public static List<string> B = new List<string>();
        public static List<string> C = new List<string>();
        public static List<string> D = new List<string>();
        public static List<int> Goal = new List<int>();
        private void setNull()
        {
            q_id.Clear();
            questions.Clear();
            answer.Clear();
            A.Clear();
            B.Clear();
            C.Clear();
            D.Clear();
            Goal.Clear();
        }
        //增加考题，跳转到上传考题界面，返回后显示在窗口fLP_showQuestions上
        private void btn_addQuestions_Click(object sender, EventArgs e)
        {
            LoadExam.Question_index = null;
            LoadExam.i = -1;
            LoadExam loadExam = new LoadExam();
            loadExam.Owner = this;
            Hide();
            loadExam.ShowDialog();
        }
        public void ShowQuestions()
        {
            //去除重复数据
            questions = questions.Distinct().ToList();
            //清屏
            fLP_showQuestions.Controls.Clear();
            //预览
            if (questions != null)
            {
                for (int i = 0; i < questions.Count; i++)
                {
                    var q_title = new Label { Text = i+1 + "、" +questions[i] };
                    q_title.Font = font;
                    q_title.Size = new Size(200, 60);
                    //q_title.BorderStyle.Fixed3D = true;                    

                    var btn_Edit = new Button { Text = "编辑" };
                    btn_Edit.Width = 50;
                    btn_Edit.Name = i.ToString();
                    btn_Edit.Click += new EventHandler(EditQuestion);

                    //删除button的name为对应label的Text，实现对应
                    var btn_delete = new Button { Text = "删除" };
                    btn_delete.Width = 50;
                    btn_delete.Name = i.ToString();
                    btn_delete.Click += new EventHandler(Deletequestion);

                    fLP_showQuestions.Controls.Add(q_title);                    
                    fLP_showQuestions.Controls.Add(btn_Edit);
                    fLP_showQuestions.Controls.Add(btn_delete);
                    fLP_showQuestions.SetFlowBreak(btn_delete, true);
                }
            }
            else
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 490;
                lbl_no_data.Height = 150;
                fLP_showQuestions.Controls.Add(lbl_no_data);
            }
        }
        private void Deletequestion(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要删除该试题吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
            {
                Button button = (Button)sender;
                int index = 0;
                int.TryParse(button.Name,out index);
                if (index >= q_id.Count)
                {
                    //删除该下标位置的值
                    questions.RemoveAt(index);
                }else
                {
                    int qu_id = q_id[index];
                    DataBaseConnection dc = new DataBaseConnection();
                    string delete_sql = "delete from question where q_id = "+qu_id;
                    int flag = dc.ExecuteUpdate(delete_sql);
                    if (flag != 1)
                    {
                        MessageBox.Show("删除失败，请联系系统管理员！");
                    }
                }                
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
            int qe_id = 0,i = 0,count_q = 0,count = 0,flag1 = 0,flag2 = 0;
            if (cBx_passCount.SelectedItem == null)
            {
                MessageBox.Show("请选择通过题目数！");
            }else
            {
                int.TryParse(cBx_passCount.SelectedItem.ToString(), out count);
                for (i = 0; i < questions.Count; i++)
                {
                    if(q_id.Count > i)//非新增的试题时，获取该试题的q_id
                    {
                        qe_id = q_id[i];
                    }
                    else//新增的试题则置为0
                    {
                        qe_id = 0;
                    }                    
                    string q_title = questions[i];
                    string q_answer = answer[i];
                    string q_option1 = A[i];
                    string q_option2 = B[i];
                    string q_option3 = C[i];
                    string q_option4 = D[i];
                    int q_goal = Goal[i];
                    string select_q_id = "select count(1) from question where q_id ="+qe_id;
                    DataSet ds = dc.ExecuteQuery(select_q_id);
                    int.TryParse(ds.Tables["user"].Rows[0][0].ToString(),out count_q);
                    if (count_q == 0)
                    {
                        //无课程id时需要将c_id置为null
                        string insert_sql = "";
                        if (c_id == -1)
                        {
                            insert_sql += "insert into question values(next value for question_s,null,null,N'" + q_title + "','" + q_answer + "',N'" + q_option1 + "',N'" + q_option2 + "',N'" + q_option3 + "',N'" + q_option4 + "'," + q_goal + ")";
                        }
                        else
                        {
                            insert_sql += "insert into question values(next value for question_s," + c_id + ",null,N'" + q_title + "','" + q_answer + "',N'" + q_option1 + "',N'" + q_option2 + "',N'" + q_option3 + "',N'" + q_option4 + "'," + q_goal + ")";
                        }                        
                        flag1 = dc.ExecuteUpdate(insert_sql);
                    }else
                    {
                        string update_q_sql = "update question set q_title = N'" + q_title + "', q_answer = '" + q_answer + "', q_option1 = N'" + q_option1 + "', q_option2 = N'" + q_option2 + "', q_option3 = N'" + q_option3 + "', q_option4 = '" + q_option4 + "', q_goal = " + q_goal + " where q_id = "+qe_id;
                        flag2 = dc.ExecuteUpdate(update_q_sql);
                    }                 
                }
                string update_sql = "update Classes set c_count = " + count + " where c_id = '" + c_id + "'";
                int flag = dc.ExecuteUpdate(update_sql);
                if (i == questions.Count && flag == 1 && flag1 == 1 || flag2 == 1)
                {
                    MessageBox.Show("上传/修改试题成功！");
                    //返回上一界面
                    setNull();
                    Owner.Owner.Show();
                    Owner.Dispose();
                }                
            }            
        }
        //取消操作
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //返回上一界面
            setNull();
            Owner.Show();
            Dispose();
        }
        //更新下拉框的选项
        private void click(object sender, EventArgs e)
        {
            cBx_passCount.Items.Clear();
            for (int i = 1; i <= questions.Count; i++)
            {
                cBx_passCount.Items.Add(i);
            }
        }
        private void ExamShow_Load(object sender, EventArgs e)
        {
            setNull();
            cBx_passCount.Click += new EventHandler(click);
            DataBaseConnection dc = new DataBaseConnection();
            if (c_id == -1)
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 490;
                lbl_no_data.Height = 150;
                fLP_showQuestions.Controls.Add(lbl_no_data);
            }
            else
            {
                string select_question = "select q.q_id,q.q_title,q.q_answer,q.q_option1,q.q_option2,q.q_option3,q.q_option4,q_goal from question q where c_id = " + c_id + "";
                DataSet ds = dc.ExecuteQuery(select_question);
                if (ds.Tables["user"].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables["user"].Rows.Count; i++)
                    {
                        int que_id = 0;
                        int.TryParse(ds.Tables["user"].Rows[i][0].ToString(),out que_id);
                        q_id.Add(que_id);
                        questions.Add(ds.Tables["user"].Rows[i][1].ToString());
                        answer.Add(ds.Tables["user"].Rows[i][2].ToString());
                        A.Add(ds.Tables["user"].Rows[i][3].ToString());
                        B.Add(ds.Tables["user"].Rows[i][4].ToString());
                        C.Add(ds.Tables["user"].Rows[i][5].ToString());
                        D.Add(ds.Tables["user"].Rows[i][6].ToString());
                        int goal = 0;
                        int.TryParse(ds.Tables["user"].Rows[i][7].ToString(),out goal);
                        Goal.Add(goal);
                    }
                    ShowQuestions();
                }
                else
                {
                    //无数据时显示提示
                    var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                    lbl_no_data.Font = font;
                    lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                    lbl_no_data.Width = 490;
                    lbl_no_data.Height = 150;
                    fLP_showQuestions.Controls.Add(lbl_no_data);
                }
            }
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//新建打开文件对话框
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//设置初始文件目录
            ofd.Filter = "Excel文件（*.xls；*.xlsx）|*.xls;*.xlsx|所有文件|*.*";//设置打开文件类型
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = ofd.FileName;//FileName就是要打开的文件路径
                                               //下边可以添加用户代码
                this.MM_lblFileName.Visible = true;
                MM_lblFileName.Text = FileName;
            }
        }

        private void MM_btnInput_Click(object sender, EventArgs e)
        {
            //批量上传考题功能
            DataTable dt = new DataTable();
            DataBaseConnection dc = new DataBaseConnection();
            string q_title, q_answer, q_a, q_b, q_c, q_d;
            int q_goal, count = 0, flag = 0;
            string insert_user, select_sql/*, update_sql*/;
            string fileAdd = MM_lblFileName.Text;
            if (!string.IsNullOrEmpty(fileAdd))
            {
                dt = Excel.ImportExcelFile(fileAdd);
                //遍历datatable
                if (dt.Rows.Count > 0)
                {
                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        q_title = dt.Rows[i][1].ToString();
                        q_answer = dt.Rows[i][2].ToString();
                        q_a = dt.Rows[i][3].ToString();
                        q_b = dt.Rows[i][4].ToString();
                        q_c = dt.Rows[i][5].ToString();
                        q_d = dt.Rows[i][6].ToString();
                        int.TryParse(dt.Rows[i][7].ToString(), out q_goal);
                        select_sql = "select isnull(count(1),0),isnull(q_id,-1) from question where q_title = N'" + q_title + "'and q_answer = '" + q_answer + "' and q_option1 = N'" + q_a + "' and q_option2 = N'" + q_b + "' and q_option3 = N'" + q_c + "' and q_option4 = '" + q_d + "' and q_goal = " + q_goal + " group by q_id";
                        DataSet ds1 = dc.ExecuteQuery(select_sql);
                        int count_e = 0;
                        int q_id = -1;
                        if (ds1.Tables["user"].Rows.Count > 0)
                        {
                            int.TryParse(ds1.Tables["user"].Rows[0][0].ToString(), out count_e);
                            int.TryParse(ds1.Tables["user"].Rows[0][1].ToString(), out q_id);
                        }
                        if (count_e == 1)
                        {
                            //存在则执行update操作
                            //string update_sql = "update question set q_title = N'" + q_title + "', q_answer = '" + q_answer + "' , q_option1 = N'" + q_a + "' , q_option2 = N'" + q_b + "' , q_option3 = N'" + q_c + "' , q_option4 = '" + q_d + "' , q_goal = " + q_goal + " where q_id = " + q_id;
                            //flag = dc.ExecuteUpdate(update_sql);
                            //if (flag == 1)
                            //{
                            count++;
                            //}
                        }
                        else if (count_e == 0)
                        {
                            //执行插入语句
                            insert_user = "insert into question values (next value for question_s,null,null,'" + q_title + "','" + q_answer + "','" + q_a + "','" + q_b + "','" + q_c + "','" + q_d + "'," + q_goal + ")";
                            //Console.WriteLine(insert_user);
                            flag = dc.ExecuteUpdate(insert_user);
                            if (flag == 1)
                            {
                                count++;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Excel表数据与数据库已有数据冲突，请仔细核对！");
                        }
                    }
                    if (count == dt.Rows.Count - 1)
                    {
                        MessageBox.Show("批量导入成功！");
                    }
                }
                else
                {
                    MessageBox.Show("Excel表中无数据！");
                }
            }
            else
            {
                MessageBox.Show("请选择文件！");
            }
        }
    }
}
