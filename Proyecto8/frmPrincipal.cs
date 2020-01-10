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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8
{
    public partial class frmPrincipal : Form
    {
        private bool controlar = false;
        private bool cambio = false;
        private static List<string> lstFilas = new List<string>();
        public frmPrincipal()
        {
            InitializeComponent();
            dtgAlumnos.Enabled = false;
            btnGuardarGrupo.Enabled = false;
        }

        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            frmCrearGrupo crearGrupo = new frmCrearGrupo();
            crearGrupo.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dtgAlumnos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dtgAlumnos.CurrentCell.ColumnIndex == 1 || dtgAlumnos.CurrentCell.ColumnIndex == 2 || dtgAlumnos.CurrentCell.ColumnIndex == 3
                || dtgAlumnos.CurrentCell.ColumnIndex == 4)
            {
                cambio = false;
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                    tb.KeyUp += new KeyEventHandler(dtgAlumnos_KeyUp);
                }
            }
            else
            {
                cambio = true;
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cambio == false)
            {
                if (controlar == false)
                {
                    CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != cc.NumberFormat.NumberDecimalSeparator)
                    {
                        e.Handled = true;
                    }
                }
                else if (controlar == true)
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            }
            else if (cambio == true)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        private void btnGuardarGrupo_Click(object sender, EventArgs e)
        {
            frmGuardarGrupo guardarGrupo = new frmGuardarGrupo();
            guardarGrupo.Show();
        }

        private void btnAbrirGrupo_Click(object sender, EventArgs e)
        {
            frmAbrirGrupo abrirGrupo = new frmAbrirGrupo();
            abrirGrupo.Show();
        }

        private void dtgAlumnos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgAlumnos_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = 1; i < 5; i++)
            {
                if (dtgAlumnos.CurrentCell.ColumnIndex == i)
                {
                    controlar = false;
                    TextBox caja = (TextBox)sender;
                    if (caja.Text == "")
                    {
                        caja.Text = "";
                    }
                    else if (caja.Text.StartsWith(","))
                    {
                        caja.Text = "";
                    }
                    else if (caja.Text.Equals("10,"))
                    {
                        caja.Text = caja.Text.Substring(0, caja.Text.Count() - 1);
                    }
                    else if (caja.Text.Contains(","))
                    {
                        if (caja.Text.Length > 4)
                        {
                            caja.Text = caja.Text.Substring(0, caja.Text.Count() - 1);
                        }
                        else if (float.Parse(caja.Text) > 10)
                        {
                            caja.Text = "10";
                        }
                        controlar = true;
                    }
                    else if (float.Parse(caja.Text) > 10)
                    {
                        caja.Text = "10";
                    }
                    else if (float.Parse(caja.Text) < 0)
                    {
                        caja.Text = "0";
                    }
                    else if (caja.Text.Equals("00"))
                    {
                        caja.Text = caja.Text.Substring(0, caja.Text.Count() - 1);
                    }
                }
            }
        }

        private void btnFiltrarAprobados_Click(object sender, EventArgs e)
        {
            lstFilas.Clear();
            foreach (DataGridViewRow rows in dtgAlumnos.Rows)
            {
                string strLinea = "";
                if (rows.Index == dtgAlumnos.Rows.Count - 1)
                    break;
                foreach (DataGridViewCell cell in rows.Cells)
                {
                    if (cell.Value == null)
                        strLinea += " ";
                    else
                        strLinea += cell.Value.ToString();
                    strLinea += "|";
                }
                lstFilas.Add(strLinea.TrimEnd('|'));
            }
            dtgAlumnos.Rows.Clear();
            for (int i = 0; i < lstFilas.Count; i++)
            {
                string[] items = lstFilas[i].Split('|');
                for (int j = 1; j < items.Length; j++)
                {
                    if (items[j].Equals(" "))
                    {
                        items[j] = "0";
                    }
                }
                if (float.Parse(items[1]) >= 5 && float.Parse(items[2]) >= 5 && float.Parse(items[3]) >= 5 && float.Parse(items[4]) >= 5)
                {
                    dtgAlumnos.Rows.Add(items);
                }
            }
        }

        private void btnTodosAlumnos_Click(object sender, EventArgs e)
        {
            dtgAlumnos.Rows.Clear();
            for (int i = 0; i < lstFilas.Count; i++)
            {
                string[] items = lstFilas[i].Split('|');
                dtgAlumnos.Rows.Add(items);
            }
        }
    }
}
