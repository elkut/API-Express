namespace PostmanCloneUI
{
	partial class Dashboard
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
			callAPi = new Button();
			header = new Label();
			urlLable = new Label();
			resultsBox = new TextBox();
			statusStrip = new StatusStrip();
			systemStatus = new ToolStripStatusLabel();
			resultsLabel = new Label();
			urlBox = new TextBox();
			statusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// callAPi
			// 
			callAPi.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			callAPi.Location = new Point(660, 105);
			callAPi.Name = "callAPi";
			callAPi.Size = new Size(51, 39);
			callAPi.TabIndex = 0;
			callAPi.Text = "GO";
			callAPi.TextAlign = ContentAlignment.TopCenter;
			callAPi.UseVisualStyleBackColor = true;
			callAPi.Click += callApi_Click;
			// 
			// header
			// 
			header.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			header.AutoSize = true;
			header.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			header.Location = new Point(221, 9);
			header.Name = "header";
			header.Size = new Size(345, 57);
			header.TabIndex = 2;
			header.Text = "API Checker";
			header.TextAlign = ContentAlignment.TopCenter;
			header.Click += label1_Click;
			// 
			// urlLable
			// 
			urlLable.AutoSize = true;
			urlLable.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			urlLable.Location = new Point(51, 70);
			urlLable.Name = "urlLable";
			urlLable.Size = new Size(52, 28);
			urlLable.TabIndex = 3;
			urlLable.Text = "URL:";
			urlLable.Click += label2_Click;
			// 
			// resultsBox
			// 
			resultsBox.Location = new Point(51, 210);
			resultsBox.Multiline = true;
			resultsBox.Name = "resultsBox";
			resultsBox.ReadOnly = true;
			resultsBox.ScrollBars = ScrollBars.Both;
			resultsBox.Size = new Size(657, 351);
			resultsBox.TabIndex = 4;
			resultsBox.TextChanged += textBox1_TextChanged;
			// 
			// statusStrip
			// 
			statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
			statusStrip.Location = new Point(0, 570);
			statusStrip.Name = "statusStrip";
			statusStrip.Size = new Size(773, 27);
			statusStrip.TabIndex = 6;
			statusStrip.Text = "statusStrip2";
			// 
			// systemStatus
			// 
			systemStatus.Font = new Font("Bernard MT Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			systemStatus.Name = "systemStatus";
			systemStatus.Size = new Size(60, 22);
			systemStatus.Text = "Ready";
			// 
			// resultsLabel
			// 
			resultsLabel.AutoSize = true;
			resultsLabel.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			resultsLabel.Location = new Point(51, 176);
			resultsLabel.Name = "resultsLabel";
			resultsLabel.Size = new Size(83, 28);
			resultsLabel.TabIndex = 7;
			resultsLabel.Text = "Results:";
			resultsLabel.Click += resultsLabel_Click;
			// 
			// urlBox
			// 
			urlBox.Location = new Point(51, 105);
			urlBox.Name = "urlBox";
			urlBox.Size = new Size(602, 39);
			urlBox.TabIndex = 8;
			// 
			// Dashboard
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackColor = Color.PaleGoldenrod;
			BackgroundImageLayout = ImageLayout.Center;
			ClientSize = new Size(773, 597);
			Controls.Add(urlBox);
			Controls.Add(resultsLabel);
			Controls.Add(statusStrip);
			Controls.Add(resultsBox);
			Controls.Add(urlLable);
			Controls.Add(header);
			Controls.Add(callAPi);
			Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ForeColor = Color.Black;
			Margin = new Padding(6);
			Name = "Dashboard";
			Text = "API Checker";
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button callAPi;
		private Label header;
		private Label urlLable;
		private TextBox resultsBox;
		private StatusStrip statusStrip;
		private Label resultsLabel;
		private TextBox urlBox;
		private ToolStripStatusLabel systemStatus;
	}
}