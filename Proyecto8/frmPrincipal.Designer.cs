namespace Proyecto8
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnCrearGrupo = new System.Windows.Forms.Button();
            this.btnAbrirGrupo = new System.Windows.Forms.Button();
            this.btnGuardarGrupo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtgAlumnos = new System.Windows.Forms.DataGridView();
            this.nombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignatura1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignatura2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignatura3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignatura4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloGrupo = new System.Windows.Forms.Label();
            this.btnFiltrarAprobados = new System.Windows.Forms.Button();
            this.btnTodosAlumnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearGrupo
            // 
            this.btnCrearGrupo.Location = new System.Drawing.Point(47, 37);
            this.btnCrearGrupo.Name = "btnCrearGrupo";
            this.btnCrearGrupo.Size = new System.Drawing.Size(202, 39);
            this.btnCrearGrupo.TabIndex = 0;
            this.btnCrearGrupo.Text = "Crear Grupo";
            this.btnCrearGrupo.UseVisualStyleBackColor = true;
            this.btnCrearGrupo.Click += new System.EventHandler(this.btnCrearGrupo_Click);
            // 
            // btnAbrirGrupo
            // 
            this.btnAbrirGrupo.Location = new System.Drawing.Point(47, 94);
            this.btnAbrirGrupo.Name = "btnAbrirGrupo";
            this.btnAbrirGrupo.Size = new System.Drawing.Size(202, 36);
            this.btnAbrirGrupo.TabIndex = 1;
            this.btnAbrirGrupo.Text = "Abrir Grupo";
            this.btnAbrirGrupo.UseVisualStyleBackColor = true;
            this.btnAbrirGrupo.Click += new System.EventHandler(this.btnAbrirGrupo_Click);
            // 
            // btnGuardarGrupo
            // 
            this.btnGuardarGrupo.Location = new System.Drawing.Point(47, 152);
            this.btnGuardarGrupo.Name = "btnGuardarGrupo";
            this.btnGuardarGrupo.Size = new System.Drawing.Size(202, 35);
            this.btnGuardarGrupo.TabIndex = 2;
            this.btnGuardarGrupo.Text = "Guardar Grupo";
            this.btnGuardarGrupo.UseVisualStyleBackColor = true;
            this.btnGuardarGrupo.Click += new System.EventHandler(this.btnGuardarGrupo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(47, 208);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(202, 35);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgAlumnos
            // 
            this.dtgAlumnos.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreAlumno,
            this.asignatura1,
            this.asignatura2,
            this.asignatura3,
            this.asignatura4});
            this.dtgAlumnos.Location = new System.Drawing.Point(282, 75);
            this.dtgAlumnos.Name = "dtgAlumnos";
            this.dtgAlumnos.RowTemplate.Height = 24;
            this.dtgAlumnos.Size = new System.Drawing.Size(545, 168);
            this.dtgAlumnos.TabIndex = 4;
            this.dtgAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlumnos_CellContentClick);
            this.dtgAlumnos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgAlumnos_EditingControlShowing);
            // 
            // nombreAlumno
            // 
            this.nombreAlumno.HeaderText = "Nombre Alumno";
            this.nombreAlumno.Name = "nombreAlumno";
            // 
            // asignatura1
            // 
            this.asignatura1.HeaderText = "";
            this.asignatura1.Name = "asignatura1";
            this.asignatura1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // asignatura2
            // 
            this.asignatura2.HeaderText = "";
            this.asignatura2.Name = "asignatura2";
            this.asignatura2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // asignatura3
            // 
            this.asignatura3.HeaderText = "";
            this.asignatura3.Name = "asignatura3";
            this.asignatura3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // asignatura4
            // 
            this.asignatura4.HeaderText = "";
            this.asignatura4.Name = "asignatura4";
            this.asignatura4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lblTituloGrupo
            // 
            this.lblTituloGrupo.AutoSize = true;
            this.lblTituloGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGrupo.Location = new System.Drawing.Point(532, 37);
            this.lblTituloGrupo.Name = "lblTituloGrupo";
            this.lblTituloGrupo.Size = new System.Drawing.Size(0, 29);
            this.lblTituloGrupo.TabIndex = 5;
            this.lblTituloGrupo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFiltrarAprobados
            // 
            this.btnFiltrarAprobados.Location = new System.Drawing.Point(739, 12);
            this.btnFiltrarAprobados.Name = "btnFiltrarAprobados";
            this.btnFiltrarAprobados.Size = new System.Drawing.Size(88, 23);
            this.btnFiltrarAprobados.TabIndex = 6;
            this.btnFiltrarAprobados.Text = "Aprobados";
            this.btnFiltrarAprobados.UseVisualStyleBackColor = true;
            this.btnFiltrarAprobados.Click += new System.EventHandler(this.btnFiltrarAprobados_Click);
            // 
            // btnTodosAlumnos
            // 
            this.btnTodosAlumnos.Location = new System.Drawing.Point(739, 43);
            this.btnTodosAlumnos.Name = "btnTodosAlumnos";
            this.btnTodosAlumnos.Size = new System.Drawing.Size(88, 23);
            this.btnTodosAlumnos.TabIndex = 7;
            this.btnTodosAlumnos.Text = "Todos";
            this.btnTodosAlumnos.UseVisualStyleBackColor = true;
            this.btnTodosAlumnos.Click += new System.EventHandler(this.btnTodosAlumnos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 267);
            this.Controls.Add(this.btnTodosAlumnos);
            this.Controls.Add(this.btnFiltrarAprobados);
            this.Controls.Add(this.lblTituloGrupo);
            this.Controls.Add(this.dtgAlumnos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarGrupo);
            this.Controls.Add(this.btnAbrirGrupo);
            this.Controls.Add(this.btnCrearGrupo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Manejo Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearGrupo;
        private System.Windows.Forms.Button btnAbrirGrupo;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Label lblTituloGrupo;
        public System.Windows.Forms.DataGridView dtgAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignatura1;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignatura2;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignatura3;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignatura4;
        private System.Windows.Forms.Button btnFiltrarAprobados;
        private System.Windows.Forms.Button btnTodosAlumnos;
        public System.Windows.Forms.Button btnGuardarGrupo;
    }
}