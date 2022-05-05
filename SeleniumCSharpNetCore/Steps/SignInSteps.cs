using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumCSharpNetCore.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumCSharpNetCore.Steps
{

    [Binding]
    public class SignInSteps
    {

        private DriverHelper _driverHelper;
        LoginPage loginPage;


        public SignInSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            loginPage = new LoginPage(_driverHelper.Driver);
        }


        [Given(@"I launch the RightMove")]
        public void GivenILaunchTheRightMove()
        {
            _driverHelper.Driver.Navigate().GoToUrl("https://www.rightmove.co.uk/");

            Assert.AreEqual("Rightmove - UK's number one property website for properties for sale and to rent", _driverHelper.Driver.Title);
        }

        [Given(@"I accept the cookies")]
        public void GivenIAcceptTheCookies()
        {
            loginPage.AcceptCookies();
        }


        [Given(@"I Select Sign In")]
        public void GivenISelectSignIn()
        {
            loginPage.ClickSigninTab();
        }

        [Given(@"I enter Email Address and password")]
        public void GivenIEnterEmailAddressAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterUserNameAndPassword(data.EmailAddress, data.Password);
        }

        [Given(@"I select SignIn button")]
        public void GivenISelectSignInButton()
        {
            loginPage.SigninButton();

        }



    }
}
