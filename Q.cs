using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class Q
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"e:\\rural");
            try
            {
                di.Delete();
                Console.WriteLine("directory deleted");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.Read();
        }
    }
}
