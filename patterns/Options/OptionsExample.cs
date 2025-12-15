using Microsoft.Extensions.Options;
using static System.Console;
namespace design_patterns.patterns.Options;

/// <summary href="https://learn.microsoft.com/en-us/dotnet/core/extensions/options">
/// Example of the Options Pattern. The input parameter is one that is configured in the IoC
/// in the main Program.cs file.
/// </summary>
/// <param name="options">The options that are passed in</param>
public class OptionsExample(IOptions<ConfigurationOptions> options) : IOptionsExample
{
    public void Run()
    {
        var _options = options?.Value ?? null;
        if (_options == null) throw new ArgumentNullException(nameof(_options));
        WriteLine("Options Example: Implementation of IOptions");
        WriteLine($"Option 1 is: {_options.Option1}");
        WriteLine($"Option 2 is: {_options.Option2}");
        WriteLine($"Option 3 is: {_options.Option3}");
    }
}