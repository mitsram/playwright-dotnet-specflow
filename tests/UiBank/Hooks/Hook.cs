using TechTalk.SpecFlow;
using dotenv.net;
[assembly:Parallelizable(ParallelScope.Fixtures)]

namespace UiBank.Hooks;

[Binding]
public class Hook
{
    public Hook()
    {
        
    }

    [BeforeFeature]
    public static void BeforeFeature()
    {
        string solutionRoot = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../../"));
        string envFilePath = Path.Combine(solutionRoot, ".env");
        DotEnv.Load(options: new DotEnvOptions(ignoreExceptions: false, envFilePaths: new[] {envFilePath}));
    }    
}