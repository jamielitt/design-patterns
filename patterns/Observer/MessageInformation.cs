namespace design_patterns.patterns.Observer;

public class MessageInformation
{
    public required string Message { get; set; }
    public required string Title { get; set; }
    public string Subject { get; set; } = string.Empty;
}