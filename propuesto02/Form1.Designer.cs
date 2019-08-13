namespace propuesto02
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
			this.dgPedidos = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbCantidad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.bConsultar = new System.Windows.Forms.Button();
			this.cbCliente = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgPedidos
			// 
			this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPedidos.Location = new System.Drawing.Point(60, 132);
			this.dgPedidos.Name = "dgPedidos";
			this.dgPedidos.Size = new System.Drawing.Size(708, 169);
			this.dgPedidos.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(325, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "REPORTE DE PEDIDOS POR CLIENTE";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(383, 366);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "TOTAL DE PEDIDOS";
			// 
			// tbCantidad
			// 
			this.tbCantidad.Location = new System.Drawing.Point(569, 363);
			this.tbCantidad.Name = "tbCantidad";
			this.tbCantidad.Size = new System.Drawing.Size(100, 20);
			this.tbCantidad.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(100, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "NOMBRE DEL CLIENTE";
			// 
			// bConsultar
			// 
			this.bConsultar.Location = new System.Drawing.Point(659, 89);
			this.bConsultar.Name = "bConsultar";
			this.bConsultar.Size = new System.Drawing.Size(83, 23);
			this.bConsultar.TabIndex = 6;
			this.bConsultar.Text = "CONSULTAR";
			this.bConsultar.UseVisualStyleBackColor = true;
			this.bConsultar.Click += new System.EventHandler(this.BConsultar_Click);
			// 
			// cbCliente
			// 
			this.cbCliente.FormattingEnabled = true;
			this.cbCliente.Location = new System.Drawing.Point(279, 91);
			this.cbCliente.Name = "cbCliente";
			this.cbCliente.Size = new System.Drawing.Size(324, 21);
			this.cbCliente.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbCliente);
			this.Controls.Add(this.bConsultar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbCantidad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgPedidos);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgPedidos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbCantidad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bConsultar;
		private System.Windows.Forms.ComboBox cbCliente;
	}
}

