using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RouletteWPF
{
    public class Player : INotifyPropertyChanged
    {
        
        public float Bank = 500;


        public Player(string userName)
        {
            Name = userName;
        }

        private Player()
        {
            Name = "Shawn is awesome!";
        }

        private string _Name = "I was created by the parameterless constructor";

        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name == value)
                {
                    return;
                }
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler h = PropertyChanged;
            if (h != null)
            {
                h(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
