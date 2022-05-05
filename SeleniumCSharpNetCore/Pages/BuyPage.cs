using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    public class BuyPage
    {
        private IWebDriver Driver;

        public BuyPage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement viewMyRightMoveElement => Driver.FindElement(By.XPath("(//a[@target='_top'])[2]"));
        IWebElement buyNavBar => Driver.FindElement(By.XPath("(//a[@class='seo-nav-link'])[1]"));
        IWebElement propertyForSaleSubNavLink => Driver.FindElement(By.XPath("(//a[@class='seo-nav-subNav-link'])[1]"));
        IWebElement locationTextBox => Driver.FindElement(By.XPath("//input[@id='searchLocation']"));
        IWebElement startSearchButton => Driver.FindElement(By.XPath("//input[@id='search']"));
        IWebElement searchRadiusElement => Driver.FindElement(By.XPath("//select[@id='radius']"));
        IWebElement minPriceRange => Driver.FindElement(By.XPath("//select[@id='minPrice']"));
        IWebElement maxPriceRange => Driver.FindElement(By.XPath("//select[@id='maxPrice']")); 
        IWebElement maxBedrooms => Driver.FindElement(By.XPath("//select[@id='maxBedrooms']")); 
        IWebElement propertyTypeElement => Driver.FindElement(By.XPath("//select[@id='displayPropertyType']")); 
        IWebElement findPropertiesButton => Driver.FindElement(By.XPath("//button[@id='submit']")); 

        public void ClickViewMyRightMove()
        {
            System.Threading.Thread.Sleep(3000);
            viewMyRightMoveElement.Click();
        }
        
        public void SelectBuyNavBar()
        {
            buyNavBar.Click();
        }

        public void SelectPropertyForSaleSubNavLink()
        {
           propertyForSaleSubNavLink.Click();
        }

        public void EnterLocation(string location)
        {
            locationTextBox.Click();
            locationTextBox.SendKeys(location);
        }

        public void SelectSearchButton()
        {
            startSearchButton.Click();
        }

        public void SelectsearchRadiusOption(string searchRadius)
        {
            
            SelectElement element = new SelectElement(searchRadiusElement);
            element.SelectByText(searchRadius);
        }

        public void SelectMinPriceRange(string minprice)
        {
            SelectElement element1 = new SelectElement(minPriceRange);
            element1.SelectByText(minprice);
         }

        public void SelectMaxPriceRange(string maxprice)
        {
            SelectElement element2 = new SelectElement(maxPriceRange);
            element2.SelectByText(maxprice);

        }
        public void SelectMaxnoOfBeds(string maxnoOfBeds)
        {
            SelectElement element3 = new SelectElement(maxBedrooms);
            element3.SelectByText(maxnoOfBeds);
        }
        public void SelectPropertyType(string propertyType)
        {
            SelectElement element4 = new SelectElement(propertyTypeElement);
            element4.SelectByText(propertyType);
        }

        public void SelectFindProperties()
        {
            findPropertiesButton.Click();
        }

    }
}
