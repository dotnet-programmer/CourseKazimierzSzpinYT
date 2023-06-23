using Calculator.WpfApp.Commands;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Calculator.WpfApp.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler? PropertyChanged;

	private readonly string[] _operations = { "+", "-", "*", "/", "%" };
	private readonly DataTable _dataTable = new();
	private bool _isLastSignAndOperation;

	public MainViewModel()
	{
		Screen = "0";
		SetCommands();
	}

	private string _screen;
	public string Screen
	{
		get => _screen;
		set { _screen = value; OnPropertyChanged(); }
	}

	public ICommand AddNumberCommand { get; private set; }
	public ICommand AddOperationCommand { get; private set; }
	public ICommand ClearScreenCommand { get; private set; }
	public ICommand GetResultCommand { get; private set; }

	private void SetCommands()
	{
		AddNumberCommand = new RelayCommand(AddNumber);
		AddOperationCommand = new RelayCommand(AddOperation, CanAddOperation);
		ClearScreenCommand = new RelayCommand(ClearScreen);
		GetResultCommand = new RelayCommand(GetResult, CanGetResult);
	}

	private void AddNumber(object obj)
	{
		var number = obj as string;

		if (Screen == "0" && number != ",")
		{
			Screen = string.Empty;
		}
		else if (number == "," && _operations.Contains(Screen[^1..]))
		{
			number = "0, ";
		}

		Screen += number;
		_isLastSignAndOperation = false;
	}

	private void AddOperation(object obj)
	{
		var operation = obj as string;
		Screen += operation;
		_isLastSignAndOperation = true;
	}

	private bool CanAddOperation(object obj) => !_isLastSignAndOperation;

	private void ClearScreen(object obj)
	{
		Screen = "0";
		_isLastSignAndOperation = false;
	}

	private void GetResult(object obj) => Screen = _dataTable.Compute(Screen.Replace(",", "."), "").ToString();

	private bool CanGetResult(object obj) => !_isLastSignAndOperation;

	private void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}