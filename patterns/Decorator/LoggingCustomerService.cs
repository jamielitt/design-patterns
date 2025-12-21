namespace design_patterns.patterns.Decorator;

public class LoggingCustomerService(ICustomerService inner) : CustomerServiceDecorator(inner), ICustomerService
{
    public override Customer GetCustomer()
    {
        // Call the base class (the class we are decorating)
        var customer = base.GetCustomer();
        
        // We can do anything here, just log to the console just as an example
        Console.WriteLine($"LOG: Name: {customer.Name} Address: {customer.Address}");
        return customer;
    }
}