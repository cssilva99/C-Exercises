using System;
using System.Collections.Generic;

namespace KeyboardPasswordCracker
{

    class Program
    {

        static void Main(string[] args)
        {
            int[] array = { 2, 5, 8 , 8 , 8, 5};
            //int[] states = { 1,0,0,0,0,1,0,0 };
            sumAllElements batats = new sumAllElements();
            batats.frequencyElementsArray(array);
            Console.ReadKey();
        }

      
    }
}
