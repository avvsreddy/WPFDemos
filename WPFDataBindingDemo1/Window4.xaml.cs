using System.Windows;

namespace WPFDataBindingDemo1
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();


            List<Person> people = new List<Person>
            {
                new Person
                {
                    PersonId = 1,
                    FirstName = "Sachin",
                    LastName = "Tendulkar",
                    Email = "sachin@india.org",
                    Mobile = "4524525245",
                    Image = @"E:\Demos\WPFDemos\WPFDataBindingDemo1\Images\sachin.jfif",
                },

                new Person
                {
                    PersonId = 2,
                    FirstName = "Rahul",
                    LastName = "Dravid",
                    Email = "rahul@india.org",
                    Mobile = "4524525245",
                    Image = @"E:\Demos\WPFDemos\WPFDataBindingDemo1\Images\sachin.jfif",
                },
                new Person
                {
                    PersonId = 2,
                    FirstName = "Mahendra",
                    LastName = "Dhoni",
                    Email = "dhoni@india.org",
                    Mobile = "4524525245",
                    Image = @"E:\Demos\WPFDemos\WPFDataBindingDemo1\Images\sachin.jfif",
                },
                new Person
                {
                    PersonId = 3,
                    FirstName = "Virat",
                    LastName = "Kholi",
                    Email = "kholi@india.org",
                    Mobile = "4524525245",
                    Image = @"E:\Demos\WPFDemos\WPFDataBindingDemo1\Images\sachin.jfif",
                },
                new Person
                {
                    PersonId = 4,
                    FirstName = "Rohit",
                    LastName = "Sharma",
                    Email = "rohit@india.org",
                    Mobile = "4524525245",
                    Image = @"E:\Demos\WPFDemos\WPFDataBindingDemo1\Images\sachin.jfif",
                },
                new Person
                {
                    PersonId = 5,
                    FirstName = "Ravi",
                    LastName = "Shastri",
                    Email = "ravi@india.org",
                    Mobile = "4524525245",
                    Image = @"E:\Demos\WPFDemos\WPFDataBindingDemo1\Images\sachin.jfif",
                },
            };


            // ContactManagement.DataAccess.ContactsEFRepository repo = new //ContactManagement.DataAccess.ContactsEFRepository();

            //var contacts = repo.GetContacts();
            this.DataContext = people;


        }
    }
}
