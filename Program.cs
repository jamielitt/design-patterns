using design_patterns.patterns.Observer;

Console.WriteLine("Design Patterns example application");

// ***************
// An example of how to use the observer pattern
// ***************

// Instantiate our provider (this inherits from IObservable<T>)
MessageProvider messageProvider = new MessageProvider();

// Instantiate each handler that can recieve calls from the Provider (inherits from IObserver<T>)
WebsiteHandler websiteHandler = new WebsiteHandler();
ScreenHandler screenHandler = new ScreenHandler();

// Firstly, just the website that needs to receive messages.
websiteHandler.Subscribe(messageProvider);

messageProvider.MessageReceived(new MessageInformation() {Message = "This is the first broadcast message", Title = "Test Message"});
messageProvider.MessageReceived(new MessageInformation() {Message = "This is the second broadcast message", Title = "Test Message"});

// Now we want to add a Screen in to be able to receive messages
// (should see both Website and Screen reveive messages)
screenHandler.Subscribe(messageProvider);
messageProvider.MessageReceived(new MessageInformation() {Message = "This is the third broadcast message", Title = "Test Message"});

// The website is not interested in any more messages
websiteHandler.Unsubscribe();

// Only the Screen should receive the last message
messageProvider.MessageReceived(new MessageInformation() {Message = "This is the screen only message", Title = "Test Message"});