using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Corneluis_Smith___Hendry_Ihlenfeldt___Pieter_Nel___Tiaan_Theron__Project
{
    public class LoanConstants
    {
        private const string _companyName = "Unique Building Services Loan Company";
        private const double _maxLoanAmount = 100000.0;

        public static string CompanyName
        {
            get { return _companyName; }
        }

        public static double MaxLoanAmount
        {
            get{ return _maxLoanAmount;}
        }

        public static double PrimeInterestRate { get;set; }
    }
}


