using NUnit.Framework;
using SeleniumCSharpNetCore.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumCSharpNetCore.Steps
{
    [Binding]
    public class FindPropertyForSaleSteps

    {
        private DriverHelper _driverHelper;
        BuyPage buyPage;
        MortgagesFinancingPage mortgagesFinancingPage;

        public FindPropertyForSaleSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;

            buyPage = new BuyPage(_driverHelper.Driver);
            mortgagesFinancingPage = new MortgagesFinancingPage(_driverHelper.Driver);

        }
        [Given(@"I select the ViewMyRightMove window")]
        public void GivenICloseTheViewMyRightMoveWindow()
        {
            buyPage.ClickViewMyRightMove();
        }

        [Given(@"I select Buy navbar")]
        public void GivenISelectBuyNavbar()
        {
            buyPage.SelectBuyNavBar();
        }

        [Given(@"I select property for sale")]
        public void GivenISelectPropertyForSale()
        {
            buyPage.SelectPropertyForSaleSubNavLink();
        }

        [Given(@"I enter the location (.*)")]
        public void GivenIEnterTheLocationLocation(string location)
        {
            buyPage.EnterLocation(location);
        }

        [Given(@"select start search button")]
        public void GivenSelectStartSearchButton()
        {
            buyPage.SelectSearchButton();
        }

        [Given(@"select the search radius (.*)")]
        public void GivenSelectTheSearchRadiusSearchRadius(string SearchRadius)
        {
            buyPage.SelectsearchRadiusOption(SearchRadius);
        }

        [Given(@"select the min price range £(.*)")]
        public void GivenSelectTheMinPriceRange(string minprice)
        {
            buyPage.SelectMinPriceRange(minprice);
        }

        [Given(@"select the max price range £(.*)")]
        public void GivenSelectTheMaxPriceRange(string maxprice)
        {
            buyPage.SelectMaxPriceRange(maxprice);
        }


        [Given(@"select no\. of beds (.*)")]
        public void GivenSelectNo_OfBedsMaxnoOfBeds(string maxnoOfBeds)
        {
            buyPage.SelectMaxnoOfBeds(maxnoOfBeds);
        }

        [Given(@"select the property type (.*)")]
        public void GivenSelectThePropertyTypePropertyType(string propertyType)
        {
            buyPage.SelectPropertyType(propertyType);
        }

        [Given(@"select the find properties button")]
        public void GivenSelectTheFindPropertiesButton()
        {
            buyPage.SelectFindProperties();
        }

        [Given(@"I select mortgages navbar")]
        public void GivenISelectMortgagesNavbar()
        {
            mortgagesFinancingPage.MortgagesSubNavLink();
        }

        [Given(@"I select calculate now button")]
        public void GivenISelectCalculateNowButton()
        {
            mortgagesFinancingPage.ClickCalculateNowButton();
        }

        [Given(@"I eneter deposit (.*)")]
        public void GivenIEneterDeposit(string deposit)
        {
            mortgagesFinancingPage.EnterDeposit(deposit);
            Assert.AreEqual("Mortgage Calculator | Financing your new home | Rightmove", _driverHelper.Driver.Title);
        }

        [Given(@"I select next")]
        public void GivenISelectNext()
        {
            mortgagesFinancingPage.ClickDepositNextButton();
        }

        [Given(@"I enter the annual income (.*)")]
        public void GivenIEnterTheAnnualIncome(string annualIncome)
        {
            mortgagesFinancingPage.EnterAnnualIncome(annualIncome);
        }
        [Given(@"I select income next")]
        public void GivenISelectIncomeNext()
        {
            mortgagesFinancingPage.ClickIncomeNextButton();
        }
        [Given(@"I select mortgage term slider")]
        public void GivenISelectMortgageTermSlider()
        {
            mortgagesFinancingPage.SelectMortgageTermSlider();
        }

        [Given(@"I select term next button")]
        public void GivenISelectTermNextButton()
        {
            mortgagesFinancingPage.ClickMortgageTermNextButton();
        }


        [Given(@"I enter the interest rate (.*)")]
        public void GivenIEnterTheInterestRate(string InterestRate)
        {
            mortgagesFinancingPage.EnterInterestRateTextBox(InterestRate);
        }



        [Given(@"I select caculate button")]
        public void GivenISelectCaculateButton()
        {
            mortgagesFinancingPage.SelectCalculateButton();
        }











    }
}
