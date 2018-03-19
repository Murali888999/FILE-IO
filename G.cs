using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class G
    {
        static void Main(string[] args)
        {
            using (TextWriter t = File.CreateText("e:\\w.txt"))
            {
                t.WriteLine("hello to all");
                t.WriteLine("good morning");
                t.WriteLine("have a nice day");
            }
            Console.WriteLine("done");
            Console.Read();

        }
    }
}
