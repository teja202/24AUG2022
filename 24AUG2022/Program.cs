﻿// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.ComponentModel.Design;


// open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// lanch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

// indetify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

// check if user has logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in succesfully, test passed.");
}
else
{
    Console.WriteLine("Login failed, test failed.");
}
