using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;
using System.Timers;

namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //String ProductList = "";
            //for( int i = 1; i <= 5000; i++)
            //{
            //    ProductList += "PROD-" + i + ",";
            //}
            //(a)Explain why this code is inefficient.Reference what happens in memory.
            //This code inefficient because the string is immutable that mean Every time creat a new object,
            //and the old object becomes eligible for Garbage Collector
            //------------------------------------------------------------------------------------------------
            //(b) Rewrite this code using StringBuilder to be more efficient.
            //StringBuilder ProductList =new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    ProductList.Append("PROD-" + i + ",");
            //}
            //------------------------------------------------------------------------------------------------
            //(c) Add timing code(using Stopwatch) to both versions and report the time difference.
            //String ProductList1 = "";
            //var watch1= Stopwatch.StartNew();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    ProductList1 += "PROD-" + i + ",";
            //}
            //watch1.Stop();
            //Console.WriteLine(watch1);
            //var watch2= Stopwatch.StartNew();
            //StringBuilder ProductList2 = new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    ProductList2.Append("PROD-" + i + ",");
            //}
            //watch2 .Stop();
            //Console.WriteLine(watch2);
            #endregion
            #region Question02
            //int age, day, price ;
            //bool StudentId;
            //Console.WriteLine("Enter Your Age : ");
            //age=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter The Day : ");
            //day=int.Parse(Console.ReadLine());
            //Console.WriteLine("Do you have a valid StudentId : ");
            //string input=Console.ReadLine();
            //StudentId = input.ToLower() == "yes";
            //if (age < 5)
            //{
            //    price = 0;
            //}
            //else if (age >= 5 && age <= 12)
            //{
            //    price = 30;
            //}
            //else if(age >= 13 && age <= 59)
            //{
            //    price = 50;
            //}
            //else
            //{
            //    price = 25;
            //}
            //if (price > 0 &&( day == 6 || day == 7))
            //{
            //    price += 10;
            //}
            //if (price > 0 && StudentId)
            //{
            //    price = price - (int)(price * 0.20);

            //}
            //Console.WriteLine("Final Price = " + price);
            #endregion
            #region Question03
            // A traditional switch statement
            //String FileExtention = "PDF";
            //String FileType;
            //switch(FileExtention){
            // case "PDF":
            //      FileType = "PDF document";
            //      break;
            // case "doc":
            // case "docx":
            //        FileType = "Word document";
            //        break;
            // case "xlsx":
            // case "xls":
            //        FileType = "Excel SpreadSheet";
            //        break;
            //  case "jpg":
            //  case "png":
            //  case "gif":
            //        FileType = "imagefile";
            //        break;
            // default:
            //        FileType = "Unknown FileType";
            //        break;
            //}
            //Console.WriteLine("File Type is : "+FileType);
            //(b) switch expression
            //String FileExtention = "PDF";
            //String FileType = FileExtention switch
            //{
            //    "PDF" => "PDF document",
            //    "doc" or "docx" => "Word document",
            //    "xlsx" or "xls" => "Excel Spreadsheet",
            //    "jpg" or "png" or "gif" => "imagefile",
            //    _ => "Unknown FileType"
            //};
            //Console.WriteLine("File Type is : " + FileType);
            #endregion
            #region Quesion04
            //int temperature = 35;
            //string weatherAdvice;
            //weatherAdvice = (temperature < 0) ? "Freezing ! Stay indoors" :
            //              (temperature < 15) ? "Cold wear a jacket" :
            //              (temperature < 25) ? "Pleasant weather" :
            //              (temperature < 35) ? "Warm Stay hydratef" :
            //              "Hot Avoid Sun Exposure";
            //Console.WriteLine(weatherAdvice);
            ///if-else is better because it countains a multiple conditions ,use ternary operator for simple conditions
            #endregion
        }
    }
}
