using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


[TestFixture]
public class Tests
{
    public static readonly string URL = "https://rozetka.com.ua/ua/";
    public static readonly string SEARCH_WORD = "ноутбук";
    public static readonly string NOTEBOOK_HEADER = "notebooks";
    public static readonly string USER_NAME = "Микола";
    public static readonly string USER_SURNAME = "Петренко";
    public static readonly string USER_PHONE = "501111111";
    public static readonly string USER_EMAIL = "@mail.ua";
    public static readonly string USER_PASSWORD = "Rozetka@2022";
    public static readonly string SUBMIT_TEXT = "Підтвердити";

    private IWebDriver driver;
    private MainPage mainPage;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl(URL);
        driver.Manage().Window.Maximize();
        mainPage = new MainPage(driver);
    }

    [Test]
    public void SearchTest()
    {
        var searchPage = mainPage._searchSuggester.Search(SEARCH_WORD);
        var url = searchPage.GetURLAfterSearch();

        Assert.IsTrue(url.Contains(NOTEBOOK_HEADER), "The search results doesn't contains the search word.");
    }

    [Test]
    public void RegistrationTest()
    {
        var submitRegistration = mainPage._registrationWindow.Registration();

        Assert.IsTrue(SUBMIT_TEXT.Equals(submitRegistration));
    }

    [TearDown]
    public void TearDown()
    {
        driver.Close();
    }
}