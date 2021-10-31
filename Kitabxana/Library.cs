using System;
using System.Collections.Generic;
using System.Text;

namespace Kitabxana
{
    class Library
    {
        Library library = new Library();
        public Book[] Books;
        public double TotalIncome;

        public void Addbook(Book Book)
        {
            var temp = this.Books;
            Book[] newBooks = new Book[temp.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                newBooks[i] = temp[i];
            }
            newBooks[newBooks.Length - 1] = Book;

            this.Books = newBooks;
        }




    }
}
 public Book[] GetFilteredBooks(int min, int max)
{
    bool check = true;
    do
    {
        if (check == false)
        {
            Console.WriteLine("Min deyeri daxil edin : ");
            string minStr = Console.ReadLine();
            min = Convert.ToInt32(minStr);
            Console.WriteLine("Max deyeri daxil edin : ");
            string maxStr = Console.ReadLine();
            max = Convert.ToInt32(maxStr);
        }

        if (min == max)
        {
            check = false;
            Console.WriteLine("Min ve Max deyerleri beraber ola bilmez!");
        }
        else if (max < min)
        {
            check = false;
            Console.WriteLine("Min deyeri max deyerinden kicik ola bilmez");
        }
    } while (check == false);

    int count = 0;

    for (int i = 0; i < Books.Length; i++)
    {
        if (Books[i].Price > min && Books[i].Price < max)
        {
            count++;
        }
    }

    Book[] filteredBooks = new Book[count];
    int index = 0;
    for (int i = 0; i < filteredBooks.Length; i++)
    {
        if (Books[i].Price > min && Books[i].Price < max)
        {
            filteredBooks[index] = Books[i];
            index++;
        }
    }
    return filteredBooks;

} 


