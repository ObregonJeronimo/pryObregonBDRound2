namespace pryObregonBDRound2
{
    partial class frmRegistroEntrenador
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
            this.btnRegistroDeportistas = new System.Windows.Forms.Button();
            this.txtCodigoEntrenador = new System.Windows.Forms.TextBox();
            this.txtApellidoEntrenador = new System.Windows.Forms.TextBox();
            this.txtDireccionEntrenador = new System.Windows.Forms.TextBox();
            this.txtNombreEntrenador = new System.Windows.Forms.TextBox();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegistroDeportistas
            // 
            this.btnRegistroDeportistas.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroDeportistas.Location = new System.Drawing.Point(102, 191);
            this.btnRegistroDeportistas.Name = "btnRegistroDeportistas";
            this.btnRegistroDeportistas.Size = new System.Drawing.Size(171, 33);
            this.btnRegistroDeportistas.TabIndex = 49;
            this.btnRegistroDeportistas.Text = "Registrar";
            this.btnRegistroDeportistas.UseVisualStyleBackColor = true;
            this.btnRegistroDeportistas.Click += new System.EventHandler(this.btnRegistroDeportistas_Click);
            // 
            // txtCodigoEntrenador
            // 
            this.txtCodigoEntrenador.Location = new System.Drawing.Point(184, 23);
            this.txtCodigoEntrenador.Name = "txtCodigoEntrenador";
            this.txtCodigoEntrenador.Size = new System.Drawing.Size(111, 20);
            this.txtCodigoEntrenador.TabIndex = 48;
            // 
            // txtApellidoEntrenador
            // 
            this.txtApellidoEntrenador.Location = new System.Drawing.Point(184, 74);
            this.txtApellidoEntrenador.Name = "txtApellidoEntrenador";
            this.txtApellidoEntrenador.Size = new System.Drawing.Size(111, 20);
            this.txtApellidoEntrenador.TabIndex = 46;
            // 
            // txtDireccionEntrenador
            // 
            this.txtDireccionEntrenador.Location = new System.Drawing.Point(184, 100);
            this.txtDireccionEntrenador.Name = "txtDireccionEntrenador";
            this.txtDireccionEntrenador.Size = new System.Drawing.Size(111, 20);
            this.txtDireccionEntrenador.TabIndex = 45;
            // 
            // txtNombreEntrenador
            // 
            this.txtNombreEntrenador.Location = new System.Drawing.Point(184, 49);
            this.txtNombreEntrenador.Name = "txtNombreEntrenador";
            this.txtNombreEntrenador.Size = new System.Drawing.Size(111, 20);
            this.txtNombreEntrenador.TabIndex = 44;
            // 
            // lstDeporte
            // 
            this.lstDeporte.FormattingEnabled = true;
            this.lstDeporte.Items.AddRange(new object[] {
            "TENIS",
            "BASQUET",
            "CICLISMO",
            "FUTBOL",
            "VOLEY"});
            this.lstDeporte.Location = new System.Drawing.Point(184, 152);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(111, 21);
            this.lstDeporte.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Deporte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Codigo Entrenador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Provincia";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(184, 126);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(111, 20);
            this.txtProvincia.TabIndex = 51;
            // 
            // frmRegistroEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 253);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegistroDeportistas);
            this.Controls.Add(this.txtCodigoEntrenador);
            this.Controls.Add(this.txtApellidoEntrenador);
            this.Controls.Add(this.txtDireccionEntrenador);
            this.Controls.Add(this.txtNombreEntrenador);
            this.Controls.Add(this.lstDeporte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistroEntrenador";
            this.Text = "frmRegistroEntrenador";
            this.Load += new System.EventHandler(this.frmRegistroEntrenador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroDeportistas;
        private System.Windows.Forms.TextBox txtCodigoEntrenador;
        private System.Windows.Forms.TextBox txtApellidoEntrenador;
        private System.Windows.Forms.TextBox txtDireccionEntrenador;
        private System.Windows.Forms.TextBox txtNombreEntrenador;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProvincia;
    }
}