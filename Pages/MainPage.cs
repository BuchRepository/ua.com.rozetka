using OpenQA.Selenium;

public class MainPage
{
    private readonly IWebDriver _driver;

    public SearchSuggester _searchSuggester;
    public RegistrationWindow _registrationWindow;

    public MainPage(IWebDriver driver)
    {
        _driver = driver;
        _registrationWindow = new RegistrationWindow(driver);
        _searchSuggester = new SearchSuggester(driver);
    }
}