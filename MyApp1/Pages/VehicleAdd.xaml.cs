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
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;

namespace MyApp1.Page
{
    /// <summary>
    /// Interaction logic for VehicleAdd.xaml
    /// </summary>
    /// 

    public partial class VehicleAdd : System.Windows.Window
    {
        VehicleContext context;
       // MyApp1.Model.Vehicle newVehicle = new Model.Vehicle();

        public VehicleAdd(VehicleContext context)
        {
            this.context = context;
            InitializeComponent();
        }




    }
}
