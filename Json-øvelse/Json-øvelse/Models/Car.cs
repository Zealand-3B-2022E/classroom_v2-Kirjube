using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Json_øvelse.Models
{
    internal class Car
    {
        private string _brand;
        private string _model;
        private string _color;
        private int _milage;
        public string Brand { get { return _brand; } set { _brand = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public string Color { get { return _color; } set { _color = value; } }
        public int Milage { get { return _milage; } set { _milage = value; } }
        //public Car(string brand, string model, string color, int milage)
        //{
        //    _brand = brand;
        //    _model = model;
        //    _color = color;
        //    _milage = milage;
        //}
        public Car()
        {

        }
        public override string ToString()
        {
            return $"{ nameof(Brand)}:{Brand}, {nameof(Model)}:{Model},{nameof(Color)}:{Color},{nameof(Milage)}:{Milage} ";
        }
    }
}
