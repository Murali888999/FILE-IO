using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class F
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("e:\\k.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            string line = "";
            while ((s.ReadLine() != null))
            {
                Console.WriteLine(line);
               
            }
            s.Close();
            f.Close();
            Console.Read();
        }
    }
}
