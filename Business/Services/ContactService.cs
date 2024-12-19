using Business.Helpers;
using Business.Interfaces;
using Business.Models;

namespace Business.Services;

public class ContactService(ContactSerializer contactSerializer) : IContactService
{
    private readonly ContactSerializer _contactSerializer = contactSerializer;
    private List<Contact> _contacts = [];

    public bool CreateContact(Contact contact)
    {
        contact.Id = UniqueIdGenerator.GenerateUniqueId();

        _contacts.Add(contact);

        var result = _contactSerializer.SaveContacts(_contacts);
        return result;
    }

    public IEnumerable<Contact> GetAllContacts()
    {
        _contacts = _contactSerializer.GetContacts();
        return _contacts;
    }
}
