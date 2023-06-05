using Microsoft.Playwright;

namespace UiBank.Drivers;

public class Driver: IDisposable
{
    private readonly Task<IPage> _page;
    private IBrowserContext? _context;
    public IPage Page => _page.Result;

    public Driver()
    {
        _page = InitializePlaywright();
    }
    public async Task<IPage> InitializePlaywright()
    { 
        var factory = new DriverFactory(GetBrowserTypeFromEnv());
        var driver = await factory.CreateDriver();

        var browser = await driver.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false,
        });

        _context = await browser.NewContextAsync(new BrowserNewContextOptions
        {
            BaseURL = "https://uibank.uipath.com"
        });

        return await _context.NewPageAsync();
    }

    public BrowserType GetBrowserTypeFromEnv()
    {
        string? envBrowserType = Environment.GetEnvironmentVariable("BROWSER_TYPE");
        string browserType = string.IsNullOrEmpty(envBrowserType) ? "Chrome" : envBrowserType;

        if (!Enum.TryParse(browserType, true, out BrowserType type))
            throw new ArgumentException($"Invalid browser type: {browserType}");
        return type;
    }

    public void Dispose()
    {
        _context?.CloseAsync();
    }
}