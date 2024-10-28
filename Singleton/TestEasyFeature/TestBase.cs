using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEasyFeature
{
    public abstract class TestBase
    {

        [TestInitialize]
        public void TestInitialize()
        {

            SettingA.PowerMode = false;

        }
    }
}
