namespace Library.GangOfFour.Creational.AbstractFactory.Interfaces;

public interface IContinentFactory
{
    IHerbivore CreateHerbivore();
    ICarnivore CreateCarnivore();
}