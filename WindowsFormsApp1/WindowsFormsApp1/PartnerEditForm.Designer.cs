namespace WindowsFormsApp1
{
	partial class PartnerEditForm
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
			this.labelName = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.labelType = new System.Windows.Forms.Label();
			this.comboType = new System.Windows.Forms.ComboBox();
			this.labelDirector = new System.Windows.Forms.Label();
			this.textDirector = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.textEmail = new System.Windows.Forms.TextBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.textPhone = new System.Windows.Forms.TextBox();
			this.labelAddress = new System.Windows.Forms.Label();
			this.textAddress = new System.Windows.Forms.TextBox();
			this.labelInn = new System.Windows.Forms.Label();
			this.textInn = new System.Windows.Forms.TextBox();
			this.labelRating = new System.Windows.Forms.Label();
			this.numericRating = new System.Windows.Forms.NumericUpDown();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericRating)).BeginInit();
			this.SuspendLayout();
			// 
			// labels and inputs
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(20, 20);
			this.labelName.Text = "Наименование";

			this.textName.Location = new System.Drawing.Point(180, 18);
			this.textName.Width = 320;

			this.labelType.AutoSize = true;
			this.labelType.Location = new System.Drawing.Point(20, 55);
			this.labelType.Text = "Тип партнёра";

			this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboType.Location = new System.Drawing.Point(180, 53);
			this.comboType.Width = 320;

			this.labelDirector.AutoSize = true;
			this.labelDirector.Location = new System.Drawing.Point(20, 90);
			this.labelDirector.Text = "ФИО руководителя";

			this.textDirector.Location = new System.Drawing.Point(180, 88);
			this.textDirector.Width = 320;

			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(20, 125);
			this.labelEmail.Text = "Email";

			this.textEmail.Location = new System.Drawing.Point(180, 123);
			this.textEmail.Width = 320;

			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(20, 160);
			this.labelPhone.Text = "Телефон";

			this.textPhone.Location = new System.Drawing.Point(180, 158);
			this.textPhone.Width = 320;

			this.labelAddress.AutoSize = true;
			this.labelAddress.Location = new System.Drawing.Point(20, 195);
			this.labelAddress.Text = "Юридический адрес";

			this.textAddress.Location = new System.Drawing.Point(180, 193);
			this.textAddress.Width = 320;

			this.labelInn.AutoSize = true;
			this.labelInn.Location = new System.Drawing.Point(20, 230);
			this.labelInn.Text = "ИНН";

			this.textInn.Location = new System.Drawing.Point(180, 228);
			this.textInn.Width = 320;

			this.labelRating.AutoSize = true;
			this.labelRating.Location = new System.Drawing.Point(20, 265);
			this.labelRating.Text = "Рейтинг (0-10)";

			this.numericRating.Location = new System.Drawing.Point(180, 263);
			this.numericRating.Minimum = 0;
			this.numericRating.Maximum = 10;

			this.buttonSave.BackColor = System.Drawing.Color.FromArgb(0, 206, 209);
			this.buttonSave.ForeColor = System.Drawing.Color.White;
			this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.Location = new System.Drawing.Point(180, 310);
			this.buttonSave.Size = new System.Drawing.Size(150, 36);
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.Location = new System.Drawing.Point(350, 310);
			this.buttonCancel.Size = new System.Drawing.Size(150, 36);
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);

			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(540, 370);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.numericRating);
			this.Controls.Add(this.labelRating);
			this.Controls.Add(this.textInn);
			this.Controls.Add(this.labelInn);
			this.Controls.Add(this.textAddress);
			this.Controls.Add(this.labelAddress);
			this.Controls.Add(this.textPhone);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.textEmail);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.textDirector);
			this.Controls.Add(this.labelDirector);
			this.Controls.Add(this.comboType);
			this.Controls.Add(this.labelType);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.labelName);
			this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Партнёр";
			this.Load += new System.EventHandler(this.PartnerEditForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.ComboBox comboType;
		private System.Windows.Forms.Label labelDirector;
		private System.Windows.Forms.TextBox textDirector;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.TextBox textEmail;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.TextBox textPhone;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.TextBox textAddress;
		private System.Windows.Forms.Label labelInn;
		private System.Windows.Forms.TextBox textInn;
		private System.Windows.Forms.Label labelRating;
		private System.Windows.Forms.NumericUpDown numericRating;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
	}
}


