﻿namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        3. Return the last element of the array
            TOPIC: Accessing Array Elements
        */
        public int ReturnLastElement()
        {
            int[] portNumbers = { 80, 8080, 443 };

            return portNumbers[2];

            //portNumbers[portNumbers.Length - 1]
            //return portNumbers[^1];
        }
    }
}