using FluentAssertions;
using TechTalk.SpecFlow;
using UiBank.Drivers;

namespace UiBank.Steps;

[Binding]
public sealed class AccountsPageSteps
{
    private readonly Driver _driver;
    private readonly AccountsPage _accountsPage;

    public AccountsPageSteps(Driver driver)
    {
        _driver = driver;
        _accountsPage = new AccountsPage(_driver.Page);
    }

    [Then("I should see my accounts dashboard")]
    public async Task ThenIShouldSeeMyAccountDashboard()
    {
        var isPageLoaded = await _accountsPage.IsPageLoaded();
        isPageLoaded.Should().Be(true);
    }
}