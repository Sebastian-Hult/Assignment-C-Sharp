using Business.Helpers;
using Business.Services;
using MainApp.Dialogs;

var fileService = new FileService("Data", "contact.json");
var contactSerializer = new ContactSerializer(fileService);
var contactService = new ContactService(contactSerializer);
var menuDialog = new MenuDialog(contactService);
menuDialog.MainMenu();