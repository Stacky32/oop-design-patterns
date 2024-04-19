using System;
using System.Collections.Generic;

namespace Library.GangOfFour.Behavioural.Strategy;

public class SortedList : List<Student>
{
    public ISortStrategy SortStrategy { get; set; } = null!;

    public void SortStudents()
    {
        SortStrategy.Sort(this);

        foreach (var student in this)
        {
            Console.WriteLine(student.Name);
        }

        Console.WriteLine();
    }
}