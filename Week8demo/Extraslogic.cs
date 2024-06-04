using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8demo
{
    public class Extra()
    {
       public static double  extralogic(bool Twentyfour, bool Personal, bool Diet, bool ON, double fee)
        {
            double Ex = 0;

            if (Twentyfour) Ex =fee + 1;
            else if (Personal) Ex = fee + 20;
            else if (Diet)Ex = fee + 20; 
            else if (ON) Ex = fee + 2;
            else
            {
                Ex = 0;
            }


            return Ex;        
        }

    }
}
