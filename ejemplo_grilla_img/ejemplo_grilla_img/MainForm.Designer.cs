/*
 * Created by SharpDevelop.
 * User: jerem
 * Date: 28/11/2023
 * Time: 10:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ejemplo_grilla_img
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
		private System.Windows.Forms.DataGridViewImageColumn imagen;
		private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
			this.seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.titulo,
			this.imagen,
			this.seleccionar});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 100;
			this.dataGridView1.Size = new System.Drawing.Size(612, 439);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1CellFormatting);
			// 
			// titulo
			// 
			this.titulo.DataPropertyName = "jueg_titulo";
			this.titulo.HeaderText = "titulo";
			this.titulo.Name = "titulo";
			// 
			// imagen
			// 
			this.imagen.DataPropertyName = "jueg_img_path";
			this.imagen.HeaderText = "imagen";
			this.imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.imagen.Name = "imagen";
			// 
			// seleccionar
			// 
			this.seleccionar.DataPropertyName = "jueg_check";
			this.seleccionar.HeaderText = "seleccionar";
			this.seleccionar.Name = "seleccionar";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 439);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainForm";
			this.Text = "ejemplo_grilla_img";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
