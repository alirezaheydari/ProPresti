using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProPrestiCore.Entities;

public class Customer
{
    public Guid Id { get; set; }                // Unique identifier
    public required string PhoneNumber { get; set; }    // User's contact number
    public required string FullName { get; set; }       // Full name
    public required string Password { get; set; }       // Password (should be hashed in real apps)
    public DateTime Birthdate { get; set; }    // Date of birth
    public bool Confirmed { get; set; } = false;     // Account confirmation status

    
    public static Customer Create(Guid id, string phoneNumber, string fullName, string password, DateTime birthdate, bool confirmed)
    {
        return new Customer
        {
            Id = id,
            PhoneNumber = phoneNumber,
            FullName = fullName,
            Password = password,
            Birthdate = birthdate,
            Confirmed = confirmed
        };
    }
}
