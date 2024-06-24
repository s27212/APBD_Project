using System.ComponentModel.DataAnnotations;

namespace FinancesProject.DTO;

public class CompanyForm
{
    [MaxLength(100)] 
    public string Email { get; set; } = null!;
    
    [MaxLength(100)]
    public string PhoneNumber { get; set; } = null!;
    
    [MaxLength(100)]
    public string Name { get; set; } = null!;
    
    [MaxLength(100)]
    public string Address { get; set; } = null!;
    
    [MaxLength(100)]
    public string Krs { get; set; } = null!;
}