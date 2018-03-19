using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class O
    {
        static void Main(string[] args)
        {
            try
            {
                string s = "e:\\abc1.txt";
                FileInfo fl = new FileInfo(s);

                StreamReader sr = fl.OpenText();
                String s1 = "";
                while((s1=sr.ReadLine())!= null)
                {
                    Console.WriteLine(s1);
                }
               
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }


            Console.Read();
        }
    }
}
