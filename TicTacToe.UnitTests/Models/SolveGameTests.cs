using NUnit.Framework;
using TicTacToe.WpfApp.Models;

namespace TicTacToe.UnitTests.Models;

internal class SolveGameTests
{
	[TestCase("X", 0)]
	[TestCase("O", 1)]
	public void GameResult_WhenPlayerWinsInRow_ShouldReturnCorrectWinner(string player, int gameResult)
	{
		// arrange
		var board = new string[,]
		{
			{ player, player, player },
			{ "X", "O", "X" },
			{ "", "", "" },
		};
		SolveGame solveGame = new();

		// act
		var result = solveGame.GameResult(board);

		// assert
		Assert.That(result.Result, Is.EqualTo((Result)gameResult));
	}

	[Test]
	public void GameResult_WhenPlayerWinsInRow_ShouldReturnWinnerTypeRow()
	{
		// arrange
		var board = new string[,]
		{
			{ "X", "X", "X" },
			{ "X", "O", "X" },
			{ "", "", "" },
		};
		SolveGame solveGame = new();

		// act
		var result = solveGame.GameResult(board);

		// assert
		Assert.That(result.WinnerType, Is.EqualTo(WinnerType.Row));
	}

	[TestCase("X", 0)]
	[TestCase("O", 1)]
	public void GameResult_WhenPlayerWinsInColumn_ShouldReturnCorrectWinner(string player, int gameResult)
	{
		// arrange
		var board = new string[,]
		{
			{ player, "O", "X" },
			{ player, "O", "X" },
			{ player, "", "" },
		};
		SolveGame solveGame = new();

		// act
		var result = solveGame.GameResult(board);

		// assert
		Assert.That(result.Result, Is.EqualTo((Result)gameResult));
	}

	[Test]
	public void GameResult_WhenPlayerWinsInColumn_ShouldReturnWinnerTypeColumn()
	{
		// arrange
		var board = new string[,]
		{
			{ "X", "", "X" },
			{ "X", "O", "" },
			{ "X", "", "" },
		};
		SolveGame solveGame = new();

		// act
		var result = solveGame.GameResult(board);

		// assert
		Assert.That(result.WinnerType, Is.EqualTo(WinnerType.Column));
	}

	[TestCase("X", 0)]
	[TestCase("O", 1)]
	public void GameResult_WhenPlayerWinsInDiagonal_ShouldReturnCorrectWinner(string player, int gameResult)
	{
		// arrange
		var board = new string[,]
		{
			{ player, player, "" },
			{ "O", player, "X" },
			{ "", "", player },
		};
		SolveGame solveGame = new();

		// act
		var result = solveGame.GameResult(board);

		// assert
		Assert.That(result.Result, Is.EqualTo((Result)gameResult));
	}

	[Test]
	public void GameResult_WhenPlayerWinsInDiagonal_ShouldReturnWinnerTypeDiagonal()
	{
		// arrange
		var board = new string[,]
		{
			{ "X", "", "X" },
			{ "O", "X", "" },
			{ "O", "", "X" },
		};
		SolveGame solveGame = new();

		// act
		var result = solveGame.GameResult(board);

		// assert
		Assert.That(result.WinnerType, Is.EqualTo(WinnerType.Diagonal));
	}

	[Test]
	public void GameResult_WhenGameIsNotSolved_ShouldReturnGameInProgress()
	{
		// arrange
		var board = new string[,]
		{
			{ "", "", "X" },
			{ "O", "X", "" },
			{ "O", "", "X" },
		};
		SolveGame solveGame = new();

		// act
		var result = solveGame.GameResult(board);

		// assert
		Assert.That(result.Result, Is.EqualTo(Result.GameInProgress));
	}

	[Test]
	public void GameResult_WhenGameIsNotSolved_ShouldReturnWinnerTypeNone()
	{
		// arrange
		var board = new string[,]
		{
			{ "", "", "X" },
			{ "O", "X", "" },
			{ "O", "", "X" },
		};
		SolveGame solveGame = new();

		// act
		var result = solveGame.GameResult(board);

		// assert
		Assert.That(result.WinnerType, Is.EqualTo(WinnerType.None));
	}

	[Test]
	public void GameResult_WhenGameIsTied_ShouldReturnDraw()
	{
		// arrange
		var board = new string[,]
		{
			{ "X", "O", "X" },
			{ "O", "X", "O" },
			{ "O", "X", "O" },
		};
		SolveGame solveGame = new();

		// act
		var result = solveGame.GameResult(board);

		// assert
		Assert.That(result.Result, Is.EqualTo(Result.Draw));
	}

	[Test]
	public void GameResult_WhenGameIsTied_ShouldReturnWinnerTypeNone()
	{
		// arrange
		var board = new string[,]
		{
			{ "X", "O", "X" },
			{ "O", "X", "O" },
			{ "O", "X", "O" },
		};
		SolveGame solveGame = new();

		// act
		var result = solveGame.GameResult(board);

		// assert
		Assert.That(result.WinnerType, Is.EqualTo(WinnerType.None));
	}
}