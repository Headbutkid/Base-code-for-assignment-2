using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Week8demo
{
    public class PrintInvoice
    {
        public static void WriteInvoice(string fname, string email, string membership)
        {

            TextWriter wr = new StreamWriter("C:/Users/2022000425/Downloads/Invoice.txt");

            wr.WriteLine("Thank you for your membership!");
            wr.WriteLine("");
            wr.WriteLine("");
            wr.WriteLine("*************Invoice*************");
            wr.WriteLine("");
            wr.WriteLine("");
            wr.WriteLine($"Firstname: {fname}");
            wr.WriteLine($"Email: {email}");
            wr.WriteLine($"Membership fee: {membership}");
            wr.Close();


        }
       
    }

 }

