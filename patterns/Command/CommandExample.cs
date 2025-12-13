namespace design_patterns.patterns.Command;

public class CommandExample : ICommandExample
{
    public void Run()
    {
        var light = new Light();
        var _switchOn = new SwitchOnCommand(light);
        var _switchOff = new SwitchOffCommand(light);
        var user = new User();
        user.SetAction(_switchOn);
        user.PerformAction();
        user.SetAction(_switchOff);
        user.PerformAction();
    }
}