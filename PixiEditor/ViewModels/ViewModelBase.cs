﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PixiEditor.ViewModels
{
     class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        internal void RaisePropertyChanged(string property)
        {
            if (property != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        internal void CloseButton(object parameter)
        {
            ((Window)parameter).Close();
        }

        internal void DragMove(object parameter)
        {
            Window popup = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                popup.DragMove();
            }
        }
    }
}
