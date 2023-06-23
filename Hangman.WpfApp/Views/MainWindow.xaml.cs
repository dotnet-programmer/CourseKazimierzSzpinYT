using Hangman.WpfApp.ViewModels;
using MahApps.Metro.Controls;

namespace Hangman.WpfApp;

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