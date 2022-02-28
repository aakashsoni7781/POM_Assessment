using NUnit.Framework;
using Pom2.BaseClass;
using Pom2.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pom2.TestScripts
{
    [TestFixture]
    public class Module1 : BaseTest
    {
        [Test]
        public void TestMethod1()
        {

            var firstpage = new FirstPage(driver);
            var secondpage = firstpage.NavigateToSecondPage();
            secondpage.NavigateToThirdPage();
            Thread.Sleep(4000);
        }
    }
}
