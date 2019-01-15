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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SiyanthanVijithamparanathan300925200_T1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Car> CarOptions = new ObservableCollection<Car>();
        Car car = new Car();
        Repository repository = new Repository();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = car;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (car != null)
            {
                CarOptions.Add(car);
                repository = new Repository(CarOptions);
                Ouput output = new Ouput(repository);
                output.Show();
                car = new Car();
                this.DataContext = car;
            }
        }
    }
}
