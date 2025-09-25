using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1
{
	public partial class PartnerEditForm : Form
	{
		private readonly int? partnerId;

		public PartnerEditForm(int? partnerId)
		{
			this.partnerId = partnerId;
			InitializeComponent();
		}

		private void PartnerEditForm_Load(object sender, EventArgs e)
		{
			try
			{
				LoadTypes();
				if (partnerId.HasValue)
				{
					LoadPartner(partnerId.Value);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка загрузки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadTypes()
		{
			var table = Database.ExecuteTable("SELECT id, name FROM PartnerTypes ORDER BY id");
			comboType.DataSource = table;
			comboType.DisplayMember = "name";
			comboType.ValueMember = "id";
		}

		private void LoadPartner(int id)
		{
			var sql = "SELECT * FROM Partners WHERE id = @id";
			var table = Database.ExecuteTable(sql, p => p.AddWithValue("@id", id));
			if (table.Rows.Count == 0)
			{
				MessageBox.Show("Партнёр не найден", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
				DialogResult = DialogResult.Cancel;
				return;
			}
			var r = table.Rows[0];
			textName.Text = Convert.ToString(r["name"]);
			comboType.SelectedValue = Convert.ToInt32(r["partner_type_id"]);
			textDirector.Text = Convert.ToString(r["manager_fio"]);
			textEmail.Text = Convert.ToString(r["email"]);
			textPhone.Text = Convert.ToString(r["phone"]);
			textAddress.Text = Convert.ToString(r["legal_address"]);
			textInn.Text = Convert.ToString(r["inn"]);
			numericRating.Value = Convert.ToDecimal(r["rating"]);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textName.Text))
			{
				MessageBox.Show("Заполните наименование", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				if (partnerId.HasValue)
				{
					UpdatePartner();
				}
				else
				{
					InsertPartner();
				}
				DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка сохранения: " + ex.Message, "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void InsertPartner()
		{
			var sql = "INSERT INTO Partners(name, partner_type_id, manager_fio, email, phone, legal_address, inn, rating) VALUES(@name, @type, @director, @email, @phone, @address, @inn, @rating)";
			Database.ExecuteNonQuery(sql, p =>
			{
				p.AddWithValue("@name", textName.Text.Trim());
				p.AddWithValue("@type", (int)comboType.SelectedValue);
				p.AddWithValue("@director", (object)textDirector.Text ?? (object)DBNull.Value);
				p.AddWithValue("@email", (object)textEmail.Text ?? (object)DBNull.Value);
				p.AddWithValue("@phone", (object)textPhone.Text ?? (object)DBNull.Value);
				p.AddWithValue("@address", (object)textAddress.Text ?? (object)DBNull.Value);
				p.AddWithValue("@inn", (object)textInn.Text ?? (object)DBNull.Value);
				p.AddWithValue("@rating", (int)numericRating.Value);
			});
		}

		private void UpdatePartner()
		{
			var sql = "UPDATE Partners SET name=@name, partner_type_id=@type, manager_fio=@director, email=@email, phone=@phone, legal_address=@address, inn=@inn, rating=@rating WHERE id=@id";
			Database.ExecuteNonQuery(sql, p =>
			{
				p.AddWithValue("@id", partnerId.Value);
				p.AddWithValue("@name", textName.Text.Trim());
				p.AddWithValue("@type", (int)comboType.SelectedValue);
				p.AddWithValue("@director", (object)textDirector.Text ?? (object)DBNull.Value);
				p.AddWithValue("@email", (object)textEmail.Text ?? (object)DBNull.Value);
				p.AddWithValue("@phone", (object)textPhone.Text ?? (object)DBNull.Value);
				p.AddWithValue("@address", (object)textAddress.Text ?? (object)DBNull.Value);
				p.AddWithValue("@inn", (object)textInn.Text ?? (object)DBNull.Value);
				p.AddWithValue("@rating", (int)numericRating.Value);
			});
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}


