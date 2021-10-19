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
    public class RegistratioFormTest : BaseTest
    {
     
        [Test]
        public static void TestRegistrationForm()
        {
            RegistrationFormPage _registrationFormPage = new RegistrationFormPage(Driver);
            string firstValue = "Julija";
            string secondValue = "Ziniene";
            string thirdValue = "varnaite.j@gmail.com";
            string fourthValue = "varnaite.j@gmail.com";
            string fithValue = "12345678";
            string sixthValue = "123456789";

            _registrationFormPage.NavigateToDefaultPage();
            _registrationFormPage.ClickOnRegistrationButtonToStartRegistration();
            _registrationFormPage.InsertAllValuestoRegistrationForm(firstValue, secondValue, thirdValue, fourthValue, fithValue, sixthValue);
            _registrationFormPage.ClickOnRegistrationSendButton();
        }

        [TestCase("Julija", "Ziniene", "varnaite.j@gmail.com", "varnaite.j@gmail.com", "12345678", "123456789", "Nesutampa slaptažodžiai", TestName = "Julija, Ziniene, varnaite.j@gmail.com, varnaite.j@gmail.com, 12345678, 123456789")]
        public static void TestRegistration(string firstValue, string secondValue, string thirdValue, string fourthValue, string fithValue, string sixthValue, string expectedResult)
        {
            RegistrationFormPage _registrationFormPage = new RegistrationFormPage(Driver);

            _registrationFormPage.NavigateToDefaultPage();
            _registrationFormPage.ClickOnRegistrationButtonToStartRegistration();
            _registrationFormPage.InsertAllValuestoRegistrationForm(firstValue, secondValue, thirdValue, fourthValue, fithValue, sixthValue);
            _registrationFormPage.ClickOnRegistrationSendButton();
            _registrationFormPage.VerifyResult(expectedResult);
        }
    }
}
