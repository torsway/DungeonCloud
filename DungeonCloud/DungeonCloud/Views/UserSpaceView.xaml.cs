﻿using DungeonCloud.Infrastructure;
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

namespace DungeonCloud.Views
{
    /// <summary>
    /// Логика взаимодействия для UserSpaceView.xaml
    /// </summary>
    public partial class UserSpaceView : UserControl, IUserView
    {
        public UserSpaceView()
        {
            InitializeComponent();
        }
    }
}
