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
            Console.WriteLine(" Downloading a file");
            Download();
            Console.ReadLine();
        }

        static async void Download()
        {
            await Network.Download();
            Console.WriteLine("Download Completed");
        }

    }

    class Network
    {
        static public Task Download()
        {
<<<<<<< HEAD
            return Task.Run(() => Thread.Sleep(3000));

=======
            Thread.Sleep(66000);
            Console.WriteLine("Download complete...");
>>>>>>> 18bb1ec3dfaa1436b26648bee0a98ff2ab344602
        }
    }
}

