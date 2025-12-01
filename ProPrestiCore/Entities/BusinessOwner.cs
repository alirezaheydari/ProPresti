namespace ProPrestiCore.Entities;

public class BusinessOwner
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string PhoneNumber { get; set; }
    public IEnumerable<Business> Businesses { get; set; } = Enumerable.Empty<Business>();

    public static BusinessOwner Create(Guid id, string name, string phoneNumber)
    {
        return new BusinessOwner
        {
            Id = id,
            Name = name,
            PhoneNumber = phoneNumber
        };
    }
}
