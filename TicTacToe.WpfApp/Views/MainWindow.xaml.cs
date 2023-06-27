using MahApps.Metro.Controls;
using TicTacToe.WpfApp.ViewModels;

namespace TicTacToe.WpfApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : MetroWindow
{
	public MainWindow()
	{
		InitializeComponent();
		DataContext = new MainViewModel();
	}
}