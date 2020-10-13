using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium_Demo
{
    class Selenium_Demo
    {
        String test_url = "http://prelive.aptimea.com/";

        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            // Local Selenium WebDriver
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }



        [Test]
        public void test1()
        {
            driver.Url = test_url;

            System.Threading.Thread.Sleep(2000);

            driver.Navigate().GoToUrl("http://prelive.aptimea.com/form/questionnaire");

            

            IWebElement btn = driver.FindElement(By.CssSelector(".eu-cookie-compliance-secondary-button"));
            btn.Click();
            IWebElement radio1 = driver.FindElement(By.Id("edit-je-suis-0"));
            radio1.Click();
            SelectElement select = new SelectElement(driver.FindElement(By.Id("edit-je-suis-ne-e-en-annee-year")));
            int i = 5;
            select.SelectByIndex(i);
            IWebElement radio2 = driver.FindElement(By.Id("edit-je-fais-du-sport-chaque-semaine-0"));
            radio2.Click();
            IWebElement radio3 = driver.FindElement(By.Id("edit-je-suis-2-0"));
            radio3.Click();
            IWebElement text1 = driver.FindElement(By.CssSelector("[name = 'mes_traitements_medicaux_sont']"));
            text1.SendKeys("None");
            IWebElement text2 = driver.FindElement(By.CssSelector("[name='user_weight']"));
            text2.SendKeys("68");
            IWebElement text3 = driver.FindElement(By.CssSelector("[name='user_height']"));
            text3.SendKeys("183");
            IWebElement radio4 = driver.FindElement(By.Id("edit-je-vis-0"));
            radio4.Click();
            IWebElement text4 = driver.FindElement(By.CssSelector("[name='j_ai_enfants_nombre_']"));
            text4.SendKeys("0");
            IWebElement radio5 = driver.FindElement(By.Id("edit-patient-goals-28"));
            radio5.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement btn2 = driver.FindElement(By.Id("edit-wizard-next"));
            btn2.Submit();
            System.Threading.Thread.Sleep(2000);
            IWebElement radio6 = driver.FindElement(By.Id("edit-fatigue-surtout-matinale-difficultes-a-demarrer-1--eO-CN2r4S_k"));
            radio6.Click();
            System.Threading.Thread.Sleep(1000000);

            Console.WriteLine("Test Passed");
        }


        [TearDown]
        public void close_Browser()
        {
            //driver.Quit();
        }
    }
}