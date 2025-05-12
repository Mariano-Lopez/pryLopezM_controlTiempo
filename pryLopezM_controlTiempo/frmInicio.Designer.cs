namespace pryLopezM_controlTiempo
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            this.btnTrabajo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatuslblTiempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatuslblResul = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerTrab = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTrabajo
            // 
            this.btnTrabajo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnTrabajo.Location = new System.Drawing.Point(249, 107);
            this.btnTrabajo.Name = "btnTrabajo";
            this.btnTrabajo.Size = new System.Drawing.Size(271, 176);
            this.btnTrabajo.TabIndex = 0;
            this.btnTrabajo.Text = "Trabajo";
            this.btnTrabajo.UseVisualStyleBackColor = false;
            this.btnTrabajo.Click += new System.EventHandler(this.btnTrabajo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatuslblTiempo,
            this.toolStripStatuslblResul});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatuslblTiempo
            // 
            this.toolStripStatuslblTiempo.Name = "toolStripStatuslblTiempo";
            this.toolStripStatuslblTiempo.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatuslblTiempo.Text = "Tiempo";
            
            // toolStripStatuslblResul
            // 
            this.toolStripStatuslblResul.Name = "toolStripStatuslblResul";
            this.toolStripStatuslblResul.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatuslblResul.Text = "Resultado";
            // 
            // timerTrab
            // 
            this.timerTrab.Tick += new System.EventHandler(this.timerTrab_Tick);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnTrabajo);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrabajo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatuslblTiempo;
        private System.Windows.Forms.Timer timerTrab;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatuslblResul;
    }
}

