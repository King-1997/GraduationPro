using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class EmailSend
    {
        private static List<String> str = new List<String>();
        public void Read()//从txt文件中读取发件人邮箱地址和授权码,格式为第一行邮箱地址，第二行为授权码
        {
            StreamReader sr = new StreamReader("C:\\MailAddress.txt", Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line.ToString());
                str.Add(line.ToString());
            }
        }
        public void Sendemail(string type,string name,string mailaddress)
        {
            Read();
            //发送
            SmtpClient client = new SmtpClient("smtp.qq.com");   //设置邮件协议
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;//这一句得写前面
            client.DeliveryMethod = SmtpDeliveryMethod.Network; //通过网络发送到Smtp服务器
            //client.Credentials = new NetworkCredential("1597595060@qq.com", "nnikfgqtbbdkhcfj"); //邮箱  和 授权码
            ////使用txt文件来读取发件人邮箱和授权码
            client.Credentials = new NetworkCredential(str[0], str[1]); //qq邮箱  和 授权码
            /*str[0]/*使用txt文件操作时*/
            MailMessage mmsg = new MailMessage(new MailAddress(str[0]), new MailAddress(mailaddress)); //发件人和收件人的邮箱地址
            //MailMessage mmsg = new MailMessage(new MailAddress("1597595060@qq.com"), new MailAddress(mailaddress)); //发件人和收件人的邮箱地址
            mmsg.Subject = name + "向您发送了一条请假申请，请及时处理！";      //邮件主题
            mmsg.Subject = name+"向您发送了一条请假申请，请及时处理！";      //邮件主题
            mmsg.SubjectEncoding = Encoding.UTF8;   //主题编码
            mmsg.Body = name + "向您发送了一条请假申请，请假事由为：" + type + "申请，请您进入签批系统个人中心进行处理。";         //邮件正文
            mmsg.BodyEncoding = Encoding.UTF8;      //正文编码
            mmsg.IsBodyHtml = true;    //设置为HTML格式          
            mmsg.Priority = MailPriority.High;   //优先级         
            try
            {
                client.Send(mmsg);
                MessageBox.Show("邮件已发送成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void sendFeedBackEmail(string name,string mailaddress)
        {
            Read();
            //发送
            SmtpClient client = new SmtpClient("smtp.qq.com");   //设置邮件协议
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;//这一句得写前面
            client.DeliveryMethod = SmtpDeliveryMethod.Network; //通过网络发送到Smtp服务器
            client.Credentials = new NetworkCredential("1597595060@qq.com", "xtpobxhzhyglgecb"); //qq邮箱  和 授权码
            ////使用txt文件来读取发件人邮箱和授权码
            client.Credentials = new NetworkCredential(str[0], str[1]); //qq邮箱  和 授权码
            MailMessage mmsg = new MailMessage(new MailAddress(str[0]), new MailAddress(mailaddress)); //发件人和收件人的邮箱地址
            /*str[0]/*使用txt文件操作时*/
            //MailMessage mmsg = new MailMessage(new MailAddress("1597595060@qq.com"), new MailAddress(mailaddress)); //发件人和收件人的邮箱地址
            mmsg.Subject = name + "向您发送了一条反馈";      //邮件主题
            mmsg.SubjectEncoding = Encoding.UTF8;   //主题编码
            mmsg.Body = name + "向您发送了一条反馈，您所提交的申请已经处理完成，请您进入签批系统个人中心进行处理。";         //邮件正文
            mmsg.BodyEncoding = Encoding.UTF8;      //正文编码
            mmsg.IsBodyHtml = true;    //设置为HTML格式          
            mmsg.Priority = MailPriority.High;   //优先级         
            try
            {
                client.Send(mmsg);
                MessageBox.Show("邮件已发成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void sendNoticeEmail(string c_name,string mailaddress)
        {
            Read();
            //发送
            SmtpClient client = new SmtpClient("smtp.qq.com");   //设置邮件协议
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;//这一句得写前面
            client.DeliveryMethod = SmtpDeliveryMethod.Network; //通过网络发送到Smtp服务器
            client.Credentials = new NetworkCredential("1597595060@qq.com", "xtpobxhzhyglgecb"); //qq邮箱  和 授权码
            ////使用txt文件来读取发件人邮箱和授权码
            client.Credentials = new NetworkCredential(str[0], str[1]); //qq邮箱  和 授权码
            MailMessage mmsg = new MailMessage(new MailAddress(str[0]), new MailAddress(mailaddress)); //发件人和收件人的邮箱地址
            /*str[0]/*使用txt文件操作时*/
            //MailMessage mmsg = new MailMessage(new MailAddress("1597595060@qq.com"), new MailAddress(mailaddress)); //发件人和收件人的邮箱地址
            mmsg.Subject = "您收到一条学习提醒";      //邮件主题
            mmsg.SubjectEncoding = Encoding.UTF8;   //主题编码
            mmsg.Body = "您的所学课程："+c_name +" 进度较慢，请尽快学习！";         //邮件正文
            mmsg.BodyEncoding = Encoding.UTF8;      //正文编码
            mmsg.IsBodyHtml = true;    //设置为HTML格式          
            mmsg.Priority = MailPriority.High;   //优先级         
            try
            {
                client.Send(mmsg);
                MessageBox.Show("邮件已发成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

