namespace ContactManagement.DataAccess
{
    public interface IContactsRepository
    {
        void Add(Contact contact);
        void Update(Contact contact);
        void Delete(int id);
        Contact GetContact(int id);
        List<Contact> GetAllContacts();
        List<Contact> GetContactsByLocation(string location);

    }
}
