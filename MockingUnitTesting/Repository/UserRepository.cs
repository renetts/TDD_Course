using System;
namespace MockingUnitTesting.Repository
{
	public class UserRepository: IUserRepository
	{
		public UserRepository()
		{
		}

        public List<object> GetAllUsers()
        {
            //Go to the database and fetch all users.
            return null;
        }

        public void Insert(object user)
        {
            //Insert a user into the database here.
        }

    }
}

