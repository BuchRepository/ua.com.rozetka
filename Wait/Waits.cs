using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

public static class Waits
{
    private const double TIME = 20;

    public static void WaitWhenElementToBeVisible(IWebDriver driver, By locator)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TIME));
        wait.Until(ExpectedConditions.ElementIsVisible(locator));
    }

    public static void WaitWhenElementToBeClickable(IWebDriver driver, By locator)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TIME));
        wait.Until(ExpectedConditions.ElementToBeClickable(locator));
    }
}