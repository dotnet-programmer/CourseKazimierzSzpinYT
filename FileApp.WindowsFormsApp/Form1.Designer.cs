namespace FileApp.WindowsFormsApp;

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
		BtnSave = new Button();
		TbFileName = new TextBox();
		RtbContent = new RichTextBox();
		label1 = new Label();
		label2 = new Label();
		BtnRead = new Button();
		BtnDeleteFile = new Button();
		BtnCopy = new Button();
		pageSetupDialog1 = new PageSetupDialog();
		label = new Label();
		TbUserName = new TextBox();
		BtnSaveUserName = new Button();
		LbUserName = new Label();
		SuspendLayout();
		// 
		// BtnSave
		// 
		BtnSave.Location = new Point(12, 12);
		BtnSave.Name = "BtnSave";
		BtnSave.Size = new Size(140, 75);
		BtnSave.TabIndex = 0;
		BtnSave.Text = "Zapisz";
		BtnSave.UseVisualStyleBackColor = true;
		BtnSave.Click += BtnSave_Click;
		// 
		// TbFileName
		// 
		TbFileName.Location = new Point(207, 39);
		TbFileName.Name = "TbFileName";
		TbFileName.Size = new Size(308, 23);
		TbFileName.TabIndex = 1;
		// 
		// RtbContent
		// 
		RtbContent.Location = new Point(207, 141);
		RtbContent.Name = "RtbContent";
		RtbContent.Size = new Size(308, 272);
		RtbContent.TabIndex = 2;
		RtbContent.Text = "";
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Location = new Point(309, 21);
		label1.Name = "label1";
		label1.Size = new Size(74, 15);
		label1.TabIndex = 3;
		label1.Text = "Nazwa pliku:";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(309, 122);
		label2.Name = "label2";
		label2.Size = new Size(93, 15);
		label2.TabIndex = 4;
		label2.Text = "Zawartość pliku:";
		// 
		// BtnRead
		// 
		BtnRead.Location = new Point(12, 93);
		BtnRead.Name = "BtnRead";
		BtnRead.Size = new Size(140, 70);
		BtnRead.TabIndex = 5;
		BtnRead.Text = "Wczytaj";
		BtnRead.UseVisualStyleBackColor = true;
		BtnRead.Click += BtnRead_Click;
		// 
		// BtnDeleteFile
		// 
		BtnDeleteFile.Location = new Point(12, 169);
		BtnDeleteFile.Name = "BtnDeleteFile";
		BtnDeleteFile.Size = new Size(140, 75);
		BtnDeleteFile.TabIndex = 6;
		BtnDeleteFile.Text = "Usuń plik";
		BtnDeleteFile.UseVisualStyleBackColor = true;
		BtnDeleteFile.Click += BtnDeleteFile_Click;
		// 
		// BtnCopy
		// 
		BtnCopy.Location = new Point(12, 250);
		BtnCopy.Name = "BtnCopy";
		BtnCopy.Size = new Size(140, 75);
		BtnCopy.TabIndex = 7;
		BtnCopy.Text = "Kopiuj plik";
		BtnCopy.UseVisualStyleBackColor = true;
		BtnCopy.Click += BtnCopy_Click;
		// 
		// label
		// 
		label.AutoSize = true;
		label.Location = new Point(612, 336);
		label.Name = "label";
		label.Size = new Size(71, 15);
		label.TabIndex = 8;
		label.Text = "Użytkownik:";
		// 
		// TbUserName
		// 
		TbUserName.Location = new Point(560, 354);
		TbUserName.Name = "TbUserName";
		TbUserName.Size = new Size(192, 23);
		TbUserName.TabIndex = 9;
		// 
		// BtnSaveUserName
		// 
		BtnSaveUserName.Location = new Point(560, 390);
		BtnSaveUserName.Name = "BtnSaveUserName";
		BtnSaveUserName.Size = new Size(192, 23);
		BtnSaveUserName.TabIndex = 10;
		BtnSaveUserName.Text = "Zapisz nazwę użyszkodnika";
		BtnSaveUserName.UseVisualStyleBackColor = true;
		BtnSaveUserName.Click += BtnSaveUserName_Click;
		// 
		// LbUserName
		// 
		LbUserName.Location = new Point(532, 13);
		LbUserName.Name = "LbUserName";
		LbUserName.Size = new Size(256, 23);
		LbUserName.TabIndex = 11;
		LbUserName.TextAlign = ContentAlignment.MiddleRight;
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Controls.Add(LbUserName);
		Controls.Add(BtnSaveUserName);
		Controls.Add(TbUserName);
		Controls.Add(label);
		Controls.Add(BtnCopy);
		Controls.Add(BtnDeleteFile);
		Controls.Add(BtnRead);
		Controls.Add(label2);
		Controls.Add(label1);
		Controls.Add(RtbContent);
		Controls.Add(TbFileName);
		Controls.Add(BtnSave);
		Name = "Form1";
		Text = "Form1";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Button BtnSave;
	private TextBox TbFileName;
	private RichTextBox RtbContent;
	private Label label1;
	private Label label2;
	private Button BtnRead;
	private Button BtnDeleteFile;
	private Button BtnCopy;
	private PageSetupDialog pageSetupDialog1;
	private Label label;
	private TextBox TbUserName;
	private Button BtnSaveUserName;
	private Label LbUserName;
}
