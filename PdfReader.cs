using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace ConsoleApp1
{
    class PdfReader
    {
        public static string ExtractTextFromPdf(string path)
        {
            using (PdfReader reader = new PdfReader(path))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }

                return text.ToString();
            }
        }
        static void Main(string[] args)
        {
            var ExtractedPDFToString = ExtractTextFromPdf(@"B:\sameer.pdf");
            Console.WriteLine(ExtractedPDFToString);

        }
        
    }
}
