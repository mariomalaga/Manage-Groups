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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8
{
    public partial class frmAbrirGrupo : Form
    {
        public frmAbrirGrupo()
        {
            InitializeComponent();
            DirectoryInfo di = new DirectoryInfo(".");
            foreach (var fi in di.GetFiles("*.gru*"))
            {
                cboListaArchivos.Items.Add(fi.Name);
            }
        }

        private void btnAbrirGrupo_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = Application.OpenForms.OfType<frmPrincipal>().FirstOrDefault();
            principal.dtgAlumnos.Rows.Clear();
            if (!File.Exists(cboListaArchivos.SelectedItem.ToString()))
                return;
       
            string[] arrFilas;
            arrFilas = File.ReadAllLines(cboListaArchivos.SelectedItem.ToString());
            for(int i = 0; i < arrFilas.Length; i++)
            {
                if (i == 0)
                {
                    string[] titulos = arrFilas[i].Split('|');
                    for (int j = 0; j < titulos.Length; j++)
                    {
                        if (j == 0)
                        {
                            principal.lblTituloGrupo.Text = titulos[j];
                        }
                        else
                        {
                            principal.dtgAlumnos.Columns[j-1].HeaderText = titulos[j];
                        }
                    }
                }
                else
                {
                    string[] items = arrFilas[i].Split('|');
                    principal.dtgAlumnos.Rows.Add(items);
                }
            }
            principal.dtgAlumnos.Enabled = true;
            principal.btnGuardarGrupo.Enabled = true;
            if (principal != null) 
            {
                principal.Refresh();
            }
            this.Dispose();
        }

        private void btnCancelarAbrirGrupo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
