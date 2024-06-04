using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8demo
{
    public class MemLogic
    {
        
        public static double Logic(bool ThreeMonth, bool TwelveMonth, bool Bas, bool Reg)
        {
            double fee;

            if (ThreeMonth)
            {
                if (Bas)
                {
                    fee = 12 * 10.00;
                }
                else if (Reg)
                {
                    fee = 12 * 15.00;
                }
                else
                {
                    fee = 12 * 20.00;
                }

            }
            else if (TwelveMonth)
                if (Bas)
                {
                    fee = 48 * 8.00; //per week
                }
                else if (Reg)
                {
                    fee = 48 * 13.00;  // per week
                }
                else
                {
                    fee = 48 * 18.00;
                }
            else
            {
                if (Bas)
                {
                    fee = 96
                        * 5.00; //per week
                }
                else if (Reg)
                {
                    fee = 96 * 10.00;  // per week
                }
                else
                {
                    fee = 96 * 15.00;
                }
                
            }
            return fee;
        }

    }
    
}
