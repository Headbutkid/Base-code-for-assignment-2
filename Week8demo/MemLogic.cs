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
                    fee = 36 * 10.00;
                }
                else if (Reg)
                {
                    fee = 36 * 15.00;
                }
                else
                {
                    fee = 36 * 20.00;
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
                    fee = 136 * 5.00; //per week
                }
                else if (Reg)
                {
                    fee = 136 * 10.00;  // per week
                }
                else
                {
                    fee = 136 * 15.00;
                }
                
            }
            return fee;
        }

    }
    
}
