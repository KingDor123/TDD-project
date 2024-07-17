using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Library
    {
        private List<Book> listOfBooks = null;

        List<int> yearList = new List<int>();
        public Library()
        {
            listOfBooks = new List<Book>();
        }
        //()
        public void addBook(Book newBook)
        {
            try
            {
                listOfBooks.Add(newBook);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void DeleteBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Book to delete cannot be null");
            }
            bool removed = listOfBooks.Remove(book);
            if (!removed)
            {
                throw new InvalidOperationException("The book was not found in the library");
            }
        }

        public List<Book> GetListOfBooks() { return listOfBooks; }
        override
        public string ToString()
        {
            string temp = "The library is:\n";
            foreach (Book book in listOfBooks)
            {
                temp += "\nnext book:\n" + book.ToString();
            }

            return temp;

        }

        public int generateRandomYear()
        {
            int minYear = 1990;
            int maxYear = 2024;
            Random rnd = new Random();
            int randomYear = rnd.Next(minYear, maxYear + 1);
            return randomYear;
        }
       
        public void addBooksFromFile()
        {
            var f = new files_12();
            for (int i = 0; i < 10000; i++)
            {
               
                Book b = new Book(f.Titles[i], f.Author_names[i], generateRandomYear(), f.Category_names[i%7],generateBool());
                addBook(b);
            }
        }
        private void Swap(int index1, int index2)
        {
            Book temp = listOfBooks[index1];
            listOfBooks[index1] = listOfBooks[index2];
            listOfBooks[index2] = temp;
        }
        public Boolean generateBool()
        {
            Random random = new Random();
            Boolean ans = random.Next(0, 2) ==0;
            return ans;
        }

        public void Sort()
        {
            for (int i = 0; i < listOfBooks.Count; i++)
            {
                for (int j = i + 1; j < listOfBooks.Count; j++)
                {
                    if (listOfBooks[i].getYearOfPub() < listOfBooks[j].getYearOfPub())
                    {
                        Swap(i, j);
                    }
                }
            }
        }
    }
}

