using System;
using System.Collections.Generic;
using System.Text;

namespace KeyboardPasswordCracker
{
    class C_Sharp_Exercises_Gui
    {
        /*

        // (123) 456-7890  

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 14) { return false; }

            bool isNotFirstParenthesesValid = phoneNumber[0] != '(';
            bool isNotSecondParenthesesValid = phoneNumber[4] != ')';
            bool isNotSpaceValid = phoneNumber[5] != ' ';
            bool isNotHifenValid = phoneNumber[9] != '-';
            if (isNotFirstParenthesesValid || isNotSecondParenthesesValid || isNotSpaceValid || isNotHifenValid)
            {
                return false;
            }

            phoneNumber = phoneNumber.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            if (int.TryParse(phoneNumber, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

*/
        // convenience store exercise
        /*Given a total due and an array representing the amount of change in your pocket, 
         * determine whether or not you are able to pay for the item. 
        * Change will always be represented in the following order: quarters, dimes, nickels, pennies.
         */
        public bool ConvenienceStore(int cenas, int [] array)
        {

        }



    }
}
