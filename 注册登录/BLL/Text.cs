using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.ComponentModel;

namespace BLL
{
    public class Text
    {
        private MailMessage mailMessage;
        private SmtpClient smtpClient;
        private string password;
        private static bool mailSent = false;

        //获取异步发送状态
        public static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                mailSent = false;
            }
            if (e.Error != null)
            {
                mailSent = false;
            }
            else
            {
                mailSent = true;
            }
        }

        /// <summary>  
        /// 发送邮件
        /// </summary>  
        /// <param name="To">收件人地址，多个地址时以分号隔开</param>  
        /// <param name="From">发件人地址</param>  
        /// <param name="Body">邮件正文</param>  
        /// <param name="Title">邮件主题</param>  
        /// <param name="Password">发件人密码</param> 
        /// <returns>发送是否成功</returns>
        public bool Sendmail(string to, string from, string body, string title, string password)
        {
            string[] mailNames = to.Split(';');
            try
            {
                foreach (string name in mailNames)
                {
                    if (name != string.Empty)
                    {
                        this.password = password;
                        mailMessage = new MailMessage();
                        mailMessage.To.Add(name);
                        mailMessage.From = new System.Net.Mail.MailAddress(from);
                        mailMessage.Subject = title;
                        mailMessage.Body = body;
                        mailMessage.IsBodyHtml = true;
                        mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
                        mailMessage.Priority = System.Net.Mail.MailPriority.Normal;
                        smtpClient = new SmtpClient();
                        smtpClient.Credentials = new System.Net.NetworkCredential(mailMessage.From.Address, password);//设置发件人身份的票据 
                        smtpClient.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);//异步发送完成获取发送状态
                        smtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                        smtpClient.Host = "smtp." + mailMessage.From.Host;//邮件发送服务器
                        smtpClient.SendAsync(mailMessage, "OK");//异步发送邮件
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
