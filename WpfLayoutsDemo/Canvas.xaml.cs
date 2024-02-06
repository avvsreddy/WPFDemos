using System.Windows;

namespace WpfLayoutsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class CanvasLayout : Window
    {
        public CanvasLayout()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mycanvas.Strokes.Clear();
        }
    }
}
