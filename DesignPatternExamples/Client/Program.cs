using Library.GangOfFour.Behavioural.Composite;
using Library.GangOfFour.Creational.AbstractFactory;
using Library.GangOfFour.Creational.AbstractFactory.Factories;
using Library.GangOfFour.Creational.Builder;
using Library.GangOfFour.Creational.Builder.Builders;
using Library.GangOfFour.Creational.FactoryMethod.Documents;
using Library.GangOfFour.Creational.Prototype;
using Library.GangOfFour.Creational.Singleton;

namespace Client;

public class Program
{
    public static void Main(string[] args)
    {
        TestAbstractFactoryPattern();
        TestBuilderPattern();
        TestFactoryMethodPattern();
        TestPrototypePattern();
        TestSingletonPattern();

        TestCompositePattern();

        Console.ReadKey();
    }


    private static void TestAbstractFactoryPattern()
    {
        var africa = new AnimalWorld<Africa>();
        Console.WriteLine(africa.RunFoodChain());

        var america = new AnimalWorld<America>();
        Console.WriteLine(america.RunFoodChain());

        var europe = new AnimalWorld<Europe>();
        Console.WriteLine(europe.RunFoodChain());
    }

    private static void TestBuilderPattern()
    {
        var shop = new Shop();

        shop.Construct(new ScooterBuilder());
        Console.WriteLine(shop.ShowVehicle());

        shop.Construct(new CarBuilder());
        Console.WriteLine(shop.ShowVehicle());

        shop.Construct(new MotorcycleBuilder());
        Console.WriteLine(shop.ShowVehicle());
    }

    private static void TestFactoryMethodPattern()
    {
        List<Document> documents = [new Resume(), new Report()];

        foreach (var document in documents)
        {
            Console.WriteLine($"{document}:");
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            document.CreatePages();

            foreach (var page in document.Pages)
            {
                Console.WriteLine($"\t{page}");
            }
            Console.WriteLine();
        }
    }

    private static void TestPrototypePattern()
    {
        var manager = new ColorManager();

        manager[ColorType.Red] = new Color(255, 0, 0);
        manager[ColorType.Green] = new Color(0, 255, 0);
        manager[ColorType.Blue] = new Color(0, 0, 255);

        manager[ColorType.Angry] = new Color(255, 54, 0);
        manager[ColorType.Peace] = new Color(128, 211, 128);
        manager[ColorType.Flame] = new Color(211, 34, 20);

        var red = manager[ColorType.Red].Clone();
        Console.WriteLine($"Red: {red}");

        var angry = manager[ColorType.Angry].Clone();
        Console.WriteLine($"Angry: {angry}");

        var peace = manager[ColorType.Peace].Clone(false);
        Console.WriteLine($"Peace: {peace}");
    }

    private static void TestSingletonPattern()
    {
        var balancer = LoadBalancer.GetLoadBalancer();

        for (int i = 0; i < 25; i++)
        {
            Console.WriteLine($"Dispatch request to: {balancer.NextServer}");
        }
    }

    private static void TestCompositePattern() {
            var root = new TreeNode<Shape>(new ("Picture"));
        root.Add(new ("Red Line"));
        root.Add(new ("Blue Circle"));
        root.Add(new ("Green Box"));
        var branch = root.Add(new Shape("Two Circles"));
        branch.Add(new ("Black Circle"));
        branch.Add(new ("White Circle"));
        // Add, remove, and add a shape
        var shape = new Shape("Yellow Line");
        root.Add(shape);
        root.Remove(shape);
        root.Add(shape);
        // Display tree using static method
        TreeNode<Shape>.Display(root, 1);
    }
}
