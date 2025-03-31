namespace CRUD_13_VB_31_Marzo
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
            groupBox1 = new GroupBox();
            btnModificar = new Button();
            btnNuevo = new Button();
            btnRegistrar = new Button();
            txtCod = new TextBox();
            txtTel = new TextBox();
            txtNumCita = new TextBox();
            txtNombApell = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvDatos = new DataGridView();
            code = new DataGridViewTextBoxColumn();
            nombreyapellido = new DataGridViewTextBoxColumn();
            citanumero = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(txtCod);
            groupBox1.Controls.Add(txtTel);
            groupBox1.Controls.Add(txtNumCita);
            groupBox1.Controls.Add(txtNombApell);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(715, 221);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(596, 155);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 44);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(596, 93);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 44);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(596, 38);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 44);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCod
            // 
            txtCod.Location = new Point(167, 172);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(405, 23);
            txtCod.TabIndex = 5;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(167, 130);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(405, 23);
            txtTel.TabIndex = 5;
            // 
            // txtNumCita
            // 
            txtNumCita.Location = new Point(167, 83);
            txtNumCita.Name = "txtNumCita";
            txtNumCita.Size = new Size(405, 23);
            txtNumCita.TabIndex = 5;
            // 
            // txtNombApell
            // 
            txtNombApell.Location = new Point(167, 38);
            txtNombApell.Name = "txtNombApell";
            txtNombApell.Size = new Size(405, 23);
            txtNombApell.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 180);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 130);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 83);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero de CIta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 41);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre y Apellido";
            // 
            // dgvDatos
            // 
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { code, nombreyapellido, citanumero, telefono });
            dgvDatos.Location = new Point(38, 271);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(715, 180);
            dgvDatos.TabIndex = 1;
            // 
            // code
            // 
            code.HeaderText = "Codigo";
            code.Name = "code";
            // 
            // nombreyapellido
            // 
            nombreyapellido.HeaderText = "Nombre y Apellido";
            nombreyapellido.Name = "nombreyapellido";
            // 
            // citanumero
            // 
            citanumero.HeaderText = "Cita Numero";
            citanumero.Name = "citanumero";
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(47, 470);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(149, 470);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 505);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(dgvDatos);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnModificar;
        private Button btnNuevo;
        private Button btnRegistrar;
        private TextBox txtCod;
        private TextBox txtTel;
        private TextBox txtNumCita;
        private TextBox txtNombApell;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvDatos;
        private Button btnEliminar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn nombreyapellido;
        private DataGridViewTextBoxColumn citanumero;
        private DataGridViewTextBoxColumn telefono;
    }
}
