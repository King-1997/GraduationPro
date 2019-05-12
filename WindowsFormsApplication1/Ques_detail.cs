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
    public partial class Ques_detail : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public List<string> question = new List<string>();//保存选择的试题信息
        public int exam_p_id = -1;
        public List<string> q_id = new List<string>();//保存选择的试题id信息
        public static string select_sql = "";
        public Ques_detail()
        {
            InitializeComponent();
            cbB_findKey.Items.AddRange(new object[] { "按课程", "按分数" });
            cbB_findKey.SelectedIndex = 0;

            DataBaseConnection dc = new DataBaseConnection();
            string select_c_name = "select distinct c_name from classes";
            DataSet ds = dc.ExecuteQuery(select_c_name);
            for (int i = 0; i < ds.Tables["user"].Rows.Count; i++)
            {
                cBx_c_name.Items.Add(ds.Tables["user"].Rows[i][0]);
            }
            cBx_c_name.SelectedIndex = 0;

            string select_goal = "select distinct q_goal from question";
            DataSet ds1 = dc.ExecuteQuery(select_goal);
            for (int i = 0; i < ds1.Tables["user"].Rows.Count; i++)
            {
                cBx_goal.Items.Add(ds1.Tables["user"].Rows[i][0]);
            }
            cBx_goal.SelectedIndex = 0;
        }

        private void Ques_detail_Load(object sender, EventArgs e)
        {
            select_sql = "select q.q_title,isnull(c.c_name,'无'),q.q_goal,q_id from question q,classes c where q.c_id = c.c_id and q.q_id not in (select ed.q_id from exam_detail ed where ed.exam_p_id = " + exam_p_id + ")";
            QuestionShow(select_sql);
        }
        private void QuestionShow(string sql)
        {
            //刷新显示窗口
            fLP_people.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            //从数据库中提取数据
            DataSet ds = dc.ExecuteQuery(sql);
            //在窗口添加员工信息
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

                fLP_people.Controls.Add(u_name_lbl);
                fLP_people.Controls.Add(u_group_lbl);
                fLP_people.Controls.Add(u_sex_lbl);
                fLP_people.SetFlowBreak(u_sex_lbl, true);
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //题目
                    var u_name = new CheckBox { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    u_name.Font = font;
                    u_name.Name = ds.Tables["user"].Rows[i][3].ToString();
                    u_name.TextAlign = ContentAlignment.MiddleCenter;
                    u_name.CheckedChanged += ck_child_CheckedChanged;
                    //所属课程
                    var u_group = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    u_group.Font = font;
                    u_group.TextAlign = ContentAlignment.MiddleCenter;

                    //分值
                    var u_sex = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    u_sex.Font = font;
                    u_sex.TextAlign = ContentAlignment.MiddleCenter;

                    fLP_people.Controls.Add(u_name);
                    fLP_people.Controls.Add(u_group);
                    fLP_people.Controls.Add(u_sex);
                    fLP_people.SetFlowBreak(u_sex, true);
                }
            }
            else
            {
                //无数据
                var lbl_no_user = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_user.Font = font;
                lbl_no_user.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_user.Width = 550;
                lbl_no_user.Height = 150;
                fLP_people.Controls.Add(lbl_no_user);
            }
        }
        //全选复选框的功能实现
        private void cBx_allSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (cBx_allSelect.CheckState == CheckState.Checked)
            {
                foreach (Control peo in fLP_people.Controls)
                {
                    if (peo is CheckBox)
                    {
                        CheckBox ple = (CheckBox)peo;
                        ple.Checked = true;
                    }
                }
            }
            else
            {
                foreach (Control peo in fLP_people.Controls)
                {
                    if (peo is CheckBox)
                    {
                        CheckBox ple = (CheckBox)peo;
                        ple.Checked = false;
                    }
                }
            }
        }
        //全选框的反选功能实现
        private void ck_child_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            if (c.Checked == true)
            {
                foreach (Control ch in fLP_people.Controls)
                {
                    if (ch is CheckBox)
                    {
                        if ((ch as CheckBox).Checked == false)
                        {
                            return;
                        }
                    }
                }
                cBx_allSelect.Checked = true;
            }
            else
            {
                cBx_allSelect.Checked = false;
            }
        }

        private void btn_oK_Click(object sender, EventArgs e)
        {
            //遍历 
            foreach (Control ctl in fLP_people.Controls)
            {
                if (ctl is CheckBox)
                {
                    if ((ctl as CheckBox).Checked == true)
                    {
                        //处理代码
                        //question.Add(ctl.Text);
                        q_id.Add(ctl.Name);
                    }
                }
            }
            ManageExam.q_id.Distinct().ToList();
            //传递选定的题目id
            ManageExam.q_id.AddRange(q_id);
            //获取上一界面的已选员工窗口
            ManageExam manageExam = (ManageExam)Owner;
            //manageExam.EmpsShow();
            Owner.Show();
            Dispose();

        }

        private void cbB_findKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当下拉框选为“按课程”选择时，输入框变为组别下拉框
            if (cbB_findKey.Text == "按课程")
            {
                //生成新的下拉框
                Controls.Add(cBx_c_name);
                Controls.Remove(cBx_goal);
            }
            else if (cbB_findKey.Text == "按分数")
            {
                //生成新的下拉框
                Controls.Remove(cBx_c_name);
                Controls.Add(cBx_goal);
                cBx_goal.Location = cBx_c_name.Location;
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            select_sql = "select q.q_title,isnull(c.c_name,'无'),q.q_goal,q_id from question q,classes c where q.c_id = c.c_id and q.q_id not in (select ed.q_id from exam_detail ed where ed.exam_p_id = " + exam_p_id + ")";
            if (cbB_findKey.Text == "按课程")
            {
                string c_name = cBx_c_name.SelectedItem.ToString();
                select_sql += " and c.c_name = '" + c_name + "'";
                QuestionShow(select_sql);
            }
            else if (cbB_findKey.Text == "按分数")
            {
                string goal = cBx_goal.SelectedItem.ToString();
                int q_goal = 0;
                int.TryParse(goal, out q_goal);
                select_sql += " and q.q_goal = " + q_goal;
                QuestionShow(select_sql);
            }
        }

        private void qd_btn_reset_Click(object sender, EventArgs e)
        {
            Ques_detail_Load(sender, e);
        }
    }
}
