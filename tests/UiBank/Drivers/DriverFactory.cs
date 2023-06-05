using Microsoft.Playwright;

namespace UiBank.Drivers;

public class DriverFactory
{
    private readonly BrowserType _browserType;
    
    public DriverFactory(BrowserType browserType)
    {
        _browserType = browserType;
    }

    public async Task<IBrowserType> CreateDriver()
    {        
        var playwright = await Playwright.CreateAsync();

        switch (_browserType)
        {
            case BrowserType.Chrome:
                return playwright.Chromium;
            case BrowserType.Safari:
                return playwright.Webkit;
            case BrowserType.Firefox:
                return playwright.Firefox;
            default:
                throw new ArgumentException("Invalid browser type");       
        }
    }
}

public enum BrowserType
{
    Chrome,
    Firefox,
    Safari
}