using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using socketDemo.SocketAsyncCore;

namespace socketDemo
{
    class Program
    {
        //public static SocketAsyncCore.SocketAsyncServe AsyncSocketSvr;
        static void Main(string[] args)
        {
            try
            {
                string IP = System.Configuration.ConfigurationSettings.AppSettings["IP"];
                int parallelNum = 100;
                int port = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["Port"]);
               
                SocketAsyncServe server = new SocketAsyncServe(port, parallelNum);
                server.Start();
                Console.WriteLine("服务器已启动....");
                System.Console.ReadLine();  
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
