using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace filehandling
{
    class H
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("e:\\w.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
            Console.WriteLine("done");
            Console.Read();
        }
    }
}
