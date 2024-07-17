using System;
using Xunit;
using TDD;

namespace TDD.Tests
{
    public class BookTests
    {
        Book b = new Book("Title", "Author", 2023, "Category", true);
        
        [Fact]
        public void Book_Constructor_ValidInputs_ShouldCreateBook()
        {
         
            Assert.Equal(100000, b.getISBN());
            Assert.Equal("Title", b.getTitle());
            Assert.Equal("Author", b.getAuthor());
            Assert.Equal(2023, b.getYearOfPub());
            Assert.Equal("Category", b.getCaregory());
            Assert.True(b.getStatus());
        }
    }
}
