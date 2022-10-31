namespace PracticaForms
{
    partial class frmJuegos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labGenero = new System.Windows.Forms.Label();
            this.labVentas = new System.Windows.Forms.Label();
            this.numVentas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.labFechaSalida = new System.Windows.Forms.Label();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.labTitulo = new System.Windows.Forms.Label();
            this.dgvJuegos = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(165, 133);
            this.txtTitulo.MaxLength = 50;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(300, 31);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGenero);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labGenero);
            this.groupBox1.Controls.Add(this.labVentas);
            this.groupBox1.Controls.Add(this.numVentas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaSalida);
            this.groupBox1.Controls.Add(this.labFechaSalida);
            this.groupBox1.Controls.Add(this.numId);
            this.groupBox1.Controls.Add(this.labTitulo);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Location = new System.Drawing.Point(33, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 342);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(165, 202);
            this.cbGenero.MaxLength = 20;
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(300, 33);
            this.cbGenero.TabIndex = 13;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(659, 129);
            this.txtPrecio.MaxLength = 20;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(126, 31);
            this.txtPrecio.TabIndex = 12;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Precio";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // labGenero
            // 
            this.labGenero.AutoSize = true;
            this.labGenero.Location = new System.Drawing.Point(22, 205);
            this.labGenero.Name = "labGenero";
            this.labGenero.Size = new System.Drawing.Size(69, 25);
            this.labGenero.TabIndex = 9;
            this.labGenero.Text = "Género";
            this.labGenero.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // labVentas
            // 
            this.labVentas.AutoSize = true;
            this.labVentas.Location = new System.Drawing.Point(521, 69);
            this.labVentas.Name = "labVentas";
            this.labVentas.Size = new System.Drawing.Size(122, 25);
            this.labVentas.TabIndex = 8;
            this.labVentas.Text = "Ventas totales";
            this.labVentas.Click += new System.EventHandler(this.label2_Click);
            // 
            // numVentas
            // 
            this.numVentas.Location = new System.Drawing.Point(659, 67);
            this.numVentas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numVentas.Name = "numVentas";
            this.numVentas.Size = new System.Drawing.Size(126, 31);
            this.numVentas.TabIndex = 7;
            this.numVentas.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(165, 265);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(300, 31);
            this.dtpFechaSalida.TabIndex = 5;
            // 
            // labFechaSalida
            // 
            this.labFechaSalida.AutoSize = true;
            this.labFechaSalida.Location = new System.Drawing.Point(22, 270);
            this.labFechaSalida.Name = "labFechaSalida";
            this.labFechaSalida.Size = new System.Drawing.Size(132, 25);
            this.labFechaSalida.TabIndex = 4;
            this.labFechaSalida.Text = "Fecha de salida";
            this.labFechaSalida.Click += new System.EventHandler(this.label1_Click_5);
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(165, 67);
            this.numId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(104, 31);
            this.numId.TabIndex = 3;
            this.numId.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Location = new System.Drawing.Point(27, 136);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(56, 25);
            this.labTitulo.TabIndex = 2;
            this.labTitulo.Text = "Título";
            this.labTitulo.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // dgvJuegos
            // 
            this.dgvJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJuegos.Location = new System.Drawing.Point(33, 470);
            this.dgvJuegos.Name = "dgvJuegos";
            this.dgvJuegos.RowHeadersWidth = 62;
            this.dgvJuegos.RowTemplate.Height = 33;
            this.dgvJuegos.Size = new System.Drawing.Size(1044, 268);
            this.dgvJuegos.TabIndex = 3;
            this.dgvJuegos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJuegos_CellClick_1);
            this.dgvJuegos.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvJuegos_RowStateChanged_1);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(52, 409);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(112, 34);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(170, 409);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 34);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(288, 409);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 34);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(944, 409);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 34);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(826, 409);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 34);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvJuegos);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmJuegos";
            this.Text = "Juegos";
            this.Load += new System.EventHandler(this.frmJuegos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txtTitulo;
        private GroupBox groupBox1;
        private Label labTitulo;
        private NumericUpDown numId;
        private Label labFechaSalida;
        private Label labVentas;
        private NumericUpDown numVentas;
        private Label label1;
        private DateTimePicker dtpFechaSalida;
        private DataGridView dgvJuegos;
        private Label labGenero;
        private TextBox txtPrecio;
        private Label label2;
        private Button btnCrear;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cbGenero;
    }
}