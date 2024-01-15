using System;

namespace _15012024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();
            
            //Books[0].Name = "Test";
            //Books[0].Price = 100.5;
            //Books[0].Genre = "Dram";

            string opr;
            do
            {
                Console.WriteLine("\tMENU\t\n");
                Console.WriteLine("1.Kitab elave et");
                Console.WriteLine("2.Kitab sil");
                Console.WriteLine("3.Butun kitablara bax"); 
                Console.WriteLine("4.Secilmis kitaba bax");
                Console.WriteLine("5.Ada gore axtaris et");
                Console.WriteLine("0.Cix");

                Console.WriteLine("Emeliyyati Daxil Et: ");
                opr = Console.ReadLine();

                switch (opr)
                {
                    case "1":
                        string name;
                        do
                        {
                            Console.WriteLine("Elave Etmek Istediyin Kitabin Adini Daxil Et: ");
                            name = Console.ReadLine();
                        } while (string.IsNullOrWhiteSpace(name) || name.Length < 3 || name.Length > 20);

                        if (library.CheckBookName(name) == false)
                        {
                            Console.WriteLine("Kitab artiq movcuddur!");

                        }
                        else
                        {
                            Console.WriteLine("Elave Etmek Istediyin Kitabin Qiymetini Daxil Et: ");
                            string priceStr;
                            double price;
                            do
                            {
                                priceStr = Console.ReadLine();
                            } while (!double.TryParse(priceStr, out price) || price < 0);

                            Console.WriteLine("Elave Etmek Istediyin Kitabin Janrini Daxil Et: ");
                            string genre = Console.ReadLine();

                            Book book = new Book(name, price, genre);
                            library.AddBook(book);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Sileceyiniz kitabi daxil edin: ");
                        string name3 = Console.ReadLine();
                        library.RemoveBookByName(name3);
                        break;
                    case "3":
                        library.ShowInfo();
                        break;
                    case "4":
                        Console.WriteLine("Axtardiginiz kitabi daxil edin: ");
                        string name2 = Console.ReadLine();
                        Book abc = library.ShowWantedBook(name2);
                        if (abc != null)
                        {
                            abc.ShowInfo();
                        }
                        else
                        {
                            Console.WriteLine("Kitab yoxdur!");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Axtardiginiz kitabi daxil edin: ");
                        string name1 = Console.ReadLine();
                        Book[] abcd = library.FindBookByName(name1);
                        if (abcd != null)
                        {
                            for (int i = 0; i < abcd.Length; i++)
                            {
                                abcd[i].ShowInfo();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bu Kitab Yoxdur!");
                        }

                        break;
                    case "0":
                        Console.WriteLine("Proqram Bitdi!");
                        break;
                    default:
                        Console.WriteLine("Yanlis Emeliyyat!");
                        break;
                }

            } while (opr != "0");
        }

        static void ShowAllBooks(Library[] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i}.");
              
                
            }
        }

        

        static void ShowWantedBook(Book[] books)
        {
            Console.WriteLine("Kitabin adini daxil et: ");
            string name = Console.ReadLine();
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Name == name)
                {
                    Console.WriteLine($"{i}.");
                    books[i].ShowInfo();
                    break;
                }
            }

        }
    }
}
