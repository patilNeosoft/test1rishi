using ContactTask.model;
using ContactTask.Repository;

ContactRepo contactRepo = new ContactRepo();
List<Contact> contactlist = contactRepo.GetContacts();
foreach (Contact contact in contactlist)
{
    Console.WriteLine(contact);
}


//add contact to list
Console.WriteLine("list with new contacts :");
try
{
    Contact Contact = new Contact() { Name = "uday", Address = "sai nivas,room 101,navi mumbai", City = "pune", Phone = "9876564537" };

    contactRepo.Addcontact(Contact);
    foreach (Contact contact in contactlist)
    {
        Console.WriteLine(contact);
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//delete contact

Console.WriteLine("enter contact name to delete ");
var itemToDel = Console.ReadLine();
Console.WriteLine(contactRepo.DeleteContact(itemToDel));

foreach (Contact contact in contactlist)
{
    Console.WriteLine(contact);
}

//filter names 
Console.WriteLine("filtered names");
List<Contact> filtered = contactRepo.GetAllContactsByName("pooja");
foreach (Contact contact in filtered)
{
    Console.WriteLine(contact);
}

//update contact
Console.WriteLine("updated names");
Contact NewC = new Contact() { Name = "Sam", Address = "Kolhapur", City = "kolhapur", Phone = "9876564537" };

contactRepo.UpdateContact(NewC,"pooja");
foreach (Contact contact in contactlist)
{
    Console.WriteLine(contact);
}
