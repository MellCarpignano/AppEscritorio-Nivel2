
namespace Presentacion
{
    partial class FrmPresentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbxPresent = new System.Windows.Forms.PictureBox();
            this.dgvPresent = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtFiltro1 = new System.Windows.Forms.TextBox();
            this.btnfiltro1 = new System.Windows.Forms.Button();
            this.lblMarcaFiltro = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblCategoriaFiltro = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.txtFiltroBusq = new System.Windows.Forms.TextBox();
            this.btnOKbusq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPresent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresent)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPresent
            // 
            this.pbxPresent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPresent.Location = new System.Drawing.Point(201, 3);
            this.pbxPresent.Name = "pbxPresent";
            this.pbxPresent.Size = new System.Drawing.Size(335, 233);
            this.pbxPresent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPresent.TabIndex = 0;
            this.pbxPresent.TabStop = false;
            this.pbxPresent.Click += new System.EventHandler(this.pbxPresent_Click);
            // 
            // dgvPresent
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPresent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPresent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPresent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPresent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPresent.GridColor = System.Drawing.SystemColors.Menu;
            this.dgvPresent.Location = new System.Drawing.Point(14, 242);
            this.dgvPresent.MultiSelect = false;
            this.dgvPresent.Name = "dgvPresent";
            this.dgvPresent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPresent.Size = new System.Drawing.Size(761, 145);
            this.dgvPresent.TabIndex = 1;
            this.dgvPresent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPresent_CellContentClick);
            this.dgvPresent.SelectionChanged += new System.EventHandler(this.dgvPresent_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Linen;
            this.btnAgregar.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(27, 78);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Articulo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Linen;
            this.btnModificar.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(27, 121);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar Articulo";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Linen;
            this.btnEliminar.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(27, 165);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Articulo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtFiltro1
            // 
            this.txtFiltro1.Location = new System.Drawing.Point(46, 405);
            this.txtFiltro1.Name = "txtFiltro1";
            this.txtFiltro1.Size = new System.Drawing.Size(218, 20);
            this.txtFiltro1.TabIndex = 5;
            this.txtFiltro1.TextChanged += new System.EventHandler(this.txtFiltro1_TextChanged);
            this.txtFiltro1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro1_KeyPress);
            // 
            // btnfiltro1
            // 
            this.btnfiltro1.BackColor = System.Drawing.Color.Linen;
            this.btnfiltro1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltro1.Location = new System.Drawing.Point(295, 398);
            this.btnfiltro1.Name = "btnfiltro1";
            this.btnfiltro1.Padding = new System.Windows.Forms.Padding(5);
            this.btnfiltro1.Size = new System.Drawing.Size(154, 33);
            this.btnfiltro1.TabIndex = 6;
            this.btnfiltro1.Text = "Busqueda rápida";
            this.btnfiltro1.UseVisualStyleBackColor = false;
            this.btnfiltro1.Click += new System.EventHandler(this.btnfiltro1_Click);
            // 
            // lblMarcaFiltro
            // 
            this.lblMarcaFiltro.AutoSize = true;
            this.lblMarcaFiltro.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaFiltro.Location = new System.Drawing.Point(554, 119);
            this.lblMarcaFiltro.Name = "lblMarcaFiltro";
            this.lblMarcaFiltro.Size = new System.Drawing.Size(45, 13);
            this.lblMarcaFiltro.TabIndex = 7;
            this.lblMarcaFiltro.Text = "Criterio";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCriterio.Location = new System.Drawing.Point(632, 111);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(156, 21);
            this.cboCriterio.TabIndex = 11;
            this.cboCriterio.SelectedIndexChanged += new System.EventHandler(this.cboCriterio_SelectedIndexChanged);
            // 
            // lblCategoriaFiltro
            // 
            this.lblCategoriaFiltro.AutoSize = true;
            this.lblCategoriaFiltro.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaFiltro.Location = new System.Drawing.Point(554, 78);
            this.lblCategoriaFiltro.Name = "lblCategoriaFiltro";
            this.lblCategoriaFiltro.Size = new System.Drawing.Size(44, 13);
            this.lblCategoriaFiltro.TabIndex = 9;
            this.lblCategoriaFiltro.Text = "Campo";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(632, 75);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(156, 21);
            this.cboCampo.TabIndex = 10;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCategoriaFiltro_SelectedIndexChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(558, 161);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(38, 13);
            this.lblFiltrar.TabIndex = 12;
            this.lblFiltrar.Text = "Filtrar:";
            // 
            // txtFiltroBusq
            // 
            this.txtFiltroBusq.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroBusq.Location = new System.Drawing.Point(632, 154);
            this.txtFiltroBusq.Name = "txtFiltroBusq";
            this.txtFiltroBusq.Size = new System.Drawing.Size(156, 22);
            this.txtFiltroBusq.TabIndex = 13;
            this.txtFiltroBusq.TextChanged += new System.EventHandler(this.txtFiltroBusq_TextChanged);
            // 
            // btnOKbusq
            // 
            this.btnOKbusq.BackColor = System.Drawing.Color.Linen;
            this.btnOKbusq.Location = new System.Drawing.Point(700, 195);
            this.btnOKbusq.Name = "btnOKbusq";
            this.btnOKbusq.Size = new System.Drawing.Size(75, 23);
            this.btnOKbusq.TabIndex = 14;
            this.btnOKbusq.Text = "OK";
            this.btnOKbusq.UseVisualStyleBackColor = false;
            this.btnOKbusq.Click += new System.EventHandler(this.btnOKbusq_Click);
            // 
            // FrmPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOKbusq);
            this.Controls.Add(this.txtFiltroBusq);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblCategoriaFiltro);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.lblMarcaFiltro);
            this.Controls.Add(this.btnfiltro1);
            this.Controls.Add(this.txtFiltro1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvPresent);
            this.Controls.Add(this.pbxPresent);
            this.Name = "FrmPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Articulos";
            this.Load += new System.EventHandler(this.FrmPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPresent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPresent;
        private System.Windows.Forms.DataGridView dgvPresent;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtFiltro1;
        private System.Windows.Forms.Button btnfiltro1;
        private System.Windows.Forms.Label lblMarcaFiltro;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblCategoriaFiltro;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.TextBox txtFiltroBusq;
        private System.Windows.Forms.Button btnOKbusq;
    }
}

