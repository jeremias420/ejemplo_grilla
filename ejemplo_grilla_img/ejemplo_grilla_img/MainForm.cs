/*
 * Created by SharpDevelop.
 * User: jerem
 * Date: 28/11/2023
 * Time: 10:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ejemplo_grilla_img
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		ClassConexionSQL cnx;
		string ApplicationPath;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		void DataGridView1CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			switch(this.dataGridView1.Columns[e.ColumnIndex].Name)
			{
				case "imagen":
					if(e.Value != null){
						try
						{
      							//obtengo el path completo de la image fusionando el path de la aplicacion con el path de la imagen que tengo en la bd
							string imgPath = Path.Combine(ApplicationPath, e.Value.ToString());
       							//carga la imagen y la asigna a la celda
							Image img = Image.FromFile(imgPath);
							e.Value = img;
						} catch {
							e.Value = null;
						}
					}break;
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
  			//esta configuracion evita que se autogeneren columnas, o sea que va a respetar las columas que crees manualmente en la grilla
			dataGridView1.AutoGenerateColumns = false;
   			//se obtiene el path de la aplicacion para usarlo luego para cargar las imagenes
			ApplicationPath = AppDomain.CurrentDomain.BaseDirectory;
   			//se crea instancia y conexion a la base de datos
			cnx = new ClassConexionSQL();
			cnx.CrearConexion();
   			//se llena el grid con los datos de la tabla juegos
			cnx.LLenarGrid(ref dataGridView1, "select * from juegos");
		}
	}
}
