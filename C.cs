using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class C
    {
        static void Main(string[] args)
        {
            FileStream k = new FileStream("E:\\k.txt", FileMode.OpenOrCreate);
            int i = 0;
            while ((i = k.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            k.Close();
            Console.Read();
        }
    }
}
