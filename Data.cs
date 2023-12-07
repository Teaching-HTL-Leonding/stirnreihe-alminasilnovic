using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;

namespace Stirnreihe.Data;

public class Person(string firstName, string lastName, int height)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public int Height { get; set; } = height;
    public override string ToString()
    {
        return $"{LastName}, {FirstName} ({Height} cm)";
    }
}
public class Node(Node? next, Person person)
{
    public Person Person { get; set; } = person;
    public Node? Next { get; set; } = next;
}
public class LineOfPeople(Node? first)
{
    public Node? First { get; set; } = first;
    public void AddToFront(Person person)
    {
        var node = new Node(First, person);
        First = node;
    }
    public void AddSorted(Person person)
    {
        var node = new Node(null, person);
        if (First == null)
        {
            First = node;
        }
        else
        {
            if (First.Person.Height > node.Person.Height)
            {
                AddToFront(person);
            }
            else
            {
                var current = First;
                while (current.Next != null)
                {
                    if (current.Person.Height < node.Person.Height && node.Person.Height < current.Next.Person.Height)
                    {
                        node.Next = current.Next;
                        current.Next = node;
                        break;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
                current.Next = node;
            }
        }
    }
    public void Clear()
    {
        First = null;
    }
}