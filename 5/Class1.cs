using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _5
{
    /// <summary>
    /// класс машина
    /// </summary>
    public class Car
    {
        //string _marka;//марка автомобиля (Поля)
        int _culindr; //количество циллиндров
        int _moshnost; //мощность
        //метод 
        public bool Proverka(int value)
        {

            if (value > 0)
            {
                return true;
            }
            else return false;
        }
        //Свойства
        public string Marka { get; set; }//марка автомобиля
        public int Culindr//количество циллиндров
        {
            get
            {
                return _culindr;
            }
            set
            {
                if(Proverka(value) == true)
                {
                    _culindr = value;
                }
                else MessageBox.Show("Неверные данные!", "Ошибка");
            }
        }
        public int Moshnost //мощность
        {
            get
            {
                return _moshnost;
            }
            set
            {
                if (Proverka(value) == true)
                {
                    _moshnost = value;
                }
                else MessageBox.Show("Неверные данные!", "Ошибка");
            }
        
        }

       

        public string Show()
        {
            string info = "Машина имеет такую характеристику:\n" +
                Marka + " - Марка\n" +
                Culindr + " - Циллиндр\n" +
                Moshnost + " - Мощность\n";
            return info;

        }
        public Car() { }

        //Параметризированный конструктор 
        public Car(string initMarka, int initCulindr, int initMashnost)
        {
            Marka = initMarka;
            Culindr = initCulindr;
            Moshnost = initMashnost;
        }
        //перегруженный метод
        public void SetParams(string marka)
        {
            Marka = marka;
           
        }
        public void SetParams(int culindr, int moshnost)
        {
            Culindr = culindr;
            Moshnost = moshnost;
        }
        public void SetParams(string marka, int culindr, int moshnost)
        {
            Marka = marka;
            Culindr = culindr;
            Moshnost = moshnost;
        }


    }
}
