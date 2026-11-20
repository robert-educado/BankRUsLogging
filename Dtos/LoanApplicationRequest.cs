namespace BankRUs.Dtos;

public record LoanApplicationRequest
{
    public required int Amount { get; init; }
    public required int PaybackPeriod { get; init; }
    public required string SocialSecurityNumber { get; init; }
    public required int ResidenceType { get; init; }
    public required int ResidenceCost { get; init; }
    public required int EmploymentType { get; init; }
    public DateOnly? EmployedSince { get; init; }
    public required int Salary { get; init; }
}
