using System.Configuration;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Configuration;
using System.ComponentModel;

namespace MySchoolSolution
{
    /// <summary>
    /// Summary description for Connection
    /// </summary>
    public class CommonFunctions
    {
        public static string UserName { get; set; }
        public static string AdminEmailAddress = "info@aarshapublicschool.com";
        public static string ccEmailAddress = "vatssusheel@gmail.com";
        public CommonFunctions()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        public static void SendSMS(string mobile, string message)
        {
            try
            {


                WebClient webClient = new WebClient();
                string baseURL = "https://platform.clickatell.com/messages/http/send?apiKey=gG8EJQz8SOGfguUQtj4vKA==&to=919953624768&content=" + message + "";
                webClient.OpenRead(baseURL);
            }
            catch
            {
                CommonFunctions.ShowError("SMS could not be send!");
            }
        }

        public static string SendEmail(string _ToEmail, string _Subject, string _Body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(AdminEmailAddress);
                mail.IsBodyHtml = true;
                mail.To.Add(_ToEmail);
                mail.CC.Add(new MailAddress(ccEmailAddress));
                //mail.Bcc.Add(new MailAddress(BccEmailAddress));

                mail.Subject = _Subject;
                mail.Body = _Body;
                SmtpClient client = new SmtpClient();
                client.Host = "mail.aarshapublicschool.com";
                client.Credentials = new NetworkCredential("info@aarshapublicschool.com", "abc123@#");
                client.Port = 25;
                client.Send(mail);
                //client.EnableSsl = true;
                //client.SendAsync(mail,"chk");
                //client.SendCompleted += new SendCompletedEventHandler(smtp_SendCompleted);
                //client.Timeout = 100;

                //client.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static string[] GetClasses
        {
            get
            {
                string _iSTR = System.Convert.ToString(ConfigurationManager.AppSettings["Classes"]);
                string[] Classes = _iSTR.Split(',');

                return Classes;
            }
        }

        public static string GetCurrentSession
        {
            get
            {
                string session = string.Empty;
                int currentYear = DateTime.Now.Year;
                int ndYear = 0;
                int currentMonth = DateTime.Now.Month;
                if (currentMonth < 4)
                {
                    session = (currentYear - 1) + "-" + currentYear;

                }
                else
                {
                    session = currentYear + "-" + (currentYear + 1);

                }
                return session;
            }
        }

        public static string Connections
        {
            get
            {
                return System.Convert.ToString(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            }
        }
        public static class LoginInfo
        {
            public static string UserID;

        }

    }
}