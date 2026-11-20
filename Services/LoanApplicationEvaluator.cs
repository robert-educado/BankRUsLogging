using BankRUs.Models;

namespace BankRUs.Services;

public class LoanApplicationEvaluator
{
    public string Evaluate(LoanApplication loanApplication)
    {
        if (
        loanApplication.EmployedSince.HasValue &&
        loanApplication.EmployedSince.Value <= DateOnly.FromDateTime(DateTime.Now.AddYears(-1)))
        {
            return "Approved";
        }

        return "Declined";
    }
}
