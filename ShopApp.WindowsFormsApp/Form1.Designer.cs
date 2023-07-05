namespace ShopApp.WindowsFormsApp;

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
		LbName = new Label();
		LbAmount = new Label();
		TbName = new TextBox();
		NudAmount = new NumericUpDown();
		BtnAdd = new Button();
		DgvShopping = new DataGridView();
		((System.ComponentModel.ISupportInitialize)NudAmount).BeginInit();
		((System.ComponentModel.ISupportInitialize)DgvShopping).BeginInit();
		SuspendLayout();
		// 
		// LbName
		// 
		LbName.Location = new Point(12, 7);
		LbName.Name = "LbName";
		LbName.Size = new Size(180, 23);
		LbName.TabIndex = 0;
		LbName.Text = "Nazwa";
		LbName.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// LbAmount
		// 
		LbAmount.Location = new Point(12, 99);
		LbAmount.Name = "LbAmount";
		LbAmount.Size = new Size(180, 23);
		LbAmount.TabIndex = 1;
		LbAmount.Text = "Kwota:";
		LbAmount.TextAlign = ContentAlignment.MiddleCenter;
		// 
		// TbName
		// 
		TbName.Location = new Point(12, 33);
		TbName.Name = "TbName";
		TbName.Size = new Size(180, 23);
		TbName.TabIndex = 2;
		TbName.TextAlign = HorizontalAlignment.Center;
		// 
		// NudAmount
		// 
		NudAmount.Location = new Point(12, 125);
		NudAmount.Name = "NudAmount";
		NudAmount.Size = new Size(180, 23);
		NudAmount.TabIndex = 3;
		NudAmount.TextAlign = HorizontalAlignment.Center;
		// 
		// BtnAdd
		// 
		BtnAdd.Location = new Point(12, 194);
		BtnAdd.Name = "BtnAdd";
		BtnAdd.Size = new Size(180, 48);
		BtnAdd.TabIndex = 4;
		BtnAdd.Text = "Dodaj";
		BtnAdd.UseVisualStyleBackColor = true;
		BtnAdd.Click += BtnAdd_Click;
		// 
		// DgvShopping
		// 
		DgvShopping.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		DgvShopping.Location = new Point(198, 33);
		DgvShopping.Name = "DgvShopping";
		DgvShopping.RowTemplate.Height = 25;
		DgvShopping.Size = new Size(590, 405);
		DgvShopping.TabIndex = 5;
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Controls.Add(DgvShopping);
		Controls.Add(BtnAdd);
		Controls.Add(NudAmount);
		Controls.Add(TbName);
		Controls.Add(LbAmount);
		Controls.Add(LbName);
		Name = "Form1";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "ShopApp";
		((System.ComponentModel.ISupportInitialize)NudAmount).EndInit();
		((System.ComponentModel.ISupportInitialize)DgvShopping).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label LbName;
	private Label LbAmount;
	private TextBox TbName;
	private NumericUpDown NudAmount;
	private Button BtnAdd;
	private DataGridView DgvShopping;
}
