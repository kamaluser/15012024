using System;
using System.Collections.Generic;
using System.Text;

namespace _15012024
{
    internal class Book:Product
    {

        public Book(string name, double price, string genre):base(name,price)
        {
            this.Genre = genre;
        }

        public string Genre;

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nPrice: {Price}\nGenre: {Genre}");
        }
    }
}
