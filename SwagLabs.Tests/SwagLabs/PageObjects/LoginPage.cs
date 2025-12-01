using OpenQA.Selenium;
using SwagLabs.Tests.SwagLabs.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Tests.SwagLabs.PageObjects
{
	internal class LoginPage : CommonOps
	{		
		public IWebElement txt_username => driver.FindElement(By.Id("user-name"));
		public IWebElement txt_password => driver.FindElement(By.Id("password"));
		public IWebElement btn_submit => driver.FindElement(By.Id("login-button"));

	}
}
		
