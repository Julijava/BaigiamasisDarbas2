using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas2.Page
{
    public class UsedCarPage : BasePage
    {
        private const string _pageAddress = "https://finder.porsche.com/lt/lt_LT/search/list";
        private IWebElement _automobiliuPasiulymaiButton => Driver.FindElement(By.CssSelector("#root > main > div > div.pui-mt--6 > div:nth-child(2) > div.sc-ArjOu.chGsuE > section > div > div > div:nth-child(4)"));
        private IWebElement _checkBoxButton => Driver.FindElement(By.CssSelector("#root > main > div > div > section > div > div > div:nth-child(1) > div.expansionPanel_expansion-panel__2kkja > div > div:nth-child(2) > div > div:nth-child(2) > p-checkbox-wrapper > span > span.sc-bdnylx.jACvsA.sc-gSYCTC.fkCSEE"));
        private IWebElement _chooseUsedModel => Driver.FindElement(By.CssSelector("#root > main > div > div > div:nth-child(2) > div.sc-ArjOu.chGsuE > section > div > div.pui-flex.pui-flex--wrap.pui-m-nl--12.pui-m-nr--12 > div:nth-child(1)"));
        private IWebElement _findModel => Driver.FindElement(By.CssSelector("#root > main > div > section > div > div > button > i"));
        private IWebElement _findCarResult => Driver.FindElement(By.CssSelector("#root > main > div > section > div > div > div:nth-child(1)"));
        public UsedCarPage(IWebDriver webDriver) : base(webDriver) { } 

        public UsedCarPage NavigateToDefaultPage()
        {
            if (Driver.Url != _pageAddress)
            {
                Driver.Url = _pageAddress;
            }
            return this;
        }

        public void ClickOnAutomobiliuPasiulymaiButton()
        {
            _automobiliuPasiulymaiButton.Click();
        }
        public void ClickOnCheckBoxButton()
        {
            _checkBoxButton.Click();
        }
        public void ClickOnChooseUsedModel()
        {
            _chooseUsedModel.Click();
        }
        public void ClickOnFindModel()
        {
            _findModel.Click();
        }
        public void VerifyResult(string result)
        {
            Assert.IsTrue(_findCarResult.Text.Contains(result), $"Result is not the same. Expected result is {result}, but was {_findCarResult.Text}");
        }
    }
}
