namespace Business.Models;

// This class represents a contact with the following properties: Id, FirstName, LastName, Email, PhoneNumber, Address, ZipCode, City
public class Contact
{
    public string Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
    public string City { get; set; } = null!;
}
