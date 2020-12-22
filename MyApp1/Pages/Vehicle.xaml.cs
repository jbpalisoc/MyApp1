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

namespace MyApp1.Page
{
    /// <summary>
    /// Interaction logic for Vehicle.xaml
    /// </summary>
    public partial class Vehicle : System.Windows.Controls.Page
    {
        VehicleContext _context;
       // MyApp1.Model.Vehicle newVehicle = new Model.Vehicle();

        //Vehicle selectedProduct = new Vehicle();

        public Vehicle()
        {
            InitializeComponent();
        }

        private void GetVehicle()
        {
            VehicleDataGrid.ItemsSource = _context.Vehicles.ToList();
        }


        private void VeicleAddButton_Click(object sender, RoutedEventArgs e)
        {

            VehicleAdd vehicleAddWindow = new VehicleAdd(_context);
            vehicleAddWindow.ShowDialog();
        }



        private void DeleteVehicle(object s, RoutedEventArgs e)
        {
            var vehicleToDelete = (s as FrameworkElement).DataContext as Model.Vehicle;
            _context.Vehicles.Remove(vehicleToDelete);
            _context.SaveChanges();
        }


    }
}
