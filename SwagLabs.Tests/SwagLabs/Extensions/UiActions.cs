using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
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
				test.Log(LogStatus.Pass, "Click Sucssesfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Click Failed: " + e.Message);
				test.Log(LogStatus.Fail, "Click Failed: " + e.Message);
			}
            
        }
		public static void UpdateText(IWebElement elem, string text)
		{
			try
			{
				elem.SendKeys(text);
				ReportSucsses("Text Update Sucssesfully!");
			}
			catch (Exception e)
			{
				ReportFail("Text Update Failed: " + e.Message);
			}
		}
		public static void SelectDropDown(IWebElement elem, string text)
		{
			try
			{
				SelectElement dropDown = new SelectElement(elem);
				dropDown.SelectByText(text);
				ReportSucsses("Drop Down Update Sucssesfully!");
			}
			catch (Exception e)
			{
				ReportFail("Drop Down Update Failed: " + e.Message);
			}
		}
		public static void SelectDropDown(IWebElement elem, int index)
		{
			try
			{
				SelectElement dropDown = new SelectElement(elem);
				dropDown.SelectByIndex(index);
				ReportSucsses("Drop Down Update Sucssesfully!");
			}
			catch (Exception e)
			{
				ReportFail("Drop Down Update Failed: " + e.Message);
				
			}
		}
		public static int GetListCount(IList<IWebElement> elems)
		{
			try
			{
				int count = elems.Count();
				ReportSucsses("Count Elements Sucssesfully!");
				return count;
			}
			catch (Exception e)
			{
				ReportFail("Count Elements Failed: " + e.Message);
				return 0;
			}
			
		}
		
	}
}
