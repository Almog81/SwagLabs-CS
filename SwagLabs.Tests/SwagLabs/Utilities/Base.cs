using RelevantCodes.ExtentReports;
using OpenQA.Selenium;
using SwagLabs.Tests.SwagLabs.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Tests.SwagLabs.Utilities
{
    internal class Base
    {
		//Paths
		protected static string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		protected static string timeStemp = Convert.ToDateTime(DateTime.Now).ToString("dd-MM-yyyy_HH-mm-ss");
		protected static string reportsPath;

		protected static IWebDriver driver;
		protected static ExtentReports extent;
		protected static ExtentTest test;


		//Pages
		protected static LoginPage loginPage;
		protected static HomePage homePage;
		protected static CartPage cartPage;

	}
}
