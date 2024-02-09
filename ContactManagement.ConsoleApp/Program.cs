using ContactManagement.DataAccess;

namespace ContactManagement.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// add new contact
            //Contact c = new Contact { Name = "Ravi", Email = "ravi@mail.com", Location = "Bangalore", Mobile = "234234234" };

            //ContactsRepository repo = new ContactsRepository();
            //repo.Add(c);
            //Console.WriteLine("Contact saved....");

            // delete
            //ContactsRepository repo = new ContactsRepository();
            //repo.Delete(1);
            //Console.WriteLine("deleted...");

            // edit

            ContactsRepository repo = new ContactsRepository();
            // get record to edit
            //var contactToEdit = repo.GetContact(2);
            //contactToEdit.Mobile = "123123123123";
            //repo.Update(contactToEdit);
            //Console.WriteLine("edited");


            // get all contacts and display
            var allContacts = repo.GetAllContacts();
            foreach (var contact in allContacts)
            {
                Console.WriteLine($"{contact.ContactID}\t{contact.Name}\t{contact.Email}\t{contact.Mobile}\t{contact.Location}");
            }
        }
    }
}
