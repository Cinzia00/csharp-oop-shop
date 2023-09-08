using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp_oop_shop
{

    internal class Prodotto
    {
     
        private int code;
        private string name;
        private string description;
        private float price;
        private int vat = 22;




        //GETTER

        public int GetCode()
        {
            return this.code;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public float GetPrice()
        {
            return this.price;
        }

        public int GetVat()
        {
            return this.vat;
        }




        //SETTER

        public string SetName(string value)
        {
            return value;
        }

        public string SetDescription(string value)
        {
            return value;
        }

        public float SetPrice(float value)
        {
            return value;
        }

        public int SetVat(int value)
        {
            return value;
        }





        //METODI

        public float basePrice()
        {
            return price;
        }

        public float vatPrice() 
        {
            float vatPrice = (price * vat / 100) + price;
            return vatPrice;
        }

        public string extendedName()
        {
            string extendedName = code + name;
            return extendedName;
        }

        // Metodi Bonus

        public string codePadLeft()
        {
            string newCode = code.ToString();
            newCode = code.ToString().PadLeft(8, '0');
            return newCode;
        }




        //COSTRUTTORI

        public Prodotto(string name, string description, float price)
        {
            Random rnd = new Random();
            this.code = rnd.Next(0, 999999);
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}
