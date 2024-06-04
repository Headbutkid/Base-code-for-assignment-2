using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8demo
{
    public class Monthlyouput
    {
        public static double monthlyoutput(bool monthly, bool ThreeMonth, bool TwelveMonth, double totalFee)
        {
            double output2 = 0;
            if (monthly)
            {
                if (ThreeMonth)
                    output2 = totalFee / 3;
                else if (TwelveMonth)
                {
                    output2 = totalFee / 12;

                }
                else
                {
                    output2 = totalFee / 24;
                }


            }
            return output2;
        }
    }
}
