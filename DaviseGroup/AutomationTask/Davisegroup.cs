using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace AutomationTask
{
   [TestFixture]
    public class Davisegroup
    {
        [Test]
        static void Main(string[] args)
        { 
        
          
            IWebDriver driver = new ChromeDriver();

            //Navigate to davise group website and validate Twitter social meadia page

            driver.Navigate().GoToUrl("https://davies-group.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1613, 945);
            driver.FindElement(OpenQA.Selenium.By.CssSelector("li:nth-child(2) > .fa-twitter")).Click();
            Assert.That(driver.Title, Is.EqualTo("Davies Group (@Davies_Group) / Twitter"));

            //Navigate to davise group website and validate Linkidin social meadia page
            driver.FindElement(By.CssSelector("li:nth-child(3) > .fa")).Click();
            Assert.That(driver.Title, Is.EqualTo("Davies Group | LinkedIn"));
            driver.Close();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Navigate to davise group website and Find and validate Insurence services
            driver.FindElement(By.CssSelector("input:nth-child(3)")).Click();
            driver.FindElement(By.CssSelector(".eut-toggle-search-modal")).Click();
            driver.FindElement(By.CssSelector(".eut-search-placeholder")).Click();
            driver.FindElement(By.CssSelector("input:nth-child(3)")).SendKeys("insurance");
            driver.FindElement(By.CssSelector("input:nth-child(3)")).Click();
            driver.Manage().Window.Size = new System.Drawing.Size(1613, 945);
            driver.FindElement(By.CssSelector("#eut-search-3903-5e54d858add7a .eut-post-title")).Click();
            Assert.That(driver.Title, Is.EqualTo("Insurance Services – Davies Group"));
            driver.Close();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Navigate to davise group website and Find and validate Location
            driver.Manage().Window.Size = new System.Drawing.Size(1665, 945);
            driver.FindElement(By.CssSelector(".eut-advanced-menu-button > .eut-button-icon")).Click();
            driver.FindElement(By.CssSelector(".active > .menu-item-84 .eut-item")).Click();
            driver.FindElement(By.CssSelector("div:nth-child(3) > div:nth-child(6) > img")).Click();
            driver.FindElement(By.CssSelector("div:nth-child(3) > div > div:nth-child(3)")).Click();
            driver.FindElement(By.CssSelector("#gmimap15 > area")).Click();
            driver.FindElement(By.CssSelector(".gm-style-iw")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".gmwd-infowindow-address")).Text, Is.EqualTo("3rd and 4th Floors, No.2 Smithfields, Stoke-on-Trent ST1 3DH, UK"));
            driver.Quit();
        }
    }
    }

