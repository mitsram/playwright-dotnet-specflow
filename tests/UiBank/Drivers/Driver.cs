using Microsoft.Playwright;

namespace UiBank.Drivers;

public class Driver: IDisposable
{
    private readonly Task<IPage> _page;
    private IBrowser? _browser;
    public IPage Page => _page.Result;

    public Driver()
    {
        _page = InitializePlaywright();
    }
    public async Task<IPage> InitializePlaywright()
    {
        var playwright = await Playwright.CreateAsync();
        _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });
        return await _browser.NewPageAsync();
    }

    public void Dispose()
    {
        _browser?.CloseAsync();
    }
}