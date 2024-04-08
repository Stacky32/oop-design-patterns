using Library.GangOfFour.Creational.FactoryMethod.Pages;

namespace Library.GangOfFour.Creational.FactoryMethod.Documents;

public sealed class Report : Document
{
    public override void CreatePages()
    {
        Pages = [
            new IntroductionPage(),
            new ConclusionPage(),
            new SummaryPage(),
            new BibliographyPage(),
        ];
    }
}