using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBlueprint
{
     class Car
    {
        //protected string _type { get; set; }  /*to choise a vehicle type*/
        protected string _model { get; set; }  /*Sedan,Sportback,SUV*/
        protected EngineTyp _engineType { get; set; }
        protected Color _color { get; set; }
        protected int _seats { get; set; }
        protected long _serielNum { get; set; }

        public Car(string model, EngineTyp engineTyp, string color, int seats) 
        {
            _model = model;
            bool CloseWhile = false;
            
            while (CloseWhile == true)
            {
                switch (color)
                {
                    case "Black":
                        _color = Color.Black;
                        CloseWhile = false;
                        break;
                    case "White":
                        _color = Color.White;
                        CloseWhile = false;
                        break;
                    case "Red":
                        _color = Color.Red;
                        CloseWhile = false;
                        break;
                    case "Blue":
                        _color = Color.Blue;
                        CloseWhile = false;
                        break;
                    case "Gray":
                        _color = Color.Gray;
                        CloseWhile = false;
                        break;
                    case "Silver":
                        _color = Color.Silver;
                        CloseWhile = false;
                        break;
                    default:
                        Console.WriteLine("The color isn't available. Coming soon!");
                        break;
                }
            } //Color Choise
            _seats = seats;
            SerielNumber serielNumber = new SerielNumber();
            serielNumber.GetNumber();
            _serielNum = serielNumber.SerielNum;
        }
    }
}
