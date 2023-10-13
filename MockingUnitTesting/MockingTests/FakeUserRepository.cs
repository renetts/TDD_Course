using System;
using MockingUnitTesting.Repository;
namespace MockingTests
{
	public class FakeUserRepository: IUserRepository
	{
        private List<object> _users = new List<object>();

		public FakeUserRepository()
		{
		}

        public List<object> GetAllUsers()
        {
            return _users;
        }

        public void Insert(object user)
        {
            _users.Add(user);
        }
    }
}

