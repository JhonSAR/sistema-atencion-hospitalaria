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
    public partial class Form1 : Form
    {
        private const string STRCLAVE = "unad";
        private ErrorProvider error;
        
        public Form1()
        {
            InitializeComponent();
            error = new ErrorProvider();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string strClave = "";

            strClave = this.txtClave.Text.Trim();

            if (strClave == "")
            {
                this.error.SetError(this.txtClave, "¡Ingrese su clave!");
                this.txtClave.Focus();
            }
            else
            {
                if (strClave != STRCLAVE)
                {
                    this.error.SetError(this.txtClave, "¡La clave ingresada es incorrecta!");
                    this.txtClave.Focus();
                }
                else
                {
                    this.error.SetError(this.txtClave, null);
                    frmEstructuraUsuario estructuraUsuario = new frmEstructuraUsuario();
                    estructuraUsuario.Show();
                    this.Hide();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estructura de Datos \nJhon Sebastian Ardila Reyes \nGrupo No. 301305_43", "Acerca de");
        }

        private void itemInicioDeSesion_Click(object sender, EventArgs e)
        {
            txtClave.Enabled = true;
            btnIngresar.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
