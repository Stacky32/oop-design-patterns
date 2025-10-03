using System;
using System.Collections.Generic;

namespace Library.GangOfFour.Behavioural.Command;

public class User
{
    private readonly Calculator calculator = new();
    private readonly List<ICommand> commands = [];
    private int _current = 0;

    public void Redo(int levels)
    {
        Console.WriteLine($"Redo {levels} levels");

        for (var i = 0; i < levels; i++)
        {
            if (_current < commands.Count - 1)
            {
                commands[_current++].Execute();
            }
        }
    }

    public void Undo(int levels)
    {
        Console.WriteLine($"Undo {levels} commands");

        for (var i = 0; i < levels; i++)
        {
            if (_current > 0)
            {
                commands[--_current].UnExecute();
            }
        }
    }

    public void Compute(char operation, int operand)
    {
        var command = new CalculatorCommand(calculator, operation, operand);
        command.Execute();

        commands.Add(command);
        _current++;
    }
}