﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class Darshan_Tada_9000046_Assignment4
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void insuranceQuote1validDatanoAccidentsage24exp3rate5500()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(783, 816);

        //Act
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("phone")).SendKeys("5483983379");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("24");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("btnSubmit")).Click();
    
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("548-398-3379");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();

        {

            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$5500"));
        }
    }
    [Test]
    public void insuranceQuote2validData4Accidentsage25exp3insuranceRefused()
    {

        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(782, 823);

        //Act
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("phone")).SendKeys("5483983379");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("548-398-3379");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("4");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
        }
    }
    [Test]
    public void insuranceQuote3validData2Accidentsage35exp9rateReduction29Percent()
    {

        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(783, 416);

        //Act
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("phone")).SendKeys("5483983379");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("548-398-3379");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("9");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        driver.FindElement(By.CssSelector(".card-body")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$3905"));
        }
    }
    [Test]
    public void insuranceQuote4invalidPhonenoAccidentsage27exp3invalidPhoneError()
    {

        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);

        //Act
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("phone")).SendKeys("5483983379");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("12345");
        driver.FindElement(By.Id("phone")).SendKeys("1234567");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("27");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
    }
    [Test]
    public void insuranceQuote5invalidEmailnoAccidentsage28exp3invalidEmailError()
    {

        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);

        //Act
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("phone")).SendKeys("5483983379");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("invalidemail");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("548-398-3379");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("28");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            var element = driver.FindElement(By.Id("btnSubmit"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        {
            var element = driver.FindElement(By.TagName("body"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element, 0, 0).Perform();
        }
        Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
    }
    [Test]
    public void insuranceQuote6invalidPostal1Accidentage35exp15invalidPostalError()
    {

        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);

        //Act
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("phone")).SendKeys("5483983379");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("548-398-3379");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("12345");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("15");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("1");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            var element = driver.FindElement(By.Id("btnSubmit"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        //{
        //    var element = driver.FindElement(By.tagName("body"));
        //    Actions builder = new Actions(driver);
        //    builder.MoveToElement(element, 0, 0).Perform();
        //}
        Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
    }
    [Test]
    public void insuranceQuote7ageOmittednoAccidentsexp5invalidAgeError()
    {

        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);

        //Act
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("phone")).SendKeys("5483983379");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("548-398-3379");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("5");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));
    }
    [Test]
    public void insuranceQuote8accidentsOmittedvalidDataage37exp8invalidAccidentsError()
    {

        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);

        //Act
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("phone")).SendKeys("5483983379");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("548-398-3379");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("38");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("37");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("8");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            var element = driver.FindElement(By.Id("btnSubmit"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        //{
        //    var element = driver.FindElement(By.tagName("body"));
        //    Actions builder = new Actions(driver);
        //    builder.MoveToElement(element, 0, 0).Perform();
        //}
        Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Number of accidents is required"));
    }
    [Test]
    public void insuranceQuote9experienceOmittedvalidDataage45noAccidentsinvalidExperienceError()
    {

        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(790, 816);

        //Act
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("phone")).SendKeys("5483983379");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("548-398-3379");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("45");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            var element = driver.FindElement(By.Id("btnSubmit"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).Perform();
        }
        //{
        //    var element = driver.FindElement(By.tagName("body"));
        //    Actions builder = new Actions(driver);
        //    builder.MoveToElement(element, 0, 0).Perform();
        //}
        Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));
    }
    [Test]
    public void insuranceQuote10noNamevalidDataage30exp5rateReduction29Percent()
    {

        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);

        //Act
        driver.FindElement(By.Id("lastName")).Click();
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).Click();
        driver.FindElement(By.Id("address")).SendKeys("Albert Street");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("province")).Click();
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("phone")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("548-398-3379");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("30");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("5");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        driver.FindElement(By.CssSelector(".container")).Click();
        Assert.That(driver.FindElement(By.Id("firstName-error")).Text, Is.EqualTo("First Name is required"));
    }
    //[Test]
    //public void insuranceQuote11validData4Accidentsage45exp12insuranceRefused()
    //{

    //    //Arrange
    //    driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
    //    driver.Manage().Window.Size = new System.Drawing.Size(786, 816);

    //    //Act
    //    driver.FindElement(By.Id("firstName")).Click();
    //    driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
    //    driver.FindElement(By.Id("lastName")).SendKeys("Tada");
    //    driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
    //    driver.FindElement(By.Id("city")).SendKeys("waterloo");
    //    driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
    //    driver.FindElement(By.Id("phone")).SendKeys("5483983379");
    //    driver.FindElement(By.Id("phone")).Click();
    //    driver.FindElement(By.Id("phone")).SendKeys("548-398-3379");
    //    driver.FindElement(By.Id("email")).Click();
    //    driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
    //    driver.FindElement(By.Id("age")).Click();
    //    driver.FindElement(By.Id("age")).SendKeys("45");
    //    driver.FindElement(By.Id("experience")).Click();
    //    driver.FindElement(By.Id("experience")).SendKeys("12");
    //    driver.FindElement(By.Id("accidents")).Click();
    //    driver.FindElement(By.Id("accidents")).SendKeys("4");

    //    //Assert
    //    driver.FindElement(By.Id("btnSubmit")).Click();
    //    {
    //        string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
    //        Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
    //    }
    //}


    [Test]
    public void insuranceQuote11validData4Accidentsage45exp12insuranceRefused()
    {
        // Arrange
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);

        // Act: Fill out the form
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        driver.FindElement(By.Id("phone")).SendKeys("5483983379");
        driver.FindElement(By.Id("phone")).Click();

        driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("45");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("12");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("4");

        // Submit the form
        driver.FindElement(By.Id("btnSubmit")).Click();

        // Wait for the final quote to appear and ensure the element is populated
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20)); // Increased wait time to 20 seconds
        wait.Until(d => d.FindElement(By.Id("finalQuote")).Displayed); // Wait for the element to be displayed

        // Alternatively, wait for the text to be populated inside the element
        wait.Until(d => !string.IsNullOrEmpty(d.FindElement(By.Id("finalQuote")).Text)); // Wait until the text is not empty

        // Debugging: Log the content of the final quote
        string value = driver.FindElement(By.Id("finalQuote")).Text;
        Console.WriteLine($"Final Quote Text: {value}");

        // Assert the expected message
        Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
    }

    [Test]
    public void insuranceQuote12validDatalowAgeage15exp0insuranceRefused()
    {


        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);

        //Act
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
       
        driver.FindElement(By.Id("phone")).SendKeys("548-398-3379");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("15");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("0");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
     
        Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Please enter a value greater than or equal to 16."));
    }
    [Test]
    public void insuranceQuote13validDatanoExperienceage21exp0rate7000()
    {

        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);

        //Act
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");

        driver.FindElement(By.Id("phone")).SendKeys("548-398-3379");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("21");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("0");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("$7000"));
        }
    }
    [Test]
    public void insuranceQuote14validDatanegativeExperienceage30expNegativeinsuranceRefused()
    {

        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);

        //Act
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
        
        driver.FindElement(By.Id("phone")).SendKeys("548-398-3379");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("30");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("-1");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Please enter a value greater than or equal to 0."));
    }
    [Test]
    public void insuranceQuote15invalidDataage21exp7noInsurance()
    {

        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog8170a04/getQuote.html");
        driver.Manage().Window.Size = new System.Drawing.Size(786, 816);

        //Act
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Darshan");
        driver.FindElement(By.Id("lastName")).SendKeys("Tada");
        driver.FindElement(By.Id("address")).SendKeys("507, 383 albert street");
        driver.FindElement(By.Id("city")).SendKeys("waterloo");
        driver.FindElement(By.Id("postalCode")).SendKeys("N2L 6E3");
      
        driver.FindElement(By.Id("phone")).SendKeys("548-398-3379");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("darshantada7@gmail.com");
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("21");
        driver.FindElement(By.Id("experience")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("7");
        driver.FindElement(By.Id("accidents")).Click();
        driver.FindElement(By.Id("accidents")).SendKeys("0");

        //Assert
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("No Insurance for you!! Driver Age / Experience Not Correct"));
        }
    }
}


