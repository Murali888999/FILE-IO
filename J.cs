using System;
using System.IO;
namespace filehandling
{
    class J
    {
        static void Main(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();
            Console.Read();
        }
        static void WriteBinaryFile()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("e:\\d.txt", FileMode.Create)))
            {

                bw.Write("lara");
                bw.Write(2005);
                bw.Write("Ramesh");
            }
        }
        static void ReadBinaryFile()
        {
            using (BinaryReader br = new BinaryReader(File.Open("e:\\d.txt", FileMode.Open)))
            {
                Console.WriteLine("institute  name : " + br.ReadString());
                Console.WriteLine("year of  establish : " + br.ReadInt32());
                Console.WriteLine("founder  : " + br.ReadString());
            }
        }
    }
}