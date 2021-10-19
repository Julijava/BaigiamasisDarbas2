using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas2.Page
{
    public class SearchPage : BasePage
    {
        private const string PageAddress = "https://store.porsche.lt/";
        private IWebElement _searchField => Driver.FindElement(By.Id("frm-search-form-search"));
        private IWebElement _searchButtonSubmit => Driver.FindElement(By.CssSelector("#frm-search-form > div.form-group.form-group--inline > div > div > div > button > span > svg"));
        private IWebElement _searchButtonSubmit3 => Driver.FindElement(By.CssSelector("h1"));
        private IWebElement _searchResult => Driver.FindElement(By.CssSelector("#top > div > div.container > h1"));

        public SearchPage(IWebDriver webDriver) : base(webDriver) { } 

        public SearchPage NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
            return this;
        }
       
        public void InsertValueToSearchField(string value)
        {
            InsertTextToSearchField(value);
        }
        private void InsertTextToSearchField(string value)
        {
            _searchField.Click();
            _searchField.Clear();
            _searchField.SendKeys(value);
        }
        public void ClickOnSearchButtonSubmit()
        {
            _searchButtonSubmit.Click();
        }
        public void ClickOnSearchButtonSubmit3()
        {
            _searchButtonSubmit3.Click();
        }
        public void VerifyResult(string result)
        {
            Assert.IsTrue(_searchResult.Text.Contains(result), $"Result is not the same. Expected result is {result}, but was {_searchResult.Text}");
        }
    }
}
