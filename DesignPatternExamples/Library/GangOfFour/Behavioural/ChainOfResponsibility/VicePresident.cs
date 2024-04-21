using System;

namespace Library.GangOfFour.Behavioural.ChainOfResponsibility;

public class VicePresident : Approver
{
    public override void PurchaseHandler(object sender, PurchaseEventArgs e)
    {
        if (e.Purchase.Amount < 25000)
        {
            Console.WriteLine(
                "{0} approved request {1}",
                this.GetType().Name,
                e.Purchase.Number);
        }
        else
        {
            Successor?.PurchaseHandler(this, e);
        }
    }
}