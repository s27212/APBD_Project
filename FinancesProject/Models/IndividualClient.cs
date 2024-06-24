using System.ComponentModel.DataAnnotations;

namespace FinancesProject.Models;

public class IndividualClient
{
    public int IndividualClientId { get; set; }
    
    [MaxLength(100)]
    public string FirstName { get; set; } = null!;
    
    [MaxLength(100)]
    public string LastName { get; set; } = null!;
    
    [MaxLength(100)]
    public string Address { get; set; } = null!;
    
    [MaxLength(100)]
    public string Pesel { get; set; } = null!;
    
    public virtual Client Client { get; set; } = null!;
    
    public int ClientId { get; set; }
}