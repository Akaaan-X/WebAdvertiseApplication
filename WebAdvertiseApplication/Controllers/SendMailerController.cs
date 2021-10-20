using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
namespace SendMailwithAttachment.Controllers
{
    public class SendMailerController : Controller
    {
        //  
        // GET: /SendMailer/  
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>  
        /// Send Mail with Gmail  
        /// </summary>  
        /// <param name="objModelMail">MailModel Object, keeps all properties</param>  
        /// <param name="fileUploader">Selected file data, example-filename,content,content type(file type- .txt,.png etc.),length etc.</param>  
        /// <returns></returns>  
        [HttpPost]
        public ActionResult Index(WebAdvertiseApplication.Models.MailModel objModelMail, HttpPostedFileBase fileUploader)
        {
            if (ModelState.IsValid)
            {
                string from = "lingxi9531@gmail.com"; //example:- sourabh9303@gmail.com  
                using (MailMessage mail = new MailMessage(from, objModelMail.To))
                {
                    mail.Subject = objModelMail.Subject;
                    mail.Body = objModelMail.Body;
                    if (fileUploader != null)
                    {
                        string fileName = Path.GetFileName(fileUploader.FileName);
                        mail.Attachments.Add(new Attachment(fileUploader.InputStream, fileName));
                    }
                    mail.IsBodyHtml = false;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential networkCredential = new NetworkCredential(from, "jlsidvqzqzaimrya");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = networkCredential;
                    smtp.Port = 587;
                    smtp.Send(mail);
                    ViewBag.Message = "Sent";
                    return View("Index", objModelMail);
                }
            }
            else
            {
                return View();
            }
        }
    }
}