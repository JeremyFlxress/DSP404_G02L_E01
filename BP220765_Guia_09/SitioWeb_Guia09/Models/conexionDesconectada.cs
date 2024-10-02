using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SitioWeb_Guia09.Models
{
    public class conexionDesconectada
    {
        string coneccionString;
        SqlConnection conexionSQL;
        public DataSet DataSetPrincipal;
        SqlDataAdapter DataAdapterEspecifico;

        public conexionDesconectada()
        {
            coneccionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            conexionSQL = new SqlConnection(coneccionString);
            DataSetPrincipal = new DataSet();
            conexionSQL.Open();
            //Inicializamos el adaptador especifico que se utilizará en la gestion de registros de produtos
            DataAdapterEspecifico = new SqlDataAdapter();
            DataAdapterEspecifico.SelectCommand = new SqlCommand("SELECT * FROM Products", conexionSQL);
        }

        public void Conectar()
        {
            conexionSQL.Open();
        }
        public void Desconectar()
        {
            conexionSQL.Close();
        }
        public void copiarBaseDatos()
        {
            cargarTabla("Categories", "CategoryID");
            cargarTabla("Suppliers", "SupplierID");
            cargarTabla("Products", "ProductID");

            //Establecemos las relaciones de llaves foraneas entre las tablas
            ForeignKeyConstraint fk1_cat_pro;
            fk1_cat_pro = new
                ForeignKeyConstraint(DataSetPrincipal.Tables["Categories"].Columns["CategoryID"],
                DataSetPrincipal.Tables["Products"].Columns["CategoryID"]);
            DataSetPrincipal.Tables["Products"].Constraints.Add(fk1_cat_pro);
        }

        public void cargarTabla(String nombreTabla, String primaryKey)
        {
            nombreTabla = nombreTabla.Trim();

            if (DataSetPrincipal.Tables.IndexOf(nombreTabla) == -1)
            {
                /*Configuramos un control dataAdapter para que funcione como puente entre 
                dataset y base de datos */
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand();

                dataAdapter.SelectCommand.CommandText = "SELECT * FROM " + nombreTabla;
                dataAdapter.SelectCommand.Connection = conexionSQL;
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                //Populamos el dataset con la tabla que acabamos de obtener
                dataAdapter.FillSchema(DataSetPrincipal, SchemaType.Source, nombreTabla);
                dataAdapter.Fill(DataSetPrincipal, nombreTabla);
                dataAdapter.SelectCommand.Dispose();
                dataAdapter.Dispose();
                //Obtenemos la tabla actual y establecemos el campo que se 
                //utilizará como llave primaria
                DataTable tablaActual;
                tablaActual = DataSetPrincipal.Tables[nombreTabla];

                DataColumn[] columnasPrincipales = new DataColumn[1];
                columnasPrincipales[0] = tablaActual.Columns[primaryKey];
                tablaActual.PrimaryKey = columnasPrincipales;
            }
        }
        public int insertarProducto(DataSet ds, string Categorias, string Proveedores,
            string ProductName, string QuantityPerUnit, string UnitPrice,
            string UnitsInStock, string UnitsOnOrder)
        {
            DataTable table = ds.Tables["Products"];

            DataRow row = table.NewRow();
            row["ProductName"] = ProductName;
            row["SupplierID"] = Proveedores;
            row["CategoryID"] = Categorias;
            row["QuantityPerUnit"] = QuantityPerUnit;
            row["UnitsInStock"] = UnitsInStock;
            row["UnitPrice"] = UnitPrice;
            row["UnitsOnOrder"] = UnitsOnOrder;
            table.Rows.Add(row);

            if (ds.HasChanges())
            {
                SqlCommandBuilder comando = new SqlCommandBuilder(DataAdapterEspecifico);
                int filasAfectadas = DataAdapterEspecifico.Update(ds, "Products");
                ds.AcceptChanges();
                return filasAfectadas;
            }
            return 0;
        }
        public Product mostrarDatos(int productID, DataSet ds)
        {
            DataView vistaFiltro = new DataView(ds.Tables["Products"]);
            vistaFiltro.RowFilter = "ProductID = " + productID;

            Product itemproduct = new Product();
            foreach (DataRowView dr in vistaFiltro)
            {
                itemproduct.ProductID = dr["ProductID"].ToString();
                itemproduct.ProductName = dr["ProductName"].ToString();
                itemproduct.SupplierID = dr["SupplierID"].ToString();
                itemproduct.CategoryID = dr["CategoryID"].ToString();
                itemproduct.QuantityPerUnit = dr["QuantityPerUnit"].ToString();
                itemproduct.UnitPrice = dr["UnitPrice"].ToString();
                itemproduct.UnitsInStock = dr["UnitsInStock"].ToString();
                itemproduct.UnitsOnOrder = dr["UnitsOnOrder"].ToString();
            }
            return itemproduct;
        } 

        public int actualizarProducto (DataSet ds, int ProductID, string Categorias,
            string Proveedores, string ProductName, string QuantityPerUnit,
            string UnitPrice, string UnitsInStock, string UnitsOnOrder)
        {
            DataRow fila2Update;
            DataTable tablaProductos;
            tablaProductos = ds.Tables["Products"];

            try
            {
                fila2Update = tablaProductos.Rows.Find(ProductID);
                fila2Update["ProductName"] = ProductName;
                fila2Update["SupplierID"] = int.Parse(Proveedores);
                fila2Update["CategoryID"] = int.Parse(Categorias);
                fila2Update["QuantityPerUnit"] = QuantityPerUnit;
                fila2Update["UnitPrice"] = double.Parse(UnitPrice);
                fila2Update["UnitsInStock"] = int.Parse(UnitsInStock);
                fila2Update["UnitsOnOrder"] = int.Parse(UnitsOnOrder);

                if (DataSetPrincipal.HasChanges())
                {
                    SqlCommandBuilder comando =
                    new SqlCommandBuilder(DataAdapterEspecifico);
                    int filasAfectadas =
                    DataAdapterEspecifico.Update(DataSetPrincipal, "Products");
                    DataSetPrincipal.AcceptChanges();
                    return filasAfectadas;
                }
                return 0;
            }
            catch(Exception e)
            {
                return 0;
            }
        }
        public int eliminarProducto (DataSet ds, int ProductID)
        {
            DataRow fila2Delete;
            DataTable tablaProductos;
            tablaProductos = ds.Tables["Products"];

            try
            {
                fila2Delete = tablaProductos.Rows.Find(ProductID);
                fila2Delete.Delete();
                if (DataSetPrincipal.HasChanges())
                {
                    SqlCommandBuilder comando = new SqlCommandBuilder(DataAdapterEspecifico);

                    int filasAfectadas = DataAdapterEspecifico.Update(ds, "Products");
                    ds.AcceptChanges();
                    return filasAfectadas;
                }
                return 0;
            }
            catch(Exception e)
            {
                return 0;
            }
        }
    }

}