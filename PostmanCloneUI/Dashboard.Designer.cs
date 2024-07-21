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
            comboBox1 = new ComboBox();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // callAPi
            // 
            callAPi.BackColor = Color.FromArgb(0, 64, 64);
            callAPi.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            callAPi.ForeColor = Color.DarkKhaki;
            callAPi.Location = new Point(660, 105);
            callAPi.Name = "callAPi";
            callAPi.Size = new Size(51, 39);
            callAPi.TabIndex = 0;
            callAPi.Text = "GO";
            callAPi.TextAlign = ContentAlignment.TopCenter;
            callAPi.UseVisualStyleBackColor = false;
            callAPi.Click += CallApi_Click;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            header.AutoSize = true;
            header.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header.ForeColor = Color.DarkKhaki;
            header.Location = new Point(214, 9);
            header.Name = "header";
            header.Size = new Size(332, 57);
            header.TabIndex = 2;
            header.Text = "API Express";
            header.TextAlign = ContentAlignment.TopCenter;
            // 
            // urlLable
            // 
            urlLable.AutoSize = true;
            urlLable.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            urlLable.ForeColor = Color.DarkKhaki;
            urlLable.Location = new Point(51, 70);
            urlLable.Name = "urlLable";
            urlLable.Size = new Size(52, 28);
            urlLable.TabIndex = 3;
            urlLable.Text = "URL:";
            // 
            // resultsBox
            // 
            resultsBox.Location = new Point(51, 317);
            resultsBox.Multiline = true;
            resultsBox.Name = "resultsBox";
            resultsBox.ReadOnly = true;
            resultsBox.ScrollBars = ScrollBars.Both;
            resultsBox.Size = new Size(657, 244);
            resultsBox.TabIndex = 4;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(0, 64, 64);
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
            systemStatus.ForeColor = Color.DarkKhaki;
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(60, 22);
            systemStatus.Text = "Ready";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.BackColor = Color.Transparent;
            resultsLabel.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultsLabel.ForeColor = Color.DarkKhaki;
            resultsLabel.Location = new Point(51, 286);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(83, 28);
            resultsLabel.TabIndex = 7;
            resultsLabel.Text = "Results:";
            // 
            // urlBox
            // 
            urlBox.BackColor = Color.White;
            urlBox.Location = new Point(148, 105);
            urlBox.Name = "urlBox";
            urlBox.PlaceholderText = "Past URL here";
            urlBox.Size = new Size(505, 39);
            urlBox.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(51, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(81, 40);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(0, 64, 64);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(773, 597);
            Controls.Add(comboBox1);
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
            Text = "API Express by Alkut Askar";
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
        private ComboBox comboBox1;
    }
}