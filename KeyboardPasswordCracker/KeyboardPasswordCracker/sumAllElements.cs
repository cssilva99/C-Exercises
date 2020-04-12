using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace KeyboardPasswordCracker
{
    class sumAllElements
    {
        //Write a program in C# Sharp to count the frequency of each element of an array         
        public int sumAllElementsArray(int[] array_one)
        {
            int counter = 0;
            foreach(var value in array_one)
            {
                counter += value;
            }
            /*for (int i = 0; i < length; i++)
            {
                //counter = counter + array_one[i];
                if (i == 0)
                {
                    counter = array_one[i];
                }
                else
                {
                    counter = counter + array_one[i];
                }
            }*/
            Console.WriteLine("The sum of all elements of the array is  : " + counter);
            return counter;
        }
        //20, 10, 20, 5, 20, 5
        


        public class Frequncy
        {
            int Number;
            int Quantity;
        }

      
    }
}
