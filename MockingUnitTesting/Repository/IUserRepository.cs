using System;
namespace MockingUnitTesting.Repository
{
	public interface IUserRepository
	{
        void Insert(object user);
        List<object> GetAllUsers();
    }
}

