
using Microsoft.Playwright;

public class LoginPage
{
    private IPage _page;

    public LoginPage(IPage page)
    {
        _page = page;
    }

    private ILocator _txtUsername => _page.GetByPlaceholder("Enter username");
    private ILocator _txtPassword => _page.GetByPlaceholder("Enter password");
    private ILocator _btnSignIn => _page.GetByRole(AriaRole.Button, new PageGetByRoleOptions() { Name = "Sign In"});
    
    public async Task Login(string username, string password)
    {
        await _txtUsername.FillAsync(username);
        await _txtPassword.FillAsync(password);
        await _btnSignIn.ClickAsync();
    }
}