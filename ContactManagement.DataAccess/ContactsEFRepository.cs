namespace ContactManagement.DataAccess
{
    public class ContactsEFRepository : IContactsRepository
    {
        private ContactsDbContext db = new ContactsDbContext();
        public void Add(Contact contact)
        {
            db.Contacts.Add(contact);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var contactToDel = db.Contacts.Find(id);
            db.Contacts.Remove(contactToDel);
            db.SaveChanges();
        }

        public List<Contact> GetAllContacts()
        {
            return db.Contacts.ToList();
        }

        public Contact GetContact(int id)
        {
            // select * from contacts where contactid = id

            return db.Contacts.Find(id);
        }

        public List<Contact> GetContactsByLocation(string location)
        {
            var contacts = from c in db.Contacts
                           where c.Location == location
                           select c;
            return contacts.ToList();
        }

        public void Update(Contact contact)
        {
            db.Entry(contact).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
