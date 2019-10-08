using System.Collections.Generic;
using UnityEngine;

public class MacroCommand : ICommand
{
    private List<ICommand> _innerCommands;

    public MacroCommand(List<ICommand> commands)
    {
        _innerCommands = commands;
    }

    public void Execute()
    {
        foreach (var innerComand in _innerCommands)
        {
            innerComand.Execute();
        }
    }

  
}
