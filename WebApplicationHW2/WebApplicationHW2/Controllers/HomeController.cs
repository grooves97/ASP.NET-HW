using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationHW2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(string name, string email, string subject, string comments)
        {
            SmtpClient _smtp = new SmtpClient("smtp.yandex.ru", 25);
            _smtp.Credentials = new NetworkCredential("nurseitov.aslan@yandex.kz", "avadakedavrawws");
            _smtp.EnableSsl = true;
            MailMessage _mail = new MailMessage();
            _mail.From = new MailAddress("nurseitov.aslan@yandex.kz");
            _mail.To.Add(new MailAddress(email,name));
            _mail.SubjectEncoding = Encoding.UTF8;
            _mail.BodyEncoding = Encoding.UTF8;
            _mail.Subject = subject;
            _mail.Body = comments;
            _smtp.Send(_mail);

            return Redirect("index");
        }
    }
}