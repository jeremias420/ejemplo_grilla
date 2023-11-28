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
							string imgPath = Path.Combine(ApplicationPath, e.Value.ToString());
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
			dataGridView1.AutoGenerateColumns = false;
			ApplicationPath = AppDomain.CurrentDomain.BaseDirectory;
			cnx = new ClassConexionSQL();
			cnx.CrearConexion();
			cnx.LLenarGrid(ref dataGridView1, "select * from juegos");
		}
	}
}
