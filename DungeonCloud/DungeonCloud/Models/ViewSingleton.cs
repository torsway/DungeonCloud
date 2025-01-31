﻿using Caliburn.Micro;
using DungeonCloud.Infrastructure;
using DungeonCloud.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DungeonCloud.Models
{
    public class ViewSingleton : PropertyChangedBase
    {
        private static ViewSingleton instance;

        public IUserView mainView = new UserSpaceView();
        public IUserView settingsView = new SettingsView();
        public IUserView registrationView = new RegistrationView();
        public IUserView imageView = new ImageView();



        public IUserView currentView;
        public IUserView CurrentView
        {
            set
            {
                currentView = value;
                NotifyOfPropertyChange();
            }
            get => currentView;
        }



        private ViewSingleton() { }

        public static ViewSingleton Instance => instance ?? (instance = new ViewSingleton()); 
    }
}
