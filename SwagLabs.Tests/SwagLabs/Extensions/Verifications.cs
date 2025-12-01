using NUnit.Framework;
using OpenQA.Selenium;
using SwagLabs.Tests.SwagLabs.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Tests.SwagLabs.Extensions
{
    internal class Verifications : CommonOps
    {
        public static void VerifyEquals(int expected,  int actual)
        {
            try
            {
				Assert.That(expected, Is.EqualTo(actual));
                Console.WriteLine("Verification Passed!");
			}
            catch(Exception e) 
            {
                Console.WriteLine("Verification Failed: " + e.Message);
            }  
        }
		public static void VerifyEquals(string expected, string actual)
		{
			try
			{
				Assert.That(expected, Is.EqualTo(actual));
				Console.WriteLine("Verification Passed!");
			}
			catch (Exception e)
			{
				Console.WriteLine("Verification Failed: " + e.Message);
			}
		}
		public static void VerifyElementText(IWebElement elem, string expected)
		{
			try
			{
				Assert.That(elem.Text, Is.EqualTo(expected));
				Console.WriteLine("Verification Passed!");
			}
			catch (Exception e)
			{
				Console.WriteLine("Verification Failed: " + e.Message);
			}
		}
		public static void VerifyElementDisplayed(IWebElement elem)
		{
			try
			{
				Assert.That(elem.Displayed, Is.True);
				Console.WriteLine("Verification Passed!");
			}
			catch (Exception e)
			{
				Console.WriteLine("Verification Failed: " + e.Message);
			}
		}
	}
}
