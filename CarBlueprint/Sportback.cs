using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBlueprint
{
    internal class Sportback : Car
    {
        public Sportback(EngineTyp engineTyp, string color, int seats) : base("Sportback", engineTyp, color, seats)
        {
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

        }
    }
}
