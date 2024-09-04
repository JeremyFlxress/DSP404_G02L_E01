namespace clsEmpleado

{
    public class clsPlanilla
    {
        // ATRIBUTOS
        private int Estado; // Valores:
                            //1. Sin iniciar
                            //2. En proceso
                            //3. Finalizada

        private string Empresa;
        private DateTime FechaPlanilla;

        //Diccionario de objetos con informe de c/u de los empleados
        private Dictionary<int, clsEmpleado> ListaEmpleados = new Dictionary<int, clsEmpleado>();

        //Totales finales al generar la planilla
        private int TotalEmpleados;

        public clsPlanilla()
        {
            Estado = 1;
            Empresa = "";
            FechaPlanilla = DateTime.Now; // Asume que planilla se inicia hoy mismo
            TotalEmpleados = 0;
        }

        // METODO ABRIR PLANILLA
        public void abrirPlanilla(DateTime fechaInicio, string nombreEmpresa = "(Sin nombre)")
        {
            //Activa una nueva planilla. Evalua el estado del objeto
            nombreEmpresa = nombreEmpresa.Trim();
            switch (Estado)
            {
                case 1:
                    FechaPlanilla = fechaInicio;
                    if (nombreEmpresa.Length > 0)
                    {
                        Empresa = nombreEmpresa;
                    }

                    Estado = 2; //La planilla está activada
                    MessageBox.Show("Planilla abierta, inicie registro de empleados",
                        "Planilla de " + Empresa + ", APERTURA" + FechaPlanilla.ToString(),
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case 2:
                    //La plantilla ya esta activa en proceso
                    MessageBox.Show("La planilla está abierta desde el: " +
                        FechaPlanilla.ToString(), "Planilla de " + Empresa,
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case 3:
                    //La plantilla ya finalizo
                    MessageBox.Show("Planilla creada desde el: " +
                        FechaPlanilla.ToString() + " ya se cerro", "Planilla de " + Empresa,
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
            }
        }

        // METODO RECIBIR EMPLEADO
        public void recibirEmpleado(clsEmpleado nuevoEmpleado)
        {
            /*
             * Agrega trabajador recibido al dictionary de empleados de la planilla
             * evalua que Estado Actual de planilla sea 2 (En proceso)
             */

            if (Estado == 2)
            {
                //Evalua a un trabajador con todos sus datos completos
                if (nuevoEmpleado.datosPersonalesAceptados == false)
                {
                    MessageBox.Show("Datos personales incompletos", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (nuevoEmpleado.datosLaboralesAceptados == false)
                {
                    MessageBox.Show("Datos laborales incompletos", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Registrar un nuevo empleado al listado de la planilla abierta
                TotalEmpleados += 1;
                ListaEmpleados.Add(TotalEmpleados, nuevoEmpleado);
            }
            else
            {
                MessageBox.Show("Planilla aún no está abierta", "Planilla de " + Empresa,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //METODO GENERAR LISTADO
        public void generarListado(ref DataGridView cuadro)
        {
            int i = 1;
            string sb = "0";
            string sn = "0";
            //Evalua si la planilla aún está abierta!!
            switch (Estado)
            {
                case 1:
                    MessageBox.Show("Planilla aun no ha sido abierta", "Planilla" + Empresa);
                    return;
                    break;
                case 2:
                    //Evalua si estados está vacío
                    if (TotalEmpleados == 0)
                    {
                        MessageBox.Show("Planilla aun no tiene empleados registrados", "Planilla" + Empresa);
                        return;
                    }

                    Estado = 3;
                    MessageBox.Show("Planilla cerrada con " + TotalEmpleados + " empleados",
                        "Planilla de " + Empresa);
                    MessageBox.Show("Planilla abierta el " + FechaPlanilla.ToString() + " se muestra ahora!!",
                       "Planilla de " + Empresa);
                    break;
            }

            //Finalizo planilla activa y la genera el dataGrid
            cuadro.Rows.Clear();
            cuadro.Columns.Add("ID", "num");
            cuadro.Columns.Add("nom", "Nombre completo");
            cuadro.Columns.Add("sb", "Sueldo base");
            cuadro.Columns.Add("sf", "Sueldo final");

            //Alternar colores de DataGridView
            cuadro.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Bisque;
            cuadro.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige;

            //Comenzar a llenar filas del grid con los datos de cada empleado registrado en la planilla
            foreach (var result in ListaEmpleados)
            {
                cuadro.Rows.Add();
                cuadro.Rows[i - 1].Cells[0].Value = result.Key;
                cuadro.Rows[i - 1].Cells[1].Value = result.Value.nombreCompleto;
                result.Value.verSueldos(ref sb, ref sn);
                cuadro.Rows[i - 1].Cells[2].Value = sb;
                cuadro.Rows[i - 1].Cells[3].Value = sn;
                i++;
            }
            MessageBox.Show("Planilla del pago final completa generada en pantalla!!");
        }

        public void AbrirPlanilla(DateTime now, string v)
        {
            throw new NotImplementedException();
        }

        public void GenerarListado(ref System.Windows.Forms.DataGridView dataGridView)
        {
            throw new NotImplementedException();
        }

        public void GenerarListado(ref object dataGridView1)
        {
            throw new NotImplementedException();
        }

        public void GenerarListado(ref System.Windows.Forms.DataGridView dataGridView)
        {
            throw new NotImplementedException();
        }

        //PROPIEDAD (Procedimientos de propiedad)  
        public string TotaldeEmpleados
        {
            get { return TotaldeEmpleados.ToString(); }
        }
    }

}
