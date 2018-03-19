using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling
{
    class D
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("E:\\file\\j.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine("hello");
            s.Close();
            f.Close();
        }
    }
}
