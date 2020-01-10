/*
* PRÁCTICA.............: Práctica 8
* NOMBRE Y APELLIDOS...: Mario Olivera Castañeda
* CURSO Y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: App.de Formulario II. Generación de Componentes.
* FECHA DE ENTREGA.....: 08 de Enero de 2019
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica8
{
    public partial class frmSplash : Form
    {
        private int contador = 0;
        public frmSplash()
        {
            InitializeComponent();
            tmrCargar.Enabled = true;
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            contador++;
            lblCargando.Text = "CARGANDO: " + contador + " %";
            progressBarCargar.Increment(1);
            if (progressBarCargar.Value == 100)
            {
                tmrCargar.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void progressBarCargar_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
