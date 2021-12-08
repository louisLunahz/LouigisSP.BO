using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouigisSP.BO
{
    public class MechanicalKeyboard : Keyboard
    {
        string switchColor;
        string switchBrand;

        public string SwitchColor { get => switchColor; set => switchColor = value; }
        public string SwitchBrand { get => switchBrand; set => switchBrand = value; }

        public MechanicalKeyboard(string id, string distribution, string size, string methodOfConnection, float price, string brand, string model, string ilumination, bool wristRest, string design, string color, string switchColor, string switchBrand) : base(id, distribution, size, methodOfConnection, price, brand, model, ilumination, wristRest, design, color)
        {
            this.SwitchColor = switchColor;
            this.SwitchBrand = switchBrand;


        }

        public MechanicalKeyboard() { 

        }


        public override void PrintAllDetails()
        {
            base.PrintAllDetails();
            Console.WriteLine("Switch Brand: "+switchBrand);
            Console.WriteLine("Switch color: "+switchColor);
        }

    }
}
