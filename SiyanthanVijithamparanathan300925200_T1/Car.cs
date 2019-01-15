using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiyanthanVijithamparanathan300925200_T1
{
    public class Car:INotifyPropertyChanged
    {
        public string LicensePlate { get; set; }
        public double Milage { get; set; }
        public double Price {
            get { return _price; }
            set { _price = value; }
        }

        private double _price;
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
