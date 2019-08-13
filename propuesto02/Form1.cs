using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace propuesto02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Propuesto02"].ConnectionString);

		public void ListaPedidos()
		{
			using (SqlDataAdapter df = new SqlDataAdapter("S01_Propuesto02", cn))
			{
				df.SelectCommand.CommandType = CommandType.StoredProcedure;
				df.SelectCommand.Parameters.Add("@busquedaCliente", SqlDbType.VarChar).Value = cbCliente.Text;
				using (DataSet ds = new DataSet())
				{
					df.Fill(ds, "Pedidos");
					dgPedidos.DataSource = ds.Tables["Pedidos"];
					tbCantidad.Text = ds.Tables["Pedidos"].Rows.Count.ToString();
				}
			}
		}

		public void ListaClientes()
		{
			using (SqlDataAdapter df = new SqlDataAdapter("S01_Propuesto02_clientes", cn))
			{
				df.SelectCommand.CommandType = CommandType.StoredProcedure;
				
				using (DataSet ds = new DataSet())
				{
					df.Fill(ds, "Clientes");
					cbCliente.DataSource = ds.Tables["Clientes"];
					cbCliente.DisplayMember = "NombreCompañia";
				}
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			ListaClientes();
		}

		private void BConsultar_Click(object sender, EventArgs e)
		{
			ListaPedidos();
		}
	}
}
