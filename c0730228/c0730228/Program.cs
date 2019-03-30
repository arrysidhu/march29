using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730228
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("download");
            Download();
            Console.ReadLine();
            { 
        }
    }
  

        static void Download()

        {
            Thread.Sleep(66000);
            Console.WriteLine("Download complete...");
        }
}
