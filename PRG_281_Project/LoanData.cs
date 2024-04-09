using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Corneluis_Smith___Hendry_Ihlenfeldt___Pieter_Nel___Tiaan_Theron__Project
{
    class LoanData
    {
        public int LoanNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname {get; set; }
        public double LoanAmount { get; set; }
        public LoanTerm TermOfLoan { get; set; }
        public LoanType TypeOfLoan { get; set; }


        public override string ToString()
        {
            return  $"Loan number: {LoanNumber} \t First Name: {CustomerName} \t" +
                   $"Last Name: {CustomerSurname} \t Loan Amount: {LoanAmount} \t Loan Term: {TermOfLoan} \t Loan Type: {TypeOfLoan}";
        }

    }
}
