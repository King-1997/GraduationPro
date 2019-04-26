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
    public partial class ManagePlan : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        private int sp_head_id = -1;
        public static List<string> classes = null;
        public ManagePlan()
        {
            InitializeComponent();
            showOrHide();
        }
        private void showOrHide()
        {
            this.mp_flp_PlanInfo.Height = 300;
            this.mp_lbl_Plan_Name.Visible = false;
            this.mp_tBx_Plan_Name.Visible = false;
            this.mp_lbl_Head_Summary.Visible = false;
            this.mp_tBx_Head_Summary.Visible = false;
            this.mp_lbl_Emp_Type.Visible = false;
            this.mp_tBx_Emp_type.Visible = false;
            this.mp_tBx_Plan_Name.Font = font;
            this.mp_tBx_Head_Summary.Font = font;
            this.mp_tBx_Emp_type.Font = font;
        }
        private void ManagePlan_Load(object sender, EventArgs e)
        {
            string select_sql = "select sp_head_name,sp_head_summary,sp_created,sp_created_time,sp_emp_type,sp_head_id from study_plan_header";
            showPlanInfo(select_sql);
        }
        private void mp_btn_find_Click(object sender, EventArgs e)
        {
            string keyword = this.mp_tBx_findkeywords.Text;
            if (keyword == null)
            {
                ManagePlan_Load(sender,e);
            }
            string select_sql = "select sp_head_name,sp_head_summary,sp_created,sp_created_time,sp_emp_type,sp_head_id from study_plan_header where sp_head_name = '"+keyword+"'";
            showPlanInfo(select_sql);
        }
        private void showPlanInfo(string sql)
        {
            this.mp_flp_PlanInfo.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            //在窗口添加课程信息
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //计划名称标签
                var lbl_plan_name = new Label { Text = "计划名称" };
                lbl_plan_name.Font = font;
                lbl_plan_name.Width = 100;
                lbl_plan_name.TextAlign = ContentAlignment.MiddleCenter;
                //计划简介标签
                var lbl_introducation = new Label { Text = "计划简介" };
                lbl_introducation.Font = font;
                lbl_introducation.Width = 120;
                lbl_introducation.TextAlign = ContentAlignment.MiddleCenter;
                //创建人标签
                var lbl_creater = new Label { Text = "创建人" };
                lbl_creater.Font = font;
                lbl_creater.Width = 60;
                lbl_creater.TextAlign = ContentAlignment.MiddleCenter;
                //创建时间标签
                var lbl_create_time = new Label { Text = "创建时间" };
                lbl_create_time.Font = font;
                lbl_create_time.Width = 80;
                lbl_create_time.TextAlign = ContentAlignment.MiddleCenter;
                //针对员工类型标签
                var lbl_btn_emp_type = new Label { Text = "针对员工类型"};
                lbl_btn_emp_type.Width = 100;
                lbl_btn_emp_type.Font = font;
                lbl_btn_emp_type.TextAlign = ContentAlignment.MiddleCenter;
                //编辑学习计划信息标签
                var lbl_btn_edit = new Label { Text = "" };
                lbl_btn_edit.Width = 50;
                lbl_btn_edit.TextAlign = ContentAlignment.MiddleCenter;
                //删除学习计划信息标签
                var lbl_btn_delete = new Label { Text = "" };
                lbl_btn_delete.Width = 50;
                lbl_btn_delete.TextAlign = ContentAlignment.MiddleCenter;
                mp_flp_PlanInfo.Controls.Add(lbl_plan_name);               
                mp_flp_PlanInfo.Controls.Add(lbl_introducation);
                mp_flp_PlanInfo.Controls.Add(lbl_creater);
                mp_flp_PlanInfo.Controls.Add(lbl_create_time);
                mp_flp_PlanInfo.Controls.Add(lbl_btn_emp_type);
                mp_flp_PlanInfo.Controls.Add(lbl_btn_edit);
                mp_flp_PlanInfo.Controls.Add(lbl_btn_delete);
                mp_flp_PlanInfo.SetFlowBreak(lbl_btn_delete, true);
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //计划名
                    var plan_name = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    plan_name.Font = font;
                    plan_name.Width = 100;
                    plan_name.Name = ds.Tables["user"].Rows[i][0].ToString();
                    plan_name.TextAlign = ContentAlignment.MiddleCenter;
                    
                    //计划简介
                    var introducation = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    introducation.Font = font;
                    introducation.Width = 120;
                    introducation.TextAlign = ContentAlignment.MiddleCenter;
                    
                    //创建人
                    var creater = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    creater.Font = font;
                    creater.Width = 60;
                    creater.TextAlign = ContentAlignment.MiddleCenter;
                    //创建时间
                    var create_time = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    create_time.Font = font;
                    create_time.Width = 80;
                    create_time.TextAlign = ContentAlignment.MiddleCenter;
                    //针对员工类型
                    var emp_type = new Label { Text = ds.Tables["user"].Rows[i][4].ToString() };
                    emp_type.Font = font;
                    emp_type.Width = 100;
                    emp_type.TextAlign = ContentAlignment.MiddleCenter;
                    //编辑计划信息
                    var btn_check = new Button { Text = "编辑" };
                    btn_check.Width = 50;
                    btn_check.TextAlign = ContentAlignment.MiddleCenter;
                    btn_check.Name = ds.Tables["user"].Rows[i][5].ToString();
                    btn_check.Click += new EventHandler(editPlanInfo);

                    //删除计划
                    var btn_delete = new Button { Text = "删除" };
                    btn_delete.Width = 50;
                    btn_delete.TextAlign = ContentAlignment.MiddleCenter;
                    btn_delete.Name = ds.Tables["user"].Rows[i][5].ToString();
                    btn_check.Click += new EventHandler(deletePlan);

                    mp_flp_PlanInfo.Controls.Add(plan_name);                    
                    mp_flp_PlanInfo.Controls.Add(introducation);
                    mp_flp_PlanInfo.Controls.Add(creater);
                    mp_flp_PlanInfo.Controls.Add(create_time);
                    mp_flp_PlanInfo.Controls.Add(emp_type);                    
                    mp_flp_PlanInfo.Controls.Add(btn_check);
                    mp_flp_PlanInfo.Controls.Add(btn_delete);
                    mp_flp_PlanInfo.SetFlowBreak(btn_delete, true);
                }
            }
            else
            {
                //员工姓名
                var lbl_no_data = new Label { Text = string.Concat("抱歉，当前没有查询到任何数据！") };
                lbl_no_data.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 579;
                lbl_no_data.Height = 150;
                mp_flp_PlanInfo.Controls.Add(lbl_no_data);
            }
        }
        //编辑按钮事件处理
        private void editPlanInfo(object sender, EventArgs e)
        {
            //Button button = (Button)sender;
            //int.TryParse(button.Name, out EditPeriod.sp_head_id);
            //EditPeriod editperiod = new EditPeriod();
            //editperiod.Owner = this;
            //this.Hide();
            //editperiod.Show();
            mp_btn_addPlan_Click(sender, e);
            Button button = (Button)sender;            
            int.TryParse(button.Name,out sp_head_id);
            DataBaseConnection dc = new DataBaseConnection();
            string sql = "select sp_head_name,sp_head_summary,sp_emp_type from study_plan_header where sp_head_id = "+sp_head_id;
            DataSet ds = dc.ExecuteQuery(sql);
            this.mp_tBx_Plan_Name.Text = ds.Tables["user"].Rows[0][0].ToString();
            this.mp_tBx_Head_Summary.Text = ds.Tables["user"].Rows[0][1].ToString();
            this.mp_tBx_Emp_type.Text = ds.Tables["user"].Rows[0][2].ToString();
        }
        //删除按钮事件处理
        private void deletePlan(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要删除该学习计划吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
            {
                Button button = (Button)sender;
                int.TryParse(button.Name, out sp_head_id);
                DataBaseConnection dc = new DataBaseConnection();
                string delete_head_sql = "delete from study_plan_header where sp_head_id = " + sp_head_id;
                int flag1 = dc.ExecuteUpdate(delete_head_sql);
                //查询子表中头id为按钮中的id的信息条数
                string select_line_sql = "select count(1) from study_plan_lines where sp_head_id = " + sp_head_id;
                DataSet ds = dc.ExecuteQuery(select_line_sql);
                int count = -1;
                int.TryParse(ds.Tables["user"].Rows[0][0].ToString(), out count);
                string delete_line_sql = "delete from study_plan_lines where sp_head_id = " + sp_head_id;
                int flag2 = dc.ExecuteUpdate(delete_line_sql);
                if (flag1 == 1 && flag2 == count)
                {
                    MessageBox.Show("删除计划成功！");
                    ManagePlan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("系统错误！");
                }
            }
        }
        //返回按钮事件处理
        private void mp_btn_back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
            classes = null;
        }
        //新增计划按钮事件处理
        private void mp_btn_addPlan_Click(object sender, EventArgs e)
        {
            ////打开计划阶段信息界面EditPeriod，隐藏本界面
            //EditPeriod editperiod = new EditPeriod();
            //editperiod.Owner = this;
            //editperiod.Show();
            //this.Hide();

            this.mp_flp_PlanInfo.Height = 145;
            this.mp_lbl_Plan_Name.Visible = true;
            this.mp_tBx_Plan_Name.Visible = true;
            this.mp_lbl_Head_Summary.Visible = true;
            this.mp_tBx_Head_Summary.Visible = true;
            this.mp_lbl_Emp_Type.Visible = true;
            this.mp_tBx_Emp_type.Visible = true;

            this.mp_tBx_Plan_Name.Text = null;
            this.mp_tBx_Head_Summary.Text = null;
            this.mp_tBx_Emp_type.Text = null;
        }

        private void mp_btn_reset_Click_1(object sender, EventArgs e)
        {
            showOrHide();
            this.mp_tBx_findkeywords.Text = null;
            ManagePlan_Load(sender, e);
        }

        private void mp_btn_confirm_Click(object sender, EventArgs e)
        {
            //修改之前还需询问是否执行修改操作            
            string plan_name = this.mp_tBx_Plan_Name.Text;
            string head_summary = this.mp_tBx_Head_Summary.Text;
            string emp_type = this.mp_tBx_Emp_type.Text;
            DataBaseConnection dc = new DataBaseConnection();
            if (sp_head_id == -1)
            {
                string insert_sql = "insert into study_plan_header values(next value for study_plan_header_s,'" + plan_name + "','" + head_summary + "','" + Model.User.userName + "',convert(char(10),GetDate(),120),'" + emp_type + "')";
                int flag = dc.ExecuteUpdate(insert_sql);
                if (flag != 0)
                {
                    MessageBox.Show("新增学习计划头信息成功！");
                }
                else
                {
                    MessageBox.Show("系统错误！");
                }
            }else
            {
                if (MessageBox.Show("您确定要保存该修改吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string update_sql = "update study_plan_header set sp_head_name = '" + plan_name + "',sp_head_summary = '" + head_summary + "',sp_emp_type = '" + emp_type + "' where sp_head_id =" + sp_head_id;
                    int flag = dc.ExecuteUpdate(update_sql);
                    if (flag != 0)
                    {
                        MessageBox.Show("修改学习计划头信息成功！");
                    }
                    else
                    {
                        MessageBox.Show("系统错误！");
                    }
                }               
            }
            ManagePlan_Load(sender,e);
        }
    }
}
