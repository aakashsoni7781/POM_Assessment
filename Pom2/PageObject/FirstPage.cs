using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Pom2.PageObjects
{
    public class FirstPage
    {
        IWebDriver driver;

        public FirstPage(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement EnterFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement EnterLastName { get; set; }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement EnterUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Passwd")]
        public IWebElement EnterPswd { get; set; }

        [FindsBy(How = How.Name, Using = "ConfirmPasswd")]
        public IWebElement EnterCnfrPswd { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='VfPpkd-muHVFf-bMcfAe']")]
        public IWebElement ClickShowBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[@class='VfPpkd-vQzf8d'])[2]")]
        public IWebElement ClickNxtBtn { get; set; }

        public SecondPage NavigateToSecondPage()
        {
            EnterFirstName.SendKeys("Aakash");
            EnterLastName.SendKeys("Soni");
            EnterUserName.SendKeys("TPGakash3214");
            EnterPswd.SendKeys("Aakash@3214");
            EnterCnfrPswd.SendKeys("Aakash@3214");
            ClickShowBtn.Click();
            Thread.Sleep(4000);
            ClickNxtBtn.Click();

            return new SecondPage(driver);

        }

    }
}
