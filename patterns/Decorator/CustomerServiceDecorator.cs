namespace design_patterns.patterns.Decorator;

public abstract class CustomerServiceDecorator(ICustomerService inner) : ICustomerService
{
    public virtual Customer GetCustomer()
    {
        return inner.GetCustomer();
    }
}