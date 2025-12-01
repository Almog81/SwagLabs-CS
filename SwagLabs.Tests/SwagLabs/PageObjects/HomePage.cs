using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SwagLabs.Tests.SwagLabs.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Tests.SwagLabs.PageObjects
{
    internal class HomePage : CommonOps
    {
		public IWebElement imgg_logo => driver.FindElement(By.ClassName("app_logo"));
		public IList<IWebElement> inventoryItems => driver.FindElements(By.Id("inventory_item"));
		public IWebElement btn_cart => driver.FindElement(By.ClassName("shopping_cart_link"));
		public IWebElement btn_menu => driver.FindElement(By.Id("react-burger-menu-btn"));
		public IWebElement sort => driver.FindElement(By.ClassName("product_sort_container"));
		public SelectElement btn_sort => new SelectElement(sort);

	}

}
