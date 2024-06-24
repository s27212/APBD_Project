using System.ComponentModel.DataAnnotations;

namespace FinancesProject.Models;

public class Client
{
    public int ClientId { get; set; }
    
    [MaxLength(100)]
    public string Email { get; set; } = null!;
    
    [MaxLength(100)]
    public string PhoneNumber { get; set; } = null!;
}