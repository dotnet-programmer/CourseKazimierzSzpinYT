using Hangman.WpfApp.Commands;
using Hangman.WpfApp.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Hangman.WpfApp.ViewModels;

internal class MainViewModel : BaseViewModel
{
	private const int MaxAttempts = 10;

	private readonly Random _random = new();
	private List<string> _availableWords;
	private string _guessingWord;
	private int _wrongAttempts;
	private bool _isGameOver = false;

	public MainViewModel()
	{
		SetCommands();
		GetAvailableWordsFromFile();
	}

	private ObservableCollection<char> _guessingLetters = new();
	public ObservableCollection<char> GuessingLetters
	{
		get => _guessingLetters;
		set { _guessingLetters = value; OnPropertyChanged(); }
	}

	private string _gameStatus = "Kliknij przycisk NOWA GRA aby rozpocząć grę.";
	public string GameStatus
	{
		get => _gameStatus;
		set { _gameStatus = value; OnPropertyChanged(); }
	}

	private Brush _backgroundColor = Brushes.White;
	public Brush BackgroundColor
	{
		get => _backgroundColor;
		set { _backgroundColor = value; OnPropertyChanged(); }
	}

	private BitmapSource _hangmanPicture;
	public BitmapSource HangmanPicture
	{
		get => _hangmanPicture;
		set { _hangmanPicture = value; OnPropertyChanged(); }
	}

	public ICommand NewGameCommand { get; private set; }
	public ICommand KeyClickedCommand { get; private set; }

	private void SetCommands()
	{
		NewGameCommand = new RelayCommand(NewGame);
		KeyClickedCommand = new RelayCommand(KeyClicked);
	}

	private void NewGame(object keyboardGrid)
	{
		_isGameOver = false;
		_wrongAttempts = 0;
		GameStatus = "Kliknij w wybraną literę w celu odgadnięcia hasła...";
		BackgroundColor = Brushes.White;
		EnableKeyboard(keyboardGrid as Grid);
		NewRandomWord();
		InitBoard();
		UpdateImage();
	}

	private void EnableKeyboard(Grid? grid)
	{
		foreach (StackPanel stackPanel in grid.Children)
		{
			foreach (Button button in stackPanel.Children)
			{
				button.IsEnabled = true;
			}
		}
	}

	private void NewRandomWord() => _guessingWord = _availableWords[_random.Next(_availableWords.Count)].ToUpper();

	private void InitBoard()
	{
		GuessingLetters.Clear();
		foreach (var item in _guessingWord)
		{
			char letter = item == ' ' ? ' ' : '\0';
			GuessingLetters.Add(letter);
		}
	}

	private void UpdateImage() => HangmanPicture = new BitmapImage(new Uri(Path.Combine(Environment.CurrentDirectory, "Images", $"{_wrongAttempts}_mistake.png")));

	private void KeyClicked(object clickedButton)
	{
		if (_isGameOver)
		{
			return;
		}

		(clickedButton as Button).IsEnabled = false;
		var choosenKey = Convert.ToChar((clickedButton as Button).Content);
		var keyExistsInGuessingWord = _guessingWord.Contains(choosenKey);

		if (!keyExistsInGuessingWord)
		{
			_wrongAttempts++;
			UpdateImage();

			if (_wrongAttempts == MaxAttempts)
			{
				_isGameOver = true;
				GameStatus = $"Niestety przegrałeś. Prawidłowe hasło to: {_guessingWord}";
				BackgroundColor = Brushes.OrangeRed;
			}
			return;
		}

		for (int i = 0; i < _guessingWord.Length; i++)
		{
			if (_guessingWord[i] == choosenKey)
			{
				GuessingLetters[i] = choosenKey;
			}
		}

		if (!GuessingLetters.Contains('\0'))
		{
			_isGameOver = true;
			GameStatus = "Gratulacje. Wygrałeś!";
			BackgroundColor = Brushes.LightGreen;
		}
	}

	private void GetAvailableWordsFromFile()
	{
		if (!FileHelper.FileExists())
		{
			FileHelper.CreateNewFile();
		}
		_availableWords = FileHelper.GetAvailableWords();
	}
}