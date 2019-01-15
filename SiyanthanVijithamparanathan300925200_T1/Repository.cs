using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiyanthanVijithamparanathan300925200_T1
{
    public class Repository
    {
        public ObservableCollection<Car> cars { get; set; }
        public double Total { get; }

        public Repository(ObservableCollection<Car> cars)
        {
            this.cars = cars;
            this.Total = getCarsTotal();
        }
        public Repository() { }

        public double getCarsTotal()
        {
            double total = 0;

            foreach(var item in cars)
            {
                total = total + item.Price;
            }
            return total;
        }
    }
}
