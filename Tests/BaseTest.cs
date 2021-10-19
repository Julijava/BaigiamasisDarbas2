using BaigiamasisDarbas2.Drivers;
using BaigiamasisDarbas2.Page;
using BaigiamasisDarbas2.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
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
    public class BaseTest
    {
        protected static IWebDriver Driver;

        public static ByACarPage _byACarPage;
        public static EShopPage _eShopPage;
        public static RegistrationFormPage _registrationFormPage;
        public static SearchPage _searchPage;
        public static UsedCarPage _usedCarPage;
        public static PorschePage _porschePage;

        [OneTimeSetUp]
        [Test]
        public static void SetUp()
        {
            Driver = CustomDriver.GetIncognitoChromeDriver();
            _byACarPage = new ByACarPage(Driver);
            _eShopPage = new EShopPage(Driver);
            _registrationFormPage = new RegistrationFormPage(Driver);
            _searchPage = new SearchPage(Driver);
            _usedCarPage = new UsedCarPage(Driver);
            _porschePage = new PorschePage(Driver);
        }

        [TearDown]
        public static void TearDownAttribute()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(Driver);
            }
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Driver.Quit();
        }
    }
}
