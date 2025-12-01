using NUnit.Framework;
using SwagLabs.Tests.SwagLabs.Utilities;
using SwagLabs.Tests.SwagLabs.WorkFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SwagLabs.Tests.SwagLabs.TestCases
{
    [TestFixture]
    internal class Sanity : CommonOps
    {
        [Test(Description ="This Test Login Action")]
        public void Test01_LoginAction()
        {
            UiFlows.LoginAction("standard_user", "secret_sauce");
        }
		[Test(Description = "This Test Login Action")]
		public void Test02_LoginAction()
		{
			UiFlows.LoginAction("locked_out_user", "secret_sauce");
		}
	}
}
