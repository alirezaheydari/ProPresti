namespace ProPrestiCore.Entities.PhoneNumber;

public class GroupOfPhoneNumbers
{
    public int Id { get; set; }
    public required Business Business { get; set; }
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public static GroupOfPhoneNumbers Create(int id, string name, decimal price, Business business)
    {
        return new GroupOfPhoneNumbers
        {
            Id = id,
            Name = name,
            Business = business,
            Price = price
        };
    }

}
