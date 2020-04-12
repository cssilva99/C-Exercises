using System;
using System.Collections.Generic;
using System.Text;

namespace KeyboardPasswordCracker
{
    class KeyboardManager
    {
        Dictionary<string, string> phoneKeyboard = new Dictionary<string, string>();

        public KeyboardManager(int[] states, int days)
        {
            states = cellComplete(states, days);
            foreach(var item in states)
            {
                Console.Write(item);
            }
        }

        private int[] cellComplete(int[] states, int days)
        {
            int day = 0;
            int lastValue = 2;
            while(day <= days)
            {
                for(int i = 0; i < states.Length - 1; i++)
                {
                    if(i == 0)
                    {
                        lastValue = states[i];
                        states[i] = GetNewState(false == IsActive(states[i + 1]));
                    }
                    else if (i == states.Length - 2)
                    {
                        states[i] = GetNewState(IsActive(lastValue) == false);
                    } 
                    else
                    {
                        int auxLastValue = lastValue;
                        lastValue = states[i];
                        states[i] = GetNewState(IsActive(auxLastValue) == IsActive(states[i + 1]));
                    }
                }
                day++;
            }
            return states;
        }

        private bool IsActive(int state)
        {
            if(state == 1)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        private int GetNewState(bool isActive)
        {
            if(isActive)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
