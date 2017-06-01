using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
//using ICSharpCode;
using System.Windows.Forms;
using System.IO;
using Font = iTextSharp.text.Font;
using System.Drawing;

namespace AIS_DIBLOM
{
    class ToPDF
    {
        public void MakePdf(string name, string report)
        {
            try
            {
                name = name + ".pdf";
                string head1Text = "Отчет составлен в программе АИС Аналитик";
                BaseFont headLineFont = BaseFont.CreateFont("Arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                Font headLineFormat = new Font(headLineFont, 16);

                BaseFont paraFont = BaseFont.CreateFont("Calibri.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                Font paraFormat = new Font(paraFont, 12);
                Font paraBoldFormat = new Font(paraFont, 12, Font.BOLD);

                var doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(name, FileMode.Create));
                doc.Open();
                doc.Open();

                var para = new Paragraph(head1Text, headLineFormat);
                para.Alignment = Element.ALIGN_CENTER;
                doc.Add(para);

                doc.Add(new Paragraph(" ", paraFormat));

                para = new Paragraph(report, paraFormat);
                para.Alignment = Element.ALIGN_LEFT;
                doc.Add(para);

                doc.Add(new Paragraph(" ", paraFormat));
                doc.Add(new Paragraph(" ", paraFormat));

                doc.Add(new Paragraph("Отчет составлен", paraFormat));
                para = new Paragraph(Convert.ToString(DateTime.Now));
                para.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(para);

                var jpg = iTextSharp.text.Image.GetInstance(@"\itech-logo.png");
                jpg.SetAbsolutePosition(180, 180);
                jpg.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(jpg);

                doc.Close();
                MessageBox.Show("Сохранение успешно выполнено!");
            }
            catch { MessageBox.Show("Ошибка при сохранении"); }
        }
    }
}

