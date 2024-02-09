using System.Data.SqlClient;
namespace ContactManagement.DataAccess
{
    public class ContactsRepository : IContactsRepository
    {
        public void Add(Contact contact)
        {
            // c# + sql + ado.net library
            // Step 1: login/open db connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyContacts2024;Integrated Security=true";
            conn.Open();
            // Step 2: send sql insert statment to database
            string sqlInsert = $"insert into contacts values('{contact.Name}','{contact.Location}','{contact.Email}','{contact.Mobile}')";
            SqlCommand cmd = new SqlCommand(sqlInsert, conn);
            cmd.ExecuteNonQuery();
            // Step 3: close db connection
            conn.Close();
        }

        public void Delete(int id)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyContacts2024;Integrated Security=true";
            conn.Open();

            string sqlDelete = $"delete from contacts where contactid={id}";
            SqlCommand cmd = new SqlCommand(sqlDelete, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public List<Contact> GetAllContacts()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyContacts2024;Integrated Security=true";
            conn.Open();

            string sqlSelect = $"select * from contacts";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Contact> contacts = new List<Contact>();

            while (reader.Read())
            {
                Contact c = new Contact();
                c.ContactID = (int)reader[0];
                c.Name = reader[1].ToString();
                c.Email = reader.GetString(3);
                c.Location = reader.GetString(2);
                contacts.Add(c);
            }

            conn.Close();
            return contacts;
        }

        public Contact GetContact(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyContacts2024;Integrated Security=true";
            conn.Open();

            string sqlSelect = $"select * from contacts where contactid = {id}";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            //List<Contact> contacts = new List<Contact>();
            Contact c = new Contact();
            reader.Read();
            c.ContactID = (int)reader[0];
            c.Name = reader[1].ToString();
            c.Email = reader.GetString(3);
            c.Location = reader.GetString(2);
            //contacts.Add(c);


            conn.Close();
            return c;
        }

        public List<Contact> GetContactsByLocation(string location)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyContacts2024;Integrated Security=true";
            conn.Open();

            string sqlSelect = $"select * from contacts where location = {location}";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Contact> contacts = new List<Contact>();

            while (reader.Read())
            {
                Contact c = new Contact();
                c.ContactID = (int)reader[0];
                c.Name = reader[1].ToString();
                c.Email = reader.GetString(3);
                c.Location = reader.GetString(2);
                contacts.Add(c);
            }

            conn.Close();
            return contacts;
        }

        public void Update(Contact contact)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyContacts2024;Integrated Security=true";
            conn.Open();

            string sqlUpdate = $"update contacts set name='{contact.Name}', mobile='{contact.Mobile}', location='{contact.Location}', email='{contact.Email}' where contactid={contact.ContactID}";
            SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
