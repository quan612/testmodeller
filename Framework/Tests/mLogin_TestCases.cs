using NUnit.Framework;
using CuriositySoftware.RunResult.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuriositySoftware.DataAllocation.Engine;
using CuriositySoftware.DataAllocation.Entities;
using CuriositySoftware.RunResult.Entities;
using Utilities;

namespace Tests
{
    [TestFixture]
    public class mLogin_TestCases : TestBase
    {
		

		
       [Test]
        [TestModellerId("4a964944-7721-43ed-9ecd-b73cf4ed9dce")]
        public void GoToUrlEmptyusernameandpassworderror()
        {
        

        pages.Page_Objects _Page_Objects = new pages.Page_Objects(driver);
    TestModellerLogger.SetLastNodeGuid("58bd5de8-881a-44a2-b873-0ac4aeb73983");
    _Page_Objects.GoToUrl();

    TestModellerLogger.SetLastNodeGuid("d6118e2a-35d2-43a3-b410-d64d27c9f77d");
    _Page_Objects.Click_Sign_In();

    TestModellerLogger.SetLastNodeGuid("d6118e2a-35d2-43a3-b410-d64d27c9f77d");
    _Page_Objects.Assert_Password_is_required();

        }

    }
}