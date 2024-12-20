using Business.Models;

namespace Business.Interfaces;

// This interface defines the methods that the ContactService class must implement
public interface IContactService
{
    bool CreateContact(Contact contact);
    IEnumerable<Contact> GetAllContacts();
}
