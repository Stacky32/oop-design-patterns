using Library.GangOfFour.Creational.AbstractFactory.Interfaces;

namespace Library.GangOfFour.Creational.AbstractFactory.Animals;

public class Wolf : ICarnivore
{
    public string Eat(IHerbivore herbivore)
    {
        return $"{this.GetType().Name} eats {herbivore.GetType().Name}";
    }
}