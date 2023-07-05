namespace ZipApp.WindowsFormsApp;

partial class Form1
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		groupBox1 = new GroupBox();
		BtnCopyZipFile = new Button();
		BtnZipFile = new Button();
		LbZipPath = new Label();
		BtnChooseFolder = new Button();
		groupBox2 = new GroupBox();
		BtnShowUnzipFiles = new Button();
		BtnUnzipFile = new Button();
		LbUnzipFile = new Label();
		BtnChooseZipFile = new Button();
		groupBox1.SuspendLayout();
		groupBox2.SuspendLayout();
		SuspendLayout();
		// 
		// groupBox1
		// 
		groupBox1.BackColor = Color.Beige;
		groupBox1.Controls.Add(BtnCopyZipFile);
		groupBox1.Controls.Add(BtnZipFile);
		groupBox1.Controls.Add(LbZipPath);
		groupBox1.Controls.Add(BtnChooseFolder);
		groupBox1.Location = new Point(12, 12);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(295, 426);
		groupBox1.TabIndex = 0;
		groupBox1.TabStop = false;
		groupBox1.Text = "Pakowanie plików ZIP";
		// 
		// BtnCopyZipFile
		// 
		BtnCopyZipFile.Location = new Point(51, 269);
		BtnCopyZipFile.Name = "BtnCopyZipFile";
		BtnCopyZipFile.Size = new Size(166, 45);
		BtnCopyZipFile.TabIndex = 3;
		BtnCopyZipFile.Text = "Kopiuj skompresowany plik";
		BtnCopyZipFile.UseVisualStyleBackColor = true;
		BtnCopyZipFile.Click += BtnCopyZipFile_Click;
		// 
		// BtnZipFile
		// 
		BtnZipFile.Location = new Point(51, 185);
		BtnZipFile.Name = "BtnZipFile";
		BtnZipFile.Size = new Size(166, 45);
		BtnZipFile.TabIndex = 2;
		BtnZipFile.Text = "Skompresuj pliki";
		BtnZipFile.UseVisualStyleBackColor = true;
		BtnZipFile.Click += BtnZipFile_Click;
		// 
		// LbZipPath
		// 
		LbZipPath.AutoSize = true;
		LbZipPath.Location = new Point(51, 125);
		LbZipPath.Name = "LbZipPath";
		LbZipPath.Size = new Size(0, 15);
		LbZipPath.TabIndex = 1;
		// 
		// BtnChooseFolder
		// 
		BtnChooseFolder.Location = new Point(51, 36);
		BtnChooseFolder.Name = "BtnChooseFolder";
		BtnChooseFolder.Size = new Size(166, 45);
		BtnChooseFolder.TabIndex = 0;
		BtnChooseFolder.Text = "Wybierz folder";
		BtnChooseFolder.UseVisualStyleBackColor = true;
		BtnChooseFolder.Click += BtnChooseFolder_Click;
		// 
		// groupBox2
		// 
		groupBox2.BackColor = Color.MistyRose;
		groupBox2.Controls.Add(BtnShowUnzipFiles);
		groupBox2.Controls.Add(BtnUnzipFile);
		groupBox2.Controls.Add(LbUnzipFile);
		groupBox2.Controls.Add(BtnChooseZipFile);
		groupBox2.Location = new Point(313, 12);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new Size(295, 426);
		groupBox2.TabIndex = 1;
		groupBox2.TabStop = false;
		groupBox2.Text = "Rozpakowywanie plików (UNZIP)";
		// 
		// BtnShowUnzipFiles
		// 
		BtnShowUnzipFiles.Location = new Point(51, 269);
		BtnShowUnzipFiles.Name = "BtnShowUnzipFiles";
		BtnShowUnzipFiles.Size = new Size(166, 45);
		BtnShowUnzipFiles.TabIndex = 3;
		BtnShowUnzipFiles.Text = "Pokaż rozpakowane pliki";
		BtnShowUnzipFiles.UseVisualStyleBackColor = true;
		BtnShowUnzipFiles.Click += BtnShowUnzipFiles_Click;
		// 
		// BtnUnzipFile
		// 
		BtnUnzipFile.Location = new Point(51, 185);
		BtnUnzipFile.Name = "BtnUnzipFile";
		BtnUnzipFile.Size = new Size(166, 45);
		BtnUnzipFile.TabIndex = 2;
		BtnUnzipFile.Text = "Rozpakuj pliki";
		BtnUnzipFile.UseVisualStyleBackColor = true;
		BtnUnzipFile.Click += BtnUnzipFile_Click;
		// 
		// LbUnzipFile
		// 
		LbUnzipFile.AutoSize = true;
		LbUnzipFile.Location = new Point(51, 125);
		LbUnzipFile.MaximumSize = new Size(250, 0);
		LbUnzipFile.Name = "LbUnzipFile";
		LbUnzipFile.Size = new Size(0, 15);
		LbUnzipFile.TabIndex = 1;
		// 
		// BtnChooseZipFile
		// 
		BtnChooseZipFile.Location = new Point(51, 36);
		BtnChooseZipFile.Name = "BtnChooseZipFile";
		BtnChooseZipFile.Size = new Size(166, 45);
		BtnChooseZipFile.TabIndex = 0;
		BtnChooseZipFile.Text = "Wybierz plik .ZIP";
		BtnChooseZipFile.UseVisualStyleBackColor = true;
		BtnChooseZipFile.Click += BtnChooseZipFile_Click;
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(619, 450);
		Controls.Add(groupBox2);
		Controls.Add(groupBox1);
		Name = "Form1";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "Form1";
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		ResumeLayout(false);
	}

	#endregion

	private GroupBox groupBox1;
	private Label LbZipPath;
	private Button BtnChooseFolder;
	private Button BtnCopyZipFile;
	private Button BtnZipFile;
	private GroupBox groupBox2;
	private Button BtnShowUnzipFiles;
	private Button BtnUnzipFile;
	private Label LbUnzipFile;
	private Button BtnChooseZipFile;
}
