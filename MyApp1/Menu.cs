﻿using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp1
{
    class Menu
    {
        public String Name { get; private set; }
        public PackIconKind Icon { get; private set;}

        public Menu(String name, PackIconKind icon)
        {
            Name = name;
            Icon = icon;
        }
    }
}
