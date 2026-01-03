namespace design_patterns.patterns.builder;

public class Pizza
{
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public List<string> Toppings { get; set; } = new List<string>();
    public string Size { get; set; }
    public bool HasCheese { get; set; }

    public override string ToString()
    {
        return $"Pizza: {Size}, Dough: {Dough}, Sauce: {Sauce}, " +
               $"Cheese: {HasCheese}, Toppings: {string.Join(", ", Toppings)}";
    }
}