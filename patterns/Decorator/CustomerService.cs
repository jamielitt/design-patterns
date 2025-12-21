namespace design_patterns.patterns.Decorator;

public class CustomerService : ICustomerService
{
    public Customer GetCustomer()
    {
        return new Customer() { Name = "Jamie", Address = "6 Red Kite Close" };
    }
}