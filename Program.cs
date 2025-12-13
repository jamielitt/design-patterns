using design_patterns;
using design_patterns.patterns.Command;
using design_patterns.patterns.Observer;
using Microsoft.Extensions.DependencyInjection;

// Set up DI container
ServiceCollection services = new();

// Register your main application class
services.AddSingleton<Application>();

// Add services for design patterns
services.AddSingleton<IObserver, Observer>();
services.AddSingleton<ICommandExample, CommandExample>();

// Build the provider
var provider = services.BuildServiceProvider();

// Run the app
var app = provider.GetRequiredService<Application>();
app.Run();