using ConsoleApp7;

class Program
{
    static void Main()
    {
        Console.WriteLine("Select a task to execute: \n1\n2\n3\n4\n5");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Task1.Execute();
                break;

            case "2":
                Task2.Execute();
                break;
            case "3":
                Task3.Execute();
                break;
            case "4":
                Task4.Execute();
                break;
            case "5":
                Task5.Execute();
                break;
            default:
                Console.WriteLine("Invalid choice. Please select 1,2,3,4 or 5.");
                break;
        }
    }
}
