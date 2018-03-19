using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class l
    {
        static void Main(string[] args)
        {
            StringWriter sw = new StringWriter();
            sw.WriteLine("bvjbsdjbvjsdbvjlsdbvlsbd");
            sw.Flush();
            sw.Close();
            StringReader sr = new StringReader(sw.ToString());
          // while(sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
            Console.Read();
        }
    }
}
