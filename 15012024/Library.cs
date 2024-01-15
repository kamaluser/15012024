using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace _15012024
{
    internal class Library
    {
        public Book[] Books=new Book[0];


        public void AddBook(Book book)
        {
            
           
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }
        public void ShowInfo()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Console.WriteLine($"Name: {Books[i].Name}\nPrice: {Books[i].Price}\nGenre: {Books[i].Genre}");
            }
        }

        public Book[] FindBookByName(string name)
        {
            
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name.Contains(name))
                {
                    return Books;

                }
                
            }
            return null;
        }

        public Book ShowWantedBook(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name == name)
                {
                    return Books[i];
                }
            }
            return null;
        }

        public void RemoveBookByName(string name)
        {
            for (int i = 0; i < Books.Length-1; i++)
            {

                var temp = Books[i];
                Books[i] = Books[i + 1];
                Books[i + 1] = temp;
            }
            Array.Resize(ref Books, Books.Length - 1);

        }

        public bool CheckBookName(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name == name)
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}
