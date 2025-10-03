using Library.GangOfFour.Creational.AbstractFactory.Animals;
using Library.GangOfFour.Creational.AbstractFactory.Interfaces;

namespace Library.GangOfFour.Creational.AbstractFactory.Factories;

public class America : IContinentFactory
{
    public ICarnivore CreateCarnivore() => new Wolf();

    public IHerbivore CreateHerbivore() => new Bison();
}