using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MyApp1.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        private readonly DelegateCommand _menuClickCommand;
        public ICommand MenuClickCommand => _menuClickCommand;
        private IList<Menu> _menuList;

        public MainWindowViewModel()
        {
            _menuList = new List<Menu>
            {
                new Menu("Dashboard", PackIconKind.MonitorDashboard),
                new Menu("Schedule", PackIconKind.Calendar),
                new Menu("Vehicle", PackIconKind.Car),
                new Menu("Users", PackIconKind.User)
            };

            _menuClickCommand = new DelegateCommand(OnMenuClick);


        }

        public IList<Menu> MenuItems
        {
            get { return _menuList; }
            set { _menuList = value; }
        }

        public Menu SelectedMenu { get; set; }

        private void OnMenuClick(object commandParameter)
        {
            MessageBox.Show(SelectedMenu.Name);
        }
    }
}
