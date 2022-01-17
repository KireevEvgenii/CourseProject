using CourseWork.ViewModel;
using System.Windows;

namespace CourseWork.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainVM();
        }

        private void ReservationCanvasUC_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void winClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosed(e);
            App.Current.Shutdown();
        }
    }
}
