using System;
using System.Collections.Generic;
using System.Text;

namespace KeyboardPasswordCracker
{
    class C_Sharp_Exercises_Clau
    {
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            string phone = phoneNumber.ToString();
            int phoneNo = int.Parse(phoneNumber);
            int size = phone.Length;
            bool flag = true;

            //validate if phone number has the right size
            if (size == 14)
            {
                // (123) 456-7890
                int i;
                for (i = 0; i < 14; i++)
                {
                    string charater = phone[i].ToString();
                    switch (i)
                    {
                        case 0:
                            if (charater != "(")
                                flag = false;
                            break;
                        case 4:
                            if (charater != ")")
                                flag = false;
                            break;
                        case 5:
                            if (charater != " ")
                                flag = false;
                            break;
                        case 9:
                            if (charater != "-")
                                flag = false;
                            break;
                        default:
                            if (i > 0 && i < 4)
                            {
                                flag= RecursiveFunction(charater, i);
                            }
                            else if (i > 5 && i < 9)
                            {
                                flag = RecursiveFunction(charater, i);
                            }
                            else if (i > 9 && i < 14)
                            {
                                flag = RecursiveFunction(charater, i);
                            }
                            break;
                    }
                }
            }
            return flag;
        }


        public bool RecursiveFunction(string charater, int i)
        {
            bool flag = false;
            try
            {
                //validates if it is a number
                if ((int.Parse(charater)) >= 0 && (int.Parse(charater)) <= 9)
                {
                    flag = true;
                }
            }
            catch (Exception)
            {
                flag = false;
            }
            return flag;
        }
    }
}
