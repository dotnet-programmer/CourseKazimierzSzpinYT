using Calculations.ConsoleApp;
using NUnit.Framework;

namespace Calculations.UnitTests;

internal class FizzBuzzTests
{
	[Test]
	public void GetOutput_WhenInputIsDivisibleOnlyBy3_ShouldReturnFizz()
	{
		// arrange
		FizzBuzz fizzBuzz = new();

		// act
		var result = fizzBuzz.GetOutput(3);

		// assert
		Assert.That(result, Is.EqualTo("Fizz"));
	}

	[Test]
	public void GetOutput_WhenInputIsDivisibleOnlyBy5_ShouldReturnBuzz()
	{
		// arrange
		FizzBuzz fizzBuzz = new();

		// act
		var result = fizzBuzz.GetOutput(5);

		// assert
		Assert.That(result, Is.EqualTo("Buzz"));
	}

	[Test]
	public void GetOutput_WhenInputIsDivisibleBy3And5_ShouldReturnFizzBuzz()
	{
		// arrange
		FizzBuzz fizzBuzz = new();

		// act
		var result = fizzBuzz.GetOutput(15);

		// assert
		Assert.That(result, Is.EqualTo("FizzBuzz"));
	}

	[Test]
	public void GetOutput_WhenInputIsNotDivisibleBy3Or5_ShouldReturnFizzInput()
	{
		// arrange
		FizzBuzz fizzBuzz = new();

		// act
		var result = fizzBuzz.GetOutput(1);

		// assert
		Assert.That(result, Is.EqualTo("1"));
	}
}