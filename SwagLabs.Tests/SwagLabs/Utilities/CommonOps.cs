using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
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
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string configFilePath = Path.Combine(baseDirectory, "SwagLabs", "Configuration", "config.xml");
			XDocument doc = XDocument.Load(configFilePath);
			return doc.Descendants(nodeName).FirstOrDefault()?.Value;
		}
		[OneTimeSetUp]
		public static void StartSession()
		{
			InitBrowser(GetData("Browser"));
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl(GetData("URL"));
			

		}

		[OneTimeTearDown]
		public static void ClosseSession()
		{
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
	}
}
