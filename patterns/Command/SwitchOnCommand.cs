namespace design_patterns.patterns.Command;

// This is a concrete implementation of the ICommand interface, the bit that does the action.
public class SwitchOnCommand(Light light) : ICommand
{
    public void Execute()
    {
        light.SwitchOn();
    }
}