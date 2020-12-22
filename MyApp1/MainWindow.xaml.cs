using MaterialDesignThemes.Wpf;
using MyApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {

        VehicleContext context;
       // MyApp1.Model.Vehicle newVehicle = new Model.Vehicle();

        public MainWindow(VehicleContext context)
        {
            this.context = context;
            InitializeComponent();

            List<Menu> menu = new List<Menu>();

            menu.Add(new Menu("Dashboard", PackIconKind.MonitorDashboard));
            menu.Add(new Menu("Schedule", PackIconKind.Calendar));
            menu.Add(new Menu("Vehicle", PackIconKind.Car));
            menu.Add(new Menu("Users", PackIconKind.User));

            //MenuListView.ItemsSource = menu;
           // GetVehicle();

        }


        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }
        private void Menu_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Menu menu = (Menu)MenuListView.SelectedItems[0];
            //System.Windows.MessageBox.Show(menu.Name);
            
            switch (menu.Name)
            {
                case "Dashboard":
                    Main.Content = new Page.Dashboard();
                    break;
                case "Schedule":
                    Main.Content = new Page.Schedule();
                    break;
                case "Vehicle":
                    Main.Content = new Page.Vehicle();
                    break;
                case "Users":
                    Main.Content = new Page.Users();
                    break;
                default:
                    Main.Content = new Page.Dashboard();
                    break;
            }
        }
    }
}
