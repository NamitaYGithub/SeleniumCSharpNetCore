using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    public class MortgagesFinancingPage
    {
        private IWebDriver Driver;

        public MortgagesFinancingPage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement morgagesSubnavLink => Driver.FindElement(By.XPath("(//a[@data-parent-nav='buy'])[6]"));
        IWebElement exploreElement => Driver.FindElement(By.XPath("//button[@data-testid='HeroBanner__Button']"));
        IWebElement calculateNowButton => Driver.FindElement(By.XPath("(//a[@target='_blank'])[1]"));
        IWebElement depositTextBox => Driver.FindElement(By.XPath("//input[@inputmode='numeric']"));
        IWebElement depositNextButton => Driver.FindElement(By.XPath("//button[@data-testid='next-step']"));
        IWebElement annualIncomeTextBox => Driver.FindElement(By.XPath("//input[@name='annualIncome']"));
        IWebElement incomeNextButton => Driver.FindElement(By.XPath("//button[@data-testid='next-step']"));
        IWebElement mortgageTermSlider => Driver.FindElement(By.XPath("//div[@aria-valuenow='25']"));
        IWebElement mortgageTermNextButton => Driver.FindElement(By.XPath("//button[@data-testid='next-step']"));
        IWebElement interestRateTextBox => Driver.FindElement(By.XPath("//input[@name='interestRate']"));
        IWebElement calculateButton => Driver.FindElement(By.XPath("//button[@data-testid='next-step']"));


        public void MortgagesSubNavLink() => morgagesSubnavLink.Click();
        public void ClickExplore() => exploreElement.Click();
        public void ClickCalculateNowButton() => calculateNowButton.Click();
        public void EnterDeposit(string deposit)
        {

            Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            Assert.IsTrue(Driver.WindowHandles.Count.Equals(2));
            depositTextBox.Click();
            depositTextBox.SendKeys(deposit);

        }

        public void ClickDepositNextButton() => depositNextButton.Click();
        public void EnterAnnualIncome(string annualIncome)
        {
            annualIncomeTextBox.Click();
            annualIncomeTextBox.SendKeys(annualIncome);
        }
        public void ClickIncomeNextButton() => incomeNextButton.Click();
        public void SelectMortgageTermSlider() => mortgageTermSlider.Click();
        public void ClickMortgageTermNextButton() => mortgageTermNextButton.Click();
        public void EnterInterestRateTextBox(string interestRate)
        {
            interestRateTextBox.Click();
            interestRateTextBox.SendKeys(interestRate);
        }

        public void SelectCalculateButton() => calculateButton.Click();








    }
}
