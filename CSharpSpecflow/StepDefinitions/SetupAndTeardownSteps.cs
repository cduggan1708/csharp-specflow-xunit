using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using CSharpSpecflow.Common;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CSharpSpecflow.StepDefinitions
{
    [Binding]
    class SetupAndTeardownSteps
    {
        private readonly ScenarioContext scenarioContext;
        private static ExtentReports extentReports;
        private static string browser;
        private static string remoteDriverUrl;
        private static string emulatorVersion;
        private static string apkPath;

        public SetupAndTeardownSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void InitializeReport()
        {
            extentReports = new ExtentReports();

            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(Constants.ReportingFolder + "TestResultsExtentReport.html");

            htmlReporter.Configuration().Theme = Theme.Dark;

            extentReports.AttachReporter(htmlReporter);
        }

        [BeforeTestRun]
        public static void InitializeCommandLineParameters()
        {
            browser = Environment.GetEnvironmentVariable("BROWSER");
            if (browser == null) browser = Constants.Chrome;
            remoteDriverUrl = Environment.GetEnvironmentVariable("REMOTE_DRIVER_URL");
            if (remoteDriverUrl == null) remoteDriverUrl = "http://127.0.0.1:4723/wd/hub";
            emulatorVersion = Environment.GetEnvironmentVariable("EMULATOR_VERSION"); 
            apkPath = Environment.GetEnvironmentVariable("APK_PATH"); 
            if (apkPath == null) apkPath = "C:\\Users\\cduggan\\Downloads\\Calculator_2.0.apk";
        }

        [BeforeFeature]
        public static void InitializeFeatureReport(FeatureContext featureContext)
        {
            featureContext.Set<ExtentTest>(extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title));
        }

        [BeforeFeature("web")]
        public static void BeforeWebFeatureStep(FeatureContext featureContext)
        {
            // driver is accessible from FeatureContext
            featureContext.Set<IWebDriver>(DriverHelper.GetWebDriver(browser));
        }

        [BeforeFeature("mobile")]
        public static void BeforeMobileFeatureStep(FeatureContext featureContext)
        {
            // driver is accessible from FeatureContext
            featureContext.Set<IWebDriver>(DriverHelper.GetAndroidDriver(remoteDriverUrl, emulatorVersion, apkPath));
        }

        [BeforeScenario]
        public void InitializeReportTest(FeatureContext featureContext)
        {
            ExtentTest scenario = featureContext.Get<ExtentTest>().CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
            foreach (string tag in featureContext.FeatureInfo.Tags)
            {
                scenario.AssignCategory(tag);
            }
            foreach (string tag in scenarioContext.ScenarioInfo.Tags) {
                scenario.AssignCategory(tag);
            }

            scenarioContext.Set<ExtentTest>(scenario);
        }

        [AfterStep]
        public void LogCurrentStep(FeatureContext featureContext)
        {
            if (scenarioContext.TestError == null)
            {
                scenarioContext.Get<ExtentTest>().CreateNode(new GherkinKeyword(scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString()), scenarioContext.StepContext.StepInfo.Text).Pass("pass");
            }
            else
            {
                scenarioContext.Get<ExtentTest>().CreateNode(new GherkinKeyword(scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString()), scenarioContext.StepContext.StepInfo.Text).Fail(scenarioContext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(ReportingHelper.CreateScreenshot(featureContext.Get<IWebDriver>())).Build());
            }
        }

        [AfterScenario]
        public void WrapUpReport()
        {
            scenarioContext.Clear();
        }

        [AfterFeature]
        public static void AfterFeatureStep(FeatureContext featureContext)
        {
            featureContext.Get<IWebDriver>().Quit();
            featureContext.Clear();
        }

        [AfterTestRun]
        public static void CleanUpReport()
        {
            extentReports.Flush();
        }
    }
}
