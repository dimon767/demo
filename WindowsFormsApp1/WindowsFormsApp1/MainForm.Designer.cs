namespace WindowsFormsApp1
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
			this.panelHeader = new System.Windows.Forms.Panel();
			this.pictureLogo = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.gridPartners = new System.Windows.Forms.DataGridView();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonHistory = new System.Windows.Forms.Button();
			this.panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridPartners)).BeginInit();
			this.SuspendLayout();
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.Color.LightCyan;
			this.panelHeader.Controls.Add(this.pictureLogo);
			this.panelHeader.Controls.Add(this.labelTitle);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(984, 80);
			this.panelHeader.TabIndex = 0;
			// 
			// pictureLogo
			// 
			this.pictureLogo.Location = new System.Drawing.Point(12, 12);
			this.pictureLogo.Name = "pictureLogo";
			this.pictureLogo.Size = new System.Drawing.Size(56, 56);
			this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureLogo.TabIndex = 1;
			this.pictureLogo.TabStop = false;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F);
			this.labelTitle.Location = new System.Drawing.Point(80, 26);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(286, 28);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Партнёры — Чистая планета";
			// 
			// gridPartners
			// 
			this.gridPartners.AllowUserToAddRows = false;
			this.gridPartners.AllowUserToDeleteRows = false;
			this.gridPartners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			|
			System.Windows.Forms.AnchorStyles.Left) 
			|
			System.Windows.Forms.AnchorStyles.Right)));
			this.gridPartners.BackgroundColor = System.Drawing.Color.White;
			this.gridPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridPartners.Location = new System.Drawing.Point(12, 98);
			this.gridPartners.MultiSelect = false;
			this.gridPartners.Name = "gridPartners";
			this.gridPartners.ReadOnly = true;
			this.gridPartners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridPartners.Size = new System.Drawing.Size(960, 430);
			this.gridPartners.TabIndex = 1;
			this.gridPartners.DoubleClick += new System.EventHandler(this.gridPartners_DoubleClick);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
			this.buttonAdd.ForeColor = System.Drawing.Color.White;
			this.buttonAdd.Location = new System.Drawing.Point(12, 544);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(180, 36);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Text = "Добавить партнёра";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonHistory
			// 
			this.buttonHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
			this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonHistory.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
			this.buttonHistory.ForeColor = System.Drawing.Color.White;
			this.buttonHistory.Location = new System.Drawing.Point(210, 544);
			this.buttonHistory.Name = "buttonHistory";
			this.buttonHistory.Size = new System.Drawing.Size(180, 36);
			this.buttonHistory.TabIndex = 3;
			this.buttonHistory.Text = "История услуг";
			this.buttonHistory.UseVisualStyleBackColor = false;
			this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(984, 601);
			this.Controls.Add(this.buttonHistory);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.gridPartners);
			this.Controls.Add(this.panelHeader);
			this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Партнёры — Чистая планета";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridPartners)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.PictureBox pictureLogo;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.DataGridView gridPartners;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonHistory;
	}
}


