using System;

namespace Kitabxana
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Console.WriteLine("Kitablarin sayini daxil edin!");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);
            if (count > 0)
            {
                Book[] books = new Book[count];
                for (int i = 0; i < books.Length; i++)

                {
                    Console.WriteLine("=========================================");
                    Console.WriteLine($"{i+1}.Kitabla bagli melumatlari daxil edin");
                    Console.WriteLine("======================================\n");

                    string name = GetInputStr("Name", 1, 50);
                    int no = GetInputInt("No", 1, 50);
                    int Productcount = GetInputInt("Count", 0);
                    double price = GetInputInt ("Price", 0);
                    string genre = GetInputStr("Genre");

                    Book book = new Book(name, no,count,price,genre);

                    books[i] = book;
                  
                }

                Console.WriteLine("/n Kitab siyahisi:");
                foreach (var item in library.Books)
                {
                    Console.WriteLine(item.GetInfo());
                }
            }
        }

        static string GetInputStr(string inputName, int minLength = 0, int maxLength = int.MaxValue)
        {
            string input;
            do
            {
                Console.WriteLine($"{inputName} deyerini daxil edin:");
                input = Console.ReadLine();
            } while (input.Length < minLength || input.Length > maxLength);

            return input;
        }
        static int GetInputInt(string inputName, int min = int.MinValue, int max = int.MaxValue)
        {
            int input;
            string inputStr;
            do
            {
                Console.WriteLine($"{inputName} deyerini daxil edin");
                inputStr = Console.ReadLine();
                input = Convert.ToInt32(inputStr);

            } while (input < min || input > max);

            return input;
        }
        static double GetInputDbl(string inputName, double min = double.MinValue, double max = double.MaxValue)
        {
            double input;
            string inputStr;
            do
            {
                Console.WriteLine($"{inputName} deyerini daxil edin");
                inputStr = Console.ReadLine();
                input = Convert.ToDouble(inputStr);

            } while (input < min || input > max);

            return input;
        }
    }
}

