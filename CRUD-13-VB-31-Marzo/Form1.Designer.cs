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
            button1 = new Button();
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
            groupBox1.Location = new Point(71, 66);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(1328, 471);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(1107, 331);
            btnModificar.Margin = new Padding(6);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(186, 94);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(1107, 198);
            btnNuevo.Margin = new Padding(6);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(186, 94);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(1107, 81);
            btnRegistrar.Margin = new Padding(6);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(186, 94);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCod
            // 
            txtCod.Location = new Point(310, 367);
            txtCod.Margin = new Padding(6);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(749, 39);
            txtCod.TabIndex = 5;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(310, 277);
            txtTel.Margin = new Padding(6);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(749, 39);
            txtTel.TabIndex = 5;
            // 
            // txtNumCita
            // 
            txtNumCita.Location = new Point(310, 177);
            txtNumCita.Margin = new Padding(6);
            txtNumCita.Name = "txtNumCita";
            txtNumCita.Size = new Size(749, 39);
            txtNumCita.TabIndex = 5;
            // 
            // txtNombApell
            // 
            txtNombApell.Location = new Point(310, 81);
            txtNombApell.Margin = new Padding(6);
            txtNombApell.Name = "txtNombApell";
            txtNombApell.Size = new Size(749, 39);
            txtNombApell.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 384);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 32);
            label4.TabIndex = 3;
            label4.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 277);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 177);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 32);
            label2.TabIndex = 1;
            label2.Text = "Numero de CIta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 87);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 32);
            label1.TabIndex = 0;
            label1.Text = "Nombre y Apellido";
            // 
            // dgvDatos
            // 
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { code, nombreyapellido, citanumero, telefono });
            dgvDatos.Location = new Point(71, 578);
            dgvDatos.Margin = new Padding(6);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 82;
            dgvDatos.Size = new Size(1328, 384);
            dgvDatos.TabIndex = 1;
            // 
            // code
            // 
            code.HeaderText = "Codigo";
            code.MinimumWidth = 10;
            code.Name = "code";
            // 
            // nombreyapellido
            // 
            nombreyapellido.HeaderText = "Nombre y Apellido";
            nombreyapellido.MinimumWidth = 10;
            nombreyapellido.Name = "nombreyapellido";
            // 
            // citanumero
            // 
            citanumero.HeaderText = "Cita Numero";
            citanumero.MinimumWidth = 10;
            citanumero.Name = "citanumero";
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 10;
            telefono.Name = "telefono";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(87, 1003);
            btnEliminar.Margin = new Padding(6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 49);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(277, 1003);
            btnSalir.Margin = new Padding(6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 49);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1119, 1004);
            button1.Name = "button1";
            button1.Size = new Size(280, 46);
            button1.TabIndex = 11;
            button1.Text = "Problema Tarea";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 1077);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(dgvDatos);
            Controls.Add(groupBox1);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Problema2";
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
        private Button button1;
    }
}
