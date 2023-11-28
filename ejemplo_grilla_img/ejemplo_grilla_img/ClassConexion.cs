using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.IO;

public class ClassConexionSQL
{
	public SqlConnection conexion;

	public bool Conectar()
	{
		try
		{
			if (conexion.State != ConnectionState.Open)
			{
				conexion.Open();
			}
			return true;
		}
		catch (SqlException ex)
		{
			switch (ex.Number)
			{
				case 0:
					MessageBox.Show("Cannot connect to server.  Contact administrator");
					break;

				case 1045:
					MessageBox.Show("Invalid username/password, please try again");
					break;
			}
			return false;
		}
	}

	public bool Desconectar()
	{
		try
		{
			conexion.Close();
			return true;
		}
		catch (SqlException ex)
		{
			MessageBox.Show(ex.Message);
			return false;
		}
	}

	public bool CrearConexion()
	{
		try
		{
			string strConexion = String.Format("Server=localhost;Database={0}; integrated security = true", "lista_img");
			conexion = new SqlConnection(strConexion);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool LLenarGrid(ref DataGridView grid, string Consulta)
	{
		try
		{
			if (this.Conectar())
			{
				SqlDataAdapter adaptadorDatos = new SqlDataAdapter(Consulta, conexion);

				DataTable dtDatos = new DataTable();

				adaptadorDatos.Fill(dtDatos);

				grid.DataSource = dtDatos;
				
				this.Desconectar();

				return true;
			}
			else
			{
				return false;
			}
		}
		catch
		{
			return false;
		}
	}
	

	public DataRow ObtenerData(String Consulta)
	{
		try
		{
			if (this.Conectar())
			{
				SqlDataAdapter adaptadorDatos = new SqlDataAdapter(Consulta, conexion);

				DataTable dtDatos = new DataTable();

				adaptadorDatos.Fill(dtDatos);

				this.Desconectar();

				return dtDatos.Rows[0];
			}
			else
			{
				return null;
			}
		}
		catch
		{
			return null;
		}
	}
	public void EjecutarComandoSQL(string sql)
	{
		if (this.Conectar())
		{
			SqlCommand cmd = new SqlCommand(sql, conexion);
			cmd.ExecuteNonQuery();
			this.Desconectar();
		}
	}
	
	public bool ValidarUsuario(string nombreUsuario, string contraseña){
		try
		{
			string query = "EXEC sp_ValidarUsuario @NombreUsuario, @Contraseña";
			using (SqlCommand cmd = new SqlCommand(query, conexion))
			{
				cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
				cmd.Parameters.AddWithValue("@Contraseña", contraseña);
				
				conexion.Open();
				int resultado = (int)cmd.ExecuteScalar();
				conexion.Close();
				
				return resultado != 0;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("Error al validar usuario: " + ex.Message);
			return false;
		}
	}
	
	
	public DataSet EjecutarSentencia(string consulta)
	{
		try
		{
			if (this.Conectar())
			{
				SqlDataAdapter adaptadorDatos = new SqlDataAdapter(consulta, conexion);

				DataSet dsResultado = new DataSet();

				adaptadorDatos.Fill(dsResultado);

				this.Desconectar();

				return dsResultado;
			}
			else
			{
				return null;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("Error al ejecutar sentencia: " + ex.Message);
			return null;
		}
	}

}
