using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace DA_Unidad2.ViewModel
{
    class BaseViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)

        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        protected void SetValue<T>(ref T backingFieled, T value, [CallerMemberName] string propertyName = null)

        {
            if (EqualityComparer<T>.Default.Equals(backingFieled, value))

            {
                return;
            }

            backingFieled = value;
            OnPropertyChanged(propertyName);
        }



        protected virtual void OnPropertyChangeds([CallerMemberName] string propertyName = null)

        {

            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)

            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        /*public class BaseViewModel : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
            {
                if (EqualityComparer<T>.Default.Equals(storage, value))
                {
                    return false;
                }
                storage = value;
                OnPropertyChanged(propertyName);

                return true;
            } */
    }
}
