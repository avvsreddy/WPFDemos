using System.Windows;

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int fno = int.Parse(txtFirst.Text);
            int sno = int.Parse(txtSecond.Text);
            int result = fno + sno;
            MessageBox.Show($"The Sum of {fno} and {sno} is {result}");
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            int fno = int.Parse(txtFirst.Text);
            int sno = int.Parse(txtSecond.Text);
            int result = fno - sno;
            MessageBox.Show($"The Diffrence of {fno} and {sno} is {result}");
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            int fno = int.Parse(txtFirst.Text);
            int sno = int.Parse(txtSecond.Text);
            int result = fno * sno;
            MessageBox.Show($"The Product of {fno} and {sno} is {result}");
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            int fno = int.Parse(txtFirst.Text);
            int sno = int.Parse(txtSecond.Text);
            int result = fno / sno;
            MessageBox.Show($"The Division of {fno} and {sno} is {result}");
        }
    }
}