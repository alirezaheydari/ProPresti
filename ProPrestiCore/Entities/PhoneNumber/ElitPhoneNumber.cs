using System;
using System.Collections.Generic;
using System.Text;

namespace ProPrestiCore.Entities.PhoneNumber;

public class ElitPhoneNumber
{
    public required string PhoneNumber { get; set; }
    public GroupOfPhoneNumbers? Group { get; set; }

    public static ElitPhoneNumber Create(string phoneNumber, GroupOfPhoneNumbers group)
    {
        return new ElitPhoneNumber
        {
            PhoneNumber = phoneNumber,
            Group = group
        };
    }
}
