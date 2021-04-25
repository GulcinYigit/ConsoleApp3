using System;
using System.IO;
using System.Text;
using System.Net;

namespace ConsoleApp3
{
    class Program
    {

        int zaman, tarih;
        string mesaj;

       static void Main(string[] args)
        {

            var save = new SaveFileDialog();
            save = NewMethod(save);
            save.CreatePrompt = true;
            save.InitialDirectory = @"https://www.cnnturk.com/feed/rss/turkiye/news";
            save.ShowDialog();
            save.Title = "XML KAYNAK";
            NewMethod1(save);
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";
            save.ShowDialog();


            Class1 file = new Class1();
            byte[] i = new byte[0];
            StringBuilder Veri = new StringBuilder();
            StringBuilder Veri1 = new StringBuilder();

            HttpWebRequest SiteyeBaglantiTalebi = (HttpWebRequest)HttpWebRequest.Create("https://www.cnnturk.com/feed/rss/turkiye/news");

            try
            {
                Veri.AppendLine(DateTime.Now.ToString());
                Veri.AppendLine("Tarih");
                Veri.AppendLine("Saat");
                Veri.AppendLine("Message");

                file.Write("C:\\", "Veri.txt", Veri1.ToString());


                i[999999] = 1;

            }
            catch (Exception ex)
            {
                Veri1.AppendLine(DateTime.Now.ToString());
                Veri1.AppendLine(ex.Message);
                Veri1.AppendLine(ex.StackTrace);
                file.Write("C:\\", "Veri.txt", Veri1.ToString());

            }
        }

        private static void NewMethod1(SaveFileDialog save)
        {
            NewMethod1(save);
        }

        private static SaveFileDialog NewMethod(SaveFileDialog save)
        {
            save.OverwritePrompt = false;
            return save;
        }
    }
}
