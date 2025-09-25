using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				LoadLogo();
				LoadPartners();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Не удалось загрузить данные: " + ex.Message, "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadLogo()
		{
			try
			{
				var logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "logo.png");
				if (File.Exists(logoPath))
				{
					pictureLogo.Image = Image.FromFile(logoPath);
				}
			}
			catch { }
		}

		private void LoadPartners()
		{
			var sql =
				"SELECT p.id, p.name, t.name AS type_name, p.manager_fio, p.phone, p.email, p.rating " +
				"FROM Partners p JOIN PartnerTypes t ON t.id = p.partner_type_id ORDER BY p.name";
			var table = Database.ExecuteTable(sql);
			gridPartners.DataSource = table;
			if (gridPartners.Columns.Contains("id"))
			{
				gridPartners.Columns["id"].Visible = false;
			}
			gridPartners.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private int? GetSelectedPartnerId()
		{
			if (gridPartners.CurrentRow == null)
			{
				return null;
			}
			var row = gridPartners.CurrentRow;
			if (row.Cells["id"] == null)
			{
				return null;
			}
			return Convert.ToInt32(row.Cells["id"].Value);
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			using (var dlg = new PartnerEditForm(null))
			{
				if (dlg.ShowDialog(this) == DialogResult.OK)
				{
					LoadPartners();
				}
			}
		}

		private void gridPartners_DoubleClick(object sender, EventArgs e)
		{
			var id = GetSelectedPartnerId();
			if (id == null)
			{
				return;
			}
			using (var dlg = new PartnerEditForm(id.Value))
			{
				if (dlg.ShowDialog(this) == DialogResult.OK)
				{
					LoadPartners();
				}
			}
		}

		private void buttonHistory_Click(object sender, EventArgs e)
		{
			var id = GetSelectedPartnerId();
			if (id == null)
			{
				MessageBox.Show("Выберите партнёра", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			string partnerName = string.Empty;
			if (gridPartners.CurrentRow != null && gridPartners.CurrentRow.Cells["name"] != null)
			{
				partnerName = Convert.ToString(gridPartners.CurrentRow.Cells["name"].Value);
			}
			using (var dlg = new ServiceHistoryForm(id.Value, partnerName))
			{
				dlg.ShowDialog(this);
			}
		}
	}
}


