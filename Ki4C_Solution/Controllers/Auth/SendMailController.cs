using Microsoft.AspNetCore.Mvc;

namespace Ki4C_Solution.Controllers.Auth
{
    public class SendMailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        //naver SMTP Send Method
        public string NaverSendMail()
        {
            try
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                //발신자
                mail.From = new System.Net.Mail.MailAddress("발신자명" + "<" + "발신자이메일주소" + ">");

                //수신자
                mail.To.Add("수신자이메일주소");

                //제목
                mail.Subject = "발신Subject";

                //내용
                string bodyTag = @"
                  <head>
                    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css"" integrity=""sha384-UjKWGO0VxUiZxdyYjrvZgWkTIFhcTTwzHdVjK9sCe3l3xHfzqvFUKMtS8dZqzLjM"" crossorigin=""anonymous"">
                  </head>
                  <body>
                    <div class=""container"">
                      <p class=""h4"">Dear User,</p>
                      <p>Your temporary password is: <strong>TEMPORARY_PASSWORD</strong></p>
                      <p>Please use this password to log in and reset your password to a permanent one.</p>
                      <p>Best regards,</p>
                      <p>The Support Team</p>
                    </div>
                  </body>
                 ";
                mail.Body = bodyTag;
                mail.IsBodyHtml = true;
                mail.Priority = System.Net.Mail.MailPriority.High;

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.naver.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                //네이버 메일 계정
                smtp.Credentials = new System.Net.NetworkCredential("발신자이메일주소", "패스워드");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return "메일 전송 완료";

            }
            catch (Exception ex)
            {
                return "메일 전송 실패";
            }
        }

        //naver SMTP Send Method
        public string NaverSendMail(string to, string subject, string body)
        {
            try
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.To.Add(to);
                mail.From = new System.Net.Mail.MailAddress("임윤식" + "<" + "lsun000@naver.com" + ">");
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                mail.Priority = System.Net.Mail.MailPriority.High;

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.naver.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(" ", " ");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return "메일 전송 완료";

            }
            catch (Exception ex)
            {
                return "메일 전송 실패";
            }
        }

    }
}
