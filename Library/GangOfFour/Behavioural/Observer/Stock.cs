using System;

namespace Library.GangOfFour.Behavioural.Observer;

public abstract class Stock
{
    protected string _symbol { get; set; }
    protected double _price { get; set; }

    public event EventHandler<ChangeEventArgs> Change = null!;

    public Stock(string symbol, double price)
    {
        _symbol = symbol;
        _price = price;
    }

    public virtual void OnChange(ChangeEventArgs e)
    {
        Change?.Invoke(this, e);
    }

    public void Attach(params IInvestor[] args)
    {
        foreach (var investor in args)
        {
            Change += investor.Update;
        }
    }

    public void Detach(params IInvestor[] args)
    {
        foreach (var investor in args)
        {
            Change -= investor.Update;
        }
    }

    public string Symbol => _symbol;

    public double Price
    {
        get => _price;
        set
        {
            if (_price != value) {
                _price = value;
                OnChange(new ChangeEventArgs(_symbol,_price));
                Console.WriteLine();
            }

        }
    }
}