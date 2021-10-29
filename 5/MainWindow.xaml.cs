using System;
using System.Collections.Generic;
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

namespace _5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Калион Екатерина Максимовна. 5 пр. Создать базовый класс Саr (машина), характеризуемый торговой маркой (строка), " +
                "числом цилиндров, мощностью.Создать необходимые методы и свойства.Создать " +
                " перегруженные методы SetParams, для установки параметров автомобиля.");
        }

        //Выход из программы
        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
     
       
        Car car = new Car(); //Создаем обьект типа Car
        
        private void Купить_Click(object sender, RoutedEventArgs e)
        {
            
            if (int.TryParse(Cilindr.Text, out int cilindr) && int.TryParse(Moshnost.Text, out int moshnost) && cilindr > 0 &&   moshnost > 0)
            {
                //если нажали на бмв
                if (BMW.IsChecked == true)
                {
                    car.Marka = BMW.Content.ToString();// используем свойство 
                }
                else car.Marka = Audi.Content.ToString();
                car.SetParams(cilindr, moshnost); // использууем перегруженный метод
                car1.Text = car.Show(); //используем метод
            }
            else MessageBox.Show("Неверные данные!", "Ошибка");
            
        }

        private void BMW_Checked(object sender, RoutedEventArgs e)
        {
            car.SetParams(Convert.ToString(BMW.Content));// испоьзуем метод для марки
            Cilindr.Text = "6";
            Moshnost.Text = "297";
        }
        private void Audi_Checked(object sender, RoutedEventArgs e)
        {
            car.SetParams(Convert.ToString(Audi.Content));// используем метод
            Cilindr.Text = "4";
            Moshnost.Text = "176";
        }
    }
}
       
    

