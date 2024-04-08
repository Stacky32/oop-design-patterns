using System.Collections.Generic;
using Library.GangOfFour.Creational.FactoryMethod.Pages;

namespace Library.GangOfFour.Creational.FactoryMethod.Documents;

public abstract class Document
{
    public List<Page> Pages { get; protected set; } = null!;

    public abstract void CreatePages();

    public override string ToString() => GetType().Name;
}