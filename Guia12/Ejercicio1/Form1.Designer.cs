namespace Ejercicio1
{
    partial class Form1
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
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMostrarValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Location = new System.Drawing.Point(336, 127);
            this.btnSolicitar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(169, 26);
            this.btnSolicitar.TabIndex = 0;
            this.btnSolicitar.Text = "Solicitar Valor";
            this.btnSolicitar.UseVisualStyleBackColor = true;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(50, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMostrarValor
            // 
            this.lbMostrarValor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbMostrarValor.Location = new System.Drawing.Point(208, 231);
            this.lbMostrarValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMostrarValor.Name = "lbMostrarValor";
            this.lbMostrarValor.Size = new System.Drawing.Size(297, 62);
            this.lbMostrarValor.TabIndex = 2;
            this.lbMostrarValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 390);
            this.Controls.Add(this.lbMostrarValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSolicitar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejemplo Modal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMostrarValor;
    }
}

