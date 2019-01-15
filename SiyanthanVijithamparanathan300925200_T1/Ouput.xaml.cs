using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace SiyanthanVijithamparanathan300925200_T1
{
    /// <summary>
    /// Interaction logic for Ouput.xaml
    /// </summary>
    public partial class Ouput : Window
    {
        
        public Ouput(Repository repository)
        {
            InitializeComponent();
            dgCars.ItemsSource = repository.cars;
            txtTotal.DataContext = repository;
        }


    }
}
