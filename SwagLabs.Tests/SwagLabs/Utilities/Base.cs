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
        protected static IWebDriver driver;

        //Pages
        public static LoginPage loginPage;
		public static HomePage homePage;
		public static CartPage cartPage;

	}
}
