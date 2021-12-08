using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouigisSP.BO
{
    public class Keyboard
    {
        protected string id;
        protected string distribution;
        protected string size;
        protected string methodOfConnection;
        protected float price;
        protected string brand;
        protected string model;
        protected string ilumination;
        protected bool wristRest;
        protected string design;
        protected string color;

        public Keyboard(string id, string distribution, string size, string methodOfConnection, float price, string brand, string model, string ilumination, bool wristRest, string design, string color)
        {
            this.Id = id;
            this.Distribution = distribution;
            this.Size = size;
            this.MethodOfConnection = methodOfConnection;
            this.Price = price;
            this.Brand = brand;
            this.Ilumination = ilumination;
            this.WristRest = wristRest;
            this.Design = design;
            this.Color = color;
            this.model = model;
        }

        public Keyboard() { 
        
        }

        public string Distribution { get => distribution; set => distribution = value; }
        public string Size { get => size; set => size = value; }
        public string MethodOfConnection { get => methodOfConnection; set => methodOfConnection = value; }
        public float Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Ilumination { get => ilumination; set => ilumination = value; }
        public bool WristRest { get => wristRest; set => wristRest = value; }
        public string Design { get => design; set => design = value; }
        public string Color { get => color; set => color = value; }
        public string Model { get => model; set => model = value; }
        public string Id { get => id; set => id = value; }

        public override string ToString()
        {
            return "id: " + id + " Brand: " + brand + " Model: " + model + " Price: " + price;
        }

        public virtual void PrintAllDetails() {
            Console.Clear();
            Console.WriteLine("Brand: "+brand);
            Console.WriteLine("Model: "+model);
            Console.WriteLine("Color: "+color);
            Console.WriteLine("Ilumination: "+ilumination);
            Console.WriteLine("Design: "+design);
            Console.WriteLine("Wristrest: "+wristRest);
            Console.WriteLine("Method of connection: "+methodOfConnection);
            Console.WriteLine("Size: "+size);
            Console.WriteLine("Distribution: "+distribution);
            Console.WriteLine("Price: " + price);
        }

       
    }
}
