namespace OO_Plus_Events
{
	partial class MainForm
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
			this.btnCount = new System.Windows.Forms.Button();
			this.pbCounter = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// btnCount
			// 
			this.btnCount.Location = new System.Drawing.Point(243, 12);
			this.btnCount.Name = "btnCount";
			this.btnCount.Size = new System.Drawing.Size(75, 23);
			this.btnCount.TabIndex = 0;
			this.btnCount.Text = "Count";
			this.btnCount.UseVisualStyleBackColor = true;
			this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
			// 
			// pbCounter
			// 
			this.pbCounter.Location = new System.Drawing.Point(12, 57);
			this.pbCounter.Name = "pbCounter";
			this.pbCounter.Size = new System.Drawing.Size(565, 23);
			this.pbCounter.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 105);
			this.Controls.Add(this.pbCounter);
			this.Controls.Add(this.btnCount);
			this.Name = "MainForm";
			this.Text = "Counter";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCount;
		private System.Windows.Forms.ProgressBar pbCounter;
	}
}

