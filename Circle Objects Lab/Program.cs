using Circle_Objects_Lab;


Console.WriteLine("Welcome to the Circle Tester!");

List<Circle> allCircles = new List<Circle>();
bool runProgram = true;
while (runProgram)
{
    double input = Validator.GetNumberInRange(0);

    Console.WriteLine("Enter a radius:");
    //double input = -1;
    //while(input <= 0)
    //while (double.TryParse(Console.ReadLine(), out input) == false)
    //{
    //console.WriteLine("That was invalid.Try again");
    //}
    //if(input <= 0)
    //{
    //Console.WriteLine("Value is too low.Try again."
    //}
    //}

    //Create circle object
    //CircleObj myCircle = new CircleObj(input);
    //Console.WriteLine($"Circumfrence: {myCircle.CalculateFormattedCircumference()}");
    //Console.WriteLine($Area: {myCircle.CalculatedFormattedArea()}");

    double userInput = double.Parse(Console.ReadLine());
    int numOfTries = 1;

    if (userInput > 0)
    {
        Circle myCircle = new Circle(userInput);
        allCircles.Add(myCircle);
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
    }
}



//------------------------------------
//Track how many times a user input

//List<CircleObj> allCircles = new List<CircleObj>();
//outside of code


//below code
//Console.WriteLine($"You created {allCircles.Count} circles.");

//foreach (CircleObj c in allCircles)
//{
//    Console.WriteLine($"Radius: {c.Radius} Area: {c.CalculateFormattedArea()} Circumference {c.CalculateFormattedCircumference()}");
//}