//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LouigisSP.BO
//{
//    class ProductOB
//    {

       

//        public  Product CreateProduct(string line)
//        {
//            Product pro = new Product();
//            string[] elements = line.Split(',');


//            try
//            {
//                pro.Id = elements[0];
//                pro.Name = elements[1];
//                pro.Price = float.Parse(elements[2]);
//                pro.ManufacturingDate = DateTime.Parse(elements[3]);
//                pro.ExpirationDate = DateTime.Parse(elements[4]);
//                return pro;

//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Values missing or not formated in the right way");

//                return null;
//            }




//        }

//        public  Product searchProductInList( Product pro, Product[] products)
//        {
//            Product producto=null;
//            foreach (var p in products) {
//                if (pro.Equals(p)) {
//                    producto = pro;
//                    break;
           
//                }
//            }
//            return producto;        

//        }


//        public void sortArrayUsingManuDate(Product []products) {
//            int n = products.Length;
//            int j, i;
//            int gap = n / 2;
//            while (gap>0) {
//                for ( i=gap; i<n; i++) {
//                    Product temp = products[i];
//                    j = i;
//                    while (j>=gap && products[j-gap].ManufacturingDate>temp.ManufacturingDate)
//                    {
//                        products[j] = products[j - gap];
//                        j = j - gap;
//                    }
//                    products[j] = temp;
//                }
//                gap = gap / 2;
//            }


//        }


      

//    }
//}
