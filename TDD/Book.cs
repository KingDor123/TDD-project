





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Book
    {
        static int isbnStart = 100000;
        private int ISBN;
        private string title;
        private string author;
        private int yearOfPub;
        private string caregory;
        private Boolean status;


        public Book(string title, string author, int year, string category, Boolean status)
        {
            this.ISBN = isbnStart++;
            this.title = title;
            this.author = author;
            this.yearOfPub = year;
            this.caregory = category;
            this.status = status;
        }

        public int getISBN() { return ISBN; }
        public string getTitle() { return title; }
        public string getAuthor() { return author; }
        public int getYearOfPub() { return yearOfPub; }
        public string getCaregory() { return caregory; }
        public Boolean getStatus() { return status; }
        public void setStatus(Boolean status) 
        {
            this.status= status;
        }
        override
        public string ToString()
        {
            return $"The ISBN is: {this.getISBN()} \n" +
                   $"The Title is: {this.getTitle()} \n" +
                   $"The Author is: {this.getAuthor()} \n" +
                   $"The published Year is: {this.getYearOfPub()} \n" +
                   $"The Category is: {this.getCaregory()}\n" +
                   $"The status is: {this.getStatus()}\n";
        }
    }
}