﻿using System.ComponentModel.DataAnnotations;

namespace FinancesProject.Models;

public class Company
{
    public int CompanyId { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; } = null!;
    
    [MaxLength(100)]
    public string Address { get; set; } = null!;
    
    [MaxLength(100)]
    public string Krs { get; set; } = null!;
    
    public virtual Client Client { get; set; } = null!;
    
    public int ClientId { get; set; }
}