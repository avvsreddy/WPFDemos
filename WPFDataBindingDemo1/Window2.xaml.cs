using System.Windows;
using WPFDataBindingDemo1.DataLayer;

namespace WPFDataBindingDemo1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();

            Person p = new Person()
            {
                PersonId = 1,
                FirstName = "Sachin",
                LastName = "Tendulkar",
                Email = "sachin@india.org",
                Mobile = "4524525245",
                Image = @"E:\Demos\WPFDemos\WPFDataBindingDemo1\Images\sachin.jfif"
            };

            this.DataContext = p;
        }
    }





}
