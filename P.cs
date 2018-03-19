using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class P
    {
        static void Main(string[] args)
        {
            try
            {

                DirectoryInfo di = new DirectoryInfo(@"e:\\rural");
                if (di.Exists)
                {
                    Console.WriteLine("directory exists");
                    return;
                }
                di.Create();
                Console.Write("directory created");

            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
            Console.Read();
        }
        
    }
}

