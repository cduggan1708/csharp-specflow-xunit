﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CSharpSpecflow.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "pbi1234")]
    [Xunit.TraitAttribute("Category", "web")]
    public partial class SampleFeatureForWebApplications_GoogleFeature : Xunit.IClassFixture<SampleFeatureForWebApplications_GoogleFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "web.feature"
#line hidden
        
        public SampleFeatureForWebApplications_GoogleFeature(SampleFeatureForWebApplications_GoogleFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Sample Feature for web applications - Google", "\tIn order to demonstrate the value of an open-source automation solution\r\n\tAs a Q" +
                    "A Automation Engineer\r\n\tI want to give an example of how to test using a feature" +
                    " file", ProgrammingLanguage.CSharp, new string[] {
                        "pbi1234",
                        "web"});
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Test Scenario")]
        [Xunit.TraitAttribute("FeatureTitle", "Sample Feature for web applications - Google")]
        [Xunit.TraitAttribute("Description", "Test Scenario")]
        [Xunit.InlineDataAttribute("how wonderful is the Gherkin language?", new string[0])]
        public virtual void TestScenario(string searchString, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Test Scenario", exampleTags);
#line 8
 this.ScenarioSetup(scenarioInfo);
#line 9
      testRunner.Given("I am a user on Google", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
   testRunner.When(string.Format("I enter text \"{0}\" in the text field \"Search\" by \"id\" with selector \"lst-ib\"", searchString), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
      testRunner.And("I hit Enter by \"id\" with selector \"lst-ib\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
      testRunner.Then("I should be directed to \"Google Search Results\" page by \"id\" with selector \"rcnt\"" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
      testRunner.And(string.Format("I should see value \"{0}\" in \"search\" field by \"id\" with selector \"lst-ib\"", searchString), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Test Scenario 2")]
        [Xunit.TraitAttribute("FeatureTitle", "Sample Feature for web applications - Google")]
        [Xunit.TraitAttribute("Description", "Test Scenario 2")]
        [Xunit.InlineDataAttribute("did I do that?", new string[0])]
        public virtual void TestScenario2(string searchString, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Test Scenario 2", exampleTags);
#line 18
 this.ScenarioSetup(scenarioInfo);
#line 19
      testRunner.Given("I am a user on Google", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
   testRunner.When(string.Format("I enter text \"{0}\" in the text field \"Search\" by \"id\" with selector \"lst-ib\"", searchString), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
      testRunner.And("I hit Enter by \"id\" with selector \"lst-ib\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
      testRunner.Then("I should be directed to \"Google Search Results\" page by \"id\" with selector \"rcnt\"" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
      testRunner.And(string.Format("I should see value \"{0}\" in \"search\" field by \"id\" with selector \"lst-ib\"", searchString), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SampleFeatureForWebApplications_GoogleFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SampleFeatureForWebApplications_GoogleFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion