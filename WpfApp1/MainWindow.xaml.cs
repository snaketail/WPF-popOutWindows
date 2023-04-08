using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Views.Windows;
using WpfApp1.ViewModels;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private testNotify NotificationWdinwos;

        private Timer notifyTimer;

        private notifyWdViewModel notifyWdVM;

        public MainWindow()
        {
            InitializeComponent();

            notifyTimer = new Timer();

            Show();

            NotificationWdinwos = new testNotify();
            notifyWdVM = new notifyWdViewModel();

            NotificationWdinwos.DataContext = notifyWdVM;

            NotificationWdinwos.Show();

        }

    }
}
