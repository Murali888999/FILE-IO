using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class A
    {
        static void Main(string[] args)
        {
            FileStream j = new FileStream("e:\\t.txt", FileMode.OpenOrCreate);
            j.WriteByte(76);
            j.Close();
           Console.Read();
        }
    }
}
