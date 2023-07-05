using Newtonsoft.Json;
using ShopApp.WindowsFormsApp.Models;
using System.ComponentModel;

namespace ShopApp.WindowsFormsApp;

public partial class Form1 : Form
{
	private BindingList<Purchase> _purchases = new();
	private readonly string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "data.json");

	public Form1()
	{
		InitializeComponent();

		// deserializacja
		CreateDataFile();
		GetDataFromFile();

		DgvShopping.DataSource = _purchases;
	}

	private void BtnAdd_Click(object sender, EventArgs e)
	{
		string name = TbName.Text;
		if (string.IsNullOrWhiteSpace(name))
		{
			MessageBox.Show("Wpisz nazwê produktu!");
			return;
		}

		AddPurchase();

		// serializacja
		SaveData();

		ClearFields();
	}

	private void CreateDataFile()
	{
		if (!File.Exists(_filePath))
		{
			File.Create(_filePath).Dispose();
		}
	}

	private void GetDataFromFile()
	{
		string json = File.ReadAllText(_filePath);
		_purchases = JsonConvert.DeserializeObject<BindingList<Purchase>>(json);
		if (_purchases == null || !_purchases.Any())
		{
			_purchases = new();
		}
	}

	private void AddPurchase()
	{
		Purchase purchase = new()
		{
			Amount = NudAmount.Value,
			Name = TbName.Text,
			CreatedDate = DateTime.UtcNow,
		};
		_purchases.Add(purchase);
	}

	private void SaveData()
	{
		string json = JsonConvert.SerializeObject(_purchases);
		File.WriteAllText(_filePath, json);
	}

	private void ClearFields()
	{
		TbName.Text = string.Empty;
		NudAmount.Value = 0;
	}
}