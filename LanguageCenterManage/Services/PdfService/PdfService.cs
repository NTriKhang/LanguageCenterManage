using iTextSharp.text.pdf;
using iTextSharp.text;
using LanguageCenterManage.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LanguageCenterManage.Services.PdfService
{
    public class PdfService
    {
        public int ExportIDC(Human human, string title)
        {
			try
			{
                FolderBrowserDialog fileDialog = new FolderBrowserDialog();
                
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = fileDialog.SelectedPath;
                    System.IO.FileStream fs = new FileStream(filePath + "\\" + human.Id + ".pdf", FileMode.Create);
                    Document document = new Document(PageSize.A6, 25, 25, 30, 30);

                    PdfWriter writer = PdfWriter.GetInstance(document, fs);
                    document.Open();

                    PdfContentByte cb = writer.DirectContent;
                    cb.BeginText();
                    BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_BOLDITALIC, BaseFont.CP1252, false);
                    Font font = new Font(bfTimes, 12, iTextSharp.text.Font.ITALIC, BaseColor.BLUE);
                    cb.SetFontAndSize(font.GetCalculatedBaseFont(false), 20);

                    cb.SetTextMatrix(PageSize.A6.Width / 4, PageSize.A6.Height - (PageSize.A6.Height / 10)); // Left, Top
                    cb.SetColorFill(BaseColor.BLUE);
                    cb.ShowText("Trung tam ProVip");

                    if (human.ImagePath == null)
                        return 400;

                    var resourePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "Resources", "ProfileImage");

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Path.Combine(resourePath, human.ImagePath));
                    img.ScaleAbsolute(200, 150);
                    img.SetAbsolutePosition(PageSize.A6.Width / (float)6.1, PageSize.A6.Height / 2);


                    cb.AddImage(img);

                    bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    font = new Font(bfTimes, 12, iTextSharp.text.Font.ITALIC, BaseColor.BLUE);
                    cb.SetFontAndSize(font.GetCalculatedBaseFont(false), 16);

                    string mahv = human.Id;
                    string hoten = human.FirstName + ' ' + human.LastName;
                    DateTime dateTime = human.Birth;

                    cb.SetTextMatrix(PageSize.A6.Width / 6, PageSize.A6.Height / 3 + 25);
                    cb.SetColorFill(BaseColor.BLACK);
                    cb.ShowText("Id: " + mahv);

                    cb.SetTextMatrix(PageSize.A6.Width / 6, PageSize.A6.Height / 3);
                    cb.ShowText("Full name: " + hoten);

                    cb.SetTextMatrix(PageSize.A6.Width / 6, PageSize.A6.Height / 3 - 25);
                    cb.ShowText("Birth: " + dateTime.Date.ToString("dd/MM/yyyy"));

                    cb.SetTextMatrix(PageSize.A6.Width / 6, PageSize.A6.Height / 3 - 50);
                    cb.ShowText("Title: " + title);

                    cb.EndText();


                    document.Close();

                    writer.Close();

                    fs.Close();
                    return 200;

                }
                return 201;
            }
			catch (Exception)
			{
                return 500;
			}
        }
    }
}
