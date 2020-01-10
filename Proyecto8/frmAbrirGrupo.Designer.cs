namespace Proyecto8
{
    partial class frmAbrirGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbrirGrupo));
            this.btnAbrirGrupo = new System.Windows.Forms.Button();
            this.btnCancelarAbrirGrupo = new System.Windows.Forms.Button();
            this.cboListaArchivos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAbrirGrupo
            // 
            this.btnAbrirGrupo.Location = new System.Drawing.Point(64, 133);
            this.btnAbrirGrupo.Name = "btnAbrirGrupo";
            this.btnAbrirGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirGrupo.TabIndex = 0;
            this.btnAbrirGrupo.Text = "Abrir";
            this.btnAbrirGrupo.UseVisualStyleBackColor = true;
            this.btnAbrirGrupo.Click += new System.EventHandler(this.btnAbrirGrupo_Click);
            // 
            // btnCancelarAbrirGrupo
            // 
            this.btnCancelarAbrirGrupo.Location = new System.Drawing.Point(219, 133);
            this.btnCancelarAbrirGrupo.Name = "btnCancelarAbrirGrupo";
            this.btnCancelarAbrirGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAbrirGrupo.TabIndex = 1;
            this.btnCancelarAbrirGrupo.Text = "Cancelar";
            this.btnCancelarAbrirGrupo.UseVisualStyleBackColor = true;
            this.btnCancelarAbrirGrupo.Click += new System.EventHandler(this.btnCancelarAbrirGrupo_Click);
            // 
            // cboListaArchivos
            // 
            this.cboListaArchivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListaArchivos.FormattingEnabled = true;
            this.cboListaArchivos.Location = new System.Drawing.Point(113, 51);
            this.cboListaArchivos.Name = "cboListaArchivos";
            this.cboListaArchivos.Size = new System.Drawing.Size(121, 24);
            this.cboListaArchivos.TabIndex = 2;
            // 
            // frmAbrirGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 218);
            this.Controls.Add(this.cboListaArchivos);
            this.Controls.Add(this.btnCancelarAbrirGrupo);
            this.Controls.Add(this.btnAbrirGrupo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAbrirGrupo";
            this.Text = "frmAbrirGrupo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirGrupo;
        private System.Windows.Forms.Button btnCancelarAbrirGrupo;
        private System.Windows.Forms.ComboBox cboListaArchivos;
    }
}