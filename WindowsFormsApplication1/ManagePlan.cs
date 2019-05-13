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
        public static int sps_id = -1;
        private int sp_head_id = -1;
        //public static List<string> classes = null;
        public string PlanId = null;//保存选择的课程id信息
        public string PlanName = null;//保存选择的课程名信息
        public ManagePlan()
        {
            InitializeComponent();
            mp_flp_PlanInfo.Height = 300;
            showOrHide(false);
            DataBaseConnection dc = new DataBaseConnection();
            String select_user_type = "select ut_type from UserType";
            DataSet ds = dc.ExecuteQuery(select_user_type);
            for (int i = 0; i < ds.Tables["user"].Rows.Count; i++)
            {
                mp_tbx_Emp_type.Items.Add(ds.Tables["user"].Rows[i][0]);
            }
            //Wm_cbBUserType.Items.AddRange(new object[] { "系统管理员", "管理员", "员工" });
            mp_tbx_Emp_type.SelectedIndex = Model.User.ut_id;

            string select_emp_station = "select station_name from employee_station";
            DataSet ds1 = dc.ExecuteQuery(select_emp_station);
            for (int i = 0; i < ds1.Tables["user"].Rows.Count; i++)
            {
                mp_tbx_Emp_station.Items.Add(ds1.Tables["user"].Rows[i][0]);
            }
            //Wm_cbBUserType.Items.AddRange(new object[] { "系统管理员", "管理员", "员工" });
            mp_tbx_Emp_station.SelectedIndex = Model.User.station_id;

            string sql = "select g_group from [group]";
            DataSet ds2 = dc.ExecuteQuery(sql);
            for (int i = 0; i < ds2.Tables["user"].Rows.Count; i++)
            {
                mp_tbx_Emp_dpt.Items.Add(ds2.Tables["user"].Rows[i][0]);
            }
            mp_tbx_Emp_dpt.SelectedIndex = Model.User.groupId;
        }
        private void showOrHide(Boolean flag)
        {            
            mp_lbl_Plan_Name.Visible = flag;
            mp_tBx_Plan_Name.Visible = flag;
            mp_lbl_Head_Summary.Visible = flag;
            mp_tBx_Head_Summary.Visible = flag;
            mp_lbl_Emp_dpt.Visible = flag;
            mp_tbx_Emp_dpt.Visible = flag;
            mp_lbl_Emp_station.Visible = flag;
            mp_tbx_Emp_station.Visible = flag;
            mp_lbl_Emp_type.Visible = flag;
            mp_tbx_Emp_type.Visible = flag;
            mp_tBx_Plan_Name.Font = font;
            mp_tBx_Head_Summary.Font = font;
            mp_tbx_Emp_type.Font = font;
            mp_tbx_Emp_dpt.Font = font;
            mp_tbx_Emp_station.Font = font;
        }
        private void ManagePlan_Load(object sender, EventArgs e)
        {
            string select_sql = "select sph.sp_head_name,sph.sp_head_summary,(select g_group from [group] where g_id =sph.sp_created) as created,(select g_group from [group] where g_id =sph.sp_emp_dpt) as emp_dpt,ut.ut_type,es.station_name,sp_head_id from study_plan_header sph,[group] g,UserType ut,employee_station es where sph.sp_created = g.g_id and sph.sp_emp_type = ut.ut_id and sph.sp_emp_station = es.station_id and sps_id = "+sps_id;            
            showPlanInfo(select_sql);
        }
        private void mp_btn_find_Click(object sender, EventArgs e)
        {
            string keyword = mp_tBx_findkeywords.Text;
            if (keyword == null)
            {
                ManagePlan_Load(sender,e);
            }else
            {
                string select_sql = "select sph.sp_head_name,sph.sp_head_summary,(select g_group from [group] where g_id =sph.sp_created) as created,(select g_group from [group] where g_id =sph.sp_emp_dpt) as emp_dpt,ut.ut_type,es.station_name,sp_head_id from study_plan_header sph,[group] g,UserType ut,employee_station es where sph.sp_created = g.g_id and sph.sp_emp_type = ut.ut_id and sph.sp_emp_station = es.station_id and sps_id = "+sps_id+" and sp_head_name like '%" + keyword + "%'";
                showPlanInfo(select_sql);
            }
        }
        private void showPlanInfo(string sql)
        {
            //清除之前的数据
            mp_flp_PlanInfo.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            //在窗口添加学习计划信息
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //计划名称标签
                var lbl_plan_name = new Label { Text = "计划名称" };
                lbl_plan_name.Font = font;
                lbl_plan_name.Width = 120;
                lbl_plan_name.TextAlign = ContentAlignment.MiddleCenter;
                //计划简介标签
                var lbl_introducation = new Label { Text = "计划简介" };
                lbl_introducation.Font = font;
                lbl_introducation.Width = 80;
                lbl_introducation.TextAlign = ContentAlignment.MiddleCenter;
                //创建部门标签
                var lbl_created = new Label { Text = "创建部门" };
                lbl_created.Font = font;
                lbl_created.Width = 60;
                lbl_created.TextAlign = ContentAlignment.MiddleCenter;
                //针对部门标签
                var lbl_creater = new Label { Text = "针对部门" };
                lbl_creater.Font = font;
                lbl_creater.Width = 60;
                lbl_creater.TextAlign = ContentAlignment.MiddleCenter;
                //针对员工类型标签
                var lbl_create_time = new Label { Text = "针对员工类型" };
                lbl_create_time.Font = font;
                lbl_create_time.Width = 80;
                lbl_create_time.TextAlign = ContentAlignment.MiddleCenter;
                //针对员工岗位标签
                var lbl_btn_emp_type = new Label { Text = "针对员工岗位"};
                lbl_btn_emp_type.Width = 100;
                lbl_btn_emp_type.Font = font;
                lbl_btn_emp_type.TextAlign = ContentAlignment.MiddleCenter;
                //编辑学习计划信息标签
                var lbl_btn_edit = new Label { Text = "" };
                lbl_btn_edit.Width = 50;
                lbl_btn_edit.TextAlign = ContentAlignment.MiddleCenter;
                //编辑学习计划阶段信息标签
                var lbl_btn_edit_period = new Label { Text = "" };
                lbl_btn_edit_period.Width = 70;
                lbl_btn_edit_period.TextAlign = ContentAlignment.MiddleCenter;
                //删除学习计划信息标签
                var lbl_btn_delete = new Label { Text = "" };
                lbl_btn_delete.Width = 50;
                lbl_btn_delete.TextAlign = ContentAlignment.MiddleCenter;

                mp_flp_PlanInfo.Controls.Add(lbl_plan_name);               
                mp_flp_PlanInfo.Controls.Add(lbl_introducation);
                mp_flp_PlanInfo.Controls.Add(lbl_created);                
                mp_flp_PlanInfo.Controls.Add(lbl_creater);
                mp_flp_PlanInfo.Controls.Add(lbl_create_time);
                mp_flp_PlanInfo.Controls.Add(lbl_btn_emp_type);
                mp_flp_PlanInfo.Controls.Add(lbl_btn_edit);
                mp_flp_PlanInfo.Controls.Add(lbl_btn_edit_period);
                mp_flp_PlanInfo.Controls.Add(lbl_btn_delete);
                mp_flp_PlanInfo.SetFlowBreak(lbl_btn_delete, true);
                for (int i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //计划名
                    var plan_name = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    plan_name.Font = font;
                    plan_name.Width = 120;
                    plan_name.Name = ds.Tables["user"].Rows[i][6].ToString();
                    plan_name.TextAlign = ContentAlignment.MiddleCenter;
                    //plan_name.Click += new EventHandler(btn_OK_Click);
                    //计划简介
                    var introducation = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    introducation.Font = font;
                    introducation.Width = 80;
                    introducation.TextAlign = ContentAlignment.MiddleCenter;
                    //创建部门
                    var created = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    created.Font = font;
                    created.Width = 60;
                    created.TextAlign = ContentAlignment.MiddleCenter;
                    //针对部门
                    var creater = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    creater.Font = font;
                    creater.Width = 60;
                    creater.TextAlign = ContentAlignment.MiddleCenter;
                    //针对员工类型
                    var create_time = new Label { Text = ds.Tables["user"].Rows[i][4].ToString() };
                    create_time.Font = font;
                    create_time.Width = 80;
                    create_time.TextAlign = ContentAlignment.MiddleCenter;
                    //针对员工岗位
                    var emp_type = new Label { Text = ds.Tables["user"].Rows[i][5].ToString() };
                    emp_type.Font = font;
                    emp_type.Width = 100;
                    emp_type.TextAlign = ContentAlignment.MiddleCenter;
                    //编辑计划信息
                    var btn_check = new Button { Text = "编辑" };
                    btn_check.Width = 50;
                    btn_check.TextAlign = ContentAlignment.MiddleCenter;
                    btn_check.Name = ds.Tables["user"].Rows[i][6].ToString();
                    btn_check.Click += new EventHandler(editPlanInfo);
                    //编辑计划阶段信息
                    var btn_edit_period = new Button { Text = "阶段详情" };
                    btn_edit_period.Width = 70;
                    btn_edit_period.TextAlign = ContentAlignment.MiddleCenter;
                    btn_edit_period.Name = ds.Tables["user"].Rows[i][6].ToString();
                    btn_edit_period.Click += new EventHandler(editPeriodInfo);
                    //删除计划
                    var btn_delete = new Button { Text = "删除" };
                    btn_delete.Width = 50;
                    btn_delete.TextAlign = ContentAlignment.MiddleCenter;
                    btn_delete.Name = ds.Tables["user"].Rows[i][6].ToString();
                    btn_delete.Click += new EventHandler(deletePlan);

                    mp_flp_PlanInfo.Controls.Add(plan_name);                    
                    mp_flp_PlanInfo.Controls.Add(introducation);
                    mp_flp_PlanInfo.Controls.Add(created);                    
                    mp_flp_PlanInfo.Controls.Add(creater);
                    mp_flp_PlanInfo.Controls.Add(create_time);
                    mp_flp_PlanInfo.Controls.Add(emp_type);
                    mp_flp_PlanInfo.Controls.Add(btn_check);
                    mp_flp_PlanInfo.Controls.Add(btn_edit_period);
                    mp_flp_PlanInfo.Controls.Add(btn_delete);
                    mp_flp_PlanInfo.SetFlowBreak(btn_delete, true);
                }
            }
            else
            {
                //查询不到数据时提示无数据
                var lbl_no_data = new Label { Text = "抱歉，当前没有查询到任何数据！" };
                lbl_no_data.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 540;
                lbl_no_data.Height = 150;
                mp_flp_PlanInfo.Controls.Add(lbl_no_data);
            }
        }
        //复选框选中事件（设置只选一个）
        private void btn_OK_Click(object sender, EventArgs e)
        {
            //遍历
            foreach (Control ctl in mp_flp_PlanInfo.Controls)
            {
                if (ctl is CheckBox)
                {
                    if ((ctl as CheckBox).Checked == true)
                    {
                        //处理代码
                        PlanName = ctl.Text;
                        PlanId = ctl.Name;
                    }
                }
            }
            //传递选定的课程
            PlanArrangement.plan_name = PlanName;
            PlanArrangement.plan_id = PlanId;
            //获取上一界面的已选课程窗口
            PlanArrangement planArrangement = (PlanArrangement)Owner;
            planArrangement.PlanShow();
            Owner.Show();
            Dispose();
        }
        //编辑按钮事件处理
        private void editPlanInfo(object sender, EventArgs e)
        {
            mp_btn_addPlan_Click(sender, e);
            Button button = (Button)sender;            
            int.TryParse(button.Name,out sp_head_id);
            DataBaseConnection dc = new DataBaseConnection();
            string sql = "select sp_head_name,sp_head_summary,sp_emp_dpt,sp_emp_type,sp_emp_station from study_plan_header where sp_head_id = "+sp_head_id;
            DataSet ds = dc.ExecuteQuery(sql);
            mp_tBx_Plan_Name.Text = ds.Tables["user"].Rows[0][0].ToString();
            mp_tBx_Head_Summary.Text = ds.Tables["user"].Rows[0][1].ToString();
            mp_tbx_Emp_dpt.SelectedIndex = (int)ds.Tables["user"].Rows[0][2];
            mp_tbx_Emp_type.SelectedIndex = (int)ds.Tables["user"].Rows[0][3];
            mp_tbx_Emp_station.SelectedIndex = (int)ds.Tables["user"].Rows[0][4];
        }
        //编辑阶段信息按钮事件处理
        private void editPeriodInfo(object sender, EventArgs e)
        {
            //打开计划阶段信息界面EditPeriod，隐藏本界面
            Button button = (Button)sender;
            int.TryParse(button.Name,out EditPeriod.sp_head_id);
            EditPeriod editperiod = new EditPeriod();
            editperiod.Owner = this;
            Hide();
            editperiod.Show();            
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
                    mp_btn_reset_Click_1(sender, e);
                }
                else
                {
                    MessageBox.Show("系统错误！");
                }
                sp_head_id = -1;//执行完操作之后需要将sp_head_id置为-1
            }
        }
        //返回按钮事件处理
        private void mp_btn_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Dispose();
            //classes = null;
        }
        //新增计划按钮事件处理
        private void mp_btn_addPlan_Click(object sender, EventArgs e)
        {
            mp_flp_PlanInfo.Height = 145;
            showOrHide(true);
        }

        private void mp_btn_reset_Click_1(object sender, EventArgs e)
        {
            mp_flp_PlanInfo.Height = 300;
            showOrHide(false);
            mp_tBx_findkeywords.Text = null;
            ManagePlan_Load(sender, e);
        }
        private void mp_btn_confirm_Click(object sender, EventArgs e)
        {
            //修改之前还需询问是否执行修改操作
            string plan_name = mp_tBx_Plan_Name.Text;
            string head_summary = mp_tBx_Head_Summary.Text;
            int emp_dpt = mp_tbx_Emp_dpt.SelectedIndex;
            int emp_type = mp_tbx_Emp_type.SelectedIndex;
            int emp_station = mp_tbx_Emp_station.SelectedIndex;
            DataBaseConnection dc = new DataBaseConnection();
            if (sp_head_id == -1)
            {
                string insert_sql = "insert into study_plan_header values(next value for study_plan_header_s,'" + plan_name + "','" + head_summary + "','" + Model.User.groupId + "',convert(char(10),GetDate(),120),"+ emp_dpt + "," + emp_type + ","+emp_station+","+ sps_id + ")";
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
                    string update_sql = "update study_plan_header set sp_head_name = '" + plan_name + "',sp_head_summary = '" + head_summary + "',sp_emp_dpt = "+emp_dpt+",sp_emp_type = " + emp_type + ",sp_emp_station = "+emp_station+" where sp_head_id =" + sp_head_id+" and sps_id = "+ sps_id;
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
            sp_head_id = -1;
            mp_btn_reset_Click_1(sender, e);            
        }
    }
}
