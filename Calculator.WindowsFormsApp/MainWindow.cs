namespace Calculator.WindowsFormsApp;

internal enum Operation
{
	None,
	Addition,
	Subtraction,
	Multiplication,
	Division,
}

public partial class MainWindow : Form
{
	private string _firstValue;
	private string _secondValue;
	private bool _isTheResultOnTheScreen = false;
	private Operation _currentOperation = Operation.None;

	public MainWindow()
	{
		InitializeComponent();
		btnClear.Select();
	}

	private void OnBtnNumberClick(object sender, EventArgs e)
	{
		var clickedValue = (sender as Button).Text;

		if (tbScreen.Text == "0" && clickedValue != ",")
		{
			tbScreen.Text = string.Empty;
		}

		if (_isTheResultOnTheScreen)
		{
			_isTheResultOnTheScreen = false;
			tbScreen.Text = string.Empty;

			if (clickedValue == ",")
			{
				clickedValue = "0,";
			}
		}

		tbScreen.Text += clickedValue;
		SetResultBtnState(true);
		if (clickedValue == ",")
		{
			SetCommaBtnState(false);
		}

		if (_currentOperation != Operation.None)
		{
			_secondValue += clickedValue;
		}
		else
		{
			SetOperationBtnState(true);
		}
	}

	private void OnBtnOperationClick(object sender, EventArgs e)
	{
		_firstValue = tbScreen.Text;
		var operation = (sender as Button).Text;

		_currentOperation = operation switch
		{
			"+" => Operation.Addition,
			"-" => Operation.Subtraction,
			"*" => Operation.Multiplication,
			"/" => Operation.Division,
			_ => Operation.None
		};

		tbScreen.Text += $" {operation} ";

		if (_isTheResultOnTheScreen)
		{
			_isTheResultOnTheScreen = false;
		}

		SetOperationBtnState(false);
		SetResultBtnState(false);
		SetCommaBtnState(true);
	}

	private void OnBtnResultClick(object sender, EventArgs e)
	{
		if (_currentOperation == Operation.None)
		{
			return;
		}

		tbScreen.Text = Calculate(double.Parse(_firstValue), double.Parse(_secondValue)).ToString();
		_secondValue = string.Empty;
		_currentOperation = Operation.None;
		_isTheResultOnTheScreen = true;
		SetOperationBtnState(true);
		SetResultBtnState(true);
		SetCommaBtnState(true);
	}

	private double Calculate(double firstNumber, double secondNumber)
	{
		return _currentOperation switch
		{
			Operation.None => firstNumber,
			Operation.Addition => firstNumber + secondNumber,
			Operation.Subtraction => firstNumber - secondNumber,
			Operation.Multiplication => firstNumber * secondNumber,
			Operation.Division => Division(firstNumber, secondNumber),
			_ => throw new ArgumentException("Wrong math operation!")
		};

		static double Division(double firstNumber, double secondNumber)
		{
			if (secondNumber == 0)
			{
				MessageBox.Show("Nie mo¿na dzieliæ przez 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 0;
			}
			return firstNumber / secondNumber;
		}
	}

	private void OnBtnClearClick(object sender, EventArgs e)
	{
		tbScreen.Text = "0";
		_firstValue = _secondValue = string.Empty;
		_currentOperation = Operation.None;
		SetOperationBtnState(true);
		SetResultBtnState(true);
		SetCommaBtnState(true);
	}

	private void SetOperationBtnState(bool value)
	{
		btnAdd.Enabled = value;
		btnSubtraction.Enabled = value;
		btnMultiplication.Enabled = value;
		btnDivision.Enabled = value;
	}

	private void SetResultBtnState(bool value)
		=> btnResult.Enabled = value;

	private void SetCommaBtnState(bool value)
		=> btnComma.Enabled = value;
}