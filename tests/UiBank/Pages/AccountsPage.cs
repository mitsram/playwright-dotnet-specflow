
using Microsoft.Playwright;

public class AccountsPage
{
    private IPage _page;

    public AccountsPage(IPage page)
    {
        _page = page;
    }

    private ILocator _btnApplyForNewAccount => _page.GetByText("Apply For New Account");
    
    public async Task<Boolean> IsPageLoaded()
    {
        await _page.WaitForURLAsync("/accounts");
        return await _btnApplyForNewAccount.IsVisibleAsync();
        
    }
}