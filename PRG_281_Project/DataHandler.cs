﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Corneluis_Smith___Hendry_Ihlenfeldt___Pieter_Nel___Tiaan_Theron__Project
{
    internal class DataHandler   //Handles all data related to loans
    {
        private List<Loan> loanList = new List<Loan>();

        public void AddLoan(Loan loan)
        {
            loanList.Add(loan);
        }

        public Loan GetLoanByIndex(int index)
        {
            return loanList[index];
        }

        public List<Loan> GetAllLoans() 
        { 
            return loanList;
        }
    }
}
