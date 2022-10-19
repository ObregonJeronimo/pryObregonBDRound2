namespace pryObregonBDRound2
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ssp = new System.Windows.Forms.StatusStrip();
            this.toolColorRojo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.toolRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDeportista = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.toolConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDeportista1 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEntrenador1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFechaActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssp.SuspendLayout();
            this.ms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssp
            // 
            this.ssp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado,
            this.toolColorRojo,
            this.lblFechaActual});
            this.ssp.Location = new System.Drawing.Point(0, 272);
            this.ssp.Name = "ssp";
            this.ssp.Size = new System.Drawing.Size(454, 22);
            this.ssp.TabIndex = 0;
            this.ssp.Text = "statusStrip1";
            // 
            // toolColorRojo
            // 
            this.toolColorRojo.Name = "toolColorRojo";
            this.toolColorRojo.Size = new System.Drawing.Size(12, 17);
            this.toolColorRojo.Text = "-";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // ms1
            // 
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRegistro,
            this.toolConsulta});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(454, 24);
            this.ms1.TabIndex = 5;
            this.ms1.Text = "menuStrip1";
            // 
            // toolRegistro
            // 
            this.toolRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDeportista,
            this.itemEntrenador});
            this.toolRegistro.Name = "toolRegistro";
            this.toolRegistro.Size = new System.Drawing.Size(62, 20);
            this.toolRegistro.Text = "Registro";
            // 
            // itemDeportista
            // 
            this.itemDeportista.Name = "itemDeportista";
            this.itemDeportista.Size = new System.Drawing.Size(180, 22);
            this.itemDeportista.Text = "Deportista";
            // 
            // itemEntrenador
            // 
            this.itemEntrenador.Name = "itemEntrenador";
            this.itemEntrenador.Size = new System.Drawing.Size(180, 22);
            this.itemEntrenador.Text = "Entrenador";
            // 
            // toolConsulta
            // 
            this.toolConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDeportista1,
            this.itemEntrenador1});
            this.toolConsulta.Name = "toolConsulta";
            this.toolConsulta.Size = new System.Drawing.Size(66, 20);
            this.toolConsulta.Text = "Consulta";
            // 
            // itemDeportista1
            // 
            this.itemDeportista1.Name = "itemDeportista1";
            this.itemDeportista1.Size = new System.Drawing.Size(180, 22);
            this.itemDeportista1.Text = "Deportista";
            // 
            // itemEntrenador1
            // 
            this.itemEntrenador1.Name = "itemEntrenador1";
            this.itemEntrenador1.Size = new System.Drawing.Size(180, 22);
            this.itemEntrenador1.Text = "Entrenador";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 294);
            this.Controls.Add(this.ssp);
            this.Controls.Add(this.ms1);
            this.MainMenuStrip = this.ms1;
            this.Name = "frmMain";
            this.Text = "Network Access";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ssp.ResumeLayout(false);
            this.ssp.PerformLayout();
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssp;
        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem toolRegistro;
        private System.Windows.Forms.ToolStripStatusLabel toolColorRojo;
        private System.Windows.Forms.ToolStripMenuItem itemDeportista;
        private System.Windows.Forms.ToolStripMenuItem itemEntrenador;
        private System.Windows.Forms.ToolStripMenuItem toolConsulta;
        private System.Windows.Forms.ToolStripMenuItem itemDeportista1;
        private System.Windows.Forms.ToolStripMenuItem itemEntrenador1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaActual;
    }
}

