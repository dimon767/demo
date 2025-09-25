using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Logic
{
	public static class BusinessLogic
	{
		public static decimal CalculateServiceCost(int serviceId)
		{
			try
			{
				// Materials cost: sum(consumption_rate * price_per_unit)
				// Labor cost: sum(staff_count * hourly_rate) where hourly_rate taken from Employees by position
				decimal materialsCost = 0m;
				var norms = Database.ExecuteTable(
					"SELECT n.consumption_rate, mt.id AS material_type_id, m.price_per_unit " +
					"FROM ServiceMaterialNorms n " +
					"JOIN MaterialTypes mt ON mt.id = n.material_type_id " +
					"LEFT JOIN Materials m ON m.material_type_id = mt.id " +
					"WHERE n.service_id = @sid",
					p => p.AddWithValue("@sid", serviceId)
				);
				foreach (DataRow row in norms.Rows)
				{
					var rate = row["consumption_rate"] is DBNull ? 0m : Convert.ToDecimal(row["consumption_rate"]);
					var price = row["price_per_unit"] is DBNull ? 0m : Convert.ToDecimal(row["price_per_unit"]);
					materialsCost += rate * price;
				}

				decimal laborCost = 0m;
				var staff = Database.ExecuteTable(
					"SELECT r.position, r.staff_count, e.hourly_rate " +
					"FROM ServiceStaffRequirements r " +
					"LEFT JOIN Employees e ON e.position = r.position " +
					"WHERE r.service_id = @sid",
					p => p.AddWithValue("@sid", serviceId)
				);
				foreach (DataRow row in staff.Rows)
				{
					var staffCount = row["staff_count"] is DBNull ? 0 : Convert.ToInt32(row["staff_count"]);
					var hourlyRate = row["hourly_rate"] is DBNull ? 500m : Convert.ToDecimal(row["hourly_rate"]);
					laborCost += staffCount * hourlyRate;
				}

				return materialsCost + laborCost;
			}
			catch
			{
				return -1;
			}
		}

		public static int CalculateMaterialAmount(int serviceTypeId, int materialTypeId, int serviceCount, double serviceParameter)
		{
			try
			{
				if (serviceCount <= 0 || serviceParameter < 0)
				{
					return -1;
				}

				// Coefficient by service type: try read from ServiceTypes (e.g., column 'consumption_coeff'), fallback to 1.0
				double coeff = 1.0;
				try
				{
					var coeffTable = Database.ExecuteTable(
						"SELECT TOP 1 consumption_coeff FROM ServiceTypes WHERE id = @stid",
						p => p.AddWithValue("@stid", serviceTypeId)
					);
					if (coeffTable.Rows.Count == 0)
					{
						return -1;
					}
					var cobj = coeffTable.Rows[0]["consumption_coeff"];
					if (!(cobj is DBNull))
					{
						coeff = Convert.ToDouble(cobj);
					}
				}
				catch
				{
					// If column doesn't exist or query fails, keep default coeff = 1.0
				}
				var baseNorm = serviceParameter * coeff * serviceCount;

				// Get overuse percent from MaterialTypes
				var materialTable = Database.ExecuteTable(
					"SELECT TOP 1 overuse_percent FROM MaterialTypes WHERE id = @mid",
					p => p.AddWithValue("@mid", materialTypeId)
				);
				if (materialTable.Rows.Count == 0)
				{
					return -1;
				}
				var overusePercent = 0.0;
				var overuseObj = materialTable.Rows[0]["overuse_percent"];
				if (!(overuseObj is DBNull))
				{
					overusePercent = Convert.ToDouble(overuseObj);
				}

				var total = Math.Ceiling(baseNorm * (1.0 + overusePercent / 100.0));
				if (total < 0 || total > int.MaxValue)
				{
					return -1;
				}
				return (int)total;
			}
			catch
			{
				return -1;
			}
		}
	}
}


