using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class B
    {
        static void Main(string[] args)
        {
            FileStream k = new FileStream("file12.txt", FileMode.OpenOrCreate);
            for (int i = 60; i < 97; i++)
            {
                k.WriteByte((byte)i);
               
            }
            k.Close();
            Console.Read();
        }
    }
}
