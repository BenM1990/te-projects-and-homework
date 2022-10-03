using System;
using System.IO;

namespace Lecture.Aids
{
    public class Memory_StreamSample
    {
        public static void ReadStream()
        {
            string folder = Environment.CurrentDirectory;
            string file = "input.txt";
            string fullPath = Path.Combine(folder, file);

            byte[] bytes = File.ReadAllBytes(fullPath); //file class has ReadAllBytes(path) that reads all the data in a file to a byte array
            Console.Write(bytes);
        }
    }
}
