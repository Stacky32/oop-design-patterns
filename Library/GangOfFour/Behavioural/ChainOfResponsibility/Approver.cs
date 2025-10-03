using System;

namespace Library.GangOfFour.Behavioural.ChainOfResponsibility;

public abstract class Approver
{
    public EventHandler<PurchaseEventArgs> Purchased;

    public abstract void PurchaseHandler(object sender, PurchaseEventArgs e);

    public Approver()
    {
        Purchased += PurchaseHandler!;
    }

    public void ProcessRequest(Purchase purchase)
    {
        OnPurchase(new PurchaseEventArgs { Purchase = purchase});
    }

    public virtual void OnPurchase(PurchaseEventArgs purchaseEventArgs)
    {
        Purchased?.Invoke(this, purchaseEventArgs);
    }

    public Approver? Successor { get; set;}
}