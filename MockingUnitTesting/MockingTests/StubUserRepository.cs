using System;
using MockingUnitTesting.Repository;
namespace MockingTests
{
	public class StubUserRepository:IUserRepository
	{
		public StubUserRepository()
		{
		}
        public List<object> GetAllUsers()
        {
            List<object> users = new List<object>();
            users.Add("Renato");
            users.Add("Pedrito");
            return users;
        }

        public void Insert(object user)
        {
            //Do nothing
        }
    }
}

