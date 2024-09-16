using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.Rendering;
using SitioWebBP220765.Models;

public class Conexion
{
    private string cadenaConexion { get; set; }
    private SqlConnection conexionSQL;

    public Conexion()
    {
        
        cadenaConexion = @"Data source=(local);Initial Catalog=Bolsa_Trabajo;Integrated Security=True";
    }

    
    public bool conectar()
    {
        try
        {
            conexionSQL = new SqlConnection(cadenaConexion);
            conexionSQL.Open();
            return true;
        }
        catch (Exception e)
        {
            
            Console.WriteLine($"Error de conexión: {e.Message}");
            return false;
        }
    }

    
    public bool estadoConexion()
    {
        return conexionSQL.State == ConnectionState.Open || conexionSQL.State == ConnectionState.Broken;
    }

    
    public void desconectar()
    {
        if (conexionSQL != null && conexionSQL.State != ConnectionState.Closed)
        {
            conexionSQL.Close();
        }
    }

    
    public List<SelectListItem> getCategorias()
    {
        List<SelectListItem> items = new List<SelectListItem>();
        string query = "SELECT * FROM categorias ORDER BY sNombreCategoria";

        using (SqlConnection conn = new SqlConnection(cadenaConexion))
        using (SqlCommand comando = new SqlCommand(query, conn))
        {
            try
            {
                conn.Open();
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = lector["sNombreCategoria"].ToString(),
                                Value = lector["nIdCategoria"].ToString()
                            });
                        }
                    }
                }
            }
            catch (SqlException error)
            {
                Console.WriteLine($"Error SQL: {error.Message}");
            }
        }
        return items;
    }

    
    public List<SelectListItem> getLocalidades()
    {
        List<SelectListItem> items = new List<SelectListItem>();
        string query = "SELECT * FROM municipios ORDER BY sNombreMunicipio";

        using (SqlConnection conn = new SqlConnection(cadenaConexion))
        using (SqlCommand comando = new SqlCommand(query, conn))
        {
            try
            {
                conn.Open();
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = lector["sNombreMunicipio"].ToString(),
                                Value = lector["nIdMunicipio"].ToString()
                            });
                        }
                    }
                }
            }
            catch (SqlException error)
            {
                Console.WriteLine($"Error SQL: {error.Message}");
            }
        }
        return items;
    }

    // Obtener Empresas para Dropdown
    public List<SelectListItem> getEmpresas()
    {
        List<SelectListItem> items = new List<SelectListItem>();
        string query = "SELECT * FROM empresas ORDER BY sNombreEmpresa";

        using (SqlConnection conn = new SqlConnection(cadenaConexion))
        using (SqlCommand comando = new SqlCommand(query, conn))
        {
            try
            {
                conn.Open();
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = lector["sNombreEmpresa"].ToString(),
                                Value = lector["nIdEmpresa"].ToString()
                            });
                        }
                    }
                }
            }
            catch (SqlException error)
            {
                Console.WriteLine($"Error SQL: {error.Message}");
            }
        }
        return items;
    }

    // Cargar Datos de Ofertas
    public List<Datos> CargarDatos(int categoria = 1, int municipio = 1, int empresa = 1)
    {
        List<Datos> items = new List<Datos>();
        string SQL = @"SELECT categorias.sNombreCategoria, ofertas.nIdOferta, ofertas.sTituloOferta, 
                       CASE ofertas.nTipoContrato WHEN 1 THEN 'Permanente' WHEN 2 THEN 'Por proyecto' END AS nTipoContrato,
                       CASE ofertas.nTipoJornada WHEN 1 THEN 'Tiempo Completo' WHEN 2 THEN 'Por horas' END AS nTipoJornada,
                       ofertas.fSalario, ofertas.dFechaPublicacion, empresas.sNombreEmpresa, municipios.sNombreMunicipio
                       FROM municipios
                       INNER JOIN ofertas ON municipios.nIdMunicipio = ofertas.nIdLocalidad
                       INNER JOIN empresas ON ofertas.nIdEmpresa = empresas.nIdEmpresa
                       INNER JOIN categorias ON ofertas.nIdCategoria = categorias.nIdCategoria
                       WHERE categorias.nIdCategoria = @nIdCategoria AND municipios.nIdMunicipio = @nIdMunicipio
                       AND empresas.nIdEmpresa = @nIdEmpresa";

        using (SqlConnection conn = new SqlConnection(cadenaConexion))
        using (SqlCommand comando = new SqlCommand(SQL, conn))
        {
            comando.Parameters.AddWithValue("@nIdCategoria", categoria);
            comando.Parameters.AddWithValue("@nIdMunicipio", municipio);
            comando.Parameters.AddWithValue("@nIdEmpresa", empresa);

            SqlDataAdapter dataAdaptador = new SqlDataAdapter(comando);
            DataTable t = new DataTable();

            try
            {
                conn.Open();
                dataAdaptador.Fill(t);

                foreach (DataRow fila in t.Rows)
                {
                    items.Add(new Datos
                    {
                        sNombreCategoria = fila["sNombreCategoria"].ToString(),
                        nIdOferta = fila["nIdOferta"].ToString(),
                        sTituloOferta = fila["sTituloOferta"].ToString(),
                        nTipoJornada = fila["nTipoJornada"].ToString(),
                        fSalario = fila["fSalario"].ToString(),
                        dFechaPublicacion = fila["dFechaPublicacion"].ToString(),
                        sNombreEmpresa = fila["sNombreEmpresa"].ToString(),
                        sNombreMunicipio = fila["sNombreMunicipio"].ToString()
                    });
                }
            }
            catch (SqlException error)
            {
                Console.WriteLine($"Error SQL: {error.Message}");
            }
        }
        return items;
    }

    // Insertar Nueva Oferta
    public int nuevaOferta(int nIdEmpresa, string sTituloOferta, int nTipoJornada, int nTipoContrato, double fSalario,
                           int nIdLocalidad, int nTipoLocalidad, int nIdCategoria, string fechaPublicacion,
                           string sDescripcion, string fechaContratacion, int nVacantes)
    {
        string queryInsert = @"INSERT INTO ofertas(nIdEmpresa, sTituloOferta, nTipoJornada, nTipoContrato, fSalario, 
                               nIdLocalidad, nTipoLocalidad, nIdCategoria, dFechaPublicacion, sDescripcion, 
                               fechaContratacion, nVacantes)
                               VALUES(@nIdEmpresa, @sTituloOferta, @nTipoJornada, @nTipoContrato, @fSalario, 
                               @nIdLocalidad, @nTipoLocalidad, @nIdCategoria, @dFechaPublicacion, @sDescripcion, 
                               @fechaContratacion, @nVacantes)";

        using (SqlConnection conn = new SqlConnection(cadenaConexion))
        using (SqlCommand comando = new SqlCommand(queryInsert, conn))
        {
            comando.Parameters.AddWithValue("@nIdEmpresa", nIdEmpresa);
            comando.Parameters.AddWithValue("@sTituloOferta", sTituloOferta);
            comando.Parameters.AddWithValue("@nTipoJornada", nTipoJornada);
            comando.Parameters.AddWithValue("@nTipoContrato", nTipoContrato);
            comando.Parameters.AddWithValue("@fSalario", fSalario);
            comando.Parameters.AddWithValue("@nIdLocalidad", nIdLocalidad);
            comando.Parameters.AddWithValue("@nTipoLocalidad", nTipoLocalidad);
            comando.Parameters.AddWithValue("@nIdCategoria", nIdCategoria);
            comando.Parameters.AddWithValue("@dFechaPublicacion", Convert.ToDateTime(fechaPublicacion));
            comando.Parameters.AddWithValue("@sDescripcion", sDescripcion);
            comando.Parameters.AddWithValue("@fechaContratacion", Convert.ToDateTime(fechaContratacion));
            comando.Parameters.AddWithValue("@nVacantes", nVacantes);

            try
            {
                conn.Open();
                return comando.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                Console.WriteLine($"Error SQL: {error.Message}");
                return 0;
            }
        }
    }

    // Actualizar Oferta
    public int actualizarOferta(int idOferta, int nIdEmpresa, string sTituloOferta, int nTipoJornada, int nTipoContrato,
                                double fSalario, int nIdLocalidad, int nTipoLocalidad, int nIdCategoria,
                                string fechaPublicacion, string sDescripcion, string fechaContratacion, int nVacantes)
    {
        string queryUpdate = @"UPDATE ofertas 
                               SET nIdEmpresa = @nIdEmpresa, sTituloOferta = @sTituloOferta, nTipoJornada = @nTipoJornada,
                                   nTipoContrato = @nTipoContrato, fSalario = @fSalario, nIdLocalidad = @nIdLocalidad, 
                                   nTipoLocalidad = @nTipoLocalidad, nIdCategoria = @nIdCategoria, 
                                   dFechaPublicacion = @dFechaPublicacion, sDescripcion = @sDescripcion, 
                                   fechaContratacion = @fechaContratacion, nVacantes = @nVacantes
                               WHERE nIdOferta = @idOferta";

        using (SqlConnection conn = new SqlConnection(cadenaConexion))
        using (SqlCommand comando = new SqlCommand(queryUpdate, conn))
        {
            comando.Parameters.AddWithValue("@idOferta", idOferta);
            comando.Parameters.AddWithValue("@nIdEmpresa", nIdEmpresa);
            comando.Parameters.AddWithValue("@sTituloOferta", sTituloOferta);
            comando.Parameters.AddWithValue("@nTipoJornada", nTipoJornada);
            comando.Parameters.AddWithValue("@nTipoContrato", nTipoContrato);
            comando.Parameters.AddWithValue("@fSalario", fSalario);
            comando.Parameters.AddWithValue("@nIdLocalidad", nIdLocalidad);
            comando.Parameters.AddWithValue("@nTipoLocalidad", nTipoLocalidad);
            comando.Parameters.AddWithValue("@nIdCategoria", nIdCategoria);
            comando.Parameters.AddWithValue("@dFechaPublicacion", Convert.ToDateTime(fechaPublicacion));
            comando.Parameters.AddWithValue("@sDescripcion", sDescripcion);
            comando.Parameters.AddWithValue("@fechaContratacion", Convert.ToDateTime(fechaContratacion));
            comando.Parameters.AddWithValue("@nVacantes", nVacantes);

            try
            {
                conn.Open();
                return comando.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                Console.WriteLine($"Error SQL: {error.Message}");
                return 0;
            }
        }
    }

    // Eliminar Oferta
    public int EliminarDatos(int idOferta)
    {
        string queryDelete = "DELETE FROM ofertas WHERE nIdOferta = @idOferta";

        using (SqlConnection conn = new SqlConnection(cadenaConexion))
        using (SqlCommand comando = new SqlCommand(queryDelete, conn))
        {
            comando.Parameters.AddWithValue("@idOferta", idOferta);

            try
            {
                conn.Open();
                return comando.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                Console.WriteLine($"Error SQL: {error.Message}");
                return 0;
            }
        }
    }

    // Mostrar una Oferta Específica
    public Datos mostrarOferta(int idOferta)
    {
        Datos oferta = new Datos();
        string SQL = @"SELECT * FROM ofertas WHERE nIdOferta = @idOferta";

        using (SqlConnection conn = new SqlConnection(cadenaConexion))
        using (SqlCommand comando = new SqlCommand(SQL, conn))
        {
            comando.Parameters.AddWithValue("@idOferta", idOferta);

            try
            {
                conn.Open();
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        oferta.sTituloOferta = lector["sTituloOferta"].ToString();
                        oferta.nTipoJornada = lector["nTipoJornada"].ToString();
                        oferta.fSalario = lector["fSalario"].ToString();
                        oferta.dFechaPublicacion = lector["dFechaPublicacion"].ToString();
                        oferta.sDescripcion = lector["sDescripcion"].ToString();
                        oferta.sNombreEmpresa = lector["nIdEmpresa"].ToString();
                    }
                }
            }
            catch (SqlException error)
            {
                Console.WriteLine($"Error SQL: {error.Message}");
            }
        }
        return oferta;
    }
}
