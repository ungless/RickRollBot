using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace RickRollBot
{
    class Program
    {
        public static Random _random = new Random();
        static void Main(string[] args)
        {
            
            while (true)
            {
                

                if  (_random.Next(10) == 5)
                {
                    OpenWebsite("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                }
                Thread.Sleep(1000);
            }
        }
        public static void OpenWebsite(string URL)
        {
            Process p1 = new Process();
            p1.StartInfo.FileName = "chrome.exe";
            p1.StartInfo.Arguments = URL;
            p1.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            p1.Start();
        }
    }
}
