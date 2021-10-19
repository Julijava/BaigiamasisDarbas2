using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas2.Page
{
    public class RegistrationFormPage : BasePage
    {
        private const string _pageAddress = "https://store.porsche.lt/";
        private IWebElement _registrationButton => Driver.FindElement(By.CssSelector("#top > div.page-wrap > div.fixed-header > header > div > div > div.header__nav > div.header__nav__inner > nav:nth-child(2) > div:nth-child(3) > a"));
        private IWebElement _firstNameInput => Driver.FindElement(By.Id("frm-registerControl-createForm-firstName"));
        private IWebElement _lastNameInput => Driver.FindElement(By.Id("frm-registerControl-createForm-lastName"));
        private IWebElement _emailInput => Driver.FindElement(By.Id("frm-registerControl-createForm-email"));
        private IWebElement _email2Input => Driver.FindElement(By.Id("frm-registerControl-createForm-email2"));
        private IWebElement _passInput => Driver.FindElement(By.Id("frm-registerControl-createForm-userPass"));
        private IWebElement _pass2Input => Driver.FindElement(By.Id("frm-registerControl-createForm-userPass2"));
        private IWebElement _registrationSendButton => Driver.FindElement(By.Name("send"));
        private IWebElement _registrationFormResult => Driver.FindElement(By.Id("frm-registerControl-createForm-userPass2-error"));


        public RegistrationFormPage(IWebDriver webDriver) : base(webDriver) { }
        public RegistrationFormPage NavigateToDefaultPage()
        {
            if (Driver.Url != _pageAddress)
            {
                Driver.Url = _pageAddress;
            }
            return this;
        }
       
        public void ClickOnRegistrationButtonToStartRegistration()
        {
            _registrationButton.Click();
        }

        public void InsertAllValuestoRegistrationForm(string firstValue, string secondValue, string thirdValue, string fourthValue, string fithValue, string sixthValue)
        {
            InsertTextToFirstNameInputField(firstValue);
            InsertTextToLastNameInputField(secondValue);
            InsertTextToEmailInputField(thirdValue);
            InsertTextToEmail2InputField(fourthValue);
            InsertTextToPassInputField(fithValue);
            InsertTextToPass2InputField(sixthValue);
        }

                private void InsertTextToFirstNameInputField(string firstValue)
        {
            _firstNameInput.Clear();
            _firstNameInput.Click();
            _firstNameInput.SendKeys(firstValue);
        }
                private void InsertTextToLastNameInputField(string secondValue)
        {
            _lastNameInput.Clear();
            _lastNameInput.Click();
            _lastNameInput.SendKeys(secondValue);
        }
                private void InsertTextToEmailInputField(string thirdValue)
        {
            _emailInput.Clear();
            _emailInput.Click();
            _emailInput.SendKeys(thirdValue);
        }
                private void InsertTextToEmail2InputField(string fourthValue)
        {
            _email2Input.Clear();
            _email2Input.Click();
            _email2Input.SendKeys(fourthValue);
        }
                private void InsertTextToPassInputField(string fithValue)
        {
            _passInput.Clear();
            _passInput.Click();
            _passInput.SendKeys(fithValue);
        }
        private void InsertTextToPass2InputField(string sixthValue)
        {
            _pass2Input.Clear();
            _pass2Input.Click();
            _pass2Input.SendKeys(sixthValue);
        }
        public void ClickOnRegistrationSendButton()
        {
            _registrationSendButton.Click();
        }

        public void VerifyResult(string result)
        {
            Assert.AreEqual(result, _registrationFormResult.Text, "Sutampa slaptazodziai");
        }
    }
}
