using design_patterns;
using design_patterns.patterns.Command;
using design_patterns.patterns.Decorator;
using design_patterns.patterns.Observer;
using design_patterns.patterns.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// Set up DI container
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

// Specify where to find the configuration
// TODO: Extend this to find environmental specific config files as an example
builder.Configuration.Sources.Clear();
builder.Configuration
    .AddJsonFile("appsettings.json");

ConfigurationOptions options = new();
var config = builder.Configuration.GetSection(nameof(ConfigurationOptions));
var services = builder.Services;

// Register your main application class
services.AddSingleton<Application>();

// Register configuration (example of IOptions)
services.Configure<ConfigurationOptions>(config);

// Add services for design patterns
services.AddSingleton<IObserver, Observer>();
services.AddSingleton<ICommandExample, CommandExample>();
services.AddSingleton<IOptionsExample, OptionsExample>();
services.AddSingleton<IDecoratorExample, DecoratorExample>();

// Build the provider
var provider = services.BuildServiceProvider();

// Run the app
var app = provider.GetRequiredService<Application>();
app.Run();