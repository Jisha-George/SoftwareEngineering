namespace SoftEng
{
	partial class movieSearchControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listView = new System.Windows.Forms.ListBox();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView
			// 
			this.listView.FormattingEnabled = true;
			this.listView.Location = new System.Drawing.Point(1, 48);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(962, 615);
			this.listView.TabIndex = 5;
			// 
			// searchBox
			// 
			this.searchBox.AccessibleDescription = "";
			this.searchBox.AccessibleName = "";
			this.searchBox.Location = new System.Drawing.Point(311, 16);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(184, 20);
			this.searchBox.TabIndex = 4;
			this.searchBox.Text = "Movie Title";
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(518, 15);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 22);
			this.searchButton.TabIndex = 3;
			this.searchButton.Text = "button1";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// movieSearchControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.Controls.Add(this.listView);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.searchButton);
			this.Name = "movieSearchControl";
			this.Size = new System.Drawing.Size(964, 663);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listView;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.Button searchButton;
	}
}
