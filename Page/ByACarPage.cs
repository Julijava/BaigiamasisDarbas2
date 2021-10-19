using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas2.Page
{
    public class ByACarPage : BasePage
    {
        private const string _pageAddress = "https://porsche.lt/";

        private IWebElement _aboutButton => Driver.FindElement(By.Id("about"));
        private IWebElement _chooseModelButton => Driver.FindElement(By.Id("s_model_selection_x_911_x__992440NC13"));
        private IWebElement _chooseColorButton => Driver.FindElement(By.Id("s_exterieur_x_FH2"));
        private IWebElement _suvestineButton => Driver.FindElement(By.Id("navigation_main_x_mainsuboffer_x_myPorsche"));
        private IWebElement _sugeneruotiKodaButton => Driver.FindElement(By.Id("s_navigation_main_desktop_x_s_navigation_main_desktop_x_showSavePorscheCodeDialog"));
        private IWebElement _getCodeResult => Driver.FindElement(By.CssSelector("#savePorscheCodeDialog > div > div.header-bar > div.header"));

        public ByACarPage(IWebDriver webDriver) : base(webDriver) { }

        public ByACarPage NavigateToDefaultPage()
        {
            if (Driver.Url != _pageAddress)
            {
                Driver.Url = _pageAddress;
            }
            
            return this;
        }
      
        public void ClickOnAboutButtonToStartChooseModel()
        {
            _aboutButton.Click();
        }
        public void ClickOnChooseModelButton()
        {
            _chooseModelButton.Click();
        }
        public void ClickOnChooseColorButton()
        {
            _chooseColorButton.Click();
        }
        public void ClickOnSuvestineButton()
        {
            _suvestineButton.Click();
        }
        public void ClickOnSugeneruotiKodaButton()
        {
            _sugeneruotiKodaButton.Click();
        }
        public void VerifyResult(string result)
        {
            Assert.AreEqual(result, _getCodeResult.Text, "Code is not correct");
        }
    }
}
