using System;
using System.IO;
using System.Net;

namespace iNetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // http://www.81.cn/2017zt/99627.htm
            int code = 0;
            while (true)
            {
                Console.Write("输入投票编号: ");
                int.TryParse(Console.ReadLine(), out code);
                if (code > 0) { break; }
            }

            int count = 0;
            while (true)
            {
                Console.Write("输入票数: ");
                int.TryParse(Console.ReadLine(), out count);
                if (count > 0) { break; }
            }

            WebClient client = new WebClient();
            string url = "http://vote.81.cn:81/expression/expressionMgr/getExpressionJson?eid=" + code;
            int i = 0;
            while (i < count)
            {
                Console.Write(i + "\t");
                try
                {
                    Stream data = client.OpenRead(url);
                    StreamReader reader = new StreamReader(data);
                    string s = reader.ReadToEnd();
                    Console.WriteLine(s.Trim());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                i++;
            }

            Console.WriteLine("刷票结束");
            //Console.Write("Press any key to exit: ");
            //Console.ReadKey();
        }
    }
}
