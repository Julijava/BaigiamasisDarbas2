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
    public class SearchTest : BaseTest
    {
        
        [Test]
        public static void TestSearchField()
        {
            SearchPage _searchPage = new SearchPage(Driver);
            string value = "Laikrodis";

            _searchPage.NavigateToDefaultPage();
            _searchPage.InsertValueToSearchField(value);
            _searchPage.ClickOnSearchButtonSubmit();
            _searchPage.ClickOnSearchButtonSubmit3();
        }
        [TestCase("Laikrodis", "Laikrodis", TestName = "Laikrodis")]
        public static void TestSearch(string value, string expectedResult)
        {
            SearchPage _searchPage = new SearchPage(Driver);

            _searchPage.NavigateToDefaultPage();
            _searchPage.InsertValueToSearchField(value);
            _searchPage.ClickOnSearchButtonSubmit();
            _searchPage.ClickOnSearchButtonSubmit3();
            _searchPage.VerifyResult(expectedResult);
        }
    }
}
