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
        public static List<string> classes = null;
        public ManagePlan()
        {
            InitializeComponent();
        }
        private void CreatePlan_Load(object sender, EventArgs e)
        {

        }
        private void cp_btn_find_Click(object sender, EventArgs e)
        {

        }
        private void showClassesInfo(string sql)
        {
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            //在窗口添加课程信息
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //计划名称标签
                var lbl_rb = new Label { Text = "计划名称" };
                lbl_rb.Font = font;
                lbl_rb.Width = 100;
                lbl_rb.TextAlign = ContentAlignment.MiddleCenter;
                //计划简介标签
                var lbl_introducation = new Label { Text = "计划简介" };
                lbl_introducation.Font = font;
                lbl_introducation.Width = 100;
                lbl_introducation.TextAlign = ContentAlignment.MiddleCenter;
                //创建人标签
                var lbl_Loadman = new Label { Text = "创建人" };
                lbl_Loadman.Font = font;
                lbl_Loadman.Width = 50;
                lbl_Loadman.TextAlign = ContentAlignment.MiddleCenter;
                //创建日期标签
                var lbl_createTime = new Label { Text = "创建日期" };
                lbl_createTime.Font = font;
                lbl_createTime.Width = 65;
                lbl_createTime.TextAlign = ContentAlignment.MiddleCenter;
                
                //查看计划信息标签
                var lbl_btn_check = new Label { Text = "" };
                lbl_btn_check.Width = 50;
                lbl_btn_check.TextAlign = ContentAlignment.MiddleCenter;

                cp_flpClasses.Controls.Add(lbl_rb);
                cp_flpClasses.Controls.Add(lbl_Loadman);
                cp_flpClasses.Controls.Add(lbl_introducation);
                cp_flpClasses.Controls.Add(lbl_createTime);
                cp_flpClasses.Controls.Add(lbl_btn_check);
                cp_flpClasses.SetFlowBreak(lbl_btn_check, true);
                for (var count = 0; count < ds.Tables["user"].Rows.Count; count++)
                {
                    //课程名
                    var rb = new CheckBox { Text = ds.Tables["user"].Rows[count][0].ToString() };
                    rb.Font = font;
                    rb.Width = 100;
                    rb.Name = ds.Tables["user"].Rows[count][4].ToString();
                    rb.TextAlign = ContentAlignment.MiddleCenter;
                    //rb.Click += new EventHandler(btn_oK_Click);
                    //将课程信息传入ClassesInfo模型中
                    int.TryParse(ds.Tables["user"].Rows[count][6].ToString(), out Model.ClassesInfo.class_id);
                    int.TryParse(ds.Tables["user"].Rows[count][4].ToString(), out Model.ClassesInfo.class_time);
                    Model.ClassesInfo.class_name = ds.Tables["user"].Rows[count][0].ToString();
                    //上传人
                    var Loadman = new Label { Text = ds.Tables["user"].Rows[count][1].ToString() };
                    Loadman.Font = font;
                    Loadman.Width = 50;
                    Loadman.TextAlign = ContentAlignment.MiddleCenter;
                    //课程简介
                    var introducation = new Label { Text = ds.Tables["user"].Rows[count][2].ToString() };
                    introducation.Font = font;
                    introducation.Width = 100;
                    introducation.TextAlign = ContentAlignment.MiddleCenter;
                    //课程学分
                    var credit = new Label { Text = ds.Tables["user"].Rows[count][3].ToString() };
                    credit.Font = font;
                    credit.Width = 65;
                    credit.TextAlign = ContentAlignment.MiddleCenter;
                    //课程学时
                    var recommendTime = new Label { Text = ds.Tables["user"].Rows[count][4].ToString() };
                    recommendTime.Font = font;
                    recommendTime.Width = 65;
                    recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                    //是否考试
                    var ifExam = new Label { Text = ds.Tables["user"].Rows[count][5].ToString() };
                    ifExam.Font = font;
                    ifExam.Width = 65;
                    ifExam.TextAlign = ContentAlignment.MiddleCenter;
                    //查看课程信息
                    var btn_check = new Button { Text = "查看" };
                    btn_check.Width = 50;
                    ifExam.TextAlign = ContentAlignment.MiddleCenter;
                    btn_check.Name = ds.Tables["user"].Rows[count][6].ToString();
                    //Console.WriteLine("button中的c_name："+ btn_check.Name);
                    //btn_check.Click += new EventHandler(CheckClassesInfo);

                    cp_flpClasses.Controls.Add(rb);
                    cp_flpClasses.Controls.Add(Loadman);
                    cp_flpClasses.Controls.Add(introducation);
                    cp_flpClasses.Controls.Add(credit);
                    cp_flpClasses.Controls.Add(recommendTime);
                    cp_flpClasses.Controls.Add(ifExam);
                    cp_flpClasses.Controls.Add(btn_check);
                    cp_flpClasses.SetFlowBreak(btn_check, true);
                }
            }
            else
            {
                MessageBox.Show("抱歉，查询不到相关课程！");
            }
        }

        private void cp_btn_reset_Click(object sender, EventArgs e)
        {
            this.cp_tBx_findkeywords.Text = null;
            CreatePlan_Load(sender,e);
        }

        private void cp_btn_back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
            classes = null;
        }
    }
}
