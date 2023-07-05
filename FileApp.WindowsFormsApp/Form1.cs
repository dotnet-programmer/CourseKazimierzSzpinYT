using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FileApp.WindowsFormsApp;

public partial class Form1 : Form
{
	private const string FileNameUserName = "UserName.txt";

	public Form1()
	{
		InitializeComponent();

		string userNamePath = GetFullPath(FileNameUserName);
		if (File.Exists(userNamePath))
		{
			LbUserName.Text = $"Witaj {File.ReadAllText(userNamePath)}";
		}
	}

	private void BtnSave_Click(object sender, EventArgs e)
	{
		var fileName = TbFileName.Text;
		if (string.IsNullOrWhiteSpace(fileName))
		{
			MessageBox.Show("Podaj nazwê pliku");
			return;
		}

		string path = GetFullPath(fileName);

		//using (FileStream fileStream = System.IO.File.Create(path))
		//{
		//	var text = RtbContent.Text;
		//	var content = Encoding.UTF8.GetBytes(text);
		//	fileStream.Write(content, 0, content.Length);
		//}

		if (File.Exists(path))
		{
			MessageBox.Show("Plik o takiej nazwie ju¿ istnieje");
			return;
		}

		File.WriteAllText(path, RtbContent.Text);
		//File.AppendAllText(path, RtbContent.Text);
	}

	private void BtnRead_Click(object sender, EventArgs e)
	{
		var fileName = TbFileName.Text;
		if (string.IsNullOrWhiteSpace(fileName))
		{
			MessageBox.Show("Podaj nazwê pliku");
			return;
		}
		string path = GetFullPath(fileName);
		RtbContent.Text = File.ReadAllText(path);
	}

	private void BtnDeleteFile_Click(object sender, EventArgs e)
	{
		var fileName = TbFileName.Text;
		if (string.IsNullOrWhiteSpace(fileName))
		{
			MessageBox.Show("Podaj nazwê pliku");
			return;
		}
		string path = GetFullPath(fileName);
		File.Delete(path);
	}

	private void BtnCopy_Click(object sender, EventArgs e)
	{
		var fileName = TbFileName.Text;
		if (string.IsNullOrWhiteSpace(fileName))
		{
			MessageBox.Show("Podaj nazwê pliku");
			return;
		}
		string path = GetFullPath(fileName);
		File.Copy(path, GetFullPath("NowyPlik.txt"));
	}

	private static string GetFullPath(string fileName)
	{
		var binPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
		var expectedDirectory = Path.Combine(binPath, "myFiles");
		if (!Directory.Exists(expectedDirectory))
		{
			Directory.CreateDirectory(expectedDirectory);
		}
		return Path.Combine(expectedDirectory, fileName);
	}

	private void BtnSaveUserName_Click(object sender, EventArgs e)
	{
		var userName = TbUserName.Text;
		if (string.IsNullOrWhiteSpace(userName))
		{
			MessageBox.Show("Podaj nazwê u¿ytkownika");
			return;
		}
		File.WriteAllText(GetFullPath(FileNameUserName), userName);
		LbUserName.Text = $"Witaj {userName}";
	}
}
