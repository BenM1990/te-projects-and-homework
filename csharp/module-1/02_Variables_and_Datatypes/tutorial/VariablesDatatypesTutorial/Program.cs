using System;

namespace VariablesDatatypesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            /******************************************************************************/
            // Step 1: Declare and initialize variables
            /******************************************************************************/
            double costOfDinner = 120.00;
            int tipPercent = 18;
            int numberOfGuests = 4;
            // Greet the user
            Console.WriteLine("********************************************");
            Console.WriteLine("*** Welcome to the Restaurant Calculator ***");
            Console.WriteLine("********************************************");
            Console.WriteLine("Cost of dinner: $" + costOfDinner);

            /******************************************************************************/
            // Step 2: Calculate the sales tax and tip
            /******************************************************************************/
            const double SalesTaxPercentage = 7.5;
            double taxAmount;
            taxAmount = SalesTaxPercentage / 100 * costOfDinner;
            double tipAmount = tipPercent / 100.0 * costOfDinner;
            Console.WriteLine("Tax $" + taxAmount);
            Console.WriteLine("Tip $" + tipAmount);




            /******************************************************************************/
            // Step 3: Calculate the amount per person
            /******************************************************************************/
            double amountPerPerson = (costOfDinner + taxAmount + tipAmount) / numberOfGuests;
            Console.WriteLine("Amount per person $" + amountPerPerson);





            /******************************************************************************/
            // Step 4: Given the total number of dessert pieces, determine the number each
            //      guest gets, and the number left over after each guest eats their pieces.
            /******************************************************************************/
            int numberOfCookies = 9;
            int numberCookiesPerGuest = numberOfCookies / numberOfGuests;
            int leftoverPieces = numberOfCookies % numberOfGuests;
            Console.WriteLine("Each guest can eat " + numberCookiesPerGuest + " cookies, with " + leftoverPieces + " left over.");






            Console.WriteLine("********************************************");
            Console.WriteLine("** Thanks for using Restaurant Calculator **");
            Console.WriteLine("********************************************");
        }
    }
}
