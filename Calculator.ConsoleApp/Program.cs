/*
 *  1. Write application description
 *  2. Write a request for 1st number
 *  3. Get a number from the user
 *  4. Write a request for operation
 *  5. Get an operation from the user
 *  6. Write a request for 2nd number
 *  7. Get a number from the user
 *  8. Calculate
 *  9. Write result
 */

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("CALCULATOR APP!");

string[] operations = { "+", "-", "*", "/", "%" };

while (true)
{
	Console.Write("\nWrite 1st number: ");
	double number1 = GetInput();

	Console.Write("Write type of operation (+, -, *, /, %): ");
	string operation = GetOperation();

	Console.Write("Write 2nd number: ");
	double number2 = GetInput();

	try
	{
		Console.WriteLine($"\n{number1} {operation} {number2} = {Math.Round(Calculate(number1, number2, operation), 4)}\n");
	}
	catch (Exception ex)
	{
		Console.WriteLine($"Error! {ex.Message}");
	}
}

static double GetInput()
{
	while (true)
	{
		if (double.TryParse(Console.ReadLine(), out double input))
		{
			return input;
		}
		Console.Write("Error! Wrong input! Write number: ");
	}
}

string GetOperation()
{
	while (true)
	{
		string operation = Console.ReadLine();
		if (operations.Contains(operation))
		{
			return operation;
		}
		Console.Write("Error! Wrong input! Write operation (+, -, *, /, %): ");
	}
}

static double Calculate(double number1, double number2, string operation) => operation switch
{
	"+" => number1 + number2,
	"-" => number1 - number2,
	"*" => number1 * number2,
	"/" => number1 / number2,
	"%" => number1 % number2,
	_ => throw new InvalidOperationException("Unknown operation.")
};