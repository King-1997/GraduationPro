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
    public partial class ManageExam : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public static int exam_p_id = -1;
        public static int pass_goal = 0;
        public static int total_goal = 0;
        public static string question_title = null;
        public static int question_id = -1;
        //public static List<string> question = null;
        public static List<string> q_id = new List<string> { };
        DataBaseConnection dc = new DataBaseConnection();
        public ManageExam()
        {
            InitializeComponent();
        }
        private void ManageExam_Load(object sender, EventArgs e)
        {
                string select_exam_info = "select exam_p_name,start_time,end_time from exam_paper where exam_p_id = " + exam_p_id;
                DataSet ds = dc.ExecuteQuery(select_exam_info);
                me_lbl_ExamName.Text = ds.Tables["user"].Rows[0][0].ToString();
                me_lbl_StartTime.Text = ds.Tables["user"].Rows[0][1].ToString();
                me_lbl_EndTime.Text = ds.Tables["user"].Rows[0][2].ToString();
                string select_sql = "select q.q_id from question q,classes c,exam_detail ed where c.c_id = q.c_id and ed.q_id = q.q_id and ed.exam_p_id = " + exam_p_id;
                DataSet ds1 = dc.ExecuteQuery(select_sql);
                if (ds1.Tables["user"].Rows.Count > 0)
                {
                    for (var i = 0; i < ds1.Tables["user"].Rows.Count; i++)
                    {
                        q_id.Add(ds1.Tables["user"].Rows[i][0].ToString());
                    }
                }
            string sql = "select q.q_title,isnull(c.c_name,'无') as c_name,q.q_goal,q.q_id from question q,classes c,exam_detail ed where c.c_id = q.c_id and ed.q_id = q.q_id and ed.exam_p_id = " + exam_p_id;
            showQuesInfo(sql);
        }
        private void showDetails()
        {
                if (q_id != null)
                {
                    //清除屏幕，重新加载数据
                    me_flp_q_info.Controls.Clear();
                    total_goal = 0;
                    foreach (string q_ids in q_id)
                    {
                        int q_idd = 0;
                        int.TryParse(q_ids, out q_idd);
                        q_id = q_id.Distinct().ToList();
                        string select_q_sql = "select q.q_title,isnull(c.c_name,'无') as c_name,q.q_goal,q.q_id from question q,classes c where c.c_id = q.c_id and q.q_id = " + q_idd;
                        showAddQuesInfo(select_q_sql);
                    }
            }else
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 400;
                lbl_no_data.Height = 150;
                me_flp_q_info.Controls.Add(lbl_no_data);
            }
        }
        private void showAddQuesInfo(string sql)
        {
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            //在窗口添加学习计划信息
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //题目标签
                var u_name_lbl = new Label { Text = "题目" };
                u_name_lbl.Font = font;
                u_name_lbl.TextAlign = ContentAlignment.MiddleCenter;

                //所属课程标签
                var u_group_lbl = new Label { Text = "所属课程" };
                u_group_lbl.Font = font;
                u_group_lbl.TextAlign = ContentAlignment.MiddleCenter;

                //分值标签
                var u_sex_lbl = new Label { Text = "分值" };
                u_sex_lbl.Font = font;
                u_sex_lbl.TextAlign = ContentAlignment.MiddleCenter;

                //分值标签
                var u_delete_lbl = new Label { Text = "" };
                u_delete_lbl.Font = font;
                u_delete_lbl.TextAlign = ContentAlignment.MiddleCenter;
                me_flp_q_info.Controls.Add(u_name_lbl);
                me_flp_q_info.Controls.Add(u_group_lbl);
                me_flp_q_info.Controls.Add(u_sex_lbl);
                me_flp_q_info.Controls.Add(u_delete_lbl);
                me_flp_q_info.SetFlowBreak(u_delete_lbl, true);
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //题目
                    var u_name = new Label { Text = i + 1 + "、" + ds.Tables["user"].Rows[i][0].ToString() };
                    u_name.Font = font;
                    //u_name.Name = ds.Tables["user"].Rows[i][3].ToString();
                    u_name.TextAlign = ContentAlignment.MiddleCenter;
                    //u_name.CheckedChanged += Works_delete_CheckedChanged;
                    //所属课程
                    var u_group = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    u_group.Font = font;
                    u_group.TextAlign = ContentAlignment.MiddleCenter;

                    //分值
                    var u_sex = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    u_sex.Font = font;
                    u_sex.TextAlign = ContentAlignment.MiddleCenter;
                    total_goal += (int)ds.Tables["user"].Rows[i][2];//将题目分值加起来

                    //删除
                    var btn_delete = new Button { Text = "删除" };
                    btn_delete.Width = 50;
                    btn_delete.Name = ds.Tables["user"].Rows[i][3].ToString();
                    btn_delete.TextAlign = ContentAlignment.MiddleCenter;
                    btn_delete.Click += new EventHandler(deleteQues);

                    me_flp_q_info.Controls.Add(u_name);
                    me_flp_q_info.Controls.Add(u_group);
                    me_flp_q_info.Controls.Add(u_sex);
                    me_flp_q_info.Controls.Add(btn_delete);
                    me_flp_q_info.SetFlowBreak(btn_delete, true);
                }
                me_lbl_totalGoal.Text = "当前总分为：" + total_goal;
            }
        }
        private void showQuesInfo(string sql)
        {
            //清除屏幕，重新加载数据
            me_flp_q_info.Controls.Clear();
            total_goal = 0;
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            //在窗口添加学习计划信息
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //题目标签
                var u_name_lbl = new Label { Text = "题目" };
                u_name_lbl.Font = font;
                u_name_lbl.TextAlign = ContentAlignment.MiddleCenter;

                //所属课程标签
                var u_group_lbl = new Label { Text = "所属课程" };
                u_group_lbl.Font = font;
                u_group_lbl.TextAlign = ContentAlignment.MiddleCenter;

                //分值标签
                var u_sex_lbl = new Label { Text = "分值" };
                u_sex_lbl.Font = font;
                u_sex_lbl.TextAlign = ContentAlignment.MiddleCenter;

                //分值标签
                var u_delete_lbl = new Label { Text = "" };
                u_delete_lbl.Font = font;
                u_delete_lbl.TextAlign = ContentAlignment.MiddleCenter;
                me_flp_q_info.Controls.Add(u_name_lbl);
                me_flp_q_info.Controls.Add(u_group_lbl);
                me_flp_q_info.Controls.Add(u_sex_lbl);
                me_flp_q_info.Controls.Add(u_delete_lbl);
                me_flp_q_info.SetFlowBreak(u_delete_lbl, true);
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //题目
                    var u_name = new Label { Text = i + 1 + "、" + ds.Tables["user"].Rows[i][0].ToString() };
                    u_name.Font = font;
                    //u_name.Name = ds.Tables["user"].Rows[i][3].ToString();
                    u_name.TextAlign = ContentAlignment.MiddleCenter;
                    //u_name.CheckedChanged += Works_delete_CheckedChanged;
                    //所属课程
                    var u_group = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    u_group.Font = font;
                    u_group.TextAlign = ContentAlignment.MiddleCenter;

                    //分值
                    var u_sex = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    u_sex.Font = font;
                    u_sex.TextAlign = ContentAlignment.MiddleCenter;
                    total_goal += (int)ds.Tables["user"].Rows[i][2];//将题目分值加起来

                    //删除
                    var btn_delete = new Button { Text = "删除" };
                    btn_delete.Width = 50;
                    btn_delete.Name = ds.Tables["user"].Rows[i][3].ToString();
                    btn_delete.TextAlign = ContentAlignment.MiddleCenter;
                    btn_delete.Click += new EventHandler(deleteQues);

                    me_flp_q_info.Controls.Add(u_name);
                    me_flp_q_info.Controls.Add(u_group);
                    me_flp_q_info.Controls.Add(u_sex);
                    me_flp_q_info.Controls.Add(btn_delete);
                    me_flp_q_info.SetFlowBreak(btn_delete, true);
                }
                me_lbl_totalGoal.Text = "当前总分为：" + total_goal;
            }
            else
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 400;
                lbl_no_data.Height = 150;
                me_flp_q_info.Controls.Add(lbl_no_data);
            }
        }
        private void deleteQues(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要删除该试题吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
            {
                Button button = (Button)sender;
                int.TryParse(button.Name,out question_id);
                DataBaseConnection dc = new DataBaseConnection();
                string select_sql = "select q_id from exam_detail where q_id ="+question_id;
                DataSet ds = dc.ExecuteQuery(select_sql);
                if (ds.Tables["user"].Rows.Count == 1)
                {
                    string delete_sql = "delete from exam_detail where exam_p_id = "+exam_p_id+" and q_id =" + question_id;
                    int flag = dc.ExecuteUpdate(delete_sql);
                    if (flag == 1)
                    {
                        MessageBox.Show("删除成功！");
                    }
                }
                q_id.Remove(button.Name);
                showDetails();
            }
        }
        //人员显示

        private void me_btn_back_Click(object sender, EventArgs e)
        {
            exam_p_id = -1;
            q_id.Clear();
            Owner.Show();
            Dispose();
        }

        private void ep_btn_All_Peroid_Click(object sender, EventArgs e)
        {
            showDetails();
        }

        private void me_btn_addQues_Click(object sender, EventArgs e)
        {
            Ques_detail ques_detail = new Ques_detail();
            ques_detail.exam_p_id = exam_p_id;
            ques_detail.Owner = this;
            Hide();
            ques_detail.Show();
        }

        private void ep_btn_confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(me_tbx_Pass_Goal.Text))
            {
                MessageBox.Show("请输入通过分数！");
            }
            else if (me_tbx_Pass_Goal.Text != null)
            {
                int.TryParse(me_tbx_Pass_Goal.Text, out pass_goal);
                if (pass_goal > total_goal)
                {
                    MessageBox.Show("通过分数大于总分数，请重新输入！");
                }
                else
                {
                    if (MessageBox.Show("您确定要添加吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        DataBaseConnection dc = new DataBaseConnection();
                        int count = 0;
                        foreach (string q_ids in q_id)
                        {
                            int q_idd = 0;
                            int.TryParse(q_ids, out q_idd);
                            string select_q_id = "select q_id from exam_detail where q_id = " + q_idd;
                            DataSet ds = dc.ExecuteQuery(select_q_id);
                            if (ds.Tables["user"].Rows.Count == 0)
                            {
                                string insert_detail = "insert into exam_detail values (next value for exam_detail_s," + exam_p_id + "," + q_idd + ")";
                                int flag = dc.ExecuteUpdate(insert_detail);
                            }
                            count++;
                        }
                        if (count == q_id.Count)
                        {
                            MessageBox.Show("添加试题成功！");
                            string update_sql = "update exam_paper set total_goal = " + total_goal + ",pass_goal = " + pass_goal + " where exam_p_id = " + exam_p_id;
                            int flag = dc.ExecuteUpdate(update_sql);
                            me_btn_back_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("添加试题失败，请联系系统管理员！");
                        }
                    }
                }
            }
        }
    }
}
