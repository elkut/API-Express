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
            apiMethodBox = new ComboBox();
            bodyBox = new TextBox();
            bodyTextBox = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // callAPi
            // 
            callAPi.BackColor = Color.FromArgb(0, 64, 64);
            callAPi.Font = new Font("Bernard MT Condensed", 18F);
            callAPi.ForeColor = Color.DarkKhaki;
            callAPi.Location = new Point(660, 105);
            callAPi.Name = "callAPi";
            callAPi.Size = new Size(66, 39);
            callAPi.TabIndex = 0;
            callAPi.Text = "Send";
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
            urlLable.Location = new Point(51, 74);
            urlLable.Name = "urlLable";
            urlLable.Size = new Size(52, 28);
            urlLable.TabIndex = 3;
            urlLable.Text = "URL:";
            // 
            // resultsBox
            // 
            resultsBox.Location = new Point(51, 302);
            resultsBox.Multiline = true;
            resultsBox.Name = "resultsBox";
            resultsBox.ReadOnly = true;
            resultsBox.ScrollBars = ScrollBars.Both;
            resultsBox.Size = new Size(617, 265);
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
            resultsLabel.Location = new Point(51, 271);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(83, 28);
            resultsLabel.TabIndex = 7;
            resultsLabel.Text = "Results:";
            // 
            // urlBox
            // 
            urlBox.BackColor = Color.White;
            urlBox.Location = new Point(168, 105);
            urlBox.Name = "urlBox";
            urlBox.PlaceholderText = "Past URL here";
            urlBox.Size = new Size(485, 39);
            urlBox.TabIndex = 8;
            // 
            // apiMethodBox
            // 
            apiMethodBox.BackColor = Color.FromArgb(0, 64, 64);
            apiMethodBox.Font = new Font("Bernard MT Condensed", 18F);
            apiMethodBox.ForeColor = Color.DarkKhaki;
            apiMethodBox.FormattingEnabled = true;
            apiMethodBox.Items.AddRange(new object[] { "GET", "POST", "PUT", "DELETE", "PATCH" });
            apiMethodBox.Location = new Point(79, 105);
            apiMethodBox.Name = "apiMethodBox";
            apiMethodBox.Size = new Size(83, 36);
            apiMethodBox.TabIndex = 10;
            apiMethodBox.Text = "GET";
            apiMethodBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // bodyBox
            // 
            bodyBox.Location = new Point(168, 158);
            bodyBox.Multiline = true;
            bodyBox.Name = "bodyBox";
            bodyBox.Size = new Size(485, 104);
            bodyBox.TabIndex = 11;
            // 
            // bodyTextBox
            // 
            bodyTextBox.AutoSize = true;
            bodyTextBox.Font = new Font("Bernard MT Condensed", 18F);
            bodyTextBox.ForeColor = Color.DarkKhaki;
            bodyTextBox.Location = new Point(79, 164);
            bodyTextBox.Name = "bodyTextBox";
            bodyTextBox.Size = new Size(65, 28);
            bodyTextBox.TabIndex = 12;
            bodyTextBox.Text = "Body:";
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
            Controls.Add(bodyTextBox);
            Controls.Add(bodyBox);
            Controls.Add(apiMethodBox);
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
        private ComboBox apiMethodBox;
        private TextBox bodyBox;
        private Label bodyTextBox;
    }
}