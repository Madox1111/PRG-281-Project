using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace _Corneluis_Smith___Hendry_Ihlenfeldt___Pieter_Nel___Tiaan_Theron__Project
{
    internal class Loan : LoanConstants
    {

        protected int _loanNumber;
        protected string _customerLastName;
        protected string _customerFirstName;
        protected double _loanAmount;
        protected LoanTerm _loanTerm;
        protected const LoanTerm _defaultTerm = LoanTerm.Short;
        protected double _maxLoanAmount = 100000.0;


        public Loan(LoanData loanDataHandler) 
        {
            _loanNumber = loanDataHandler.LoanNumber;
            _customerFirstName = loanDataHandler.CustomerName; 
            _customerLastName = loanDataHandler.CustomerSurname; 
            _loanAmount = loanDataHandler.LoanAmount; 
            _loanTerm = loanDataHandler.TermOfLoan;
        }

        public override string ToString()
        {
            return  $"Loan number: {_loanNumber} \t First Name: {_customerFirstName} \t" +
                   $"Last Name: {_customerLastName} \t Loan Amount: {_loanAmount} \t Loan Term: {_loanTerm}";

        }

    }
}