namespace pryObregonBDRound2
{
    partial class frmRegistroDeportista
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
            this.StatusBDdeportista = new System.Windows.Forms.StatusStrip();
            this.lblFechaActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRegistroDeportistas = new System.Windows.Forms.Button();
            this.txtCodigoDeportista = new System.Windows.Forms.TextBox();
            this.mskEdadDeportista = new System.Windows.Forms.MaskedTextBox();
            this.txtApellidoDeportista = new System.Windows.Forms.TextBox();
            this.txtDireccionDeportista = new System.Windows.Forms.TextBox();
            this.txtNombreDeportista = new System.Windows.Forms.TextBox();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.mskTelfonoDeportista = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusBDdeportista.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBDdeportista
            // 
            this.StatusBDdeportista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFechaActual,
            this.lblEstado});
            this.StatusBDdeportista.Location = new System.Drawing.Point(0, 259);
            this.StatusBDdeportista.Name = "StatusBDdeportista";
            this.StatusBDdeportista.Size = new System.Drawing.Size(379, 22);
            this.StatusBDdeportista.TabIndex = 35;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(0, 17);
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // btnRegistroDeportistas
            // 
            this.btnRegistroDeportistas.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroDeportistas.Location = new System.Drawing.Point(101, 214);
            this.btnRegistroDeportistas.Name = "btnRegistroDeportistas";
            this.btnRegistroDeportistas.Size = new System.Drawing.Size(171, 33);
            this.btnRegistroDeportistas.TabIndex = 34;
            this.btnRegistroDeportistas.Text = "Registrar";
            this.btnRegistroDeportistas.UseVisualStyleBackColor = true;
            this.btnRegistroDeportistas.Click += new System.EventHandler(this.btnRegistroDeportistas_Click);
            // 
            // txtCodigoDeportista
            // 
            this.txtCodigoDeportista.Location = new System.Drawing.Point(183, 23);
            this.txtCodigoDeportista.Name = "txtCodigoDeportista";
            this.txtCodigoDeportista.Size = new System.Drawing.Size(111, 20);
            this.txtCodigoDeportista.TabIndex = 32;
            // 
            // mskEdadDeportista
            // 
            this.mskEdadDeportista.Location = new System.Drawing.Point(183, 152);
            this.mskEdadDeportista.Mask = "999";
            this.mskEdadDeportista.Name = "mskEdadDeportista";
            this.mskEdadDeportista.Size = new System.Drawing.Size(31, 20);
            this.mskEdadDeportista.TabIndex = 31;
            this.mskEdadDeportista.ValidatingType = typeof(int);
            // 
            // txtApellidoDeportista
            // 
            this.txtApellidoDeportista.Location = new System.Drawing.Point(183, 74);
            this.txtApellidoDeportista.Name = "txtApellidoDeportista";
            this.txtApellidoDeportista.Size = new System.Drawing.Size(111, 20);
            this.txtApellidoDeportista.TabIndex = 30;
            // 
            // txtDireccionDeportista
            // 
            this.txtDireccionDeportista.Location = new System.Drawing.Point(183, 100);
            this.txtDireccionDeportista.Name = "txtDireccionDeportista";
            this.txtDireccionDeportista.Size = new System.Drawing.Size(111, 20);
            this.txtDireccionDeportista.TabIndex = 29;
            // 
            // txtNombreDeportista
            // 
            this.txtNombreDeportista.Location = new System.Drawing.Point(183, 49);
            this.txtNombreDeportista.Name = "txtNombreDeportista";
            this.txtNombreDeportista.Size = new System.Drawing.Size(111, 20);
            this.txtNombreDeportista.TabIndex = 28;
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
            this.lstDeporte.Location = new System.Drawing.Point(183, 178);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(111, 21);
            this.lstDeporte.TabIndex = 27;
            // 
            // mskTelfonoDeportista
            // 
            this.mskTelfonoDeportista.Location = new System.Drawing.Point(183, 126);
            this.mskTelfonoDeportista.Name = "mskTelfonoDeportista";
            this.mskTelfonoDeportista.Size = new System.Drawing.Size(111, 20);
            this.mskTelfonoDeportista.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Deporte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codigo deportista";
            // 
            // frmRegistroDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 281);
            this.Controls.Add(this.StatusBDdeportista);
            this.Controls.Add(this.btnRegistroDeportistas);
            this.Controls.Add(this.txtCodigoDeportista);
            this.Controls.Add(this.mskEdadDeportista);
            this.Controls.Add(this.txtApellidoDeportista);
            this.Controls.Add(this.txtDireccionDeportista);
            this.Controls.Add(this.txtNombreDeportista);
            this.Controls.Add(this.lstDeporte);
            this.Controls.Add(this.mskTelfonoDeportista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistroDeportista";
            this.Text = "Registro Deportista";
            this.Load += new System.EventHandler(this.frmRegistroDeportista_Load);
            this.StatusBDdeportista.ResumeLayout(false);
            this.StatusBDdeportista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBDdeportista;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaActual;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.Button btnRegistroDeportistas;
        private System.Windows.Forms.TextBox txtCodigoDeportista;
        private System.Windows.Forms.MaskedTextBox mskEdadDeportista;
        private System.Windows.Forms.TextBox txtApellidoDeportista;
        private System.Windows.Forms.TextBox txtDireccionDeportista;
        private System.Windows.Forms.TextBox txtNombreDeportista;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.MaskedTextBox mskTelfonoDeportista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}