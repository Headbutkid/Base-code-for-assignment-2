using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8demo
{
    public class Query
    {
        public static double output(bool weekly, bool monthly, double totalFee, bool ThreeMonth, bool TwelveMonth)
        {
            double Output = 0;
            if (weekly)
            {
                if (ThreeMonth)
                {
                    Output = totalFee / 12;
                }
                else if (TwelveMonth)
                {
                    Output = totalFee / 48;
                }
                else
                {
                    Output = totalFee / 96;
                }
            }
            

            return Output;
        }
    }
}
