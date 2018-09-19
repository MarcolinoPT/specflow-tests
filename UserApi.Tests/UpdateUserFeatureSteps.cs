namespace UserApi.Tests
{
    using Api.Controllers;
    using System.Web.Http;
    using System.Web.Http.Results;
    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;
    using Xunit;

    [Binding, Scope(Feature = "UpdateUserFeature")]
    class UpdateUserFeatureSteps
    {
        private readonly ScenarioContext context;

        public UpdateUserFeatureSteps(ScenarioContext context)
        {
            this.context = context ?? throw new System.ArgumentNullException(nameof(context));
        }

        [When(@"I request to update the user by id with details")]
        public void WhenIRequestToUpdateTheUserByIdWithDetails(Table table)
        {
            var updateData = table.CreateInstance<UpdateUserDataTable>();
            var usersController = context.Get<UsersController>();
            var response = usersController.UpdateUser(1, updateData.Name, updateData.Surname, updateData.Email);
            context.Set(response);
        }

        [Then(@"the user should be updated")]
        public void ThenTheUserShouldBeUpdated()
        {
            var response = context.Get<IHttpActionResult>();
            var resp = response as OkResult;
            Assert.NotNull(resp);
        }

        [When(@"I request to update the user by id with details Name: '(.*)' Surname: '(.*)' and Email: '(.*)'")]
        public void WhenIRequestToUpdateTheUserByIdWithDetailsNameSurnameAndEmail(string p0, string p1, string p2)
        {
            var usersController = context.Get<UsersController>();
            var response = usersController.UpdateUser(1, p0, p1, p2);
            context.Set(response);
        }
    }

    class UpdateUserDataTable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
