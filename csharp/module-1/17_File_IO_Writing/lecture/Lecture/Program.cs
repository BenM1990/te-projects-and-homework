using System;
using Lecture.Aids;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // WritingTextFiles.WritingAFile(); // exercise 5

            // LoopingCollectionToWriteFile.LoopingADictionaryToWriteAFile(); // exercise 6

            // ReadingAndWritingFiles.OpenAndWrite(); // exercise 8

            // BinaryImageManipulator.ReadFileIn(); // exercise 9

            PerformanceDemo.SlowPerformance();
            PerformanceDemo.FastPerformance();


            Console.Write("Press enter to finish");
            Console.ReadLine();
        }
    }
}
