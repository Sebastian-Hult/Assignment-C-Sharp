using Business.Helpers;
using Business.Interfaces;
using Business.Models;

namespace Business.Services;

// This class is responsible for managing contacts and their data
public class ContactService(ContactSerializer contactSerializer) : IContactService
{
    // This field stores an instance of the ContactSerializer class
    private readonly ContactSerializer _contactSerializer = contactSerializer;

    // This field stores a list of contacts
    private List<Contact> _contacts = [];


    // This method creates a new contact and adds it to the list of contacts
    // It Generate a unique ID for the contact using the UniqueIdGenerator class
    // Adds the contact to the new list of contacts
    // Saves the updated list of contacts using the ContactSerializer class and return the result
    public bool CreateContact(Contact contact)
    {
        
        contact.Id = UniqueIdGenerator.GenerateUniqueId();
        
        _contacts.Add(contact);
        
        var result = _contactSerializer.SaveContacts(_contacts);
        return result;
    }

    // This method retrieves all contacts from the list of contacts using the ContactSerializer class and returns them
    public IEnumerable<Contact> GetAllContacts()
    {
        _contacts = _contactSerializer.GetContacts();
        return _contacts;
    }
}
