using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SocketClientDemo
{
    class Program
    {
        private static byte[] result = new byte[1024];
        static void Main(string[] args)
        {
            //设定服务器IP地址  
            string IP = System.Configuration.ConfigurationSettings.AppSettings["IP"];
            IPAddress ip = IPAddress.Parse(IP);
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                int Port = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["Port"]);
                clientSocket.Connect(new IPEndPoint(ip, Port)); //配置服务器IP与端口  
                Console.WriteLine("连接服务器成功");
            }
            catch(Exception ex)
            {
                Console.WriteLine("连接服务器失败，请按回车键退出！");
                return;
            }
            //通过clientSocket接收数据  
            //int receiveLength = clientSocket.Receive(result);
            //Console.WriteLine("接收服务器消息：{0}", Encoding.ASCII.GetString(result, 0, receiveLength));
            //通过 clientSocket 发送数据  
            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    Thread.Sleep(2000);    //等待1秒钟  
                    string sendMessage = "##0098ST=32;CN=2011;PW=123456;MN=ZQHJ0001007600;CP=&&DataTime=20170904180626;011-Rtd=45.491,011-Flag=N&&71C0";
                    clientSocket.Send(Encoding.UTF8.GetBytes(sendMessage), SocketFlags.None);
                    Console.WriteLine("向服务器发送消息：{0}" ,sendMessage);
                }
                catch
                {
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                    break;
                }
            }
            Console.WriteLine("发送完毕，按回车键退出");
            Console.ReadLine();
        }  
    }
}
