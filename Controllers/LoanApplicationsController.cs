using BankRUs.Dtos;
using BankRUs.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankRUs.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoanApplicationsController (LoanApplicationEvaluator loanApplicationEvaluator) : ControllerBase
{
    // POST /api/loanapplications
    [HttpPost]
    public ActionResult Create(LoanApplicationRequest request)
    {
        // TODO: Utvärdera låneansökan...

        var result = loanApplicationEvaluator.Evaluate(new Models.LoanApplication
        {
            EmployedSince = request.EmployedSince
        });

        var response = new LoanApplicationResponse(result);

        // Returnerar 201 Created - vi kommer skapa upp en ansökan i
        // databasen
        return Created("", response);
    }

}
