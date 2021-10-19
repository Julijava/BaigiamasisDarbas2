using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas2.Page
{
    public class EShopPage : BasePage
    {
        private const string _pageAddress = "https://store.porsche.lt/";
        private IWebElement _specialusPasiulymaiButton => Driver.FindElement(By.CssSelector("#top > div.page-wrap > div.fixed-header > header > div > div > div.header__nav > div.header__nav__inner > nav:nth-child(1) > div:nth-child(5)"));
        private IWebElement _chooseProductButton => Driver.FindElement(By.CssSelector("#top > div > div.container > div > div:nth-child(6) > div > a > div > picture > img"));
        private IWebElement _addToBasketButton => Driver.FindElement(By.CssSelector("#frm-addToCart-baseForm > div.product-detail__actions > button"));

        // _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        private IWebElement _clickOnBasketButton => Driver.FindElement(By.CssSelector("#snippet--cart > a > span.icon-box.icon-box--fullwidth"));
        private IWebElement _clickOnMokejimasButton => Driver.FindElement(By.CssSelector("#top > div > div.container > div.row > div.col.col--lgUp.col--cart-content > div.form-actions.form-actions--reverse > a.btn.btn-secondary.btn-icon-left"));
        private IWebElement _testiBeRegistracijosButton => Driver.FindElement(By.CssSelector("#top > div > div.container.checkout-login > div.row.checkout-login__grid.ie-flexbox-height-fix > div:nth-child(2) > a"));
        
        private IWebElement _fillTestiButton => Driver.FindElement(By.CssSelector(".Mb\\(0\\) .custom-control-label"));
        private IWebElement _radioButton => Driver.FindElement(By.CssSelector(".row--gap-medium:nth-child(1) > .col:nth-child(1)"));
        private IWebElement _submitButton => Driver.FindElement(By.CssSelector(".btn-secondary"));
        private IWebElement _registrationResult => Driver.FindElement(By.Id("frm-addresses-form-payment-name-error"));

        public EShopPage(IWebDriver webDriver) : base(webDriver) { }
        public EShopPage NavigateToDefaultPage()
        {
            if (Driver.Url != _pageAddress)
            {
                Driver.Url = _pageAddress;
            }
            return this;
        }
       
        public void ClickOnSpecialusPasiulymai()
        {
            _specialusPasiulymaiButton.Click();
        }
        public void ClickOnChooseProductButton()
        {
            _chooseProductButton.Click();
        }
        public void ClickOnAddToBasketButton()
        {
            _addToBasketButton.Click();
        }


        public void ClickOnBasketButton()
        {
            _clickOnBasketButton.Click();
        }
        public void ClickOnMokejimaiButton()
        {
            _clickOnMokejimasButton.Click();
        }
        public void ClickOnTestiBeRegistracijosButton()
        {
            _testiBeRegistracijosButton.Click();
        }
        public void ClickOnFillTestiButton()
        {
            _fillTestiButton.Click();
        }
        public void ClickOnRadioButton()
        {
            _radioButton.Click();
        }
        public void ClickOnSubmitButton()
        {
            _submitButton.Click();
        }
        public void VerifyResult(string result)
        {
            Assert.AreEqual(result, _registrationResult.Text, "Registration is succsessful");
        }
    }
}
