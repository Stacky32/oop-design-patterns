using Library.GangOfFour.Creational.AbstractFactory.Interfaces;

namespace Library.GangOfFour.Creational.AbstractFactory.Animals;

public class Lion : ICarnivore
{
    public string Eat(IHerbivore herbivore)
    {
        return $"{this.GetType().Name} eats {herbivore.GetType().Name}";
    }
}