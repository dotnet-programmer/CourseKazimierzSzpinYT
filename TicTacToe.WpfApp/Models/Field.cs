using System.Windows.Media;
using TicTacToe.WpfApp.ViewModels;

namespace TicTacToe.WpfApp.Models;

public class Field : BaseViewModel
{
	private string _content;
	public string Content
	{
		get => _content;
		set { _content = value; OnPropertyChanged(); }
	}

	private bool _isEnabled;
	public bool IsEnabled
	{
		get => _isEnabled;
		set { _isEnabled = value; OnPropertyChanged(); }
	}

	private Brush _background;
	public Brush Background
	{
		get => _background;
		set { _background = value; OnPropertyChanged(); }
	}
}