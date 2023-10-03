using System;

class LoanApplication
{
    private double AnnualIncome { get; }
    private double LoanAmount { get; }
    private int LoanDuration { get; }

    public LoanApplication(double annualIncome, double loanAmount, int loanDuration)
    {
        AnnualIncome = annualIncome;
        LoanAmount = loanAmount;
        LoanDuration = loanDuration;
    }

    public void Evaluate()
    {
        double minIncome = 200000;
        double minLoanAmount = 100000;
        double maxLoanAmount = 1000000;
        int minLoanDuration = 1;
        int maxLoanDuration = 10;

        if (AnnualIncome < minIncome)
        {
            throw new LoanApplicationException("Insufficient annual income.");
        }
        if (LoanAmount < minLoanAmount)
        {
            throw new LoanApplicationException("Loan amount is below the minimum allowed.");
        }
        if (LoanAmount > maxLoanAmount)
        {
            throw new LoanApplicationException("Loan amount exceeds the maximum allowed.");
        }
        if (LoanDuration < minLoanDuration)
        {
            throw new LoanApplicationException("Loan duration is too short.");
        }
        if (LoanDuration > maxLoanDuration)
        {
            throw new LoanApplicationException("Loan duration is too long.");
        }
    }
   
    public double? Evaluate1()
    {
        double minIncome = 200000;
        double minLoanAmount = 100000;
        double maxLoanAmount = 1000000;
        int minLoanDuration = 1;
        int maxLoanDuration = 10;

        if (AnnualIncome < minIncome)
        {
            return null; // Insufficient annual income.
        }
        if (LoanAmount < minLoanAmount)
        {
            return null; // Loan amount is below the minimum allowed.
        }
        if (LoanAmount > maxLoanAmount)
        {
            return null; // Loan amount exceeds the maximum allowed.
        }
        if (LoanDuration < minLoanDuration)
        {
            return null; // Loan duration is too short.
        }
        if (LoanDuration > maxLoanDuration)
        {
            return null; // Loan duration is too long.
        }

        return LoanAmount; // Application meets all criteria; return the original loan amount.
    }
}


class LoanApplicationException : Exception
{
    public double? RecommendedLoanAmount { get; }

    public LoanApplicationException(string message, double? recommendedLoanAmount = null) 
        : base(message)
    {
        RecommendedLoanAmount = recommendedLoanAmount;
    }
}