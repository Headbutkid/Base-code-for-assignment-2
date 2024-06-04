using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8demo
{
    public class Extraslogic()
    {
       public static double  extralogic(bool Twentyfour, bool Personal, bool Diet, bool ON, double fee, bool ThreeMonth, bool TwelveMonth)
        {
            double Ex = 0;

            if (Twentyfour)
            {
                if (ThreeMonth)
                {
                    Ex = 12 * 1.00;
                }
                else if (TwelveMonth)
                {
                    Ex = 48 * 1.00;
                }
                else
                {
                    Ex = 96 * 1.00;
                }
               
            }
            else if (Personal)
            {
                if (ThreeMonth)
                {
                    Ex = 12 * 20.00;
                }
                else if (TwelveMonth)
                {
                    Ex = 48 * 20.00;
                }
                else
                {
                    Ex = 96 * 20.00;
                }
            }
            else if (Diet)
            {
                if (ThreeMonth)
                {
                    Ex = 12 * 20.00;
                }
                else if (TwelveMonth)
                {
                    Ex = 48 * 20.00;
                }
                else
                {
                    Ex = 96 * 20.00;
                }
            }



            else if (ON)
            { 
                if (ThreeMonth)
                {
                    Ex = 12 * 2.00;
                }
                else if (TwelveMonth)
                {
                    Ex = 48 * 2.00;
                }
                else
                {
                    Ex = 96 * 2.00;
                }
            }
            else
            {
                Ex = 0;
            }


            return Ex;        
        }

    }
}
