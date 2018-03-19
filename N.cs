using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class N
    {
        static void Main(string[] args)
        {
            try
            {
                string s = "e:\\abc1.txt";
                FileInfo fl = new FileInfo(s);           
                StreamWriter sw = fl.CreateText();
                sw.Write("helloooooooooo");
                
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }


            Console.Read();
        }
    }
}
