using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.Extensions;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SwagLabs.Tests.SwagLabs.Utilities
{
    internal class CommonOps : Base
    {
		public static string GetData(string nodeName)
		{
			string configFilePath = Path.Combine(baseDirectory, "SwagLabs", "Configuration", "config.xml");
			XDocument doc = XDocument.Load(configFilePath);
			return doc.Descendants(nodeName).FirstOrDefault()?.Value;
		}
		[OneTimeSetUp]
		public static void StartSession()
		{
			InitReport();
			InitBrowser(GetData("Browser"));
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl(GetData("URL"));
			ManagePages.InitPages();
		}

		[OneTimeTearDown]
		public static void ClosseSession()
		{
			extent.Flush();
			extent.Close();
			driver.Quit();

		}
		public static void InitBrowser(string browserType)
		{
			switch (browserType.ToLower())
			{
				case "chrome":
					driver = new ChromeDriver();
					break;
				case "firefox":
					driver = new FirefoxDriver();
					break;
				default:
					throw new NotSupportedException($"Browser type '{browserType}' is not supported.");
			}	
		}

		//Report Methods
		public static void InitReport()
		{
			reportsPath = Path.Combine(baseDirectory, "SwagLabs", "Reports",timeStemp);
			Directory.CreateDirectory(reportsPath);
			extent = new ExtentReports(reportsPath + @"/report.html");
		}
		[SetUp]
		public void BeforeTest()
		{
			test = extent.StartTest(TestContext.CurrentContext.Test.Name, TestContext.CurrentContext.Test.Properties.Get("Description").ToString());
		}
		[TearDown]
		public void AfterTest()
		{
			extent.EndTest(test);
		}
		public static void ReportSucsses(string description)
		{
			Console.WriteLine(description);
			test.Log(LogStatus.Pass, description);
		}
		public static void ReportFail(string description)
		{
			Console.WriteLine(description);
			string screenshotPath = saveScreenShots();
			test.Log(LogStatus.Fail, description + test.AddScreenCapture(screenshotPath));
			Assert.Fail(description);
		}

		public static string saveScreenShots()
		{
			string testName = test.GetTest().Name.ToString();
			test.Log(LogStatus.Info, "Save Screenshot for: " + testName);
			Directory.CreateDirectory(reportsPath + @"\screenshots\");
			string location = reportsPath + @"\ScreenShots\" + testName + ".png";
			test.Log(LogStatus.Info, "Save location is: " + location);

			try
			{
				driver.TakeScreenshot().SaveAsFile(location);
				test.Log(LogStatus.Pass, "Save sucsses!");
			}
			catch (Exception e)
			{
				test.Log(LogStatus.Fail, "Save Failed see: " + e.Message);
			}
			string reletiveScreenhots = @"ScreenShots\" + testName + ".png";
			test.Log(LogStatus.Info, "Reletive Screenhots is: " + reletiveScreenhots);
			return reletiveScreenhots;
		}
	}
}
