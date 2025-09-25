using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1
{
	public partial class ServiceHistoryForm : Form
	{
		private readonly int partnerId;
		private readonly string partnerName;

		public ServiceHistoryForm(int partnerId, string partnerName)
		{
			this.partnerId = partnerId;
			this.partnerName = partnerName;
			InitializeComponent();
		}

		private void ServiceHistoryForm_Load(object sender, EventArgs e)
		{
			try
			{
				Text = "История услуг — " + partnerName;
				labelTitle.Text = Text;
				LoadHistory();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Не удалось загрузить историю: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadHistory()
		{
			var sql =
				"SELECT s.name AS service_name, ps.quantity, ps.execution_date " +
				"FROM PartnerServices ps JOIN Services s ON s.id = ps.service_id " +
				"WHERE ps.partner_id = @pid ORDER BY ps.execution_date DESC";
			var table = Database.ExecuteTable(sql, p => p.AddWithValue("@pid", partnerId));
			gridHistory.DataSource = table;
			gridHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}
	}
}


