namespace Proyecto8
{
    partial class frmGuardarGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuardarGrupo));
            this.txtNombreGrupoGuardar = new System.Windows.Forms.TextBox();
            this.lblNombreGuardarGrupo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelarGuardarGrupo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreGrupoGuardar
            // 
            this.txtNombreGrupoGuardar.Location = new System.Drawing.Point(138, 46);
            this.txtNombreGrupoGuardar.Name = "txtNombreGrupoGuardar";
            this.txtNombreGrupoGuardar.Size = new System.Drawing.Size(100, 22);
            this.txtNombreGrupoGuardar.TabIndex = 0;
            this.txtNombreGrupoGuardar.TextChanged += new System.EventHandler(this.txtNombreGrupoGuardar_TextChanged);
            // 
            // lblNombreGuardarGrupo
            // 
            this.lblNombreGuardarGrupo.AutoSize = true;
            this.lblNombreGuardarGrupo.Location = new System.Drawing.Point(26, 49);
            this.lblNombreGuardarGrupo.Name = "lblNombreGuardarGrupo";
            this.lblNombreGuardarGrupo.Size = new System.Drawing.Size(106, 17);
            this.lblNombreGuardarGrupo.TabIndex = 1;
            this.lblNombreGuardarGrupo.Text = "Nombre Grupo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(29, 110);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelarGuardarGrupo
            // 
            this.btnCancelarGuardarGrupo.Location = new System.Drawing.Point(163, 110);
            this.btnCancelarGuardarGrupo.Name = "btnCancelarGuardarGrupo";
            this.btnCancelarGuardarGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarGuardarGrupo.TabIndex = 3;
            this.btnCancelarGuardarGrupo.Text = "Cancelar";
            this.btnCancelarGuardarGrupo.UseVisualStyleBackColor = true;
            this.btnCancelarGuardarGrupo.Click += new System.EventHandler(this.btnCancelarGuardarGrupo_Click);
            // 
            // frmGuardarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(271, 173);
            this.Controls.Add(this.btnCancelarGuardarGrupo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNombreGuardarGrupo);
            this.Controls.Add(this.txtNombreGrupoGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGuardarGrupo";
            this.Text = "Guardar Grupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreGrupoGuardar;
        private System.Windows.Forms.Label lblNombreGuardarGrupo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelarGuardarGrupo;
    }
}