namespace UserApi.Tests
{
    using Api.Controllers;
    using System.Web.Http;
    using System.Web.Http.Results;
    using TechTalk.SpecFlow;
    using UserApi.Data.Repositories;
    using UserApi.Entities;
    using Xunit;

    [Binding]
    public class GetUserFeatureSteps
    {
        UsersController usersController;
        IHttpActionResult response;

        [Given(@"that a user exists in the system")]
        public void GivenThatAUserExistsInTheSystem()
        {
            var repository = new InMemoryUsersRepository();
            var user = new User
            {
                Id = 1,
                Email = "test@test.com",
                Name = "TestName",
                Surname = "TestSurname"
            };
            repository.Add(user);
            var controller = new UsersController(repository);
            usersController = controller;
        }

        [When(@"I request to get the user by Id")]
        public void WhenIRequestToGetTheUserById()
        {
            response = this.usersController.GetUser(1);
        }

        [Then(@"the user should be returned in the response")]
        public void ThenTheUserShouldBeReturnedInTheResponse()
        {
            var user = response as OkNegotiatedContentResult<User>;
            Assert.Equal(expected: 1, actual: user.Content.Id);
        }

        [Then(@"the response status code is '(.*)'")]
        public void ThenTheResponseStatusCodeIs(string p0)
        {
            if (p0.Equals("200 OK"))
            {
                var resp = response as OkNegotiatedContentResult<User>;
                Assert.NotNull(resp);
            }
            else if (p0.Equals("404 Not Found"))
            {
                var resp = response as NotFoundResult;
                Assert.NotNull(resp);
            }
        }

        [Given(@"that a user does not exist in the system")]
        public void GivenThatAUserDoesNotExistInTheSystem()
        {
            var repository = new InMemoryUsersRepository();
            var controller = new UsersController(repository);
            usersController = controller;
        }

        [Then(@"no user should be returned in the response")]
        public void ThenNoUserShouldBeReturnedInTheResponse()
        {
            var resp = response as NotFoundResult;
            Assert.NotNull(resp);
        }

    }
}
