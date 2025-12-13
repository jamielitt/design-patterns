namespace design_patterns.patterns.Command;

// This is the Invoker
public class User
{
    private ICommand _command;

    public void SetAction(ICommand command)
    {
        _command = command;
    }

    public void PerformAction()
    {
        _command.Execute();
    }
}