namespace Proyecto8
{
    partial class frmCrearGrupo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearGrupo));
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.lblAsignaturas = new System.Windows.Forms.Label();
            this.cboAsignaturas = new System.Windows.Forms.ComboBox();
            this.btnAceptarNuevoGrupo = new System.Windows.Forms.Button();
            this.btnCancelarNuevoGrupo = new System.Windows.Forms.Button();
            this.lblAsignatura1 = new System.Windows.Forms.Label();
            this.lblAsignatura2 = new System.Windows.Forms.Label();
            this.lblAsignatura3 = new System.Windows.Forms.Label();
            this.lblAsignatura4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(154, 42);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(123, 22);
            this.txtNombreGrupo.TabIndex = 0;
            this.txtNombreGrupo.TextChanged += new System.EventHandler(this.txtNombreGrupo_TextChanged);
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Location = new System.Drawing.Point(37, 42);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(62, 17);
            this.lblNombreGrupo.TabIndex = 1;
            this.lblNombreGrupo.Text = "Nombre:";
            // 
            // lblAsignaturas
            // 
            this.lblAsignaturas.AutoSize = true;
            this.lblAsignaturas.Location = new System.Drawing.Point(37, 89);
            this.lblAsignaturas.Name = "lblAsignaturas";
            this.lblAsignaturas.Size = new System.Drawing.Size(87, 17);
            this.lblAsignaturas.TabIndex = 2;
            this.lblAsignaturas.Text = "Asignaturas:";
            // 
            // cboAsignaturas
            // 
            this.cboAsignaturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsignaturas.FormattingEnabled = true;
            this.cboAsignaturas.Items.AddRange(new object[] {
            "ACDA",
            "DEIN",
            "SIGE",
            "ANDROID",
            "PSP",
            "EIE"});
            this.cboAsignaturas.Location = new System.Drawing.Point(154, 89);
            this.cboAsignaturas.Name = "cboAsignaturas";
            this.cboAsignaturas.Size = new System.Drawing.Size(121, 24);
            this.cboAsignaturas.TabIndex = 3;
            this.cboAsignaturas.SelectedIndexChanged += new System.EventHandler(this.cboAsignaturas_SelectedIndexChanged);
            // 
            // btnAceptarNuevoGrupo
            // 
            this.btnAceptarNuevoGrupo.Location = new System.Drawing.Point(30, 206);
            this.btnAceptarNuevoGrupo.Name = "btnAceptarNuevoGrupo";
            this.btnAceptarNuevoGrupo.Size = new System.Drawing.Size(94, 30);
            this.btnAceptarNuevoGrupo.TabIndex = 4;
            this.btnAceptarNuevoGrupo.Text = "Aceptar";
            this.btnAceptarNuevoGrupo.UseVisualStyleBackColor = true;
            this.btnAceptarNuevoGrupo.Click += new System.EventHandler(this.btnAceptarNuevoGrupo_Click);
            // 
            // btnCancelarNuevoGrupo
            // 
            this.btnCancelarNuevoGrupo.Location = new System.Drawing.Point(173, 206);
            this.btnCancelarNuevoGrupo.Name = "btnCancelarNuevoGrupo";
            this.btnCancelarNuevoGrupo.Size = new System.Drawing.Size(102, 30);
            this.btnCancelarNuevoGrupo.TabIndex = 5;
            this.btnCancelarNuevoGrupo.Text = "Cancelar";
            this.btnCancelarNuevoGrupo.UseVisualStyleBackColor = true;
            this.btnCancelarNuevoGrupo.Click += new System.EventHandler(this.btnCancelarNuevoGrupo_Click);
            // 
            // lblAsignatura1
            // 
            this.lblAsignatura1.AutoSize = true;
            this.lblAsignatura1.Location = new System.Drawing.Point(67, 140);
            this.lblAsignatura1.Name = "lblAsignatura1";
            this.lblAsignatura1.Size = new System.Drawing.Size(0, 17);
            this.lblAsignatura1.TabIndex = 6;
            // 
            // lblAsignatura2
            // 
            this.lblAsignatura2.AutoSize = true;
            this.lblAsignatura2.Location = new System.Drawing.Point(67, 172);
            this.lblAsignatura2.Name = "lblAsignatura2";
            this.lblAsignatura2.Size = new System.Drawing.Size(0, 17);
            this.lblAsignatura2.TabIndex = 7;
            // 
            // lblAsignatura3
            // 
            this.lblAsignatura3.AutoSize = true;
            this.lblAsignatura3.Location = new System.Drawing.Point(202, 140);
            this.lblAsignatura3.Name = "lblAsignatura3";
            this.lblAsignatura3.Size = new System.Drawing.Size(0, 17);
            this.lblAsignatura3.TabIndex = 8;
            // 
            // lblAsignatura4
            // 
            this.lblAsignatura4.AutoSize = true;
            this.lblAsignatura4.Location = new System.Drawing.Point(202, 172);
            this.lblAsignatura4.Name = "lblAsignatura4";
            this.lblAsignatura4.Size = new System.Drawing.Size(0, 17);
            this.lblAsignatura4.TabIndex = 9;
            // 
            // frmCrearGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 260);
            this.Controls.Add(this.lblAsignatura4);
            this.Controls.Add(this.lblAsignatura3);
            this.Controls.Add(this.lblAsignatura2);
            this.Controls.Add(this.lblAsignatura1);
            this.Controls.Add(this.btnCancelarNuevoGrupo);
            this.Controls.Add(this.btnAceptarNuevoGrupo);
            this.Controls.Add(this.cboAsignaturas);
            this.Controls.Add(this.lblAsignaturas);
            this.Controls.Add(this.lblNombreGrupo);
            this.Controls.Add(this.txtNombreGrupo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCrearGrupo";
            this.Text = "CrearGrupo";
            this.Load += new System.EventHandler(this.frmCrearGrupo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.Label lblAsignaturas;
        private System.Windows.Forms.ComboBox cboAsignaturas;
        private System.Windows.Forms.Button btnAceptarNuevoGrupo;
        private System.Windows.Forms.Button btnCancelarNuevoGrupo;
        private System.Windows.Forms.Label lblAsignatura1;
        private System.Windows.Forms.Label lblAsignatura2;
        private System.Windows.Forms.Label lblAsignatura3;
        private System.Windows.Forms.Label lblAsignatura4;
    }
}