namespace _3DScatterChart
{
    using System.Windows;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.StateChanged += Window_Loaded;
        }

        private void Window_Loaded(object? sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
            {
                header.Margin = new Thickness(-270, 3, 0, 10);
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                header.Margin = new Thickness(-650, 3, 0, 10);
            }
            else if (this.WindowState == WindowState.Normal)
            {
                header.Margin = new Thickness(-270, 3, 0, 10);
            }
        }
    }
}