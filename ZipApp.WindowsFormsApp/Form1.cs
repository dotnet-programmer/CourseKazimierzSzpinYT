using System.Diagnostics;
using System.IO.Compression;

namespace ZipApp.WindowsFormsApp;

public partial class Form1 : Form
{
	private readonly string _filePath = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "Files");

	public Form1()
	{
		InitializeComponent();
		CreateFileDirectory();
	}

	private void BtnChooseFolder_Click(object sender, EventArgs e)
	{
		using FolderBrowserDialog folderBrowserDialog = new();
		var result = folderBrowserDialog.ShowDialog();
		if (result == DialogResult.OK)
		{
			LbZipPath.Text = folderBrowserDialog.SelectedPath;
		}
	}

	private void BtnZipFile_Click(object sender, EventArgs e)
	{
		if (!IsZipPathSelected())
		{
			ShowMessageZipPathIsNotSelected();
			return;
		}

		ZipFolder();
		MessageBox.Show("Folder zosta³ skompresowany.");
	}

	private void BtnCopyZipFile_Click(object sender, EventArgs e)
	{
		if (!IsZipPathSelected())
		{
			ShowMessageZipPathIsNotSelected();
			return;
		}

		string zipPath = GetZipPath();
		if (!File.Exists(zipPath))
		{
			MessageBox.Show("¯adne pliki nie zosta³y jeszcze skompresowane.");
			return;
		}

		Clipboard.SetFileDropList(new System.Collections.Specialized.StringCollection { zipPath });
	}

	private void BtnChooseZipFile_Click(object sender, EventArgs e)
	{
		using OpenFileDialog openFileDialog = new();
		openFileDialog.InitialDirectory = _filePath;
		openFileDialog.Filter = "Zip files (*.zip)|*.zip";
		var result = openFileDialog.ShowDialog();
		if (result == DialogResult.OK)
		{
			LbUnzipFile.Text = openFileDialog.FileName;
		}
	}

	private void BtnUnzipFile_Click(object sender, EventArgs e)
	{
		string selectedPath = LbUnzipFile.Text;

		if (!IsUnzipPathSelected())
		{
			ShowMessageUnzipPathIsNotSelected();
			return;
		}

		if (!File.Exists(selectedPath))
		{
			MessageBox.Show("Wybrany plik nie istnieje.");
			return;
		}
		string destinationDirectoryName = GetUnzipDestinationDirectoryName();
		ZipFile.ExtractToDirectory(selectedPath, destinationDirectoryName, true);
		MessageBox.Show("Wybrany plik zosta³ rozpakowany");
	}

	private void BtnShowUnzipFiles_Click(object sender, EventArgs e)
	{
		if (!IsUnzipPathSelected())
		{
			ShowMessageUnzipPathIsNotSelected();
			return;
		}
		string destinationDirectoryName = GetUnzipDestinationDirectoryName();
		if (!Directory.Exists(destinationDirectoryName))
		{
			MessageBox.Show("Pliki nie zosta³y rozpakowane.");
			return;
		}
		var startInfo = new ProcessStartInfo
		{
			Arguments = destinationDirectoryName,
			FileName = "explorer.exe"
		};
		Process.Start(startInfo);
	}

	private void CreateFileDirectory()
	{
		if (!Directory.Exists(_filePath))
		{
			Directory.CreateDirectory(_filePath);
		}
	}

	private bool IsZipPathSelected()
		=> !string.IsNullOrWhiteSpace(LbZipPath.Text);

	private bool IsUnzipPathSelected()
		=> !string.IsNullOrWhiteSpace(LbUnzipFile.Text);

	private void ShowMessageZipPathIsNotSelected()
		=> MessageBox.Show("Najpierw wybierz folder, który chcesz skompresowaæ");

	private void ShowMessageUnzipPathIsNotSelected()
		=> MessageBox.Show("Najpierw wybierz plik, który chcesz rozpakowaæ");

	private string GetZipPath()
	{
		string compressedFileName = $"{Path.GetFileName(LbZipPath.Text)}.zip";
		string destinationFileName = Path.Combine(_filePath, compressedFileName);
		return destinationFileName;
	}

	private void ZipFolder()
	{
		string destinationFileName = GetZipPath();
		if (File.Exists(destinationFileName))
		{
			File.Delete(destinationFileName);
		}
		ZipFile.CreateFromDirectory(LbZipPath.Text, destinationFileName);
	}

	private string GetUnzipDestinationDirectoryName()
	{
		string selectedPath = LbUnzipFile.Text;
		return Path.Combine(Path.GetDirectoryName(selectedPath), Path.GetFileNameWithoutExtension(selectedPath));
	}
}