using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using BLL;

namespace Web
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSendMail_Click(object sender, EventArgs e)
        {
            Text sm = new Text();
            try
            {
                bool flag = sm.Sendmail(txtEmailAddress.Text.Trim(), "244706194@qq.com", "邮件正文", "邮件标题", "your_password");
                if (flag)
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "", "<mce:script type='text/javascript'><!--alert(/ '邮件发送成功！/');// --></mce:script>");
                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "", "<mce:script type='text/javascript'><!--alert(/ '邮件发送失败！/');// --></mce:script>");
                }
            }
            catch (Exception ee)
            {
                Response.Write(ee.Message);
            }
        }
    }
}