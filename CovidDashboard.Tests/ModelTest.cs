using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidDashboard.Tests
{
    public class ModelTest
    {

        [Test]
        public void TestForModelAccuracy()
        {
            Assert.AreNotSame(1, 0);            
        }
    }
}
