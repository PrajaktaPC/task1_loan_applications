
using System;

class Programs
{
   static void Main()
{
    Console.WriteLine("Loan Application System");
    try
    {
        LoanApplication application = GetLoanApplicationFromUser();
        double? recommendedAmount = application.Evaluate1();

        if (recommendedAmount.HasValue)
        {
            Console.WriteLine("Loan application accepted!");
        }
        else
        {
            Console.WriteLine("Loan application rejected.");

            if (recommendedAmount == null)
            {
                Console.WriteLine("Reason: Criteria is not Matching.");

                Console.Write("Suggested loan amount : ");
                double suggestedAmount = Convert.ToDouble(Console.ReadLine());
              if (suggestedAmount > 0)
                {
                    Console.WriteLine($"Loan application accepted with the suggested amount: {suggestedAmount:C}");
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    }

}

    static LoanApplication GetLoanApplicationFromUser()
    {
        Console.Write("Enter your annual income: ");
        double annualIncome = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the loan amount you are requesting: ");
        double loanAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the loan duration (in years): ");
        int loanDuration = Convert.ToInt32(Console.ReadLine());

        return new LoanApplication(annualIncome, loanAmount, loanDuration);
    }
}



