using Library.GangOfFour.Creational.FactoryMethod.Pages;

namespace Library.GangOfFour.Creational.FactoryMethod.Documents;

public sealed class Resume : Document
{
    public override void CreatePages()
    {
        Pages = [
            new SkillsPage(),
            new EducationPage(),
            new ExperiencePage(),
        ];
    }
}