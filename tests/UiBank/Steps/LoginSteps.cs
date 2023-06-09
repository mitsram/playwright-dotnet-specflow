using TechTalk.SpecFlow;
using UiBank.Drivers;

namespace UiBank.Steps;

[Binding]
public sealed class LoginSteps
{
    private readonly Driver _driver;
    private readonly LoginPage _loginPage;

    public LoginSteps(Driver driver)
    {        
        _driver = driver;
        _loginPage = new LoginPage(_driver.Page);
    }

    [Given("I am on the login page")]
    public void GiveIAmOnTheLoginpage()
    {
        _driver.Page.GotoAsync("/login");
    }

    [When("I log in with valid credentials")]
    public async Task WhenILogInWithValidCredentials()
    {
        string? username = Environment.GetEnvironmentVariable("USERNAME");
        string? password = Environment.GetEnvironmentVariable("PASSWORD");
        await _loginPage.Login(username!, password!);
    }
}