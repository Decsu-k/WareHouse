using Microsoft.Azure.Documents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FinalProjectTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGoodLogin()
        {
            User oUser = new User();
            Assert.AreEqual(true, oUser.Login("User1", "123"), "admin/admin should be a good login");
        }
    }
}
