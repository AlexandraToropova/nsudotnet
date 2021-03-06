using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Toropova.Nsudotnet.Rss2Email
{
	public class SMTPUtils
	{
		public static void Send(string server, string to, string from, string password, string subject, string body)
		{
			using (MailMessage message = new MailMessage(from, to)) {
				message.Subject = subject;
				message.Body = body;
				using (SmtpClient client = new SmtpClient()) {
					client.Host = server;
					client.Credentials = new System.Net.NetworkCredential (from, password);
					client.EnableSsl = true;
					client.Send (message);
				}
			}

		}
		public SMTPUtils ()
		{
		}
	}
}

