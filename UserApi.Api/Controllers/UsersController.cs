namespace UserApi.Api.Controllers
{
    using System.Web.Http;
    using UserApi.Data.Interfaces;

    public class UsersController : ApiController
    {
        private readonly IUsersRepository _usersRepository;

        public UsersController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public IHttpActionResult GetUser(int id)
        {
            var user = _usersRepository.GetById(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        public IHttpActionResult UpdateUser(int id, string name, string surname, string email)
        {
            var user = _usersRepository.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(email))
            {
                return BadRequest();
            }
            _usersRepository.UpdateById(id, user);
            return Ok();
        }
    }
}
