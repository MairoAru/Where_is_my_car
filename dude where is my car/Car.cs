using System;
using System.Collections.Generic;
using System.Text;

namespace dude_where_is_my_car
{
    class Car
    {
        private string _mark;
        private string _model;
        private string _regNr;
        private string _color;
        private int _odo;
        private int _fuel = 60;
        protected int _laps;
        public Car(string mark,string model,string regNr,string color)
        {
            _color = color;
            _laps = 0;
            
            _mark = mark;
            _model = model;
            
            _regNr = regNr;
            if(regNr.Length > 6)
            {
                
                throw new ArgumentOutOfRangeException($"Reg nr cannot be longer than 6 characters. Current: {regNr}");
            }
            
        }
        public void Showcar()
        {
            Console.WriteLine($" mark:{_mark}\n color:{_color}\n model:{_model}\n regNr:{_regNr}\n Odo:{_odo}\n Fuel:{_fuel}\n Laps{_laps} ");
        }
        public void CarDrives()
        {
            Console.WriteLine($"Car drives 1 lap");
            _laps += 1;
            _odo += 100;
            _fuel -= 5;
        }
        public void TankEmpty()
        {
            do
            {
                CarDrives();
            } while (_fuel > 0);
            Console.WriteLine($"car drove {_laps} laps");

        }
        public string Mark
        {
            get
            {
                return _mark;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
        }
        public string REGnr
        {
            get
            {
                return _regNr;
            }
        }
        public int Odometer
        {
            get
            {
                return _odo;
            }
        }
        public int Fueltank
        {
            get
            {
                return _fuel;
            }
        }
    }
}
