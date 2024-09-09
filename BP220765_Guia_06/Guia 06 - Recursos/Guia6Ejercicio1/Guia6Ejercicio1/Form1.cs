using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia6Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1() //constructor de clase Form1
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarcombobox(); //llena los 3 combos (que definen a una fecha)
                              //crea las listas de doctores y vendedores
            doctores = new List<clsDoctor>();
            vendedores = new List<clsVendedor>();
            //Define filtros para el cuadro de seleccion, que mostrara solo imagenes JPG
            cuadroseleccion.Filter = "Imagenes de tipo JPG |*.jpg";
            //Inicia los controles para ingresar un nuevo Doctor o un nuevo Vendedor
            PrepararNuevoDoctor();
            PrepararNuevoVendedor();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Se invoca un objeto de clase OpenFileDialog, para que usuario seleccione archivo
            //de imagen y asi, se cargue en el cuadro de imagen
            if (cuadroseleccion.ShowDialog() == DialogResult.OK)
            {
                picFotoDoc.ImageLocation = cuadroseleccion.FileName;
            }
        }

        private void btnAgregarDoc_Click(object sender, EventArgs e)
        {
            clsDoctor Doctor = new clsDoctor(); //objeto de la clase derivada
                                                //toma los datos de los controles del form para definir a objeto Doctor
            Doctor.nombreempleado = txtNom.Text;
            Doctor.asignarfechanac(cmbAnno.Text, cmbMes.Text, cmbDia.Text);
            Doctor.sueldobase = Convert.ToSingle(nudSueldo.Value);
            Doctor.codigodoctor = mtbCodDoctor.Text;
            //envia url de foto seleccionada por usuario
            Doctor.URLfoto = picFotoDoc.ImageLocation;
            //intenta agregar nuevo doctor a coleccion de Doctores
            if (Doctor.DatossonCorrectos())
            {
                doctores.Add(Doctor);
                MessageBox.Show("Doctor " + Doctor.nombreempleado + " se ha agregado a la
                lista","Excelente!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //Inicia los controles para ingresar un nuevo Doctor
                 PrepararNuevoDoctor();
            }
            else
                MessageBox.Show("Datos incompletos");
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            //Selecciona un archivo de imagen para el vendedor
            if (cuadroseleccion.ShowDialog() == DialogResult.OK)
            {
                picFotoVen.ImageLocation = cuadroseleccion.FileName;
            }
        }

        private void btnAgregarVen_Click(object sender, EventArgs e)
        {
            clsVendedor Vendedor = new clsVendedor(); //objeto de la clase derivada
                                                      //Define valores brindados por usuario hacia objeto vendedor
            Vendedor.nombreempleado = txtNomV.Text;
            Vendedor.sueldobase = 2000; //asigna un sueldo fijo de $2000;
            Vendedor.asignarfechanac(dtpFechaNac.Value);
            Vendedor.FechaContrato = dtpFechaC.Value;
            //envia url de foto seleccionada por usuario
            Vendedor.URLfoto = picFotoVen.ImageLocation;
            //agrega vendedor actual hacia list de vendedores
            vendedores.Add(Vendedor);
            //deja controles listos para el prox. vendedor a registrar
            PrepararNuevoVendedor();
        }

        private void rbDoctores_CheckedChanged(object sender, EventArgs e)
        {
            //invoca metodo para llenar al Datagrid con datos de los doctores registrados
            MostrarLista_Doctores();
        }

        private void rbVendedores_CheckedChanged(object sender, EventArgs e)
        {
            //invoca metodo para llenar al Datagrid con datos de los vendedores registrados
            MostrarLista_Vendedores();
        }
    }
}
