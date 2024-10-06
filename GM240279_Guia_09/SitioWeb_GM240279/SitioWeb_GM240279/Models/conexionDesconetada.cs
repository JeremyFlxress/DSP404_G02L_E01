using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SitioWeb_GM240279.Models
{
    public class conexionDesconetada
    {
        string coneccionString;
        SqlConnection conexionSQL;
        public DataSet DataSetPrincipal;
        SqlDataAdapter DataAdapterEspecífico;

        public conexionDesconetada()
        {
            coneccionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            conexionSQL = new SqlConnection(coneccionString);
            DataSetPrincipal = new DataSet();
            conexionSQL.Open();
            DataAdapterEspecífico = new SqlDataAdapter(new SqlCommand("SELECT * FROM Products", conexionSQL));
        }

        public void copiarBaseDatos()
        {
            cargarTabla("Categories", "CategoryID");
            cargarTabla("Suppliers", "SupplierID");
            cargarTabla("Products", "ProductID");

            ForeignKeyConstraint fk1_cat_pro = new ForeignKeyConstraint(
                DataSetPrincipal.Tables["Categories"].Columns["CategoryID"],
                DataSetPrincipal.Tables["Products"].Columns["CategoryID"]);
            DataSetPrincipal.Tables["Products"].Constraints.Add(fk1_cat_pro);
        }

        private void cargarTabla(string nombreTabla, string primaryKey)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM {nombreTabla}", conexionSQL);
            dataAdapter.FillSchema(DataSetPrincipal, SchemaType.Source, nombreTabla);
            dataAdapter.Fill(DataSetPrincipal, nombreTabla);
            DataTable tablaActual = DataSetPrincipal.Tables[nombreTabla];
            tablaActual.PrimaryKey = new DataColumn[] { tablaActual.Columns[primaryKey] };
        }

        public int insertarProducto(string Categorias, string Proveedores, string ProductName, string QuantityPerUnit, string UnitPrice, string UnitsInStock, string UnitsOnOrder)
        {
            DataRow newRow = DataSetPrincipal.Tables["Products"].NewRow();
            newRow["CategoryID"] = Categorias;
            newRow["SupplierID"] = Proveedores;
            newRow["ProductName"] = ProductName;
            newRow["QuantityPerUnit"] = QuantityPerUnit;
            newRow["UnitPrice"] = UnitPrice;
            newRow["UnitsInStock"] = UnitsInStock;
            newRow["UnitsOnOrder"] = UnitsOnOrder;
            DataSetPrincipal.Tables["Products"].Rows.Add(newRow);

            if (DataSetPrincipal.HasChanges())
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapterEspecífico);
                int affectedRows = DataAdapterEspecífico.Update(DataSetPrincipal, "Products");
                DataSetPrincipal.AcceptChanges();
                return affectedRows;
            }
            return 0;
        }
    }
}
