using System.Text.Json;
using Business.Interfaces;
using Business.Models;

namespace Business.Helpers;

public class ContactSerializer(IFileService fileService)
{
    private readonly IFileService _fileService = fileService;

    public bool SaveContacts(List<Contact> contacts)
    {
        var json = JsonSerializer.Serialize(contacts);
        return _fileService.SaveContentToFile(json);
    }

    public List<Contact> GetContacts()
    {
        var json = _fileService.GetContentFromFile();
        var contacts = JsonSerializer.Deserialize<List<Contact>>(json);
        return contacts;
    }
}
