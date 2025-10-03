using System;

namespace Library.GangOfFour.Behavioural.ChainOfResponsibility;

public class PurchaseEventArgs : EventArgs
{
    internal Purchase Purchase { get; init; } = null!;
}