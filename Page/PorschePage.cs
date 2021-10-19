using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas2.Page
{
    public class PorschePage : BasePage
    {
        private const string _pageAddress = "https://store.porsche.lt/";
        public PorschePage(IWebDriver webDriver) : base(webDriver) { }
        public PorschePage NavigateToDefaultPage()
        {
            if (Driver.Url != _pageAddress)
            {
                Driver.Url = _pageAddress;
            }
            return this;
        }

        public PorschePage AcceptCookies()
        {
            Cookie newCookie = new Cookie("cookies-state",
                "accepted",
                "store.porsche.lt",
                "/",
                DateTime.Now.AddDays(5));

            Driver.Manage().Cookies.AddCookie(newCookie);
            Driver.Navigate().Refresh();

                return this;

        }
    }
}
