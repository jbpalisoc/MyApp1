using Microsoft.EntityFrameworkCore;
using MyApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1.ViewModel
{
    class VehicleViewModel : ViewModelBase
    {
        private IList<Vehicle> _vehicleList;

        public VehicleViewModel()
        {
            GetVehicle();

        }

        public void GetVehicle()
        {
        }
        public IList<Vehicle> VehicleItems
    {
            get { return _vehicleList; }
            set { _vehicleList = value; }
        }

    }
}
