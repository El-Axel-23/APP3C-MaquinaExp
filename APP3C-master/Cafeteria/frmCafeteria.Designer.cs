namespace APP3C.Cafeteria
{
    partial class frmCafeteria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkGluten = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbAlcoholica = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.cmbTamano = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbCaliente = new System.Windows.Forms.RadioButton();
            this.rdbFria = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGluten = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lsbLista = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.chkGluten);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rdbAlcoholica);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.txtExtra);
            this.groupBox1.Controls.Add(this.lblExtra);
            this.groupBox1.Controls.Add(this.cmbTamano);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbCaliente);
            this.groupBox1.Controls.Add(this.rdbFria);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(284, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // chkGluten
            // 
            this.chkGluten.FormattingEnabled = true;
            this.chkGluten.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.chkGluten.Location = new System.Drawing.Point(10, 390);
            this.chkGluten.Margin = new System.Windows.Forms.Padding(2);
            this.chkGluten.Name = "chkGluten";
            this.chkGluten.Size = new System.Drawing.Size(222, 30);
            this.chkGluten.TabIndex = 13;
            this.chkGluten.SelectedIndexChanged += new System.EventHandler(this.chkGluten_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contiene gluten";
            // 
            // rdbAlcoholica
            // 
            this.rdbAlcoholica.AutoSize = true;
            this.rdbAlcoholica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlcoholica.Location = new System.Drawing.Point(151, 45);
            this.rdbAlcoholica.Margin = new System.Windows.Forms.Padding(2);
            this.rdbAlcoholica.Name = "rdbAlcoholica";
            this.rdbAlcoholica.Size = new System.Drawing.Size(100, 21);
            this.rdbAlcoholica.TabIndex = 11;
            this.rdbAlcoholica.TabStop = true;
            this.rdbAlcoholica.Text = "Alcoholica";
            this.rdbAlcoholica.UseVisualStyleBackColor = true;
            this.rdbAlcoholica.CheckedChanged += new System.EventHandler(this.rbtAlcoholica_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(10, 427);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(223, 50);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Agregar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(8, 323);
            this.txtExtra.Margin = new System.Windows.Forms.Padding(2);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(224, 28);
            this.txtExtra.TabIndex = 9;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(4, 298);
            this.lblExtra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(177, 24);
            this.lblExtra.TabIndex = 8;
            this.lblExtra.Text = "Cantidad de Hielo";
            this.lblExtra.Click += new System.EventHandler(this.lblExtra_Click);
            // 
            // cmbTamano
            // 
            this.cmbTamano.FormattingEnabled = true;
            this.cmbTamano.Items.AddRange(new object[] {
            "Chico",
            "Mediano",
            "Grande"});
            this.cmbTamano.Location = new System.Drawing.Point(10, 255);
            this.cmbTamano.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTamano.Name = "cmbTamano";
            this.cmbTamano.Size = new System.Drawing.Size(222, 30);
            this.cmbTamano.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tamaño";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(8, 185);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(224, 28);
            this.txtPrecio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(8, 120);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(224, 28);
            this.txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la bebida";
            // 
            // rdbCaliente
            // 
            this.rdbCaliente.AutoSize = true;
            this.rdbCaliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCaliente.Location = new System.Drawing.Point(62, 45);
            this.rdbCaliente.Margin = new System.Windows.Forms.Padding(2);
            this.rdbCaliente.Name = "rdbCaliente";
            this.rdbCaliente.Size = new System.Drawing.Size(85, 21);
            this.rdbCaliente.TabIndex = 1;
            this.rdbCaliente.TabStop = true;
            this.rdbCaliente.Text = "Caliente";
            this.rdbCaliente.UseVisualStyleBackColor = true;
            this.rdbCaliente.CheckedChanged += new System.EventHandler(this.rdbCaliente_CheckedChanged);
            // 
            // rdbFria
            // 
            this.rdbFria.AutoSize = true;
            this.rdbFria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFria.Location = new System.Drawing.Point(4, 45);
            this.rdbFria.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFria.Name = "rdbFria";
            this.rdbFria.Size = new System.Drawing.Size(54, 21);
            this.rdbFria.TabIndex = 0;
            this.rdbFria.TabStop = true;
            this.rdbFria.Text = "Fria";
            this.rdbFria.UseVisualStyleBackColor = true;
            this.rdbFria.CheckedChanged += new System.EventHandler(this.rdbFria_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.OldLace;
            this.groupBox2.Controls.Add(this.txtGluten);
            this.groupBox2.Controls.Add(this.lblCantidad);
            this.groupBox2.Controls.Add(this.lblDescripcion);
            this.groupBox2.Controls.Add(this.lsbLista);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(304, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 479);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bebidas agregadas";
            // 
            // txtGluten
            // 
            this.txtGluten.AutoSize = true;
            this.txtGluten.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGluten.Location = new System.Drawing.Point(21, 418);
            this.txtGluten.Name = "txtGluten";
            this.txtGluten.Size = new System.Drawing.Size(16, 24);
            this.txtGluten.TabIndex = 3;
            this.txtGluten.Text = ".";
            this.txtGluten.Click += new System.EventHandler(this.txtPorcentajeAlcohol_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(21, 452);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(16, 24);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = ".";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 383);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(16, 24);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = ".";
            // 
            // lsbLista
            // 
            this.lsbLista.FormattingEnabled = true;
            this.lsbLista.ItemHeight = 22;
            this.lsbLista.Location = new System.Drawing.Point(16, 34);
            this.lsbLista.Name = "lsbLista";
            this.lsbLista.Size = new System.Drawing.Size(733, 334);
            this.lsbLista.TabIndex = 0;
            this.lsbLista.SelectedIndexChanged += new System.EventHandler(this.lsbLista_SelectedIndexChanged);
            // 
            // frmCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1071, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCafeteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCafeteria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbCaliente;
        private System.Windows.Forms.RadioButton rdbFria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTamano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ListBox lsbLista;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.RadioButton rdbAlcoholica;
        private System.Windows.Forms.Label txtGluten;
        private System.Windows.Forms.ComboBox chkGluten;
        private System.Windows.Forms.Label label4;
    }
}