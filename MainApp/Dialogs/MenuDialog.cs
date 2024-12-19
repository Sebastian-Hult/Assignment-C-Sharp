using Business.Factories;
using Business.Interfaces;

namespace MainApp.Dialogs;

public class MenuDialog(IContactService contactService)
{
    private readonly IContactService _contactService = contactService;

    public void MainMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------- MAIN MENU ----------");
            Console.WriteLine("1. Add New Contact");
            Console.WriteLine("2. View All Contacts");
            Console.WriteLine("Q. Quit Application");
            var option = Console.ReadLine()!;

            switch (option)
            {
                case "1":
                    AddNewContact();
                    break;
                case "2":
                    ViewAllContacts();
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }

    public void AddNewContact()
    {
        var contacts = ContactFactory.CreateNewContact();
        
        Console.Clear();
        Console.WriteLine("---------- CREATE NEW CONTACT ----------");
        Console.WriteLine("To create a new Contact you need to input the following contact information: ");
        Console.Write("First Name: ");
        contacts.FirstName = Console.ReadLine()!;
        Console.Write("Last Name: ");
        contacts.LastName = Console.ReadLine()!;
        Console.Write("Email: ");
        contacts.Email = Console.ReadLine()!;
        Console.Write("Phonenumber: ");
        contacts.PhoneNumber = Console.ReadLine()!;
        Console.Write("Address: ");
        contacts.Address = Console.ReadLine()!;
        Console.Write("Zip Code: ");
        contacts.ZipCode = Console.ReadLine()!;
        Console.Write("City: ");
        contacts.City = Console.ReadLine()!;

        var result = _contactService.CreateContact(contacts);
        if (result)
            Console.WriteLine("Contact was created successfully!");
        else
            Console.WriteLine("Unable to create new contact. Try again later.");

        Console.ReadKey();
    }

    public void ViewAllContacts()
    {
        Console.Clear();

        foreach (var contact in _contactService.GetAllContacts())
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Id: #{contact.Id}");
            Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"Phonenumber: {contact.PhoneNumber}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine($"Zip Code: {contact.ZipCode}");
            Console.WriteLine($"City: {contact.City} city");
            Console.WriteLine("------------------------------------------------");
        }
    }
}
