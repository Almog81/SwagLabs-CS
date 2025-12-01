using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SwagLabs.Tests.SwagLabs.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Tests.SwagLabs.Extensions
{
    internal class UiActions : CommonOps
    {
        public static void Click(IWebElement elem)
        {
            try
            {
                elem.Click();
                Console.WriteLine("Click Sucssesfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Click Failed: " + e.Message);
            }
            
        }
		public static void UpdateText(IWebElement elem, string text)
		{
			try
			{
				elem.SendKeys(text);
				Console.WriteLine("Text Update Sucssesfully!");
			}
			catch (Exception e)
			{
				Console.WriteLine("Text Update Failed: " + e.Message);
				
			}
		}
		public static void SelectDropDown(IWebElement elem, string text)
		{
			try
			{
				SelectElement dropDown = new SelectElement(elem);
				dropDown.SelectByText(text);
				Console.WriteLine("Drop Down Update Sucssesfully!");
			}
			catch (Exception e)
			{
				Console.WriteLine("Drop Down Update Failed: " + e.Message);

			}
		}
		public static void SelectDropDown(IWebElement elem, int index)
		{
			try
			{
				SelectElement dropDown = new SelectElement(elem);
				dropDown.SelectByIndex(index);
				Console.WriteLine("Drop Down Update Sucssesfully!");
			}
			catch (Exception e)
			{
				Console.WriteLine("Drop Down Update Failed: " + e.Message);

			}
		}
		public static int GetListCount(IList<IWebElement> elems)
		{
			try
			{
				int count = elems.Count();
				Console.WriteLine("Count Elements Sucssesfully!");
				return count;
			}
			catch (Exception e)
			{
				Console.WriteLine("Count Elements Failed: " + e.Message);
				return 0;
			}
		}
	}
}
