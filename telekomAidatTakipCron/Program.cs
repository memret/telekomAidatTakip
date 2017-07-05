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
        public static string connectstring = "Data Source=207.154.210.112;Database=telekomAidat;User=telekom; Password ='telekom';";

        static void Main(string[] args)
        {
            List<string> mailListesi = new List<string>();
            mailListesi = dogumGunuTarihKontrol();
            //string[] mailListesi = {"m.emret94@gmail.com", "omertanis123@gmail.com" };
            MailTopluGonder(mailListesi, "doğum günü", "doğum günün kutlu olsun reis");
        }

        static void MailTopluGonder(List<string> mailListesi, string baslik, string icerik)
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

        static private List<string> dogumGunuTarihKontrol()
        {
            List<string> liste = new List<string>();

            Database db = new Database();
            var data = db.DataOku("SELECT a.sicilNo,email FROM nufusBilgileri nb,Adres a WHERE dogumTarihi LIKE '%" + DateTime.Now.ToString("MM-dd") + "%' AND a.sicilNo = nb.sicilNo");

            while (data.Read())
            {
                liste.Add(data["email"].ToString());
                //MessageBox.Show(i + 1 + " inci " + data["dogumTarihi"].ToString());

            }
            return liste;
        }
    }
    
        
    }