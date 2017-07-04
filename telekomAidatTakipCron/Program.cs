using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace telekomAidatTakipCron
{
    class Program
    {
        //Smpt server
        public const string GMAIL_SERVER = "smtp.gmail.com";
        //Connecting port
        public const int PORT = 587;

        static void Main(string[] args)
        {

        }

        void MailTopluGonder(string[] mailListesi, string baslik, string icerik)
        {
            object smtp = "";
            //smtp tanımlanacak ayarları yapılacak burada belki veritabanından çekilebilir
            foreach (string mail in mailListesi)
            {
                //başlık içerik veritabanından çekilecek.
                MailTekliGonder(smtp,mail, baslik, icerik);
            }
        }

        void MailTekliGonder(object smtpZimbirtisi, string aliciMail, string baslik, string icerik)
        {
            try
            {
                SmtpClient mailServer = new SmtpClient(GMAIL_SERVER, PORT);
                mailServer.EnableSsl = true;

                //eMail ve şifre.
                mailServer.Credentials = new System.Net.NetworkCredential("myemail@gmail.com", "mypassword");

                //Senders email.
                string from = "göndericiMail@gmail.com";
                //Receiver email
                string to = aliciMail;

                MailMessage msg = new MailMessage(from, to);

                //mailin başlığı.
                msg.Subject = baslik;

                //mailin içeiği.
                msg.Body = icerik;

                mailServer.Send(msg);
                //form olmadığı için konsola yazdırdım.
                Console.WriteLine("Mail gönderildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mail gönderilemedi hata: " + ex);
            }

        }
        }
    
        //Buda başka çözüm ilki olmazsa bunu deneyecceğim.

        /*
        //smtp.send gibi birsey ile gönderilecek
        SmtpClient client = new SmtpClient();
        client.Port = 587;
        client.Host = "smtp.gmail.com";
        client.EnableSsl = true;
        client.Timeout = 10000;
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        client.UseDefaultCredentials = false;
        client.Credentials = new System.Net.NetworkCredential("user@gmail.com", "password");

        MailMessage mailMessage = new MailMessage( gonderici mail", aliciMail, baslik, icerik);
        mailMessage.BodyEncoding = UTF8Encoding.UTF8;
        mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

        client.Send(mailMessage);
        client.Dispose();*/
        
    }