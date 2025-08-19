using OpenQA.Selenium;
using System;

public class RegistrationWindow
{
    private readonly IWebDriver _driver;

    private readonly By mainMenu = By.XPath("//*[@href='#icon-menu']");
    private readonly By registrationLink = By.XPath("//button[contains(text(),'Реєстрація')]");
    private readonly By registerUserName = By.Id("registerUserName");
    private readonly By registerUserSurname = By.Id("registerUserSurname");
    private readonly By registerUserPhone = By.Id("registerUserPhone");
    private readonly By registerUserEmail = By.Id("registerUserEmail");
    private readonly By registerUserPassword = By.Id("registerUserPassword");
    private readonly By registerButton = By.XPath("//*[@class='button button--large button--green auth-modal__submit']");
    private readonly By submitRegistrationButton = By.XPath("//button[contains(text(),'Підтвердити')]");

    public RegistrationWindow(IWebDriver driver)
    {
        _driver = driver;
    }

    public string Registration()
    {
        var mail = Guid.NewGuid();

        Waits.WaitWhenElementToBeClickable(_driver, mainMenu);
        _driver.FindElement(mainMenu).Click();
        Waits.WaitWhenElementToBeVisible(_driver, registrationLink);
        _driver.FindElement(registrationLink).Click();
        Waits.WaitWhenElementToBeVisible(_driver, registerUserName);
        _driver.FindElement(registerUserName).SendKeys(Tests.USER_NAME);
        _driver.FindElement(registerUserSurname).SendKeys(Tests.USER_SURNAME);
        _driver.FindElement(registerUserPhone).SendKeys(Tests.USER_PHONE);
        _driver.FindElement(registerUserEmail).SendKeys(mail + Tests.USER_EMAIL);
        _driver.FindElement(registerUserPassword).SendKeys(Tests.USER_PASSWORD);
        _driver.FindElement(registerButton).Click();
        Waits.WaitWhenElementToBeVisible(_driver, submitRegistrationButton);

        return _driver.FindElement(submitRegistrationButton).Text.Trim();
    }
}
