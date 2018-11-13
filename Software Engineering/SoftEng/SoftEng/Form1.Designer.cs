namespace SoftEng
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.searchButton = new System.Windows.Forms.Button();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.wutdis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.resultView = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(446, 30);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 0;
			this.searchButton.Text = "button1";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(256, 32);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(184, 20);
			this.searchBox.TabIndex = 1;
			// 
			// resultView
			// 
			this.resultView.Location = new System.Drawing.Point(43, 62);
			this.resultView.Name = "resultView";
			this.resultView.Size = new System.Drawing.Size(710, 325);
			this.resultView.TabIndex = 0;
			this.resultView.UseCompatibleStateImageBehavior = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.resultView);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.searchButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.ColumnHeader wutdis;
		private System.Windows.Forms.ListView resultView;
	}
}

