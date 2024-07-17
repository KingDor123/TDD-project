
using TDD;
using System;
using Xunit;


namespace TDD.Tests
{
    public class LibraryTests
    {
        Book b1 = new Book("Title1","Author1",1234,"Category",false);
        Book b2 = new Book("Title2","Author2",1234,"Category",false);
        Book b3 = new Book("Title3","Author3",1234,"Category",false);
        
        Library lib = new Library();
        [Fact]
        public void given_3_books_should_add_3_books_to_list()
        {
            lib.addBook(b1);
            lib.addBook(b2);
            lib.addBook(b3);

            Assert.Equal(3, lib.GetListOfBooks().ToArray().Length);



        }

    }
}
