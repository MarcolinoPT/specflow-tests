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
    }
}
