using Microsoft.Playwright;

namespace UiBank.Drivers;

public class Driver: IDisposable
{
    private readonly Task<IPage> _page;
    private IBrowser? _browser;
    private IBrowserContext? _context;
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
        _context = await _browser.NewContextAsync(new BrowserNewContextOptions
        {
            BaseURL = "https://uibank.uipath.com"
        });
        return await _context.NewPageAsync();
    }

    public void Dispose()
    {
        _context?.CloseAsync();
    }
}