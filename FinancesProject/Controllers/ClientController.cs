using FinancesProject.DTO;
using Microsoft.AspNetCore.Mvc;

namespace FinancesProject.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController
{
    [HttpPost("add/individual")]
    public async Task<IActionResult> AddIndividualClient([FromBody] IndividualClientForm clientForm)
    {
        
    }

    [HttpPost("add/company")]
    public async Task<IActionResult> AddCompany([FromBody] CompanyForm clientForm)
    {
        
    }
}