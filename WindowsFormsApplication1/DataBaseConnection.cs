using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{

    class DataBaseConnection
    {
        public DataBaseConnection()
        {
            Read();
            //本地数据库连接语句
            MySqlCon= "Data Source = " + str[0] + ";Initial Catalog = " + str[1] + ";Integrated Security = TRUE";
            ////服务器数据库连接语句
            //MySqlCon = "Data Source=" + str[0] + ";Initial Catalog = " + str[1] + ";User ID = " + str[2] + ";Pwd =" + str[3] + "";
        }
        private static List<String> str = new List<String>();

        public void Read()//从txt文件中读取服务器的基本信息并赋值给str，服务器数据库txt文件的格式为第一行服务器名，第二行数据库名，第三行用户名，第四行密码；本地数据库txt文件格式为第一行服务器名，第二行数据库名
        {            
            StreamReader sr = new StreamReader("C:\\Connect.txt", Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                    //Console.WriteLine(line.ToString());
                    str.Add(line.ToString());              
            }        
        }        
        private string MySqlCon=null;
        public DataSet ExecuteQuery(string sqlStr)      //用于查询；
        {
            SqlConnection con = new SqlConnection(MySqlCon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr;
            DataSet ds = new DataSet();
            SqlDataAdapter msda;
            msda = new SqlDataAdapter(cmd);
            msda.Fill(ds,"user");
            con.Close();
            return ds;
        }
        public int ExecuteUpdate(string sqlStr)      //用于增删改；
        {
            int iud = 0;
            try
            {
                SqlConnection con = new SqlConnection(MySqlCon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;
                iud = cmd.ExecuteNonQuery();
                con.Close();                
            }
            catch (Exception ex)
            {
                Console.WriteLine("错误信息："+ ex);
            }
            return iud;
        }
    }
}
