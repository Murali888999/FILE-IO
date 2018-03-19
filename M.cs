using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace filehandling
{
    class M
    {
        static void Main(string[] args)
        {
            try
            {
                string s = "e:\\abc.txt";
                FileInfo fl = new FileInfo(s);
                fl.Create();

            }
            catch(IOException e)
            {
                Console.WriteLine(e);
            }


            Console.Read();
        }
        
    }
}
