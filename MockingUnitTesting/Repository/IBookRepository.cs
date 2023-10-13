using System;
using MockingUnitTesting.Domain;

namespace MockingUnitTesting.Repository
{
	public interface IBookRepository
	{

        Book GetBook(int id);

        Book SaveBook(Book book);

    }
}

