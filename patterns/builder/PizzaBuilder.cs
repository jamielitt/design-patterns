namespace design_patterns.patterns.builder;

public class PizzaBuilder
{
    private Pizza _pizza = new();

    public PizzaBuilder WithSize(string size)
    {
        _pizza.Size = size;
        return this;
    }

    public PizzaBuilder WithDough(string dough)
    {
        _pizza.Dough = dough;
        return this;
    }

    public PizzaBuilder WithSauce(string sauce)
    {
        _pizza.Sauce = sauce;
        return this;
    }

    public PizzaBuilder WithCheese()
    {
        _pizza.HasCheese = true;
        return this;
    }

    public PizzaBuilder AddTopping(string topping)
    {
        _pizza.Toppings.Add(topping);
        return this;
    }

    public Pizza Build()
    {
        return _pizza;
    }
}