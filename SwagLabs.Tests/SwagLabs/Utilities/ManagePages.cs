using SwagLabs.Tests.SwagLabs.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Tests.SwagLabs.Utilities
{
    internal class ManagePages : CommonOps
    {
        public static void InitPages() 
        {
            loginPage = new LoginPage();
            homePage = new HomePage();
            cartPage = new CartPage();
        }
    }
}
