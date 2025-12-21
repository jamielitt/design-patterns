namespace design_patterns.patterns.Decorator;
using static System.Console;

public class DecoratorExample : IDecoratorExample
{
    public void Run()
    {
        WriteLine("Decorator Pattern example");        
        var customerService = new LoggingCustomerService(new CustomerService());
        
        WriteLine("Simulating getting customer");
        var customer = customerService.GetCustomer();
        
        WriteLine("Customer  is " + customer.Name);
        WriteLine($"Address: {customer.Address}");
        
        // TODO: Extend to contain multiple decorators
    }
}