using System;

namespace Library.GangOfFour.Behavioural.Command;

public class CalculatorCommand : ICommand
{
    private readonly Calculator _calculator;
    private readonly char _operator;
    private readonly int _operand;

    public CalculatorCommand(
        Calculator calculator,
        char operation,
        int operand)
    {
        _calculator = calculator;
        _operator = operation;
        _operand = operand;
    }

    public void Execute()
    {
        _calculator.Operation(_operator, _operand);
    }

    public void UnExecute()
    {
        _calculator.Operation(InverseOperator(_operator), _operand);
    }

    private static char InverseOperator(char operation) =>
        operation switch
        {
            '+' => '-',
            '-' => '+',
            '*' => '/',
            '/' => '*',
            _ => throw new ArgumentException($"Invalid operation {operation}", nameof(operation))
        };
}