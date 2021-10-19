using BaigiamasisDarbas2.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas2.Tests
{
    public class UsedCarTest : BaseTest
    {
    
        [Test]
        public static void TestUsedCar()
        {
            UsedCarPage _usedCarPage = new UsedCarPage(Driver);

            _usedCarPage.NavigateToDefaultPage();
            _usedCarPage.ClickOnAutomobiliuPasiulymaiButton();
            _usedCarPage.ClickOnCheckBoxButton();
            _usedCarPage.ClickOnChooseUsedModel();
            _usedCarPage.ClickOnFindModel();
        }
        [TestCase("17 Porsche rasti")]
        public static void TestUsedCarResult(string expectedResult)
        {
            UsedCarPage _usedCarPage = new UsedCarPage(Driver);

            _usedCarPage.NavigateToDefaultPage();
            _usedCarPage.ClickOnAutomobiliuPasiulymaiButton();
            _usedCarPage.ClickOnCheckBoxButton();
            _usedCarPage.ClickOnChooseUsedModel();
            _usedCarPage.ClickOnFindModel();
            _usedCarPage.VerifyResult(expectedResult);
        }
    }
}
