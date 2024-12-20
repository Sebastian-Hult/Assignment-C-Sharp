using Business.Models;

namespace Business.Factories;

// This class is responsible for creating new instances of the Contact class
public static class ContactFactory
{
    // This method creates a new instance of the Contact class
    public static Contact CreateNewContact() => new();
}
