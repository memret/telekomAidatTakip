using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telekomAidatTakip
{
    class Yazdir
    {
        public PrintDocument printDoc = new PrintDocument();
        public PageSetupDialog pageSet = new PageSetupDialog();
        public PrintPreviewDialog printPre = new PrintPreviewDialog();
        public ListView.ListViewItemCollection items;
        public Yazdir(ListView.ListViewItemCollection items)
        {
            this.items = items;
            pageSet.Document = printDoc;
            printPre.Document = printDoc;
            printDoc.PrintPage += new PrintPageEventHandler(OnPrintDocument);
        }
        public void OnPrintDocument(object sender, PrintPageEventArgs e)
        {

            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //Bu kısımda başlık yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawLine(myPen, 120, 120, 750, 120);
            e.Graphics.DrawLine(myPen, 120, 180, 750, 180);
            e.Graphics.DrawString("XXX Listesi", myFont, sbrush, 200, 120);

            e.Graphics.DrawLine(myPen, 120, 320, 750, 320);

            myFont = new Font("Calibri", 12, FontStyle.Bold);
            e.Graphics.DrawString("Adet", myFont, sbrush, 140, 328);
            e.Graphics.DrawString("Ürün Adı", myFont, sbrush, 240, 328);
            e.Graphics.DrawString("Birim Fiyatı", myFont, sbrush, 440, 328);
            e.Graphics.DrawString("Fiyat", myFont, sbrush, 640, 328);

            e.Graphics.DrawLine(myPen, 120, 348, 750, 348);

            int y = 360;

            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Far;

            //decimal gTotal = 0;

            foreach (ListViewItem lvi in items)
            {
                e.Graphics.DrawString(lvi.SubItems[1].Text, myFont, sbrush, 160, y, myStringFormat);
                e.Graphics.DrawString(lvi.Text, myFont, sbrush, 220, y);
                /*
                decimal bFiyat = Convert.ToDecimal(lvi.SubItems[2].Text);
                decimal fiyat = Convert.ToDecimal(lvi.SubItems[1].Text) * Convert.ToDecimal(lvi.SubItems[2].Text);
                gTotal += fiyat;
                e.Graphics.DrawString(bFiyat.ToString("c"), myFont, sbrush, 530, y, myStringFormat);
                e.Graphics.DrawString(fiyat.ToString("c"), myFont, sbrush, 700, y, myStringFormat);
                */
                y += 20;

            }

            e.Graphics.DrawLine(myPen, 120, y, 750, y);
            //e.Graphics.DrawString(gTotal.ToString("c"), myFont, sbrush, 700, y + 10, myStringFormat);
        }
    }

}

