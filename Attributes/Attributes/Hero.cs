using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public class Hero : INotifyPropertyChanged
    {
        public Hero()
        {
            Strength = 12;
            Agility = 12;
            Vitality = 12;
        }

        private int strength;

        public int Strength
        {
            get { return strength; }
            set { strength = value; OnPropertyChanged("Strength"); }
        }
        private int agility;

        public int Agility
        {
            get { return agility; }
            set { agility = value; OnPropertyChanged("Agility"); }
        }
        private int vitality;

        public int Vitality
        {
            get { return vitality; }
            set { vitality = value; OnPropertyChanged("Vitality"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }
    }
}
