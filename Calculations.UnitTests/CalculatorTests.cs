using Calculations.ConsoleApp;
using NUnit.Framework;

namespace Calculations.UnitTests;

internal class CalculatorTests
{
	[Test]
	public void Add_WhenCalled_ShouldReturnSum()
	{
		// Arrange - przygotowanie, inicjalizowane obiekty
		Calculator calculator = new();

		// Act - działanie, wykonywanie metody którą chcemy testować
		int result = calculator.Add(1, 2);

		// Assert - sprawdzanie wyniku oczekiwanego z faktycznym
		Assert.That(result, Is.EqualTo(3));
	}
}