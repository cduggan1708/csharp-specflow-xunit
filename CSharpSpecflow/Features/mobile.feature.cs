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
    [Xunit.TraitAttribute("Category", "mobile")]
    public partial class SampleFeatureForMobileApplicationsFeature : Xunit.IClassFixture<SampleFeatureForMobileApplicationsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "mobile.feature"
#line hidden
        
        public SampleFeatureForMobileApplicationsFeature(SampleFeatureForMobileApplicationsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Sample Feature for mobile applications", "\tIn order to demonstrate the value of an open-source automation solution\r\n\tAs a Q" +
                    "A Automation Engineer\r\n\tI want to give an example of how to test using a feature" +
                    " file", ProgrammingLanguage.CSharp, new string[] {
                        "mobile"});
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
        
        [Xunit.TheoryAttribute(DisplayName="Mobile Test Scenario")]
        [Xunit.TraitAttribute("FeatureTitle", "Sample Feature for mobile applications")]
        [Xunit.TraitAttribute("Description", "Mobile Test Scenario")]
        [Xunit.InlineDataAttribute("6", "5", "30", new string[0])]
        [Xunit.InlineDataAttribute("7", "7", "49", new string[0])]
        public virtual void MobileTestScenario(string firstValue, string secondValue, string expectedResult, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mobile Test Scenario", exampleTags);
#line 7
 this.ScenarioSetup(scenarioInfo);
#line 8
  testRunner.Given("I am a user on the Calculator app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
  testRunner.When(string.Format("I click \"{0}\" by \"id\" with selector \"digit{0}\"", firstValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
  testRunner.And("I click \"x\" by \"id\" with selector \"mul\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
  testRunner.And(string.Format("I click \"{0}\" by \"id\" with selector \"digit{0}\"", secondValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
  testRunner.And("I click \"=\" by \"id\" with selector \"equal\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
  testRunner.Then(string.Format("I should see \"results\" with text \"{0}\" by \"xpath\" with selector \"//android.widget" +
                        ".EditText[1]\"", expectedResult), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SampleFeatureForMobileApplicationsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SampleFeatureForMobileApplicationsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
