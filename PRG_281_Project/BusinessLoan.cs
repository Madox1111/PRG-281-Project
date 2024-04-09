using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Corneluis_Smith___Hendry_Ihlenfeldt___Pieter_Nel___Tiaan_Theron__Project
{
    internal class BusinessLoan : Loan
    {
        public BusinessLoan(LoanData loanDataHandler) : base(loanDataHandler)
        {
            PrimeInterestRate += 0.01;
        }

        public static BusinessLoan CreateLoan(LoanData loanDataHandler)
        {
            BusinessLoan businessLoan = new BusinessLoan(loanDataHandler);
            return businessLoan;
        }

        public override string ToString()
        {
            return base.ToString() + $" \t Loan Type: Business";
        }
    }
}
