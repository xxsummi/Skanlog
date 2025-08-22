using Exercise2;

var history = new Operations.HistoryList();
string operatorMath = String.Empty;


do
{
    Console.WriteLine("Simple Calculator");

    Console.WriteLine("1. Calculate\n2. View History");
    Console.Write("Select Option: ");
    int.TryParse(Console.ReadLine(), out int select);
    if(select == 1)
    {
        Console.WriteLine("\n+ Addition\n- Subtraction\n* Multiplication\n/ Division");
        Console.Write("Enter first operand: ");
        int.TryParse(Console.ReadLine(), out int var1);
        Console.Write("Enter operator: ");
        operatorMath = Console.ReadLine();
        Console.Write("Enter second operand: ");
        int.TryParse(Console.ReadLine(), out int var2);
        Console.Write("Result: ");
        history.Operate(var1, operatorMath, var2);
    } else if(select == 2)
    {
        history.ViewHistory();
    }
    else
    {
        Console.WriteLine("Invalid Input. Try Again.");
    }
    

}while (true);