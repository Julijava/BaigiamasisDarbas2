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
    public class EShopTest : BaseTest
    {
        
        [Test]
        public static void TestEShop()
        {
            EShopPage _eShopPage = new EShopPage(Driver);

            _eShopPage.NavigateToDefaultPage();
            _eShopPage.ClickOnSpecialusPasiulymai();
            _eShopPage.ClickOnChooseProductButton();
            _eShopPage.ClickOnAddToBasketButton();
            _eShopPage.ClickOnBasketButton();
            _eShopPage.ClickOnMokejimaiButton();
            _eShopPage.ClickOnTestiBeRegistracijosButton();
            _eShopPage.ClickOnFillTestiButton();
            _eShopPage.ClickOnRadioButton();
            _eShopPage.ClickOnSubmitButton();
        }
        [TestCase("Įveskite savo vardą")]
        public static void TestRegistrationResult(string expectedResult)
        {
            EShopPage _eShopPage = new EShopPage(Driver);

            _eShopPage.NavigateToDefaultPage();
            _eShopPage.ClickOnSpecialusPasiulymai();
            _eShopPage.ClickOnChooseProductButton();
            _eShopPage.ClickOnAddToBasketButton();
            _eShopPage.ClickOnBasketButton();
            _eShopPage.ClickOnMokejimaiButton();
            _eShopPage.ClickOnTestiBeRegistracijosButton();
            _eShopPage.ClickOnFillTestiButton();
            _eShopPage.ClickOnRadioButton();
            _eShopPage.ClickOnSubmitButton();
            _eShopPage.VerifyResult(expectedResult);
        }
    }
}
