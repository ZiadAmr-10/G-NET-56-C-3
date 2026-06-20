using System.Diagnostics;
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
        }
    }
}
