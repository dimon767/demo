namespace WindowsFormsApp1
{
	partial class ServiceHistoryForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.labelTitle = new System.Windows.Forms.Label();
			this.gridHistory = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
			this.labelTitle.Location = new System.Drawing.Point(12, 9);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(118, 21);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "История услуг";
			// 
			// gridHistory
			// 
			this.gridHistory.AllowUserToAddRows = false;
			this.gridHistory.AllowUserToDeleteRows = false;
			this.gridHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			|
			System.Windows.Forms.AnchorStyles.Left) 
			|
			System.Windows.Forms.AnchorStyles.Right)));
			this.gridHistory.BackgroundColor = System.Drawing.Color.White;
			this.gridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridHistory.Location = new System.Drawing.Point(16, 42);
			this.gridHistory.MultiSelect = false;
			this.gridHistory.Name = "gridHistory";
			this.gridHistory.ReadOnly = true;
			this.gridHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridHistory.Size = new System.Drawing.Size(556, 307);
			this.gridHistory.TabIndex = 1;
			// 
			// ServiceHistoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.gridHistory);
			this.Controls.Add(this.labelTitle);
			this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ServiceHistoryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "История услуг";
			this.Load += new System.EventHandler(this.ServiceHistoryForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.DataGridView gridHistory;
	}
}


