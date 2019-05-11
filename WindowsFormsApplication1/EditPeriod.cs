using CCWin;
using CCWin.SkinClass;
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
    public partial class EditPeriod : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public static int sp_head_id = -1;
        private int sp_line_id = -1;
        public static string c_id = null;
        public static string lesson_name = null;
        public static string exam_p_id = null;
        public static string exam_name = null;
        public EditPeriod()
        {
            InitializeComponent();
            ep_tBx_Plan_Name.Font = font;
            ep_tBx_Head_Summary.Font = font;
            ep_tBx_Emp_type.Font = font;
            ep_tBx_Period_Name.Font = font;
            ep_dtp_Start_Time.Value = DateTime.Now.Date;
            //显示时间则格式为"yyyy-MM-dd HH:mm:ss"，HH表示24小时制，hh则为12小时制
            ep_dtp_Start_Time.CustomFormat = "yyyy-MM-dd";
            //使用自定义格式
            ep_dtp_Start_Time.Format = DateTimePickerFormat.Custom;
            //时间控件的启用
            //ep_dtp_Start_Time.ShowUpDown = true;
            ep_dtp_End_Time.Value = DateTime.Now.Date;
            //显示时间则格式为"yyyy-MM-dd HH:mm:ss"，HH表示24小时制，hh则为12小时制
            ep_dtp_End_Time.CustomFormat = "yyyy-MM-dd";
            //使用自定义格式
            ep_dtp_End_Time.Format = DateTimePickerFormat.Custom;
            //时间控件的启用
            //ep_dtp_End_Time.ShowUpDown = true;
        }
        private void EditPeriod_Load(object sender, EventArgs e)
        {
            sp_line_id = -1;
            c_id = null;
            exam_p_id = null;
            HideControls();
            string select_head_info = "select sph.sp_head_name,sph.sp_head_summary,g.g_group,ut.ut_type,es.station_name from study_plan_header sph,[group] g,UserType ut,employee_station es where sph.sp_created = g.g_id and sph.sp_emp_type = ut.ut_id and sph.sp_emp_station = es.station_id and sph.sp_head_id = " + sp_head_id;
            showHeaderInfo(select_head_info);
            //根据学习计划界面传head_id过来进行行信息操作
            string select_line_info = "select spl.sp_peroid,c_id,isnull((select c_name from Classes where c_id = spl.c_id),'无') AS c_name,exam_p_id,isnull((select exam_p_name from exam_paper where exam_p_id = spl.exam_p_id),'无') AS exam_p_name,spl.sp_startTime,spl.sp_endTime,spl.sp_line_id from study_plan_lines spl where spl.sp_head_id = " + sp_head_id;
            showLinesInfo(select_line_info);
        }
        public void showClass_Exam_Info()
        {
            ep_lbl_Class_Name.Text = lesson_name;
            ep_lbl_Exam_Name.Text = exam_name;
        } 
        //查询学习计划头信息
        private void showHeaderInfo(string sql)
        {
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            ep_tBx_Plan_Name.Text = ds.Tables["user"].Rows[0][0].ToString();
            ep_tBx_Head_Summary.Text = ds.Tables["user"].Rows[0][1].ToString();
            ep_tBx_Emp_type.Text = ds.Tables["user"].Rows[0][2].ToString() +" "+ ds.Tables["user"].Rows[0][3].ToString() + " " + ds.Tables["user"].Rows[0][4].ToString();
        }
        //查询学习计划行（各个阶段）信息
        private void showLinesInfo(string sql)
        {
            ep_flp_Lines_Info.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);

            //在窗口添加学习计划信息
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //计划名标签
                var lbl_period_name = new Label { Text = "阶段名" };
                lbl_period_name.Font = font;
                lbl_period_name.Width = 120;
                lbl_period_name.TextAlign = ContentAlignment.MiddleCenter;
                //课程名标签
                var lbl_class_name = new Label { Text = "课程名" };
                lbl_class_name.Font = font;
                lbl_class_name.Width = 120;
                lbl_class_name.TextAlign = ContentAlignment.MiddleCenter;
                //试卷名标签
                var lbl_exam_name = new Label { Text = "试卷名" };
                lbl_exam_name.Font = font;
                lbl_exam_name.Width = 120;
                lbl_exam_name.TextAlign = ContentAlignment.MiddleCenter;
                //开始时间标签
                var lbl_start_time = new Label { Text = "开始时间" };
                lbl_start_time.Font = font;
                lbl_start_time.Width = 80;
                lbl_start_time.TextAlign = ContentAlignment.MiddleCenter;
                //截止时间标签
                var lbl_end_time = new Label { Text = "截止时间" };
                lbl_end_time.Width = 100;
                lbl_end_time.Font = font;
                lbl_end_time.TextAlign = ContentAlignment.MiddleCenter;
                //编辑学习阶段信息标签
                var lbl_btn_edit = new Label { Text = "" };
                lbl_btn_edit.Width = 50;
                lbl_btn_edit.TextAlign = ContentAlignment.MiddleCenter;
                //删除学习阶段信息标签
                var lbl_btn_delete = new Label { Text = "" };
                lbl_btn_delete.Width = 50;
                lbl_btn_delete.TextAlign = ContentAlignment.MiddleCenter;
                ep_flp_Lines_Info.Controls.Add(lbl_period_name);
                ep_flp_Lines_Info.Controls.Add(lbl_class_name);
                ep_flp_Lines_Info.Controls.Add(lbl_exam_name);
                ep_flp_Lines_Info.Controls.Add(lbl_start_time);
                ep_flp_Lines_Info.Controls.Add(lbl_end_time);
                ep_flp_Lines_Info.Controls.Add(lbl_btn_edit);
                ep_flp_Lines_Info.Controls.Add(lbl_btn_delete);
                ep_flp_Lines_Info.SetFlowBreak(lbl_btn_delete, true);

                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //阶段名
                    var period_name = new Label { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    period_name.Font = font;
                    period_name.Width = 120;
                    period_name.Name = ds.Tables["user"].Rows[i][0].ToString();
                    period_name.TextAlign = ContentAlignment.MiddleCenter;
                    //课程名
                    var class_name = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    class_name.Font = font;
                    class_name.Width = 120;
                    class_name.TextAlign = ContentAlignment.MiddleCenter;
                    //试卷名
                    var exam_name = new Label { Text = ds.Tables["user"].Rows[i][4].ToString() };
                    exam_name.Font = font;
                    exam_name.Width = 120;
                    exam_name.TextAlign = ContentAlignment.MiddleCenter;
                    //开始时间
                    var start_time = new Label { Text = ds.Tables["user"].Rows[i][5].ToString() };
                    start_time.Font = font;
                    start_time.Width = 80;
                    start_time.TextAlign = ContentAlignment.MiddleCenter;
                    //截止时间
                    var end_time = new Label { Text = ds.Tables["user"].Rows[i][6].ToString() };
                    end_time.Font = font;
                    end_time.Width = 100;
                    end_time.TextAlign = ContentAlignment.MiddleCenter;
                    //编辑阶段信息
                    var btn_check = new Button { Text = "编辑" };
                    btn_check.Width = 50;
                    btn_check.TextAlign = ContentAlignment.MiddleCenter;
                    btn_check.Name = ds.Tables["user"].Rows[i][7].ToString();
                    c_id = ds.Tables["user"].Rows[i][1].ToString();
                    exam_p_id = ds.Tables["user"].Rows[i][3].ToString();
                    btn_check.Click += new EventHandler(editPeriodInfo);
                    //删除阶段
                    var btn_delete = new Button { Text = "删除" };
                    btn_delete.Width = 50;
                    btn_delete.TextAlign = ContentAlignment.MiddleCenter;
                    btn_delete.Name = ds.Tables["user"].Rows[i][7].ToString();
                    btn_delete.Click += new EventHandler(deletePeriod);

                    ep_flp_Lines_Info.Controls.Add(period_name);
                    ep_flp_Lines_Info.Controls.Add(class_name);
                    ep_flp_Lines_Info.Controls.Add(exam_name);
                    ep_flp_Lines_Info.Controls.Add(start_time);
                    ep_flp_Lines_Info.Controls.Add(end_time);
                    ep_flp_Lines_Info.Controls.Add(btn_check);
                    ep_flp_Lines_Info.Controls.Add(btn_delete);
                    ep_flp_Lines_Info.SetFlowBreak(btn_delete, true);
                }
            }
            else
            {
                //无数据时显示提示
                var lbl_no_data = new Label { Text = string.Concat("抱歉，当前没有查询到任何数据！") };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 400;
                lbl_no_data.Height = 150;
                ep_flp_Lines_Info.Controls.Add(lbl_no_data);
            }
        }
        //修改学习计划行信息按钮事件处理
        private void editPeriodInfo(object sender, EventArgs e)
        {
            ShowControls();
            Button button = (Button)sender;
            int.TryParse(button.Name, out sp_line_id);
            DataBaseConnection dc = new DataBaseConnection();
            string sql = "select spl.sp_peroid,isnull((select c_name from Classes where c_id = spl.c_id),'无') AS c_name,isnull((select exam_p_name from exam_paper where exam_p_id = spl.exam_p_id),'无') AS exam_p_name,spl.sp_startTime,spl.sp_endTime,spl.c_id,spl.exam_p_id from study_plan_lines spl where spl.sp_line_id = " + sp_line_id;
            DataSet ds = dc.ExecuteQuery(sql);
            //将阶段信息赋值给控件显示
            ep_tBx_Period_Name.Text = ds.Tables["user"].Rows[0][0].ToString();
            ep_lbl_Class_Name.Text = ds.Tables["user"].Rows[0][1].ToString();
            ep_lbl_Exam_Name.Text = ds.Tables["user"].Rows[0][2].ToString();
            ep_dtp_Start_Time.Text = ds.Tables["user"].Rows[0][3].ToString();
            ep_dtp_End_Time.Text = ds.Tables["user"].Rows[0][4].ToString();
            //将课程id，考试id赋值给全局变量
            c_id = ds.Tables["user"].Rows[0][5].ToString();
            exam_p_id = ds.Tables["user"].Rows[0][6].ToString();
        }
        //删除阶段信息
        private void deletePeriod(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int.TryParse(button.Name, out sp_line_id);
            DataBaseConnection dc = new DataBaseConnection();
            if (MessageBox.Show("您确定要删除该阶段吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
            {
                string delete_lines = "delete from study_plan_lines where sp_line_id = "+ sp_line_id;
                int flag = dc.ExecuteUpdate(delete_lines);
                if (flag == 1)
                {
                    MessageBox.Show("删除阶段信息成功！");                    
                }else
                {
                    MessageBox.Show("删除阶段信息失败，请联系系统管理员！");
                }
                EditPeriod_Load(sender, e);
            }
        }
        //提交修改或插入的行信息
        private void ep_btn_confirm_Click(object sender, EventArgs e)
        {
            string peroid_name = ep_tBx_Period_Name.Text;
            DateTime start_time = Convert.ToDateTime(ep_dtp_Start_Time.Value);
            DateTime end_time = Convert.ToDateTime(ep_dtp_End_Time.Value);
            int class_id = -1,exam_id = -1;
            if (c_id != null)
            {
                int.TryParse(c_id, out class_id);
            }
            if(exam_p_id != null)
            {
                int.TryParse(exam_p_id, out exam_id);
            }
            
            DataBaseConnection dc = new DataBaseConnection();
            if (sp_line_id == -1)
            {
                string insert_sql = "insert into study_plan_lines values(next value for study_plan_lines_s,"+ sp_head_id +","+ class_id + ","+ exam_id + ",'"+ peroid_name + "',convert(varchar(100),'" + start_time + "',23),convert(varchar(100),'" + end_time + "',23))";
                int flag = dc.ExecuteUpdate(insert_sql);
                if (flag == 1)
                {
                    MessageBox.Show("新增阶段信息成功！");                                      
                }
                else
                {
                    MessageBox.Show("新增阶段信息失败，请联系系统管理员！");
                }
            }
            else
            {
                if (MessageBox.Show("您确定要修改该阶段信息吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string update_sql = "update study_plan_lines set c_id = " + class_id + ",exam_p_id = " + exam_id + ",sp_peroid = '" + peroid_name + "',sp_startTime = convert(varchar(100),'" + start_time + "',23),sp_endTime = convert(varchar(100),'" + end_time + "',23) where sp_line_id = "+sp_line_id;
                    int flag = dc.ExecuteUpdate(update_sql);
                    if (flag == 1)
                    {
                        MessageBox.Show("修改阶段信息成功！");                        
                    }
                    else
                    {
                        MessageBox.Show("修改阶段信息失败，请联系管理员！");
                    }
                }                    
            }
            EditPeriod_Load(sender,e);
        }
        private void ep_btn_back_Click(object sender, EventArgs e)
        {
            sp_head_id = -1;
            sp_line_id = -1;
            Owner.Show();
            Dispose();
        }
        //添加新阶段信息，需先将sp_line_id置为-1，不然可能不为-1则会执行update而不是insert
        private void ep_btn_addPeroid_Click(object sender, EventArgs e)
        {
            sp_line_id = -1;
            ShowControls();
        }
        //显示添加阶段的控件
        private void ShowControls()
        {
            ep_flp_Lines_Info.Height = 160;
            ep_lbl_Period_Name.Visible = true;
            ep_tBx_Period_Name.Visible = true;
            ep_tBx_Period_Name.Text = null;
            ep_btn_addClass.Visible = true;
            ep_lbl_Class_Name.Visible = true;
            ep_lbl_Class_Name.Text = null;
            ep_btn_addExam.Visible = true;
            ep_lbl_Exam_Name.Visible = true;
            ep_lbl_Exam_Name.Text = null;
            ep_lbl_Start_Time.Visible = true;
            ep_dtp_Start_Time.Visible = true;
            ep_dtp_Start_Time.Value = DateTime.Now.Date;
            ep_lbl_End_Time.Visible = true;
            ep_dtp_End_Time.Visible = true;
            ep_dtp_End_Time.Value = DateTime.Now.Date;
        }
        //隐藏添加阶段的控件
        private void HideControls()
        {            
            ep_lbl_Period_Name.Visible = false;
            ep_tBx_Period_Name.Visible = false;
            ep_btn_addClass.Visible = false;
            ep_lbl_Class_Name.Visible = false;
            ep_btn_addExam.Visible = false;
            ep_lbl_Exam_Name.Visible = false;
            ep_lbl_Start_Time.Visible = false;
            ep_dtp_Start_Time.Visible = false;
            ep_lbl_End_Time.Visible = false;
            ep_dtp_End_Time.Visible = false;
            ep_flp_Lines_Info.Height = 200;
        }

        private void ep_btn_addClass_Click(object sender, EventArgs e)
        {
            //打开选择课程界面classChoose，隐藏本界面
            ClassChoose classChoose = new ClassChoose();
            classChoose.Owner = this;
            Hide();
            classChoose.Show();           
        }

        private void ep_btn_addExam_Click(object sender, EventArgs e)
        {
            //打开选择试卷界面examChoose，隐藏本界面
            ExamChoose examChoose = new ExamChoose();
            examChoose.Owner = this;
            Hide();
            examChoose.Show();
        }

        private void ep_btn_All_Peroid_Click(object sender, EventArgs e)
        {
            EditPeriod_Load(sender, e);
        }
    }
}
