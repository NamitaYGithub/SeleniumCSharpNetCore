using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    public class LoginPage
    {
        private IWebDriver Driver;
        private const string LoginUrl = "https://www.rightmove.co.uk/";

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }



        IWebElement acceptAllCookies => Driver.FindElement(By.XPath("(//button[@title='Allow all cookies'])[1]"));
        IWebElement emailAddTextBox => Driver.FindElement(By.XPath("//input[@id='email-input']"));
        IWebElement passwordTextBox => Driver.FindElement(By.XPath("//input[@name='password']"));
        IWebElement tabSignin => Driver.FindElement(By.XPath("//span[@class='user-text sign-in-link']"));
        IWebElement signInButton => Driver.FindElement(By.XPath("//button[@id='submit']"));
        IWebElement viewMyRightmoveElement => Driver.FindElement(By.XPath("(//a[@target='_top'])[2]"));


        public void NavigateToURL()
        {
            Driver.Navigate().GoToUrl(LoginUrl);
        }

        public void AcceptCookies()
        {
            System.Threading.Thread.Sleep(3000);
            acceptAllCookies.Click();
        }
        public void ClickSigninTab()
        {
            tabSignin.Click();
        }
        public void EnterUserNameAndPassword(string emailAddress, string password)
        {
            emailAddTextBox.SendKeys(emailAddress);
            passwordTextBox.SendKeys(password);

        }
        public void SigninButton()
        {
            signInButton.Click();
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(viewMyRightmoveElement.Displayed);
        }


    }
}
