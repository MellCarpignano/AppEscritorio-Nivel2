
namespace Presentacion
{
    partial class FrmEliminarArticulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodElim = new System.Windows.Forms.TextBox();
            this.lblIngreseCod = new System.Windows.Forms.Label();
            this.btnAceptarElim = new System.Windows.Forms.Button();
            this.BtnCancelarElim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Articulo ";
            // 
            // txtCodElim
            // 
            this.txtCodElim.Location = new System.Drawing.Point(230, 63);
            this.txtCodElim.Name = "txtCodElim";
            this.txtCodElim.Size = new System.Drawing.Size(100, 20);
            this.txtCodElim.TabIndex = 1;
            // 
            // lblIngreseCod
            // 
            this.lblIngreseCod.AutoSize = true;
            this.lblIngreseCod.Location = new System.Drawing.Point(56, 70);
            this.lblIngreseCod.Name = "lblIngreseCod";
            this.lblIngreseCod.Size = new System.Drawing.Size(153, 13);
            this.lblIngreseCod.TabIndex = 2;
            this.lblIngreseCod.Text = "Ingrese el codigo del producto:";
            // 
            // btnAceptarElim
            // 
            this.btnAceptarElim.Location = new System.Drawing.Point(56, 185);
            this.btnAceptarElim.Name = "btnAceptarElim";
            this.btnAceptarElim.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarElim.TabIndex = 3;
            this.btnAceptarElim.Text = "Aceptar";
            this.btnAceptarElim.UseVisualStyleBackColor = true;
            this.btnAceptarElim.Click += new System.EventHandler(this.btnAceptarElim_Click);
            // 
            // BtnCancelarElim
            // 
            this.BtnCancelarElim.Location = new System.Drawing.Point(192, 185);
            this.BtnCancelarElim.Name = "BtnCancelarElim";
            this.BtnCancelarElim.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarElim.TabIndex = 4;
            this.BtnCancelarElim.Text = "Cancelar";
            this.BtnCancelarElim.UseVisualStyleBackColor = true;
            this.BtnCancelarElim.Click += new System.EventHandler(this.BtnCancelarElim_Click);
            // 
            // FrmEliminarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 326);
            this.Controls.Add(this.BtnCancelarElim);
            this.Controls.Add(this.btnAceptarElim);
            this.Controls.Add(this.lblIngreseCod);
            this.Controls.Add(this.txtCodElim);
            this.Controls.Add(this.label1);
            this.Name = "FrmEliminarArticulo";
            this.Text = "FrmEliminarArticulo";
            this.Load += new System.EventHandler(this.FrmEliminarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodElim;
        private System.Windows.Forms.Label lblIngreseCod;
        private System.Windows.Forms.Button btnAceptarElim;
        private System.Windows.Forms.Button BtnCancelarElim;
    }
}