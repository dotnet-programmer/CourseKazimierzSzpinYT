namespace Calculator.WindowsFormsApp
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			tableLayoutPanel1 = new TableLayoutPanel();
			btnClear = new Button();
			btnComma = new Button();
			btn0 = new Button();
			btnResult = new Button();
			btnDivision = new Button();
			btn3 = new Button();
			btn2 = new Button();
			btn1 = new Button();
			btnMultiplication = new Button();
			btn6 = new Button();
			btn5 = new Button();
			btn4 = new Button();
			btnAdd = new Button();
			btnSubtraction = new Button();
			btn9 = new Button();
			btn8 = new Button();
			tbScreen = new TextBox();
			btn7 = new Button();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 5;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.Controls.Add(btnClear, 3, 4);
			tableLayoutPanel1.Controls.Add(btnComma, 2, 4);
			tableLayoutPanel1.Controls.Add(btn0, 0, 4);
			tableLayoutPanel1.Controls.Add(btnResult, 4, 3);
			tableLayoutPanel1.Controls.Add(btnDivision, 3, 3);
			tableLayoutPanel1.Controls.Add(btn3, 2, 3);
			tableLayoutPanel1.Controls.Add(btn2, 1, 3);
			tableLayoutPanel1.Controls.Add(btn1, 0, 3);
			tableLayoutPanel1.Controls.Add(btnMultiplication, 3, 2);
			tableLayoutPanel1.Controls.Add(btn6, 2, 2);
			tableLayoutPanel1.Controls.Add(btn5, 1, 2);
			tableLayoutPanel1.Controls.Add(btn4, 0, 2);
			tableLayoutPanel1.Controls.Add(btnAdd, 4, 1);
			tableLayoutPanel1.Controls.Add(btnSubtraction, 3, 1);
			tableLayoutPanel1.Controls.Add(btn9, 2, 1);
			tableLayoutPanel1.Controls.Add(btn8, 1, 1);
			tableLayoutPanel1.Controls.Add(tbScreen, 0, 0);
			tableLayoutPanel1.Controls.Add(btn7, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 5;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.Size = new Size(384, 361);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// btnClear
			// 
			btnClear.BackColor = Color.IndianRed;
			btnClear.Dock = DockStyle.Fill;
			btnClear.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnClear.ForeColor = Color.White;
			btnClear.Location = new Point(231, 289);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(70, 69);
			btnClear.TabIndex = 19;
			btnClear.Text = "C";
			btnClear.UseVisualStyleBackColor = false;
			btnClear.Click += OnBtnClearClick;
			// 
			// btnComma
			// 
			btnComma.BackColor = Color.MediumSeaGreen;
			btnComma.Dock = DockStyle.Fill;
			btnComma.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnComma.ForeColor = Color.White;
			btnComma.Location = new Point(155, 289);
			btnComma.Name = "btnComma";
			btnComma.Size = new Size(70, 69);
			btnComma.TabIndex = 18;
			btnComma.Text = ",";
			btnComma.UseVisualStyleBackColor = false;
			btnComma.Click += OnBtnNumberClick;
			// 
			// btn0
			// 
			btn0.BackColor = Color.MediumSeaGreen;
			tableLayoutPanel1.SetColumnSpan(btn0, 2);
			btn0.Dock = DockStyle.Fill;
			btn0.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btn0.ForeColor = Color.White;
			btn0.Location = new Point(3, 289);
			btn0.Name = "btn0";
			btn0.Size = new Size(146, 69);
			btn0.TabIndex = 16;
			btn0.Text = "0";
			btn0.UseVisualStyleBackColor = false;
			btn0.Click += OnBtnNumberClick;
			// 
			// btnResult
			// 
			btnResult.BackColor = Color.RoyalBlue;
			btnResult.Dock = DockStyle.Fill;
			btnResult.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnResult.ForeColor = Color.White;
			btnResult.Location = new Point(307, 217);
			btnResult.Name = "btnResult";
			tableLayoutPanel1.SetRowSpan(btnResult, 2);
			btnResult.Size = new Size(74, 141);
			btnResult.TabIndex = 15;
			btnResult.Text = "=";
			btnResult.UseVisualStyleBackColor = false;
			btnResult.Click += OnBtnResultClick;
			// 
			// btnDivision
			// 
			btnDivision.BackColor = Color.Gray;
			btnDivision.Dock = DockStyle.Fill;
			btnDivision.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnDivision.ForeColor = Color.White;
			btnDivision.Location = new Point(231, 217);
			btnDivision.Name = "btnDivision";
			btnDivision.Size = new Size(70, 66);
			btnDivision.TabIndex = 14;
			btnDivision.Text = "/";
			btnDivision.UseVisualStyleBackColor = false;
			btnDivision.Click += OnBtnOperationClick;
			// 
			// btn3
			// 
			btn3.BackColor = Color.MediumSeaGreen;
			btn3.Dock = DockStyle.Fill;
			btn3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btn3.ForeColor = Color.White;
			btn3.Location = new Point(155, 217);
			btn3.Name = "btn3";
			btn3.Size = new Size(70, 66);
			btn3.TabIndex = 13;
			btn3.Text = "3";
			btn3.UseVisualStyleBackColor = false;
			btn3.Click += OnBtnNumberClick;
			// 
			// btn2
			// 
			btn2.BackColor = Color.MediumSeaGreen;
			btn2.Dock = DockStyle.Fill;
			btn2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btn2.ForeColor = Color.White;
			btn2.Location = new Point(79, 217);
			btn2.Name = "btn2";
			btn2.Size = new Size(70, 66);
			btn2.TabIndex = 12;
			btn2.Text = "2";
			btn2.UseVisualStyleBackColor = false;
			btn2.Click += OnBtnNumberClick;
			// 
			// btn1
			// 
			btn1.BackColor = Color.MediumSeaGreen;
			btn1.Dock = DockStyle.Fill;
			btn1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btn1.ForeColor = Color.White;
			btn1.Location = new Point(3, 217);
			btn1.Name = "btn1";
			btn1.Size = new Size(70, 66);
			btn1.TabIndex = 11;
			btn1.Text = "1";
			btn1.UseVisualStyleBackColor = false;
			btn1.Click += OnBtnNumberClick;
			// 
			// btnMultiplication
			// 
			btnMultiplication.BackColor = Color.Gray;
			btnMultiplication.Dock = DockStyle.Fill;
			btnMultiplication.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnMultiplication.ForeColor = Color.White;
			btnMultiplication.Location = new Point(231, 145);
			btnMultiplication.Name = "btnMultiplication";
			btnMultiplication.Size = new Size(70, 66);
			btnMultiplication.TabIndex = 9;
			btnMultiplication.Text = "*";
			btnMultiplication.UseVisualStyleBackColor = false;
			btnMultiplication.Click += OnBtnOperationClick;
			// 
			// btn6
			// 
			btn6.BackColor = Color.MediumSeaGreen;
			btn6.Dock = DockStyle.Fill;
			btn6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btn6.ForeColor = Color.White;
			btn6.Location = new Point(155, 145);
			btn6.Name = "btn6";
			btn6.Size = new Size(70, 66);
			btn6.TabIndex = 8;
			btn6.Text = "6";
			btn6.UseVisualStyleBackColor = false;
			btn6.Click += OnBtnNumberClick;
			// 
			// btn5
			// 
			btn5.BackColor = Color.MediumSeaGreen;
			btn5.Dock = DockStyle.Fill;
			btn5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btn5.ForeColor = Color.White;
			btn5.Location = new Point(79, 145);
			btn5.Name = "btn5";
			btn5.Size = new Size(70, 66);
			btn5.TabIndex = 7;
			btn5.Text = "5";
			btn5.UseVisualStyleBackColor = false;
			btn5.Click += OnBtnNumberClick;
			// 
			// btn4
			// 
			btn4.BackColor = Color.MediumSeaGreen;
			btn4.Dock = DockStyle.Fill;
			btn4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btn4.ForeColor = Color.White;
			btn4.Location = new Point(3, 145);
			btn4.Name = "btn4";
			btn4.Size = new Size(70, 66);
			btn4.TabIndex = 6;
			btn4.Text = "4";
			btn4.UseVisualStyleBackColor = false;
			btn4.Click += OnBtnNumberClick;
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.Gray;
			btnAdd.Dock = DockStyle.Fill;
			btnAdd.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnAdd.ForeColor = Color.White;
			btnAdd.Location = new Point(307, 73);
			btnAdd.Name = "btnAdd";
			tableLayoutPanel1.SetRowSpan(btnAdd, 2);
			btnAdd.Size = new Size(74, 138);
			btnAdd.TabIndex = 5;
			btnAdd.Text = "+";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += OnBtnOperationClick;
			// 
			// btnSubtraction
			// 
			btnSubtraction.BackColor = Color.Gray;
			btnSubtraction.Dock = DockStyle.Fill;
			btnSubtraction.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnSubtraction.ForeColor = Color.White;
			btnSubtraction.Location = new Point(231, 73);
			btnSubtraction.Name = "btnSubtraction";
			btnSubtraction.Size = new Size(70, 66);
			btnSubtraction.TabIndex = 4;
			btnSubtraction.Text = "-";
			btnSubtraction.UseVisualStyleBackColor = false;
			btnSubtraction.Click += OnBtnOperationClick;
			// 
			// btn9
			// 
			btn9.BackColor = Color.MediumSeaGreen;
			btn9.Dock = DockStyle.Fill;
			btn9.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btn9.ForeColor = Color.White;
			btn9.Location = new Point(155, 73);
			btn9.Name = "btn9";
			btn9.Size = new Size(70, 66);
			btn9.TabIndex = 3;
			btn9.Text = "9";
			btn9.UseVisualStyleBackColor = false;
			btn9.Click += OnBtnNumberClick;
			// 
			// btn8
			// 
			btn8.BackColor = Color.MediumSeaGreen;
			btn8.Dock = DockStyle.Fill;
			btn8.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btn8.ForeColor = Color.White;
			btn8.Location = new Point(79, 73);
			btn8.Name = "btn8";
			btn8.Size = new Size(70, 66);
			btn8.TabIndex = 2;
			btn8.Text = "8";
			btn8.UseVisualStyleBackColor = false;
			btn8.Click += OnBtnNumberClick;
			// 
			// tbScreen
			// 
			tableLayoutPanel1.SetColumnSpan(tbScreen, 5);
			tbScreen.Dock = DockStyle.Fill;
			tbScreen.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
			tbScreen.Location = new Point(5, 14);
			tbScreen.Margin = new Padding(5, 14, 5, 5);
			tbScreen.Name = "tbScreen";
			tbScreen.Size = new Size(374, 47);
			tbScreen.TabIndex = 0;
			tbScreen.Text = "0";
			tbScreen.TextAlign = HorizontalAlignment.Right;
			// 
			// btn7
			// 
			btn7.BackColor = Color.MediumSeaGreen;
			btn7.Dock = DockStyle.Fill;
			btn7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			btn7.ForeColor = Color.White;
			btn7.Location = new Point(3, 73);
			btn7.Name = "btn7";
			btn7.Size = new Size(70, 66);
			btn7.TabIndex = 1;
			btn7.Text = "7";
			btn7.UseVisualStyleBackColor = false;
			btn7.Click += OnBtnNumberClick;
			// 
			// MainWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Gainsboro;
			ClientSize = new Size(384, 361);
			Controls.Add(tableLayoutPanel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MinimumSize = new Size(400, 400);
			Name = "MainWindow";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Calculator";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Button btnClear;
		private Button btnComma;
		private Button btn0;
		private Button btnResult;
		private Button btnDivision;
		private Button btn3;
		private Button btn2;
		private Button btn1;
		private Button btnMultiplication;
		private Button btn6;
		private Button btn5;
		private Button btn4;
		private Button btnAdd;
		private Button btnSubtraction;
		private Button btn9;
		private Button btn8;
		private TextBox tbScreen;
		private Button btn7;
	}
}