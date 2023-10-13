using MockingUnitTesting.Domain;
using MockingUnitTesting.Repository;

namespace MockingUnitTesting.Service
{
    public class BookService
	{

		private readonly IBookRepository _bookRepository;

		public BookService(IBookRepository bookRepository)
		{
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
        }

		public Book GetBook(int id) {
			return _bookRepository.GetBook(id);
		}

		public Book SaveBook(Book book) {
			return _bookRepository.SaveBook(book);
		}


	}
}

