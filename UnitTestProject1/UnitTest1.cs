using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            User oUser = new User();
            Assert.AreEqual(true, oUser.LoginScreen("User1", "123"), "admin/admin should be a good login");
        }
    }
}
