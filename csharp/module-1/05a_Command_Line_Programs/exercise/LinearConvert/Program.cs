using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length: ");
            string value = Console.ReadLine();
            int initialLengthGiven = int.Parse(value);

            Console.WriteLine("Is the measurement in (m)eter, or (f)eet: ");
            string measurementUnit = Console.ReadLine();

            if (measurementUnit == "m")
            {
                double measurementConvertTo = initialLengthGiven * 3.2808399;
                Console.WriteLine(initialLengthGiven + measurementUnit + " is " + (byte)measurementConvertTo + "f");
            }
            else // if given f
            {
                double measurementConvertTo = initialLengthGiven * 0.3048;
                Console.WriteLine(initialLengthGiven + measurementUnit + " is " + (byte)measurementConvertTo + "m");
            }
            
        }
    }
}
