using Calculator.WpfApp.ViewModels;
using MahApps.Metro.Controls;

namespace Calculator.WpfApp;

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