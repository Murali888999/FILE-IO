using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class I
    {
        static void Main(string[] args)
        {
            String s = "e:\\binarywriter.dat";
            using (BinaryWriter bw = new BinaryWriter(File.Open(s, FileMode.Create)))
            {
                bw.Write("lara");
                bw.Write(2012);
                bw.Write("ramesh");
            }
            Console.WriteLine("done");
            Console.Read();
        }
    }
}
