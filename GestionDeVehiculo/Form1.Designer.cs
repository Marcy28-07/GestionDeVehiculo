namespace GestionDeVehiculo
{
    partial class Form1
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
            cmbTipoVehiculo = new ComboBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtCapacidadCarga = new TextBox();
            txtCapacidadBateria = new TextBox();
            btnAgregar = new Button();
            btnMover = new Button();
            btnIniciar = new Button();
            btnDetener = new Button();
            btnCargarBateria = new Button();
            lstVehiculo = new ListBox();
            lblTipoDeVehiculo = new Label();
            lblMarca = new Label();
            lblModelo = new Label();
            lblCapacidadCarga = new Label();
            lblCapacidadBateria = new Label();
            SuspendLayout();
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(200, 64);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(151, 28);
            cmbTipoVehiculo.TabIndex = 0;
            cmbTipoVehiculo.SelectedIndexChanged += cmbTipoVehiculo_SelectedIndexChanged;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(200, 133);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 27);
            txtMarca.TabIndex = 1;
            txtMarca.TextChanged += textBox1_TextChanged;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(200, 189);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(125, 27);
            txtModelo.TabIndex = 2;
            // 
            // txtCapacidadCarga
            // 
            txtCapacidadCarga.Location = new Point(200, 248);
            txtCapacidadCarga.Name = "txtCapacidadCarga";
            txtCapacidadCarga.Size = new Size(125, 27);
            txtCapacidadCarga.TabIndex = 3;
            // 
            // txtCapacidadBateria
            // 
            txtCapacidadBateria.Location = new Point(200, 319);
            txtCapacidadBateria.Name = "txtCapacidadBateria";
            txtCapacidadBateria.Size = new Size(125, 27);
            txtCapacidadBateria.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(67, 418);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMover
            // 
            btnMover.Location = new Point(184, 418);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(94, 29);
            btnMover.TabIndex = 6;
            btnMover.Text = "Mover";
            btnMover.UseVisualStyleBackColor = true;
            btnMover.Click += btnMover_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(316, 418);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 29);
            btnIniciar.TabIndex = 7;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(441, 418);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(94, 29);
            btnDetener.TabIndex = 8;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnCargarBateria
            // 
            btnCargarBateria.Location = new Point(569, 418);
            btnCargarBateria.Name = "btnCargarBateria";
            btnCargarBateria.Size = new Size(133, 29);
            btnCargarBateria.TabIndex = 9;
            btnCargarBateria.Text = "Cargar Bateria";
            btnCargarBateria.UseVisualStyleBackColor = true;
            btnCargarBateria.Click += btnCargarBateria_Click;
            // 
            // lstVehiculo
            // 
            lstVehiculo.FormattingEnabled = true;
            lstVehiculo.Location = new Point(460, 90);
            lstVehiculo.Name = "lstVehiculo";
            lstVehiculo.Size = new Size(392, 224);
            lstVehiculo.TabIndex = 10;
            lstVehiculo.SelectedIndexChanged += lstVehiculo_SelectedIndexChanged;
            // 
            // lblTipoDeVehiculo
            // 
            lblTipoDeVehiculo.AutoSize = true;
            lblTipoDeVehiculo.Location = new Point(24, 72);
            lblTipoDeVehiculo.Name = "lblTipoDeVehiculo";
            lblTipoDeVehiculo.Size = new Size(122, 20);
            lblTipoDeVehiculo.TabIndex = 11;
            lblTipoDeVehiculo.Text = "Tipo de vehiculo:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(49, 136);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(50, 20);
            lblMarca.TabIndex = 12;
            lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(49, 196);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(61, 20);
            lblModelo.TabIndex = 13;
            lblModelo.Text = "Modelo";
            // 
            // lblCapacidadCarga
            // 
            lblCapacidadCarga.AutoSize = true;
            lblCapacidadCarga.Location = new Point(24, 255);
            lblCapacidadCarga.Name = "lblCapacidadCarga";
            lblCapacidadCarga.Size = new Size(123, 20);
            lblCapacidadCarga.TabIndex = 14;
            lblCapacidadCarga.Text = "Capacidad Carga";
            // 
            // lblCapacidadBateria
            // 
            lblCapacidadBateria.AutoSize = true;
            lblCapacidadBateria.Location = new Point(19, 326);
            lblCapacidadBateria.Name = "lblCapacidadBateria";
            lblCapacidadBateria.Size = new Size(131, 20);
            lblCapacidadBateria.TabIndex = 15;
            lblCapacidadBateria.Text = "Capacidad Bateria";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 553);
            Controls.Add(lblCapacidadBateria);
            Controls.Add(lblCapacidadCarga);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(lblTipoDeVehiculo);
            Controls.Add(lstVehiculo);
            Controls.Add(btnCargarBateria);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(btnMover);
            Controls.Add(btnAgregar);
            Controls.Add(txtCapacidadBateria);
            Controls.Add(txtCapacidadCarga);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(cmbTipoVehiculo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoVehiculo;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtCapacidadCarga;
        private TextBox txtCapacidadBateria;
        private Button btnAgregar;
        private Button btnMover;
        private Button btnIniciar;
        private Button btnDetener;
        private Button btnCargarBateria;
        private ListBox lstVehiculo;
        private Label lblTipoDeVehiculo;
        private Label lblMarca;
        private Label lblModelo;
        private Label lblCapacidadCarga;
        private Label lblCapacidadBateria;
    }
}
