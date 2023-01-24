using Circle_Objects_Lab;


Console.WriteLine("Welcome to the Circle Tester!");

bool runProgram = true;
//bool response = true;
while (runProgram)
{
    Console.WriteLine("Enter a radius:");
    double userInput = double.Parse(Console.ReadLine());
    int numOfTries = 1;

    if (userInput > 0)
    {
        Circle myCircle = new Circle(userInput);
        Console.WriteLine(myCircle.CalculateFormattedCircumference());
        Console.WriteLine(myCircle.CalculateFormattedArea());
    }
    else if (userInput <= 0)
    {
        Console.WriteLine("Invalid response. Please try again.");
        runProgram = true;
    }

    Console.WriteLine("Continue? (y/n):");
    string response = Console.ReadLine().ToLower().Trim();
    if (response == "y")
    {
        runProgram = true;
    }
    else if (response == "n")
    {
        runProgram = false;
        Console.WriteLine($"Goodbye! You created {numOfTries} Circle Object(s)");

        //foreach (Circle c in myCircle.Where()
        //{
        //    Console.WriteLine($"Goodbye! You created {c} Circle Object(s)");
        //}
    }
    Console.ReadLine();
}



