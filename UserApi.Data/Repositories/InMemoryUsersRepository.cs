namespace UserApi.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using UserApi.Data.Interfaces;
    using UserApi.Entities;

    public class InMemoryUsersRepository : IUsersRepository
    {
        private readonly List<User> _users;
        public InMemoryUsersRepository()
        {
            _users = new List<User>();
        }
        public void DeleteById(int id)
        {
            _users.RemoveAll(u => u.Id == id);
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public void UpdateById(int id, User user)
        {
            _users.RemoveAll(u => u.Id == id);
            _users.Add(user);
        }

        public void Add(User user)
        {
            _users.Add(user);
        }
    }
}
