namespace Organizador_rework
{
    partial class frmOrganizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrganizador));
            this.btnOrganizar = new System.Windows.Forms.Button();
            this.cboOrganizacion = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtOrganizacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrganizar
            // 
            this.btnOrganizar.Location = new System.Drawing.Point(146, 152);
            this.btnOrganizar.Name = "btnOrganizar";
            this.btnOrganizar.Size = new System.Drawing.Size(75, 23);
            this.btnOrganizar.TabIndex = 0;
            this.btnOrganizar.Text = "Organizar";
            this.btnOrganizar.UseVisualStyleBackColor = true;
            this.btnOrganizar.Click += new System.EventHandler(this.btnOrganizar_Click);
            // 
            // cboOrganizacion
            // 
            this.cboOrganizacion.FormattingEnabled = true;
            this.cboOrganizacion.Items.AddRange(new object[] {
            "Organizar por extension",
            "Organizar por fecha",
            "Organizar por año",
            "Organizar por letra",
            "Organizar por tamaño"});
            this.cboOrganizacion.Location = new System.Drawing.Point(15, 36);
            this.cboOrganizacion.Name = "cboOrganizacion";
            this.cboOrganizacion.Size = new System.Drawing.Size(206, 21);
            this.cboOrganizacion.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txtOrganizacion
            // 
            this.txtOrganizacion.AutoSize = true;
            this.txtOrganizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtOrganizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizacion.ForeColor = System.Drawing.Color.Transparent;
            this.txtOrganizacion.Location = new System.Drawing.Point(11, 13);
            this.txtOrganizacion.Name = "txtOrganizacion";
            this.txtOrganizacion.Size = new System.Drawing.Size(159, 20);
            this.txtOrganizacion.TabIndex = 3;
            this.txtOrganizacion.Text = "Tipo de organizacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Carpeta:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(163, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(58, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmOrganizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(243, 196);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrganizacion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboOrganizacion);
            this.Controls.Add(this.btnOrganizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrganizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrganizar;
        private System.Windows.Forms.ComboBox cboOrganizacion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtOrganizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
    }
}

