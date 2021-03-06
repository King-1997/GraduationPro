﻿using CCWin;
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
    public partial class PeopleChoose : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        private string preboxname = null;//保存当前输入框的Name，当下拉框改变时更改
        public List<string> people = new List<string>();//保存选择的员工名字信息
        public List<string> user_id = new List<string>();//保存选择的员工id信息
        public PeopleChoose()
        {
            //查询下拉框
            InitializeComponent();
            preboxname = tBx_findkeywords.Name;
            cbB_findKey.Items.AddRange(new object[] { "按组别", "按工号", "按性别", "按电话号码","按入职时间" });
            cbB_findKey.SelectedIndex = 0;
            //查询组别下拉框
            DataBaseConnection dc = new DataBaseConnection();
            string sql = "select g_group from [group]";
            DataSet ds1 = dc.ExecuteQuery(sql);
            for (int i = 0; i < ds1.Tables["user"].Rows.Count; i++)
            {
                cBx_workertype.Items.Add(ds1.Tables["user"].Rows[i][0]);
            }
            cBx_workertype.SelectedIndex = 0;
            cBx_workertype.Size = tBx_findkeywords.Size;
            cBx_workertype.Location = tBx_findkeywords.Location;

            string sql_entryTime = "select max(u_entryTime),min(u_entryTime) from [User]";
            DataSet ds2 = dc.ExecuteQuery(sql_entryTime);
            string maxTime = ds2.Tables["user"].Rows[0][0].ToString();
            string minTime = ds2.Tables["user"].Rows[0][1].ToString();
            /*Console.WriteLine("最大入职时间：" + maxTime);
            Console.WriteLine("最小入职时间：" + minTime);*/
            int maxYear = 0;
            int.TryParse(maxTime.Substring(0, 4), out maxYear);
            int minYear = 0;
            int.TryParse(minTime.Substring(0, 4), out minYear);
            for (int i = minYear; i <= maxYear; i++)
            {
                cBx_workerEntryYear.Items.Add(i);
            }
            cBx_workerEntryYear.SelectedIndex = 0;
            cBx_workerEntryYear.Location = tBx_findkeywords.Location;

            for (int j = 1; j < 13; j++)
            {
                String month = "";
                if (j < 10)
                {
                    month = "0" + j;
                }
                else
                {
                    month = j.ToString();
                }
                cBx_workerEntryMonth.Items.Add(month);
            }
            cBx_workerEntryMonth.SelectedIndex = 0;
            cBx_workerEntryMonth.Location = new Point(213, 98);
        }
        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Dispose();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            //刷新窗口
            fLP_people.Controls.Clear();
            JudgeYearAndMonth jym = new JudgeYearAndMonth();
            //获取查询条件：tBx_findkeywords，cbB_findKey
            string KeyWord = tBx_findkeywords.Text;
            string KeyType = cbB_findKey.SelectedItem.ToString();
            if (!cbB_findKey.Text.Equals("按组别") && string.IsNullOrEmpty(KeyWord))
            {
                MessageBox.Show("请输入关键字！");
            }
            //从数据库查找数据
            DataBaseConnection dc = new DataBaseConnection();
            string sql = "";
            //Console.WriteLine("查询条件：" + KeyType);
            if (KeyType.Equals("按组别"))
            {
                String KeyWord1 = cBx_workertype.SelectedItem.ToString();
                sql += "select u.u_name,g.g_group,u.u_sex,u_phone,u_entryTime,u.u_id from [User] u,[group] g where u.g_id = g.g_id and g.g_group = N'" + KeyWord1 + "'";
            }
            else if (KeyType.Equals("按工号"))
            {
                sql += "select u.u_name,g.g_group,u.u_sex,u_phone,u_entryTime,u.u_id from [User] u,[group] g where u.g_id = g.g_id and u.u_account = '" + KeyWord + "'";
            }
            else if (KeyType.Equals("按性别"))
            {
                sql += "select u.u_name,g.g_group,u.u_sex,u_phone,u_entryTime,u.u_id from [User] u,[group] g where u.g_id = g.g_id and u.u_sex = N'" + KeyWord + "'";
            }
            else if (KeyType.Equals("按电话号码"))
            {
                sql += "select u.u_name,g.g_group,u.u_sex,u_phone,u_entryTime,u.u_id from [User] u,[group] g where u.g_id = g.g_id and u.u_phone = " + KeyWord;
            }
            else if (KeyType.Equals("按入职时间"))
            {
                DateTime entryTime1 = new DateTime(2018, 8, 25);
                DateTime entryTime2 = new DateTime(2018, 8, 26);
                int year = 0;
                int.TryParse(cBx_workerEntryYear.SelectedItem.ToString(), out year);
                int month = 0;
                int.TryParse(cBx_workerEntryMonth.SelectedItem.ToString(), out month);
                entryTime1 = Convert.ToDateTime(year + "-" + month + "-01");//设置开始时间都为该月1号               
                entryTime2 = jym.judgeYearAndMonth(year,month);
                sql += "select u.u_name,g.g_group,u.u_sex,u_phone,u_entryTime,u.u_id from [User] u,[group] g where u.g_id = g.g_id and u.u_entryTime >= '" + entryTime1 + "' and u.u_entryTime <= '" + entryTime2 + "'";
            }
                //Console.WriteLine("查询语句：" + sql);
                WorkerShow(sql);
        }
        private void WorkerShow(string sql)
        {
            //刷新显示窗口
            fLP_people.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            //从数据库中提取数据
            DataSet ds = dc.ExecuteQuery(sql);
            //在窗口添加员工信息
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //姓名标签
                var u_name_lbl = new Label { Text = "姓名" };
                u_name_lbl.Font = font;
                u_name_lbl.TextAlign = ContentAlignment.MiddleCenter;

                //所在分组标签
                var u_group_lbl = new Label { Text = "所在分组" };
                u_group_lbl.Font = font;
                u_group_lbl.TextAlign = ContentAlignment.MiddleCenter;

                //性别标签
                var u_sex_lbl = new Label { Text = "性别" };
                u_sex_lbl.Font = font;
                u_sex_lbl.TextAlign = ContentAlignment.MiddleCenter;

                //电话号码标签
                var u_phone_lbl = new Label { Text = "电话号码" };
                u_phone_lbl.Font = font;
                u_phone_lbl.TextAlign = ContentAlignment.MiddleCenter;

                //入职时间标签
                var u_entryTime_lbl = new Label { Text = "入职时间" };
                u_entryTime_lbl.Font = font;
                u_entryTime_lbl.TextAlign = ContentAlignment.MiddleCenter;

                fLP_people.Controls.Add(u_name_lbl);
                fLP_people.Controls.Add(u_group_lbl);
                fLP_people.Controls.Add(u_sex_lbl);
                fLP_people.Controls.Add(u_phone_lbl);
                fLP_people.Controls.Add(u_entryTime_lbl);
                fLP_people.SetFlowBreak(u_entryTime_lbl, true);
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //姓名
                    var u_name = new CheckBox { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    u_name.Font = font;
                    u_name.Name = ds.Tables["user"].Rows[i][5].ToString();
                    u_name.TextAlign = ContentAlignment.MiddleCenter;
                    u_name.CheckedChanged += ck_child_CheckedChanged;
                    //所在分组
                    var u_group = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    u_group.Font = font;
                    u_group.TextAlign = ContentAlignment.MiddleCenter;

                    //性别
                    var u_sex = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    u_sex.Font = font;
                    u_sex.TextAlign = ContentAlignment.MiddleCenter;

                    //电话号码
                    var u_phone = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    u_phone.Font = font;
                    u_phone.TextAlign = ContentAlignment.MiddleCenter;

                    //入职时间
                    var u_entryTime = new Label { Text = ds.Tables["user"].Rows[i][4].ToString() };
                    u_entryTime.Font = font;
                    u_entryTime.TextAlign = ContentAlignment.MiddleCenter;

                    fLP_people.Controls.Add(u_name);
                    fLP_people.Controls.Add(u_group);
                    fLP_people.Controls.Add(u_sex);
                    fLP_people.Controls.Add(u_phone);
                    fLP_people.Controls.Add(u_entryTime);
                    fLP_people.SetFlowBreak(u_entryTime, true);
                }
            }
            else
            {
                //无数据
                var lbl_no_user = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_user.Font = font;
                lbl_no_user.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_user.Width = 579;
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
                        people.Add(ctl.Text);
                        user_id.Add(ctl.Name);
                    }
                }
            }
            //传递选定的员工
            if (PlanArrangement.people == null || people == null)
            {
                PlanArrangement.people = people;
                PlanArrangement.user_id = user_id;
            }
            else
            {
                PlanArrangement.people.AddRange(people);
                PlanArrangement.user_id.AddRange(user_id);
            }                
            //获取上一界面的已选员工窗口
            PlanArrangement lesson = (PlanArrangement)Owner;
            lesson.EmpsShow();
            Owner.Show();
            Dispose();
        }
        private void PeopleChoose_Load(object sender, EventArgs e)
        {
            fLP_people.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            string sql = "";
            if (Model.User.groupId == 0)
            {
                sql += "select u.u_name,g.g_group,u.u_sex,u_phone,u_entryTime,u.u_id from [User] u,[group] g where u.g_id = g.g_id ";
            }else
            {
                sql += "select u.u_name,g.g_group,u.u_sex,u_phone,u_entryTime,u.u_id from [User] u,[group] g where u.g_id = g.g_id and u.g_id =" + Model.User.groupId;
            }
            WorkerShow(sql);
        }
        //cbB_findKey当下拉框值改变时  
        //生成新的下拉框
        private void cbB_findKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (preboxname == "cBx_workertype")
            {
                Controls.Remove(cBx_workertype);
            }
            else if (preboxname == "cBx_workerentryTime")
            {
                Controls.Remove(cBx_workerEntryYear);
                Controls.Remove(cBx_workerEntryMonth);
            }
            else
            {
                Controls.Remove(tBx_findkeywords);
            }

            //当下拉框选为“按组别”选择时，输入框变为组别下拉框
            if (cbB_findKey.Text == "按组别")
            {
                //生成新的下拉框
                preboxname = "cBx_workertype";
                Controls.Add(cBx_workertype);
                Controls.Remove(cBx_workerEntryYear);
                Controls.Remove(cBx_workerEntryMonth);
            }
            else if (cbB_findKey.Text == "按入职时间")
            {
                //生成新的下拉框
                preboxname = "cBx_workerentryTime";
                Controls.Remove(cBx_workertype);
                Controls.Add(cBx_workerEntryYear);
                Controls.Add(cBx_workerEntryMonth);
            }
            else
            {
                preboxname = "tBx_findkeywords";
                Controls.Add(tBx_findkeywords);
            }
        }

        private void pc_btn_return_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Dispose();
        }
    }
}
