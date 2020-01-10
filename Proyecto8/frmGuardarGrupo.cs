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
    public partial class frmGuardarGrupo : Form
    {
        frmPrincipal principal = Application.OpenForms.OfType<frmPrincipal>().FirstOrDefault();
        public frmGuardarGrupo()
        {
            InitializeComponent();
            txtNombreGrupoGuardar.Text = principal.lblTituloGrupo.Text.ToString();
        }

        private void btnCancelarGuardarGrupo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreGrupoGuardar.Text.ToString();
            List<string> lstFilas = new List<string>();
            string tituloColumnas = "";
            tituloColumnas += principal.lblTituloGrupo.Text.ToString();
            tituloColumnas += "|";
            for (int i = 0; i < 5; i++)
            {
                tituloColumnas += principal.dtgAlumnos.Columns[i].HeaderText.ToString();
                tituloColumnas += "|";
            }
            lstFilas.Add(tituloColumnas.TrimEnd('|'));
            bool comprobar = false;
            int contador = 0;
            foreach (DataGridViewRow row in principal.dtgAlumnos.Rows)
            {
                string strLinea = "";
                if (row.Index == principal.dtgAlumnos.Rows.Count - 1)
                    break;
                comprobar = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {
                        comprobar = true;
                        contador++;
                        strLinea += " ";
                    }
                    else if (cell.Value.ToString() == " ")
                    {
                        comprobar = true;
                        contador++;
                        strLinea += " ";
                    }
                    else
                        strLinea += cell.Value.ToString();
                    strLinea += "|";
                }
                if (comprobar == false)
                {
                    lstFilas.Add(strLinea.TrimEnd('|'));
                }
            }
            if (contador > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Hay filas que no están completas y si guarda se perderán, ¿Está seguro que desea guardar?", "Guardar Grupo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (File.Exists(nombre + ".gru"))
                    {
                        DialogResult dialogResult1 = MessageBox.Show("El nombre del fihero existe, ¿Desea sobreescribirlo?", "Nombre Grupo", MessageBoxButtons.YesNo);
                        if (dialogResult1 == DialogResult.Yes)
                        {
                            File.Delete(nombre + ".gru");
                            File.WriteAllLines(nombre + ".gru", lstFilas);
                            this.Dispose();
                        }
                        else if (dialogResult1 == DialogResult.No)
                        {

                        }
                    }
                    else
                    {
                        File.WriteAllLines(nombre + ".gru", lstFilas);
                        this.Dispose();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
            else
            {
                if (File.Exists(nombre + ".gru"))
                {
                    DialogResult dialogResult1 = MessageBox.Show("El nombre del fihero existe, ¿Desea sobreescribirlo?", "Nombre Grupo", MessageBoxButtons.YesNo);
                    if (dialogResult1 == DialogResult.Yes)
                    {
                        File.Delete(nombre + ".gru");
                        File.WriteAllLines(nombre + ".gru", lstFilas);
                        this.Dispose();
                    }
                    else if (dialogResult1 == DialogResult.No)
                    {

                    }
                }
                else
                {
                    File.WriteAllLines(nombre + ".gru", lstFilas);
                    this.Dispose();
                }
            }
        }

        private void txtNombreGrupoGuardar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
