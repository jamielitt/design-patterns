using design_patterns.patterns.Observer;

Console.WriteLine("Design Patterns example application");

// Setting up of the Observer pattern.
MessageProvider messageProvider = new MessageProvider();

WebsiteHandler websiteHandler = new WebsiteHandler();
ScreenHandler screenHandler = new ScreenHandler();

websiteHandler.Subscribe(messageProvider);

messageProvider.MessageReceived(new MessageInformation() {Message = "This is the first broadcast message", Title = "Test Message"});
messageProvider.MessageReceived(new MessageInformation() {Message = "This is the second broadcast message", Title = "Test Message"});

screenHandler.Subscribe(messageProvider);
messageProvider.MessageReceived(new MessageInformation() {Message = "This is the third broadcast message", Title = "Test Message"});

websiteHandler.Unsubscribe();

messageProvider.MessageReceived(new MessageInformation() {Message = "This is the screen only message", Title = "Test Message"});