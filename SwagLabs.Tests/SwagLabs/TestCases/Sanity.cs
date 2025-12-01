using NUnit.Framework;
using SwagLabs.Tests.SwagLabs.Utilities;
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
        [Test]
        public void Test01()
        {
           Thread.Sleep(2000);
        }
    }
}
