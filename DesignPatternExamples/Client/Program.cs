using Library.GangOfFour.Behavioural.Command;
using Library.GangOfFour.Behavioural.Iterator;
using Library.GangOfFour.Behavioural.Observer;
using Library.GangOfFour.Behavioural.State;
using Library.GangOfFour.Behavioural.Strategy;
using Library.GangOfFour.Behavioural.TemplateMethod;
using Library.GangOfFour.Creational.AbstractFactory;
using Library.GangOfFour.Creational.AbstractFactory.Factories;
using Library.GangOfFour.Creational.Builder;
using Library.GangOfFour.Creational.Builder.Builders;
using Library.GangOfFour.Creational.FactoryMethod.Documents;
using Library.GangOfFour.Creational.Prototype;
using Library.GangOfFour.Creational.Singleton;
using Library.GangOfFour.Structural.Adapter;
using Library.GangOfFour.Structural.Composite;
using Library.GangOfFour.Structural.Decorator;
using Library.GangOfFour.Structural.Facade;
using Library.GangOfFour.Structural.Proxy;

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
        TestProxyPattern();
        TestFacadePattern();
        TestDecoratorPattern();
        TestAdapterPatten();

        TestStrategyPattern();
        TestObserverPattern();
        TestIteratorPattern();
        TestTemplateMethodPattern();
        TestCommandPattern();
        TestStatePattern();

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

    private static void TestCompositePattern()
    {
        var root = new TreeNode<Shape>(new("Picture"));
        root.Add(new("Red Line"));
        root.Add(new("Blue Circle"));
        root.Add(new("Green Box"));
        var branch = root.Add(new Shape("Two Circles"));
        branch.Add(new("Black Circle"));
        branch.Add(new("White Circle"));
        // Add, remove, and add a shape
        var shape = new Shape("Yellow Line");
        root.Add(shape);
        root.Remove(shape);
        root.Add(shape);
        // Display tree using static method
        TreeNode<Shape>.Display(root, 1);
    }

    private static void TestProxyPattern()
    {
        var proxy = new MathProxy();

        Console.WriteLine($"4 + 2 = {proxy.Add(4, 2)}");
        Console.WriteLine($"4 * 2 = {proxy.Multiply(4, 2)}");
        Console.WriteLine($"4 - 2 = {proxy.Subtract(4, 2)}");
        Console.WriteLine($"4 / 2 = {proxy.Divide(4, 2)}");
    }

    private static void TestFacadePattern()
    {
        var cust1 = new Customer("Meerm");
        var cust2 = new Customer("Sam");

        var mortgage = new Mortgage();
        static void Confirmation(string name, bool approved) =>
            Console.WriteLine($"\n{name} has been " + (approved ? "Approved" : "Rejected"));

        var eligible = mortgage.IsEligible(cust1, 6000000);
        Confirmation(cust1.Name, eligible);

        eligible = mortgage.IsEligible(cust2, 6000000);
        Confirmation(cust2.Name, eligible);
    }

    private static void TestDecoratorPattern()
    {
        // Create book
        var book = new Book("Worley", "Inside ASP.NET", 10);
        book.Display();
        // Create video
        var video = new Video("Spielberg", "Jaws", 23, 92);
        video.Display();
        // Make video borrowable, then borrow and display
        Console.WriteLine("\nMaking video borrowable:");
        var borrow = new Borrowable<Video>(video);
        borrow.BorrowItem("Customer #1");
        borrow.BorrowItem("Customer #2");
        borrow.Display();
    }

    private static void TestStrategyPattern()
    {
        SortedList students =
        [
            new (Name:"Samual", Ssn: "154-33-2009"),
            new (Name:"Jimmy", Ssn: "487-43-1665" ),
            new (Name:"Sandra", Ssn:  "655-00-2944" ),
            new (Name:"Vivek", Ssn:  "133-98-8399" ),
            new (Name:"Anna", Ssn: "760-94-9844" )
        ];

        students.SortStrategy = new QuickSort();
        students.SortStudents();
        students.SortStrategy = new ShellSort();
        students.SortStudents();
        students.SortStrategy = new MergeSort();
        students.SortStudents();
    }

    private static void TestObserverPattern()
    {
        var ibm = new IBM(120);

        var investor1 = new Investor { Name = "Alice" };
        var investor2 = new Investor { Name = "Bob" };

        ibm.Attach(investor1, investor2);

        ibm.Price = 110.4;
        ibm.Price = 114.5;
        ibm.Price = 113.3;

        ibm.Detach(investor1);

        ibm.Price = 121.6;
        ibm.Price = 120.1;

    }

    private static void TestIteratorPattern()
    {
        ItemColection<Item> items =
        [
            new("zero"),
            new("one"),
            new("two"),
            new("three"),
            new("four"),
            new("five"),
            new("six"),
            new("seven"),
            new("eight"),
            new("nine"),
        ];

        Console.WriteLine("Forwards via GetEnumerator");
        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine();

        Console.WriteLine("Backwards");
        foreach (var item in items.Backwards)
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine();

        Console.WriteLine("Indexes 1,3,5,7,9");
        foreach (var item in items.FromToStep(1, items.Count - 1, 2))
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine();
    }

    private static void TestTemplateMethodPattern()
    {
        var categories = new CategoryAccessor();
        categories.Run(5);

        var products = new ProductAccessor();
        products.Run(5);
    }

    private static void TestAdapterPatten()
    {
        static void display(Compound c) => Console.WriteLine(c.ToString());
        var unknown = new Compound();
        display(unknown);

        var water = new CompoundAdapter(Chemical.Water);
        water.Analyse();
        display(water);

        var benzene = new CompoundAdapter(Chemical.Benzene);
        benzene.Analyse();
        display(benzene);

        var ethanol = new CompoundAdapter(Chemical.Ethanol);
        ethanol.Analyse();
        display(ethanol);
    }

    private static void TestCommandPattern()
    {
        var user = new User();

        user.Compute('+', 100);
        user.Compute('*', 2);
        user.Compute('-', 50);
        user.Compute('/', 2);

        user.Undo(4);
        user.Redo(3);
    }

    private static void TestStatePattern()
    {
        var account = new Account("Jim Stevens");

        account.Deposit(500.0);
        account.Deposit(600.0);
        account.Withdraw(200.0);
        account.PayInterest();
        account.Withdraw(2000);
        account.Withdraw(100);
        account.Deposit(1200);
        account.Deposit(2000000);
        account.PayInterest();
    }
}
