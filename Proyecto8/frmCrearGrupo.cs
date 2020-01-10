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

namespace Proyecto8
{
    public partial class frmCrearGrupo : Form
    {
        int contador = 0;
        public frmCrearGrupo()
        {
            InitializeComponent();
            btnAceptarNuevoGrupo.Enabled = false;
        }

        private void btnAceptarNuevoGrupo_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = Application.OpenForms.OfType<frmPrincipal>().FirstOrDefault();
            principal.lblTituloGrupo.Text = txtNombreGrupo.Text.ToString();
            principal.dtgAlumnos.Columns[1].HeaderText = lblAsignatura1.Text;
            principal.dtgAlumnos.Columns[2].HeaderText = lblAsignatura2.Text;
            principal.dtgAlumnos.Columns[3].HeaderText = lblAsignatura3.Text;
            principal.dtgAlumnos.Columns[4].HeaderText = lblAsignatura4.Text;
            principal.dtgAlumnos.Rows.Clear();
            principal.dtgAlumnos.Enabled = true;
            principal.btnGuardarGrupo.Enabled = true;
            if (principal != null) 
            {
                principal.Refresh();
            }
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                lblAsignatura1.Text = cboAsignaturas.SelectedItem.ToString();
                cboAsignaturas.Items.Remove(cboAsignaturas.SelectedItem);
                contador++;
            }
            else if (contador == 1)
            {
                lblAsignatura2.Text = cboAsignaturas.SelectedItem.ToString();
                cboAsignaturas.Items.Remove(cboAsignaturas.SelectedItem);
                contador++;
            }
            else if (contador == 2)
            {
                lblAsignatura3.Text = cboAsignaturas.SelectedItem.ToString();
                cboAsignaturas.Items.Remove(cboAsignaturas.SelectedItem);
                contador++;
            }
            else if (contador == 3)
            {
                lblAsignatura4.Text = cboAsignaturas.SelectedItem.ToString();
                cboAsignaturas.Items.Remove(cboAsignaturas.SelectedItem);
                contador++;
            }
            if (lblAsignatura1.Text != "" && lblAsignatura2.Text != "" && lblAsignatura3.Text != "" && lblAsignatura4.Text != ""
            && txtNombreGrupo.Text != "")
            {
                btnAceptarNuevoGrupo.Enabled = true;
            }
        }

        private void btnCancelarNuevoGrupo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCrearGrupo_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreGrupo_TextChanged(object sender, EventArgs e)
        {
            if (lblAsignatura1.Text != "" && lblAsignatura2.Text != "" && lblAsignatura3.Text != "" && lblAsignatura4.Text != ""
            && txtNombreGrupo.Text != "")
            {
                btnAceptarNuevoGrupo.Enabled = true;
            }
            else
            {
                btnAceptarNuevoGrupo.Enabled = false;
            }
        }
    }
}
