using System;

namespace Library.GangOfFour.Behavioural.ChainOfResponsibility;

public class President : Approver
{
    public override void PurchaseHandler(object sender, PurchaseEventArgs e)
    {
        if (e.Purchase.Amount < 100000)
        {
            Console.WriteLine(
                "{0} approved request {1}",
                this.GetType().Name,
                e.Purchase.Number);
        }
        else if (Successor is not null)
        {
            Successor.PurchaseHandler(this, e);
        }
        else
        {
            Console.WriteLine("Request {0} needs an executive meeting.", e.Purchase.Number);
        }
    }
}