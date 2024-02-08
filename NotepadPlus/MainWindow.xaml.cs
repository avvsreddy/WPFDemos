using Microsoft.Win32;
using System.Windows;

namespace NotepadPlus
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // exit the application
            if (MessageBox.Show("Do you wish to exit the application?", "Application Exit", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            // file save
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
        }
    }
}
