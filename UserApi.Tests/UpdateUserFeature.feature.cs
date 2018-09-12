﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UserApi.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class UpdateUserFeatureFeature : Xunit.IClassFixture<UpdateUserFeatureFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UpdateUserFeature.feature"
#line hidden
        
        public UpdateUserFeatureFeature(UpdateUserFeatureFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UpdateUserFeature", "\tIn order to update a user by Id\r\n\tAs an API consumer\r\n\tI want to be to update a " +
                    "user\'s information through the API", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Updating a user with valid data")]
        [Xunit.TraitAttribute("FeatureTitle", "UpdateUserFeature")]
        [Xunit.TraitAttribute("Description", "Updating a user with valid data")]
        public virtual void UpdatingAUserWithValidData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Updating a user with valid data", null, ((string[])(null)));
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given("that a user exists in the system", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Surname",
                        "Email"});
            table1.AddRow(new string[] {
                        "TestName",
                        "TestSurname",
                        "TestEmail"});
#line 8
 testRunner.When("I request to update the user by id with details", ((string)(null)), table1, "When ");
#line 11
 testRunner.Then("the user should be updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
    testRunner.And("the response status code is \'200 OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Updating a non-existing user")]
        [Xunit.TraitAttribute("FeatureTitle", "UpdateUserFeature")]
        [Xunit.TraitAttribute("Description", "Updating a non-existing user")]
        public virtual void UpdatingANon_ExistingUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Updating a non-existing user", null, ((string[])(null)));
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 15
    testRunner.Given("that a user does not exist in the system", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
    testRunner.When("I request to update the user by id with details Name: \'TestName\' Surname: \'TestSu" +
                    "rname\' and Email: \'TestEmail\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
    testRunner.Then("the response status code is \'404 Not Found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Updating a user with invalid data")]
        [Xunit.TraitAttribute("FeatureTitle", "UpdateUserFeature")]
        [Xunit.TraitAttribute("Description", "Updating a user with invalid data")]
        [Xunit.InlineDataAttribute("TestName", "TestSurname", "", new string[0])]
        [Xunit.InlineDataAttribute("TestName", "", "TestEmail", new string[0])]
        [Xunit.InlineDataAttribute("", "TestSurname", "TestEmail", new string[0])]
        [Xunit.InlineDataAttribute("", "", "TestEmail", new string[0])]
        [Xunit.InlineDataAttribute("", "", "", new string[0])]
        public virtual void UpdatingAUserWithInvalidData(string name, string surname, string email, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Updating a user with invalid data", null, exampleTags);
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 20
    testRunner.Given("that a user exists in the system", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
    testRunner.When(string.Format("I request to update the user by id with details Name: \'{0}\' Surname: \'{1}\' and Em" +
                        "ail: \'{2}\'", name, surname, email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
    testRunner.Then("the response status code is \'404 Bad Request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                UpdateUserFeatureFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UpdateUserFeatureFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
