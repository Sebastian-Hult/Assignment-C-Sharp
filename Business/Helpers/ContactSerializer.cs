using System.Text.Json;
using Business.Interfaces;
using Business.Models;

namespace Business.Helpers;

// This class is responsible for serializing and deserializing contacts
public class ContactSerializer(IFileService fileService)
{
    // It uses the IFileService interface to save and retrieve contacts from a file
    private readonly IFileService _fileService = fileService;

    // This method serializes a list of contacts to JSON and saves the JSON string to a file using the file service
    public bool SaveContacts(List<Contact> contacts)
    {
        var json = JsonSerializer.Serialize(contacts);
        return _fileService.SaveContentToFile(json);
    }

    // This method retrieves a list of contacts from a file using the file service and deserializes them, then returns the list of contacts
    public List<Contact> GetContacts()
    {
        var json = _fileService.GetContentFromFile();
        var contacts = JsonSerializer.Deserialize<List<Contact>>(json);
        return contacts;
    }
}
