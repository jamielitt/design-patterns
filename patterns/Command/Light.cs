namespace design_patterns.patterns.Command;
using static Console;

// This class is a receiver, as it receives the action from the command itself
// i.e. the thing being acted upon
public class Light
{
    public void SwitchOn()
    {
        WriteLine("Light is On");        
    }

    public void SwitchOff()
    {
        WriteLine("Light is Off");
    }
}