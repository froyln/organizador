namespace Organizacion_app
{
    partial class Organizador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Organizador));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.direccion_marcador = new System.Windows.Forms.Label();
            this.ejemplo_text = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buscar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MaximumSize = new System.Drawing.Size(225, 400);
            this.label1.MinimumSize = new System.Drawing.Size(225, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 430);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(255, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 94);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.AccessibleName = "fecha_button";
            this.button6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 5;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(360, 128);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(99, 93);
            this.button6.TabIndex = 10;
            this.button6.Text = "Organizar por fecha de modifi...\r\n";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.fecha_button_click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "year_button";
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(465, 128);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(99, 93);
            this.button2.TabIndex = 11;
            this.button2.Text = "Organizar por año de modifi...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.año_button_click);
            // 
            // button3
            // 
            this.button3.AccessibleName = "a-z_button";
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 5;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(570, 128);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(99, 93);
            this.button3.TabIndex = 12;
            this.button3.Text = "Organizar por primera letra (A-Z)";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.letra_button_click);
            // 
            // button4
            // 
            this.button4.AccessibleName = "size_button";
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 5;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(675, 128);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(99, 93);
            this.button4.TabIndex = 13;
            this.button4.Text = "Organizar por tamaño";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.tamaño_button_click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "extension_button";
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(255, 128);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(99, 93);
            this.button1.TabIndex = 14;
            this.button1.Text = "Organizar por extension";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.extension_button_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Inserta la direccion de la carpeta a organizar.";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // direccion_marcador
            // 
            this.direccion_marcador.AutoSize = true;
            this.direccion_marcador.BackColor = System.Drawing.Color.Transparent;
            this.direccion_marcador.ForeColor = System.Drawing.Color.Cornsilk;
            this.direccion_marcador.Location = new System.Drawing.Point(270, 244);
            this.direccion_marcador.MaximumSize = new System.Drawing.Size(150, 0);
            this.direccion_marcador.MinimumSize = new System.Drawing.Size(485, 0);
            this.direccion_marcador.Name = "direccion_marcador";
            this.direccion_marcador.Size = new System.Drawing.Size(485, 13);
            this.direccion_marcador.TabIndex = 16;
            this.direccion_marcador.Text = "Direccion actual:";
            // 
            // ejemplo_text
            // 
            this.ejemplo_text.AutoSize = true;
            this.ejemplo_text.BackColor = System.Drawing.Color.Transparent;
            this.ejemplo_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejemplo_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ejemplo_text.Location = new System.Drawing.Point(248, 283);
            this.ejemplo_text.Name = "ejemplo_text";
            this.ejemplo_text.Size = new System.Drawing.Size(343, 37);
            this.ejemplo_text.TabIndex = 17;
            this.ejemplo_text.Text = "Ejemplo de direccion:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(255, 323);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(383, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "C:\\Users\\froyl\\Desktop\\";
            // 
            // buscar_button
            // 
            this.buscar_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buscar_button.Location = new System.Drawing.Point(690, 257);
            this.buscar_button.Name = "buscar_button";
            this.buscar_button.Size = new System.Drawing.Size(84, 23);
            this.buscar_button.TabIndex = 19;
            this.buscar_button.Text = "Buscar";
            this.buscar_button.UseVisualStyleBackColor = false;
            this.buscar_button.Click += new System.EventHandler(this.buscar_button_Click);
            // 
            // Organizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscar_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ejemplo_text);
            this.Controls.Add(this.direccion_marcador);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Organizador";
            this.Text = "Organizador";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label direccion_marcador;
        private System.Windows.Forms.Label ejemplo_text;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buscar_button;
    }
}

