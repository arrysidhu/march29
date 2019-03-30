﻿using System;
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
            return Task.Run(() => Thread.Sleep(3000));

        }
    }
}

