using Stirnreihe.Data;

Console.WriteLine("Welcome to the Stirnreihe World Record App! What do you want to do?");
Console.WriteLine("1) Add a person to the line");
Console.WriteLine("2) Print the line");
Console.WriteLine("3) Clear the line");
Console.WriteLine("4) Exit");
var choice = "";
var firstName = "";
var lastName = "";
var height = 0;
var person = new Person(firstName, lastName, height);
var linesOfPeople = new LineOfPeople(null);

do
{
    Console.Write("Your choice: ");
    choice = Console.ReadLine()!;
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            Console.Write("First name: ");
            firstName = Console.ReadLine()!;
            Console.Write("Last name: ");
            lastName = Console.ReadLine()!;
            Console.Write("Height in cm: ");
            height = int.Parse(Console.ReadLine()!);
            person = new Person(firstName, lastName, height);
            linesOfPeople.AddToFront(person);
            break;
        case "1b":
            Console.Write("First name: ");
            firstName = Console.ReadLine()!;
            Console.Write("Last name: ");
            lastName = Console.ReadLine()!;
            Console.Write("Height in cm: ");
            height = int.Parse(Console.ReadLine()!);
            person = new Person(firstName, lastName, height);
            linesOfPeople.AddSorted(person);
            break;
        case "2":
            var current = linesOfPeople.First;
            while (current != null)
            {
                Console.WriteLine(current.Person.ToString());
                current = current.Next;
            }
            break;
        case "3":
            linesOfPeople.Clear();
            Console.WriteLine("The line has been cleared.");
            break;
        case "4":
            break;
        default:
            Console.WriteLine("Wrong choice");
            return;
    }
    Console.WriteLine();
}
while (choice != "4");