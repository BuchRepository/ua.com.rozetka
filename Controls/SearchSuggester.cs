using OpenQA.Selenium;

public class SearchSuggester
{
    private readonly IWebDriver _driver; 
    public readonly By searchField = By.XPath("//*[@class='search-form__input ng-untouched ng-pristine ng-valid']");

    public SearchSuggester(IWebDriver driver)
    {
        _driver = driver;
    }

    public SearchPage Search(string searchWord)
    {
        Waits.WaitWhenElementToBeVisible(_driver, searchField);
        _driver.FindElement(searchField).SendKeys(searchWord + Keys.Enter);

        return new SearchPage(_driver);
    }
}