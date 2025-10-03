using System;
using System.Collections.Generic;

namespace Library.GangOfFour.Structural.Composite;

public sealed class TreeNode<T> where T : IComparable<T>
{
    public TreeNode<T>? Parent { get; set; } = null;

    public T Node { get; set; } = default!;

    public List<TreeNode<T>> Children { get; set; } = [];

    public TreeNode(T value)
    {
        Node = value;
    }

    public TreeNode<T> Add(T child)
    {
        var newNode = new TreeNode<T>(child)
        {
            Parent = this
        };

        Children.Add(newNode);
        
        return newNode;
    }

    public void Remove(T child)
    {
        foreach (var node in Children)
        {
            if (node.Node.CompareTo(child) == 0)
            {
                Children.Remove(node);
                return;
            }
        }
    }

    public static void Display(TreeNode<T> node, int indentation)
    {
        var line = new string('-', indentation);
        Console.WriteLine(line + " " + node.Node);
        node.Children.ForEach(n => Display(n, indentation + 1));
    }
}