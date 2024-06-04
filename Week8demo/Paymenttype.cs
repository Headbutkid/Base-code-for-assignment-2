using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8demo
{
    public class Paymenttype
    {
        public static double  payment(bool db, double totalFee)
        {
            double py = 0;
            if (db)
            {
                py = totalFee * 0.01;
            }
            else
            {
                py = totalFee;
            }

            return py;
        }
    }
}
