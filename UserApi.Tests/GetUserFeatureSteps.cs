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
        private readonly ScenarioContext context;

        public GetUserFeatureSteps(ScenarioContext context)
        {
            this.context = context ?? throw new System.ArgumentNullException(nameof(context));
        }

        [BeforeScenario, Scope(Scenario = "Get user by Id")]
        public static void TestHook()
        {

        }

        [AfterScenario, Scope(Scenario = "Get user by Id")]
        public static void TestHook2()
        {

        }

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
            this.context.Set(controller);
        }

        [When(@"I request to get the user by Id"), Scope(Tag = "tag1", Scenario = "Get user by Id")]
        public void WhenIRequestToGetTheUserById2()
        {
            var usersController = this.context.Get<UsersController>();
            this.context.Set(usersController.GetUser(1));
        }

        [Then(@"the user should be returned in the response")]
        public void ThenTheUserShouldBeReturnedInTheResponse()
        {
            var response = this.context.Get<IHttpActionResult>();
            var user = response as OkNegotiatedContentResult<User>;
            Assert.Equal(expected: 1, actual: user.Content.Id);
        }

        [Then(@"the response status code is '(.*)'")]
        public void ThenTheResponseStatusCodeIs(string p0)
        {
            var response = this.context.Get<IHttpActionResult>();
            if (p0.Equals("200 OK"))
            {
                var resp = response as OkNegotiatedContentResult<User>;
                var resp2 = response as OkResult;
                Assert.False(resp is null && resp2 is null);
            }
            else if (p0.Equals("404 Not Found"))
            {
                var resp = response as NotFoundResult;
                Assert.NotNull(resp);
            }
            else if (p0.Equals("400 Bad Request"))
            {
                var resp = response as BadRequestResult;
                Assert.NotNull(resp);
            }
        }

        [Given(@"that a user does not exist in the system")]
        public void GivenThatAUserDoesNotExistInTheSystem()
        {
            var repository = new InMemoryUsersRepository();
            var controller = new UsersController(repository);
            this.context.Set(controller);
        }

        [Then(@"no user should be returned in the response")]
        public void ThenNoUserShouldBeReturnedInTheResponse()
        {
            var response = this.context.Get<IHttpActionResult>();
            var resp = response as NotFoundResult;
            Assert.NotNull(resp);
        }

    }
}
