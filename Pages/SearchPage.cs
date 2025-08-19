using OpenQA.Selenium;

public class SearchPage
{
    private readonly IWebDriver _driver;

    private readonly By notebookWord = By.XPath("//*[@class='catalog-heading ng-star-inserted']");

    public SearchPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public string GetURLAfterSearch()
    {
        Waits.WaitWhenElementToBeVisible(_driver, notebookWord);

        return _driver.Url;
    }
}