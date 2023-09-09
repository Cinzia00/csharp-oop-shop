using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp_oop_shop
{

    internal class Prodotto
    {
     
        public int Code { get; }

        public string name;

        private float price;
        public string Description { get; set; }
        public int Vat { get; set; } = 22;


        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Il prezzo inseerito non è valido");
                } else
                {
                    this.price = value;
                }

            }
        }







        ////GETTER

        //public int GetCode()
        //{
        //    return this.code;
        //}

        //public string GetName()
        //{
        //    return this.name;
        //}

        //public string GetDescription()
        //{
        //    return this.description;
        //}

        //public float GetPrice()
        //{
        //    return this.price;
        //}

        //public int GetVat()
        //{
        //    return this.vat;
        //}



        ////SETTER

        //public string SetName(string value)
        //{
        //    return value;
        //}

        //public string SetDescription(string value)
        //{
        //    return value;
        //}

        //public float SetPrice(float value)
        //{
        //    return value;
        //}





        //METODI

        public float basePrice()
        {
            return Price;
        }

        public float vatPrice() 
        {
            float vatPrice = (Price * Vat / 100) + Price;
            return vatPrice;
        }

        public string extendedName()
        {
            string extendedName = Code + name;
            return extendedName;
        }

        // Metodi Bonus

        public string codePadLeft()
        {
            //string newCode = Code.ToString();
            string newCode = Code.ToString().PadLeft(8, '0');
            return newCode;
        }



        //COSTRUTTORI

        public Prodotto(string name, string description, float price)
        {
            Random rnd = new Random();
            this.Code = rnd.Next(0, 999999);
            this.name = name;
            this.Description = description;
            this.Price = price;
        }
    }
}
