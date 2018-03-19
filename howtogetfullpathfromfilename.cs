using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class howtogetfullpathfromfilename
    {
        static void Main(string[] args)
        {
            string s = "lara123.txt";
            FileInfo f = new FileInfo(s);
            string fullname = f.FullName;

            Console.WriteLine(fullname);
            Console.Read();


            //FileStream fs = new FileStream("lara123.txt", FileMode.OpenOrCreate);
            //string s = @"lara123.txt";
            //fs.WriteByte(65);
            //Console.WriteLine(s);
            //fs.Close();
            //Console.Read();
        }
    }
}
