using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telekomAidatTakipCron
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        void MailTopluGonder(string[] mailListesi, string baslik, string icerik)
        {
            object smtp = "";
            //smtp tanımlanacak ayarları yapılacak burada belki veritabanından çekilebilir
            foreach (string mail in mailListesi)
            {
                MailTekliGonder(smtp,mail, baslik, icerik);
            }
        }
        void MailTekliGonder(object smtpZimbirtisi, string mail, string baslik, string icerik)
        {
            //smtp.send gibi birsey ile gönderilecek
        }
    }
}
