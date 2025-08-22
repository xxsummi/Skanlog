
using Exercise1;

int select, id;
var StudentsList = new Operations.PersonsList();

do
{
    Console.WriteLine("Student Management");
    Console.WriteLine("1. Add a Student");
    Console.WriteLine("2. Suspend a Student ");
    Console.WriteLine("3. Unsuspend a Student ");
    Console.WriteLine("4. Display List of Students and List of Suspended Students");
    Console.WriteLine("5. Display Number of Students and Suspended Students");
    Console.WriteLine("6. Exit Program");
    Console.Write("Select Option: ");

    if (int.TryParse(Console.ReadLine(), out select))
    {
        switch (select)
        {
            case 1:
                Console.Write("Enter Student ID: ");
                int.TryParse(Console.ReadLine(), out id);
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter age: ");
                int.TryParse(Console.ReadLine(), out int age);
                Console.Write("Enter School: ");
                string school = Console.ReadLine();

                StudentsList.AddPerson(id, name, age, school);
                break;
            case 2:
                Console.WriteLine("Suspend a Student: ");
                Console.Write("Enter student ID to suspend: ");
                int.TryParse(Console.ReadLine(), out id);
                StudentsList.SuspendPerson(id);
                break;
            case 3:
                Console.WriteLine("Unsuspend a Student: ");
                Console.Write("Enter student ID to unsuspend:");
                int.TryParse(Console.ReadLine(), out id);
                StudentsList.UnsuspendPerson(id);
                break;
            case 4:
                StudentsList.displayLists();
                break;
            case 5:
                StudentsList.displayNumbers();
                break;
            case 6:
                Console.WriteLine("Exiting Program.");
                break;
            default:
                Console.WriteLine("Invalid Input.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
    Console.WriteLine();
} while (select != 6);