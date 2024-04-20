using System;

namespace Library.GangOfFour.Behavioural.Command;

public class Calculator
{
    private int _current = 0;

    public void Operation(char operation, int operand)
    {
        switch (operation)
        {
            case '+': _current += operand; break;
            case '-': _current -= operand; break;
            case '*': _current *= operand; break;
            case '/': _current /= operand; break;
        }

        Console.WriteLine(
            "Current: {0,3} (following {1} {2})",
            _current, operation, operand);
    }
}