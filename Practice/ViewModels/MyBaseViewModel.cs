using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Practice.Services;
using Xamarin.Essentials;

namespace Practice.ViewModels
{
    public class MyBaseViewModel : INotifyPropertyChanged
    {
        public MyBaseViewModel()
        {
            MilwaukeeCoffeePlaces coffeePlaces = new MilwaukeeCoffeePlaces();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        //What this method does, is look whether there is an event handler assigned or not(if it is not assigned and you just call it, you'll get a NullReferenceException). If there is one assigned, call this event handler.

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}

