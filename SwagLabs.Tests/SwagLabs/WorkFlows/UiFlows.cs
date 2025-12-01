using SwagLabs.Tests.SwagLabs.Extensions;
using SwagLabs.Tests.SwagLabs.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Tests.SwagLabs.WorkFlows
{
    internal class UiFlows : CommonOps
	{
        public static void LoginAction(string username, string password)
        {
			try
			{
				UiActions.UpdateText(loginPage.txt_username, username);
				UiActions.UpdateText(loginPage.txt_password, password);
				UiActions.Click(loginPage.btn_submit);
				Verifications.VerifyElementDisplayed(homePage.img_logo);
				ReportSucsses("login Sucsses! username: " + username + ", password: " + password);
		}
			catch (Exception e) 
			{
				ReportFail("Failed to log in see: " + e.Message);
	}

}
	}
}
