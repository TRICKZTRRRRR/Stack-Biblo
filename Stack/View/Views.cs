using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.View
{
    internal class Views
    {
        public void LoanMessage()
        {
            Console.Write("What books do you want loan? (Max 4): {name}");
        }

        public void SuccessLoan()
        {
            Console.Write("You just loan: {name}"); 
        }

        public void ErrorLoan()
        {
            Console.Write("You can't loan this book: {name}");
        }
    }
}
