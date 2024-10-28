using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;
using System;

namespace TestEasyFeature
{
    [TestClass]
    public class UnitTest1 : TestBase
    {


        [TestMethod]
        public void TestMethod1()
        {
            var vm = new AViewModel();
            Assert.AreEqual(50, vm.GetValue());
            SettingA.PowerMode = true;
            Assert.AreEqual(100, vm.GetValue());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var vm = new AViewModel();
            Assert.AreEqual(50, vm.GetValue());
            SettingA.PowerMode = true;
            Assert.AreEqual(100, vm.GetValue());
        }
        
    }


}
