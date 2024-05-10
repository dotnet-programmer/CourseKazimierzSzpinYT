using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe.WpfApp.Models;

public class SolveGame
{
	private string _winner;
	private WinnerType _winnerType;

	public GameResult GameResult(string[,] board)
		=> RowIsWon(board) || ColumnIsWon(board) || DiagonalIsWon(board)
			? new GameResult()
			{
				Result = _winner == "X" ? Result.WonX : Result.WonO,
				WinnerType = _winnerType
			}
			: GameIsInProgress(board);

	private bool RowIsWon(string[,] board)
	{
		for (int i = 0; i < board.GetLength(0); i++)
		{
			var row = GetRow(board, i);
			if (CheckIfGameIsWon(row))
			{
				_winner = row[0];
				_winnerType = WinnerType.Row;
				return true;
			}
		}
		return false;
	}

	private List<string> GetRow(string[,] board, int r)
	{
		var row = new List<string>();
		for (int c = 0; c < board.GetLength(1); c++)
		{
			row.Add(board[r, c]);
		}
		return row;
	}

	private bool ColumnIsWon(string[,] board)
	{
		for (int i = 0; i < board.GetLength(1); i++)
		{
			var column = GetColumn(board, i);
			if (CheckIfGameIsWon(column))
			{
				_winner = column[0];
				_winnerType = WinnerType.Column;
				return true;
			}
		}
		return false;
	}

	private List<string> GetColumn(string[,] board, int c)
	{
		var col = new List<string>();
		for (int r = 0; r < board.GetLength(0); r++)
		{
			col.Add(board[r, c]);
		}
		return col;
	}

	private bool DiagonalIsWon(string[,] board)
	{
		var diagonal = GetDiagonal(board);
		for (int i = 0; i < 2; i++)
		{
			if (CheckIfGameIsWon(diagonal[i]))
			{
				_winner = diagonal[i][0];
				_winnerType = WinnerType.Diagonal;
				return true;
			}
		}
		return false;
	}

	private List<List<string>> GetDiagonal(string[,] board)
	{
		var diagonal = new List<List<string>> { new(), new() };
		for (int i = 0; i < board.GetLength(0); i++)
		{
			diagonal[0].Add(board[i, i]);
		}
		for (int i = board.GetLength(0) - 1, j = 0; i >= 0; i--, j++)
		{
			diagonal[1].Add(board[i, j]);
		}
		return diagonal;
	}

	private bool CheckIfGameIsWon(List<string> list)
		=> list.All(x => x != string.Empty && x == list.First());

	private GameResult GameIsInProgress(string[,] board)
		=> board.Cast<string>().Contains(string.Empty)
			? new GameResult { Result = Result.GameInProgress }
			: new GameResult { Result = Result.Draw };
}