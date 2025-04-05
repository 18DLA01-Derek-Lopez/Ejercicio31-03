namespace CRUD_13_VB_31_Marzo
{
    public partial class Form1 : Form
    {
        int codigo = 1;//Inicializar una variable para el codigo
        static int seleccionarFila;//Variable permanente
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult mensaje;
            mensaje = MessageBox.Show("¿Desea Salir?", "Colegio Don Bosco",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (mensaje == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //Metodo Limpiar
        void limpiar()
        {
            txtNombApell.Text = "";
            txtNumCita.Text = "";
            txtTel.Text = "";
            txtNombApell.Focus();//Indica donde debe enfocarse el cursor
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            object[] agregarDatos =
                {
                    codigo.ToString(),
                    txtNombApell.Text,
                    txtNumCita.Text,
                    txtTel.Text,
                    txtCod.Text
                };
            dgvDatos.Rows.Add(agregarDatos);
            MessageBox.Show("Cita registrada", "Colegio Don Bosco", MessageBoxButtons.OK, MessageBoxIcon.Information);
            codigo++;
            txtCod.Text = codigo.ToString();
            limpiar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCod.Text = codigo.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDatos.RowCount != 0)
                {
                    int indice = dgvDatos.CurrentRow.Index;
                    dgvDatos.Rows[indice].Cells[0].Value = txtCod;
                    dgvDatos.Rows[indice].Cells[1].Value = txtNombApell;
                    dgvDatos.Rows[indice].Cells[2].Value = txtNumCita;
                    dgvDatos.Rows[indice].Cells[3].Value = txtTel;
                    MessageBox.Show("Cita Modificada", "Colegio Don Bosco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay citas", "Colegio Don Bosco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionarFila >= 0)
                    dgvDatos.Rows.RemoveAt(seleccionarFila);
                else
                    MessageBox.Show("No hay citas", "Colegio Don Bosco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("No hay citas seleccionadas", "Colegio Don Bosco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 tarea = new Form2();
            tarea.Show();
        }
    }
}
