using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LouigisSP.BO
{
    public class Product
    {
        string id;
        string name;
        float price;
        DateTime manufacturingDate;
        DateTime expirationDate;

        public Product()
        {
            this.Id = null;
            this.Name = null;
            this.Price = 0;
           
        }

        public Product(string id, string name, float price, DateTime manufacturingDate, DateTime expirationDate)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.ManufacturingDate = manufacturingDate;
            this.ExpirationDate = expirationDate;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public DateTime ManufacturingDate { get => manufacturingDate; set => manufacturingDate = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }


       

        public override bool Equals(object pro)
        {
            if (pro == null)
            {
                return false;
            }
            else
            if (!(pro is Product))
            {
                return false;
            }
            else
            {
                return ((Product)pro).name == this.name && ((Product)pro).manufacturingDate==this.manufacturingDate;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
