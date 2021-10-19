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
    public class ByACarTest : BaseTest
    {
       
        [Test]
        public static void TestByACar()
        {
            ByACarPage _byACarPage = new ByACarPage(Driver);
            _byACarPage.NavigateToDefaultPage();
            _byACarPage.ClickOnAboutButtonToStartChooseModel();
            _byACarPage.ClickOnChooseModelButton();
            _byACarPage.ClickOnChooseColorButton();
            _byACarPage.ClickOnSuvestineButton();
            _byACarPage.ClickOnSugeneruotiKodaButton();
        }
        [TestCase("Jūsų „Porsche“ kodas")]
        public static void TestGetUniqueCode(string expectedResult)
        {
            ByACarPage _byACarPage = new ByACarPage(Driver);
            _byACarPage.NavigateToDefaultPage();
            _byACarPage.ClickOnAboutButtonToStartChooseModel();
            _byACarPage.ClickOnChooseModelButton();
            _byACarPage.ClickOnChooseColorButton();
            _byACarPage.ClickOnSuvestineButton();
            _byACarPage.ClickOnSugeneruotiKodaButton();
            _byACarPage.VerifyResult(expectedResult);
        }
    }
}
