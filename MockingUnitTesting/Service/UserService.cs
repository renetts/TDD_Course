using MockingUnitTesting.Repository;

namespace MockingUnitTesting.Service
{
    public class UserService
	{

		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

		public List<object> GetAllUsers() {
			return _userRepository.GetAllUsers();
		}

		public void Insert(object user) {
			_userRepository.Insert(user);
		}


	}
}

