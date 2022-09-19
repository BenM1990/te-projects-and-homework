using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Please enter the temperature: ");
                string value = Console.ReadLine();
                int temperatureGiven = int.Parse(value);

                Console.WriteLine("Is the temperature in (C)elsius, or (F)ahrenheit?: ");
                string tempType = Console.ReadLine();

                if (tempType == "C")
                {
                    double tempConvertTo = temperatureGiven * 1.8 + 32;
                    Console.WriteLine(temperatureGiven + tempType + " is " + (byte)tempConvertTo + "F");
                }
                else
                {
                    double tempConvertTo = (temperatureGiven - 32) / 1.8;
                    Console.WriteLine(temperatureGiven + tempType + " is " + (byte)tempConvertTo + "C");
                }

            }
                
                
                
        }
    }
}
