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
            string[] mailListesi = {"m.emret94@gmail.com", "omertanis123@gmail.com" };
            MailTopluGonder(mailListesi, "test", "test içerik");
        }

        static void MailTopluGonder(string[] mailListesi, string baslik, string icerik)
        {
            
            SmtpClient mailServer = new SmtpClient(GMAIL_SERVER, PORT);
            mailServer.EnableSsl = true;

            //eMail ve şifre.
            mailServer.Credentials = new System.Net.NetworkCredential("telekomstaj2017@gmail.com", "telekom123");

            string from = "telekomstaj2017@gmail.com";
            //Receiver email

            MailMessage msg;

            //smtp tanımlanacak ayarları yapılacak burada belki veritabanından çekilebilir
            foreach (string mail in mailListesi)
            {
                msg = new MailMessage(from, mail);
                //başlık içerik veritabanından çekilecek.
                MailTekliGonder(mailServer,msg, baslik, icerik);
            }
        }

        static void MailTekliGonder(SmtpClient mailServer, MailMessage msg, string baslik, string icerik)
        {
            try
            {
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