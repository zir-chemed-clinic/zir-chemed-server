using DTO;
using System.Threading.Tasks;
using System.Net.Mail;
using System;
using System.IO;
using System.Net;

namespace BL
{
    public class EmailBL : IEmailBL
    {
        public async Task<bool> sendEmail(Form form)
        {
            byte[] HashBytes = Convert.FromBase64String(form.file);

            // in the beginning of the file
            //MailAddress msgTo = new MailAddress();

            //MailAddress to = new MailAddress("hadasa4640@gmail.com");
            //MailAddress from = new MailAddress("lab@zirchemed.org", "zirchemed laboratery");

            //MailMessage message = new MailMessage(from, msgTo);
            MailMessage message = new MailMessage();
                        message.From = new MailAddress("zirchemed@itech-websolutions.com", "מעבדה ציר חמד");

          //  message.From = new MailAddress("lab@zirchemed.org", "מעבדה ציר חמד");
          //  message.From = new MailAddress("yitz@zirchemed.org", "");

            //    message.From = new MailAddress("zirchemed@itech-websolutions.com", "מעבדה ציר חמד");
            for (int i = 0; i < form.emails.Count; i++)
            {
                message.To.Add(new MailAddress(form.emails[i]));
            }

            if (form.treatments)
            {
                message.Subject = " תוצאות טיפול " + form.familyName;
                message.Body =
           "שלום וברכה<br />" +
           "<br />" +
            "<br />" +
            "הושלם הטיפול אותו ערכתם בציר חמד<br />" +
             "התוצאות מצורפות במיל זה, אותו מסרתם בעת הטיפול. <br />" +
              "<br />" +
                 "<br />" +
              "להצטרפות למשפחת ציר חמד, תמיכה נפשית, קבוצות תמיכה, מרכז חברתי ועוד,  שלחו מייל חוזר ומשהוא יחזור אליכם" +
                "<br />" +
                  "<br />" +
              "בשורות טובות" +
                 "<br />" +
                     "<br />" +
              "צוות ציר חמד<br />"+
               "<br />" +
                     "<br />" +
              "<a href='https://docs.google.com/forms/d/e/1FAIpQLScHbDyX7EnPYWTEyAc8R1vwsPljls5mVVBQGb6yUR8Fu3qucA/viewform?pli=1'>טופס סבסוד</a>";
            }
            else
            {
                message.Subject = " תוצאות בדיקה " + form.familyName;
                message.Body =
           "שלום וברכה<br />" +
           "<br />" +
            "<br />" +
            "הושלמה הבדיקה אותה ערכתם בציר חמד<br />" +
             "התוצאות מצורפות במיל זה, אותו מסרתם בעת הבדיקה. <br />" +
              "<br />" +
                 "<br />" +
              "להצטרפות למשפחת ציר חמד, תמיכה נפשית, קבוצות תמיכה, מרכז חברתי ועוד,  שלחו מייל חוזר ומשהוא יחזור אליכם" +
                "<br />" +
                  "<br />" +
              "בשורות טובות" +
                 "<br />" +
                     "<br />" +
              "צוות ציר חמד<br />"+
                 "<br />" +
                     "<br />" +
                  "<a href='https://docs.google.com/forms/d/e/1FAIpQLScHbDyX7EnPYWTEyAc8R1vwsPljls5mVVBQGb6yUR8Fu3qucA/viewform?pli=1'>טופס סבסוד</a>"; ;
            }
        
           
            message.IsBodyHtml = true;
            //message.Attachments.Add(new Attachment("D:\\Zir\\zirnetCore\\tmp.pdf"));
            DateTime dateAndTime = DateTime.Now;
            string date = dateAndTime.Date.ToString();

            Attachment att = new Attachment(new MemoryStream(HashBytes), date.Split(' ')[0] +" "+ form.familyName+ ".pdf");
            message.Attachments.Add(att);
            //using (var ms = new MemoryStream())
            //{
            //    file.CopyTo(ms);
            //    var fileBytes = HashBytes;
            //    Attachment att = new Attachment(new MemoryStream(HashBytes), "");
            //    message.Attachments.Add(att);
            //}
            //    SmtpClient client = new SmtpClient("smtp.zirchemed.org", 587)
            //  SmtpClient client = new SmtpClient("box5658.bluehost.com", 465)

            //  SmtpClient client = new SmtpClient("mail.zirchemed.org", 587)
            //{
            //    Credentials = new NetworkCredential("lab@zirchemed.org", "Wm^n!4Cj3]3b"),
            //    EnableSsl = false
            //};
            SmtpClient client = new SmtpClient("mail.itech-websolutions.com", 25)
            {
                Credentials = new NetworkCredential("zirchemed@itech-websolutions.com", "V88H1262S8"),
                EnableSsl = false
            };
            //  SmtpClient client = new SmtpClient("smtp.office365.com", 587)

            //SmtpClient client = new SmtpClient("smtp.office365.com", 587)
            //{
            //    Credentials = new NetworkCredential("hisht5@mby.co.il", "Bsd#@!1248"),
            //    EnableSsl = true
            //};
            // code in brackets above needed if authentication required

            try
            {

                client.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}