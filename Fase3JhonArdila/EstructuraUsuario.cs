using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3JhonArdila
{
    public partial class frmEstructuraUsuario : Form
    {
        private String tipoDocumento;
        private String numeroIdentidad;
        private String nombreUsuario;
        private String edadUsuario;
        private String estratoUsuario;
        private String atencionRequerida;
        private String valorCopago;
        private String fechaDeRegistro;
        private String tipoEstructura;
        private int promedioEdades;
        private int sumaEdades;
        private int reportePila;
        private int reporteCola;
        private int reporteLista;

        Stack<EstructuraDatosUsuario> pilaUsuario = new Stack<EstructuraDatosUsuario>();
        Queue<EstructuraDatosUsuario> colaUsuario = new Queue<EstructuraDatosUsuario> ();
        List<EstructuraDatosUsuario> listaUsuario = new List<EstructuraDatosUsuario>();

        public frmEstructuraUsuario()
        {
            InitializeComponent();
            cargarElementosIniciales();
            this.reportePila = 0;
            this.reporteCola = 0;
            this.reporteLista = 0;
            this.btnReportePila.Enabled = false;
            this.btnReporteCola.Enabled = false;
            this.btnReporteLista.Enabled = false;
            this.btnEliminarPila.Enabled = false;
            this.btnEliminarCola.Enabled = false;
            this.btnEliminarLista.Enabled = false;
        }

        public void cargarElementosIniciales()
        {
            this.cbxTipoIdentidad.Text = "";
            this.txtNumeroIdentidad.Text = "";
            this.txtNombreUsuario.Text = "";
            this.txtEdad.Text = "";
            this.cbxEstratoSocial.Text = "";
            this.rbMedicinaGeneral.Checked = false;
            this.rbLaboratorio.Checked = false;
            this.txtValorCopago.Text = "";
            this.dtFechaAcceso.Value = DateTime.Now;
            this.cbxTipoEstructura.Text = "";
            this.txtReporteDatos.Text = "";

            this.cbxTipoIdentidad.Items.Clear();
            this.cbxEstratoSocial.Items.Clear();
            this.cbxTipoEstructura.Items.Clear();

            this.cbxTipoIdentidad.Items.Add("CC");
            this.cbxTipoIdentidad.Items.Add("CE");
            this.cbxTipoIdentidad.Items.Add("NUIP");
            this.cbxTipoIdentidad.Items.Add("PAS");

            this.cbxEstratoSocial.Items.Add("1");
            this.cbxEstratoSocial.Items.Add("2");
            this.cbxEstratoSocial.Items.Add("3");
            this.cbxEstratoSocial.Items.Add("4");
            this.cbxEstratoSocial.Items.Add("5");
            this.cbxEstratoSocial.Items.Add("6");

            this.cbxTipoEstructura.Items.Add("Pila");
            this.cbxTipoEstructura.Items.Add("Cola");
            this.cbxTipoEstructura.Items.Add("Lista");
        }

        public bool validarCamposFormulario()
        {
            String mensaje = "";

            this.tipoDocumento = this.cbxTipoIdentidad.Text.Trim();

            if (this.tipoDocumento == "")
            {
                mensaje = mensaje + "~ Tipo de documento \n";
            }

            this.numeroIdentidad = this.txtNumeroIdentidad.Text.Trim();

            if (this.numeroIdentidad == "")
            {
                mensaje = mensaje + "~ Número de identidad \n";
            }

            this.nombreUsuario = this.txtNombreUsuario.Text.Trim();

            if (this.nombreUsuario == "")
            {
                mensaje = mensaje + "~ Nombre del usuario \n";
            }

            this.edadUsuario = this.txtEdad.Text.Trim();

            if (this.edadUsuario == "")
            {
                mensaje = mensaje + "~ Edad del usuario \n";
            }

            this.estratoUsuario = this.cbxEstratoSocial.Text.Trim();

            if (this.estratoUsuario == "")
            {
                mensaje = mensaje + "~ Estrato socieconómico \n";
            }

            if (this.rbMedicinaGeneral.Checked == false && this.rbLaboratorio.Checked == false)
            {
                mensaje = mensaje + "~ Atención requerida \n";
            }
            else
            {
                if (this.rbMedicinaGeneral.Checked == true)
                {
                    this.atencionRequerida = "Medicina general";
                }
                if (this.rbLaboratorio.Checked == true)
                {
                    this.atencionRequerida = "Examen de laboratorio";
                }
            }

            this.tipoEstructura = this.cbxTipoEstructura.Text.Trim();

            if (this.tipoEstructura == "")
            {
                mensaje = mensaje + "~ Tipo de estructura \n";
            }

            if (mensaje != "")
            {
                mensaje = "Falta diligenciar los siguientes campos: \n\n" + mensaje;
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                this.valorCopago = (calcularValorCopago()).ToString();
                this.fechaDeRegistro = this.dtFechaAcceso.ToString();
                this.txtValorCopago.Text = "$" + this.valorCopago;
                return true;
            }
        } 

        public int calcularValorCopago()
        {
            int valorDelCopago;
            valorDelCopago = 0;

            if(this.atencionRequerida == "Medicina general")
            {
                switch(this.estratoUsuario)
                {
                    case "1":
                        valorDelCopago = 0;
                        break;
                    case "2":
                        valorDelCopago = 0;
                        break;
                    case "3":
                        valorDelCopago = 10000;
                        break;
                    case "4":
                        valorDelCopago = 15000;
                        break;
                    case "5":
                        valorDelCopago = 20000;
                        break;
                    case "6":
                        valorDelCopago = 30000;
                        break;
                }
            }

            if (this.atencionRequerida == "Examen de laboratorio")
            {
                switch (this.estratoUsuario)
                {
                    case "1":
                        valorDelCopago = 0;
                        break;
                    case "2":
                        valorDelCopago = 0;
                        break;
                    case "3":
                        valorDelCopago = 0;
                        break;
                    case "4":
                        valorDelCopago = 5000;
                        break;
                    case "5":
                        valorDelCopago = 10000;
                        break;
                    case "6":
                        valorDelCopago = 20000;
                        break;
                }
            }

            return valorDelCopago;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas salir?", "Confimar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarCamposFormulario())
            {
                EstructuraDatosUsuario estructuraDatos = new EstructuraDatosUsuario();
                estructuraDatos.tipoDocumento = this.tipoDocumento;
                estructuraDatos.numeroIdentidad = this.numeroIdentidad;
                estructuraDatos.nombreUsuario = this.nombreUsuario;
                estructuraDatos.edadUsuario = int.Parse(this.edadUsuario);
                estructuraDatos.estratoUsuario = this.estratoUsuario;
                estructuraDatos.atencionRequerida = this.atencionRequerida;
                estructuraDatos.valorCopago = int.Parse(this.valorCopago);
                estructuraDatos.fechaDeRegistro = this.fechaDeRegistro;

                if(this.tipoEstructura == "Pila")
                {
                    this.reportePila = this.reportePila + int.Parse(this.valorCopago);

                    this.pilaUsuario.Push(estructuraDatos);
                    dgPila.DataSource = null;
                    dgPila.DataSource = this.pilaUsuario.ToArray();
                    this.tabTipoEstructuras.SelectedIndex = 0;
                    MessageBox.Show("¡El registo fue agregado a la Pila exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnReportePila.Enabled = true;
                    this.btnEliminarPila.Enabled = true;
                }

                if (this.tipoEstructura == "Cola")
                {
                    this.reporteCola = this.reporteCola + 1;

                    this.colaUsuario.Enqueue(estructuraDatos);
                    dgCola.DataSource = null;
                    dgCola.DataSource = this.colaUsuario.ToArray();
                    this.tabTipoEstructuras.SelectedIndex = 1;
                    MessageBox.Show("¡El registo fue agregado a la Cola exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnReporteCola.Enabled = true;
                    this.btnEliminarCola.Enabled = true;
                }

                if (this.tipoEstructura == "Lista")
                {
                    this.sumaEdades = this.sumaEdades + int.Parse(this.edadUsuario);
                    this.reporteLista = this.reporteLista + 1;
                    this.promedioEdades = sumaEdades / this.reporteLista;

                    this.listaUsuario.Add(estructuraDatos);
                    dgLista.DataSource = null;
                    dgLista.DataSource = this.listaUsuario.ToArray();
                    this.tabTipoEstructuras.SelectedIndex = 2;
                    MessageBox.Show("¡El registo fue agregado a la Lista exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnReporteLista.Enabled = true;
                    this.btnEliminarLista.Enabled = true;
                }

                cargarElementosIniciales();
            }
        }

        private void txtNumeroIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                MessageBox.Show("Este campo solo permite ingresar números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Para la edad solo se permite ingresar números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Este campo solo permite ingresar letras", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }



        private void frmEstructuraUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtValorCopago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReporteDatos_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnReportePila_Click(object sender, EventArgs e)
        {
            this.txtReporteDatos.Text = "$" + this.reportePila.ToString();
        }

        private void btnReporteCola_Click(object sender, EventArgs e)
        {
            if(this.reporteCola > 1)
            {
                this.txtReporteDatos.Text = this.reporteCola.ToString() + " registros";
            } else
            {
                this.txtReporteDatos.Text = this.reporteCola.ToString() + " registro";
            }
            
        }

        private void btnReporteLista_Click(object sender, EventArgs e)
        {
            if (this.reporteLista >= 1)
            {
                this.txtReporteDatos.Text = this.promedioEdades + " años";
            }
            else
            {
                this.txtReporteDatos.Clear();
            }
            
        }

        private void btnEliminarPila_Click(object sender, EventArgs e)
        {
            if(this.pilaUsuario.Count > 0)
            {
                if(MessageBox.Show("¿Desea eliminar el último registro de la Pila?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EstructuraDatosUsuario estructuraDatos = new EstructuraDatosUsuario();
                    estructuraDatos = this.pilaUsuario.Pop();
                    this.reportePila = this.reportePila - estructuraDatos.valorCopago;
                    dgPila.DataSource = null;
                    dgPila.DataSource = this.pilaUsuario.ToArray();
                    MessageBox.Show("¡Último registro de la Pila elimiando con éxito!", "Confimación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarElementosIniciales();

                } 

            } 
            else
            {
                MessageBox.Show("¡No hay registros para eliminar en la Pila!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.btnReportePila.Enabled = false;
                this.btnEliminarPila.Enabled = false;
            }
        }

        private void btnEliminarCola_Click(object sender, EventArgs e)
        {
            if (this.colaUsuario.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar el primer registro de la Cola?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    EstructuraDatosUsuario estructuraDatos = new EstructuraDatosUsuario();
                    estructuraDatos = this.colaUsuario.Dequeue();
                    this.reporteCola = this.reporteCola - 1;
                    dgCola.DataSource = null;
                    dgCola.DataSource = this.colaUsuario.ToArray();
                    MessageBox.Show("¡Primer registro de la Cola elimiando con éxito!", "Confimación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarElementosIniciales();

                }

            }
            else
            {
                MessageBox.Show("¡No hay registros para eliminar en la Cola!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.btnReporteCola.Enabled = false;
                this.btnEliminarCola.Enabled = false;
            }
        }

        private EstructuraDatosUsuario buscarUsuario(string identidadUsuario)
        {
            foreach (EstructuraDatosUsuario estructuraDatos in this.listaUsuario)
            {
                if (estructuraDatos.numeroIdentidad.Equals(identidadUsuario))
                {
                    return estructuraDatos;
                }
            }

            return null;
        }

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            if (this.listaUsuario.Count > 0)
            {
                string identidadUsuario = this.txtNumeroIdentidad.Text.Trim();

                if (identidadUsuario == "")
                {
                    MessageBox.Show("¡La identificación del usuario no puede estar vacía para la eliminación!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtNumeroIdentidad.Focus();
                }
                else
                {
                    EstructuraDatosUsuario estructuraDatos = buscarUsuario(identidadUsuario);

                    if (estructuraDatos != null)
                    {
                        if (MessageBox.Show("¿Desea eliminar el registro de la Lista?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {

                            if (this.reporteLista == 1)
                            {
                                this.sumaEdades = this.sumaEdades - estructuraDatos.edadUsuario;
                                this.reporteLista = this.reporteLista - 1;
                            }
                            else
                            {
                                this.sumaEdades = this.sumaEdades - estructuraDatos.edadUsuario;
                                this.reporteLista = this.reporteLista - 1;
                                this.promedioEdades = sumaEdades / this.reporteLista;
                            }


                            this.listaUsuario.Remove(estructuraDatos);
                            dgLista.DataSource = null;
                            dgLista.DataSource = this.listaUsuario.ToArray();
                            MessageBox.Show("¡El registro de la Lista fue elimiando con éxito!", "Confimación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarElementosIniciales();
                        }
                    } 
                    else
                    {
                        MessageBox.Show("La identificación del usuario número " + identidadUsuario + " no existe en la lista", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtNumeroIdentidad.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("¡No hay registros para eliminar en la Lista!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.btnReporteLista.Enabled = false;
                this.btnEliminarLista.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargarElementosIniciales();
        }
    }
}