using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ATM_Emulator.Enitites;

public partial class Login
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public decimal AccountBalance { get; set; }

    public string? TransacationHistory { get; set; }
}
