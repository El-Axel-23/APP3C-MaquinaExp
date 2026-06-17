namespace APP3C.MaquinaExp
{
    partial class frmMaquina
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
            this.lstVitrina = new System.Windows.Forms.ListBox();
            this.txtSeleccion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnAbastecer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstVitrina
            // 
            this.lstVitrina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVitrina.FormattingEnabled = true;
            this.lstVitrina.Location = new System.Drawing.Point(64, 79);
            this.lstVitrina.Name = "lstVitrina";
            this.lstVitrina.Size = new System.Drawing.Size(262, 82);
            this.lstVitrina.TabIndex = 0;
            // 
            // txtSeleccion
            // 
            this.txtSeleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeleccion.Location = new System.Drawing.Point(64, 227);
            this.txtSeleccion.Name = "txtSeleccion";
            this.txtSeleccion.Size = new System.Drawing.Size(109, 20);
            this.txtSeleccion.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.Location = new System.Drawing.Point(64, 295);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(109, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // btnComprar
            // 
            this.btnComprar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComprar.BackColor = System.Drawing.Color.Maroon;
            this.btnComprar.Location = new System.Drawing.Point(64, 370);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(98, 44);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnAbastecer
            // 
            this.btnAbastecer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbastecer.BackColor = System.Drawing.Color.Green;
            this.btnAbastecer.Location = new System.Drawing.Point(227, 370);
            this.btnAbastecer.Name = "btnAbastecer";
            this.btnAbastecer.Size = new System.Drawing.Size(99, 44);
            this.btnAbastecer.TabIndex = 4;
            this.btnAbastecer.Text = "Abastecer";
            this.btnAbastecer.UseVisualStyleBackColor = false;
            this.btnAbastecer.Click += new System.EventHandler(this.btnAbastecer_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Maquina Expendedora";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione un producto de 1 a 4";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingrese la cantidad a comprar/abastecer";
            // 
            // frmMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(410, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbastecer);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtSeleccion);
            this.Controls.Add(this.lstVitrina);
            this.Name = "frmMaquina";
            this.Text = "Maquina Expendedora";
            this.Load += new System.EventHandler(this.frmMaquina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVitrina;
        private System.Windows.Forms.TextBox txtSeleccion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnAbastecer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}