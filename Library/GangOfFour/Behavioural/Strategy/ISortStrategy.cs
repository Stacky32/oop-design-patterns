using System.Collections.Generic;

namespace Library.GangOfFour.Behavioural.Strategy;

public interface ISortStrategy
{
    void Sort(List<Student> list);
}