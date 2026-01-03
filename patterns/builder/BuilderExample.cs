using static System.Console;
namespace design_patterns.patterns.builder;

public class BuilderExample : IBuilderExample
{
    public void Run()
    {
        // Very basic Pizza builder - shows how the builder pattern works
        WriteLine("Builder Patter - First let's build a Pizza");
        var pizza = new PizzaBuilder()
            .AddTopping("Bacon")
            .AddTopping("Ham")
            .AddTopping("Mushrooms")
            .AddTopping("Pineapple")
            .WithCheese()
            .WithDough("Thin & Crispy")
            .WithSize("14 inch")
            .WithSauce("Tomato Sauce")
            .Build();
        WriteLine(pizza);
    }
}