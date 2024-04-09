# PRG-281-Project
Programming 281 Group Project Completion Date: August 9 2023
Task:
Unique Building Services Loan Company gives out loans of up to R100 000 for construction projects. There are two categories of loans: 
· Business loans and 
· Individual loans. 

Write a C# Console application that tracks all new construction loans. The application must calculate the total amount owed at the due date (original loan amount + loan fee). The application should include the following classes: 
•• Loan: A public abstract class that implements the LoanConstants interface. A Loan includes a loan number, customer lastname, customer firstname, loan amount, interest rate, and term. The constructor requires data for each of the fields except the interest rate. Do not allow loan amounts greater than R100 000. Force any loan term that is not one of the three defined in the LoanConstants class to a short-term, 1-year loan. Create a ToString() method that displays all the loan data. 
•• LoanConstants: A public interface class. LoanConstants include constant values for short term (1 year), medium-term (3 years), and long-term (5 years) loans. The class also contains constants for the company name and the maximum loan amount. 
•• BusinessLoan: A public class that extends Loan. The BusinessLoan constructor sets the interest rate to 1% more than the current prime interest rate. •• PersonalLoan: A public class that extends Loan. The PersonalLoan constructor sets the interest rate to 2% more than the current prime interest rate. 
•• CreateLoans: An application that creates an array of five Loans. Prompt the user for the current prime interest rate. Then, in a loop, prompt the user for a loan type and all relevant information for that loan. Store the created Loan objects in the array. When data entry is complete, display all the loans.
