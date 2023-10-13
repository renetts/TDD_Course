using Moq;
using MockingUnitTesting.Repository;
using MockingUnitTesting.Domain;
using MockingUnitTesting.Service;

namespace MockingTests;

public class BookServiceTest
{
    [Fact]
    public void TestGetBook()
    {

        Mock<IBookRepository> bookRepository = new Mock<IBookRepository>();
        bookRepository.Setup(bR => bR.GetBook(1)).Returns(new Book()
        {
            Id = 1,
            Title = "Test Driven Development",
            Author = "Kent Beck"

        });
        bookRepository.Setup(bR => bR.GetBook(2)).Returns(new Book()
        {
            Id = 2,
            Title = "El llano en llamas",
            Author = "Juan Rulfo"

        });
        BookService bookService = new BookService(bookRepository.Object);

        Book actual = bookService.GetBook(1);

        Assert.NotNull(actual);
        Assert.Equal(1, actual.Id);
        Assert.Equal("Test Driven Development", actual.Title);
        Assert.Equal("Kent Beck", actual.Author);


        actual = bookService.GetBook(2);

        Assert.NotNull(actual);
        Assert.Equal(2, actual.Id);
        Assert.Equal("El llano en llamas", actual.Title);
        Assert.Equal("Juan Rulfo", actual.Author);

    }

    [Fact]
    public void TestSaveBook()
    {
        Book book = new Book();
        Mock<IBookRepository> bookRepository = new Mock<IBookRepository>();
        BookService bookService = new BookService(bookRepository.Object);

        Book actual = bookService.SaveBook(book);
        bookRepository.Verify(bR => bR.SaveBook(book));
    }
}
