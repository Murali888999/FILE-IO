using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class k
    {
        static void Main(string[] args)
        {
            String s = "hello to all \n" + "iam from Anantapur \n" + "it is located in Andhra pradesh ";
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            sw.Write(s);
            sw.Flush();
            sw.Close();
            StringReader sr = new StringReader(sb.ToString());
          while(sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
            Console.Read();
        }
    }
}