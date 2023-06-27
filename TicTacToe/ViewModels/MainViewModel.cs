using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Media;
using TicTacToe.WpfApp.Commands;
using TicTacToe.WpfApp.Models;

namespace TicTacToe.WpfApp.ViewModels;

public class MainViewModel : BaseViewModel
{
	private const int Size1 = 3;
	private const int Size2 = 3;
	private const string Player1Sign = "O";
	private const string Player2Sign = "X";
	private bool _isPlayer1Turn;
	private readonly SolveGame _solveGame = new();
	private int _gameNumber;

	public MainViewModel()
    {
		SetCommands();
		Reset(null);
	}

	private Bindable2DArray<Field> _board;
	public Bindable2DArray<Field> Board
	{ 
		get => _board; 
		set { _board = value; OnPropertyChanged(); } 
	}

	private string _turnInfo;
	public string TurnInfo
	{
		get => _turnInfo;
		set { _turnInfo = value; OnPropertyChanged(); }
	}

	private string _gameInfo;
	public string GameInfo
	{
		get => _gameInfo;
		set { _gameInfo = value; OnPropertyChanged(); }
	}

	private ObservableCollection<GamePlay> _gamePlays;
	public ObservableCollection<GamePlay> GamePlays
	{
		get => _gamePlays;
		set { _gamePlays = value; OnPropertyChanged(); }
	}


	public ICommand BoardClickCommand { get; private set; }
	public ICommand NewGameCommand { get; private set; }
	public ICommand ResetCommand { get; private set; }

	private void SetCommands()
	{
		BoardClickCommand = new RelayCommand(BoardClick);
		NewGameCommand = new RelayCommand(NewGame);
		ResetCommand = new RelayCommand(Reset);
	}


	private void BoardClick(object obj)
	{
		var index = obj as string;
		var clickedField = GetFieldByIndex(index);
		var sign = _isPlayer1Turn ? Player1Sign : Player2Sign;
		clickedField.Content = sign;
		clickedField.IsEnabled = false;
		var gameResult = _solveGame.GameResult(
			new string[Size1, Size2]
			{
				{ Board[0,0].Content, Board[0,1].Content, Board[0,2].Content },
				{ Board[1,0].Content, Board[1,1].Content, Board[1,2].Content },
				{ Board[2,0].Content, Board[2,1].Content, Board[2,2].Content }
			});
		if (gameResult.Result == Result.GameInProgress)
		{
			ChangePlayer();
			return;
		}
		GameOver(gameResult, index);
	}

	private void GameOver(GameResult gameResult, string? index)
	{
		if (gameResult.Result == Result.Draw)
		{
			GameInfo = "Remis.";
			GamePlays.Add(new GamePlay { Number = _gameNumber++, SignXInfo = "REMIS", SignOInfo = "REMIS" });
		}
		else if (gameResult.Result == Result.WonX)
		{
			GameInfo = $"Wygrał: {Player2Sign}. Gratulacje.";
			GamePlays.Add(new GamePlay { Number = _gameNumber++, SignXInfo = "WYGRANA", SignOInfo = "PORAŻKA" });
			DrawWinner(gameResult.WinnerType, index);
		}
		else if (gameResult.Result == Result.WonO)
		{
			GameInfo = $"Wygrał: {Player1Sign}. Gratulacje.";
			GamePlays.Add(new GamePlay { Number = _gameNumber++, SignXInfo = "PORAŻKA", SignOInfo = "WYGRANA" });
			DrawWinner(gameResult.WinnerType, index);
		}

		TurnInfo = "Koniec gry.";
		DisableField();
	}

	private void DrawWinner(WinnerType winnerType, string? index)
	{
		var rowNumber = index[0].ToString();
		var columnNumber = index[2].ToString();
		switch (winnerType)
		{
			case WinnerType.Row:
				Board[int.Parse(rowNumber), 0].Background = Brushes.Green;
				Board[int.Parse(rowNumber), 1].Background = Brushes.Green;
				Board[int.Parse(rowNumber), 2].Background = Brushes.Green;
				break;
			case WinnerType.Column:
				Board[0, int.Parse(columnNumber)].Background = Brushes.Green;
				Board[1, int.Parse(columnNumber)].Background = Brushes.Green;
				Board[2, int.Parse(columnNumber)].Background = Brushes.Green;
				break;
			case WinnerType.Diagonal:
				if (Board[0,0].Content == Board[1,1].Content && Board[1, 1].Content == Board[2,2].Content)
				{
					Board[0,0].Background = Brushes.Green;
					Board[1,1].Background = Brushes.Green;
					Board[2,2].Background = Brushes.Green;
				}
				else if (Board[0, 2].Content == Board[1, 1].Content && Board[1, 1].Content == Board[2, 0].Content)
				{
					Board[0, 2].Background = Brushes.Green;
					Board[1, 1].Background = Brushes.Green;
					Board[2, 0].Background = Brushes.Green;
				}
				break;
			default:
				throw new Exception("Invalid type");
		}
	}

	private void DisableField()
	{
		for (int i = 0; i < Size1; i++)
		{
			for (int j = 0; j < Size2; j++)
			{
				Board[i, j].IsEnabled = false;
			}
		}
	}

	private Field GetFieldByIndex(string? index)
	{
		var parts = index.Split('-');
		return Board[int.Parse(parts[0]), int.Parse(parts[1])];
	}

	private void NewGame(object obj)
	{
		InitBoard();
		ChangePlayer();
	}

	private void InitBoard()
	{
		Board = new(Size1, Size2);
		for (int i = 0; i < Size1; i++)
		{
			for (int j = 0; j < Size2; j++)
			{
				Board[i, j] = new Field()
				{
					Content = string.Empty,
					Background = Brushes.Transparent,
					IsEnabled = true,
				};
			}
		}
	}

	private void ChangePlayer()
	{
		_isPlayer1Turn = !_isPlayer1Turn;
		var playerTurn = _isPlayer1Turn ? Player1Sign : Player2Sign;
		TurnInfo = $"Oczekiwanie na: {playerTurn}";
	}

	private void Reset(object obj)
	{
		InitBoard();
		_isPlayer1Turn = true;
		TurnInfo = $"Oczekiwanie na: {Player1Sign}";
		GamePlays = new ObservableCollection<GamePlay>();
		_gameNumber = 1;
		GameInfo = "";
	}
}