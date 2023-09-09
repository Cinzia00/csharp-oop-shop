﻿// See https://aka.ms/new-console-template for more information
using csharp_oop_shop;


Prodotto newProduct = new Prodotto("scarpe", "Scarpa donna con intersuola abzorb firmata New balance", 50);
//Console.WriteLine($"Nome prodotto: {newProduct.GetName()}");
//Console.WriteLine($"Descrizione prodotto: {newProduct.GetDescription()}");
//Console.WriteLine($"Prezzo prodotto: {newProduct.GetPrice()} euro");
//Console.WriteLine($"Prezzo prodotto: {newProduct.basePrice()} euro");
//Console.WriteLine($"Prezzo con iva: {newProduct.vatPrice()} euro");
//Console.WriteLine($"Nome per esteso: {newProduct.extendedName()}");

//Console.WriteLine("-------------------------");

//Prodotto newProduct1 = new Prodotto("Pullover", "Pullover con collo rotondo e maniche lunghe. Orlo con spacchi laterali. Finiture a coste.", 15.95f);
//Console.WriteLine($"Nome prodotto: {newProduct1.GetName()}");
//Console.WriteLine($"Descrizione prodotto: {newProduct1.GetDescription()}");
//Console.WriteLine($"Prezzo prodotto: {newProduct1.GetPrice()} euro");
//Console.WriteLine($"Prezzo prodotto: {newProduct1.basePrice()} euro");
//Console.WriteLine($"Prezzo al netto di iva: {newProduct1.vatPrice()} euro");
//Console.WriteLine($"Nome per esteso: {newProduct1.extendedName()}");
//Console.WriteLine($"codice pad left: {newProduct1.codePadLeft()}");




Console.WriteLine($"Nome prodotto: {newProduct.name}");
Console.WriteLine($"Codice prodotto: {newProduct.Code}");
Console.WriteLine($"Descrizione prodotto: {newProduct.Description}");
Console.WriteLine($"Codice pad left: {newProduct.codePadLeft()}");
Console.WriteLine($"Prezzo prodotto: {newProduct.Price} euro");
Console.WriteLine($"Prezzo con iva: {newProduct.vatPrice()} euro");
newProduct.Price = 0;
Console.WriteLine($"Prezzo prodotto: {newProduct.Price} euro");
Console.WriteLine($"Prezzo prodotto: {newProduct.basePrice()} euro");
Console.WriteLine($"Nome prodotto per esteso: {newProduct.extendedName()}");
Console.WriteLine("--------------------------");




void printProduct()
{
    Prodotto[] arrayProdotto = {
                new Prodotto("Scarpa", "Scarpa donna con intersuola abzorb firmata New balance", 50),
                new Prodotto("Borsa", "Ssuper elegante", 30),
                new Prodotto("Pullover", "Pullover con collo rotondo e maniche lunghe. Orlo con spacchi laterali. Finiture a coste", 15.90f),
                new Prodotto("Cappello", "alla moda", 15),
                new Prodotto("jeans", "comodissimi", 20),
            };

    for (int i = 0; i < arrayProdotto.Length; i++)
    {
        Console.Write($"Prodotto: {arrayProdotto[i].name}");
        Console.WriteLine($" {arrayProdotto[i].Price} euro");
    }
}

printProduct();


