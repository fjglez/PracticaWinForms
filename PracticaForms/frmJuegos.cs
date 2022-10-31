using System.Data;
using System.Diagnostics.Contracts;
using System.Windows.Forms;

namespace PracticaForms
{
    public partial class frmJuegos : Form
    {
        public frmJuegos()
        {
            InitializeComponent();
        }
        #region Enumerado

        public enum ModoEdicion
        {
            lectura,
            crear,
            modificar
        }

        public ModoEdicion modoEdicion;

        #endregion

        private void frmJuegos_Load(object sender, EventArgs e)
        {

            modoEdicion = ModoEdicion.lectura;
            ModoPantallaLectura();

            // Cargamos los items de bbdd.
            CargarYConfigurarGrid();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
        private void dgvJuegos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //numId.Value = e.RowIndex;
            dgvJuegos.Rows[e.RowIndex].Selected = true;
        }

        private void dgvJuegos_RowStateChanged_1(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // Para cualquier operación que no sea que ha cambiado la selección de la fila, nos salimos
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // Obtenemos la fila seleccionada
            DataGridViewRow filaSeleccionada = e.Row;

            CargarInfoFilaSeleccionadaFormulario(filaSeleccionada);
            
        }
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.modificar;
            ModoPantallaEdicion();

        }

        public void ModoPantallaEdicion()
        {
            if (modoEdicion == ModoEdicion.crear)
            {
                numId.Value = 0;
                txtTitulo.Text = "";
                dtpFechaSalida.Value = DateTime.Now;
                cbGenero.Text = "";
                numVentas.Value = 0;
                txtPrecio.Text = "0,0";
            }

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtTitulo.Enabled = true;
            dtpFechaSalida.Enabled = true;
            numVentas.Enabled = true;
            txtPrecio.Enabled = true;
            cbGenero.Enabled = true;


            DataSet ds = Repositorio.ObtenerGeneros();
            string?[] generos = ds.Tables[0].Rows.OfType<DataRow>()
                        .Select(dr => dr.Field<string>("Genero")).ToArray();
            if (generos.Length > 0)
            {
                cbGenero.Items.Clear();
                cbGenero.Items.AddRange(generos);
            }

            btnCrear.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            dgvJuegos.Enabled = false;
        }

        ///// <summary>
        ///// Método para establecer el modo de la pantalla a edición.
        ///// </summary>
        public void ModoPantallaLectura()
        {
            numId.Value = 0;
            txtTitulo.Text = "";
            dtpFechaSalida.Value = DateTime.Now;
            cbGenero.Text = "";
            numVentas.Value = 0;
            txtPrecio.Text = "0.0";
        

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            numId.Enabled = false;
            txtTitulo.Enabled = false;
            dtpFechaSalida.Enabled = false;
            numVentas.Enabled = false;
            txtPrecio.Enabled = false;
            cbGenero.Enabled = false;

            btnCrear.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

            dgvJuegos.Enabled = true;
        }

        ///// <summary>
        ///// Método para obtener la información del formulario.
        ///// </summary>
        ///// <returns>Contacto con la información del formulario.</returns>
        public Juego ObtenerInformacion()
        {
            Juego juego = new Juego();

            juego.titulo = txtTitulo.Text;
            juego.fechaSalida = dtpFechaSalida.Value;

            double precio;
            if (Double.TryParse(txtPrecio.Text, out precio))
            {
                juego.precio = precio;
            }

            juego.genero = cbGenero.Text;
            juego.id = (int)numId.Value;
            juego.ventas = (int)numVentas.Value;

            return juego;
        }

        ///// <summary>
        ///// Método que carga y configura el grid.
        ///// </summary>
        ///// <param name="Contactos">DataTable con la info de los contactos</param>
        public void CargarYConfigurarGrid()
        {
            DataSet ds = Repositorio.ObtenerJuegos();
            dgvJuegos.DataSource = ds.Tables[0];

            // Tamaños columnas
            dgvJuegos.Columns["JuegoId"].Width = 80;
            dgvJuegos.Columns["Titulo"].Width = 300;
            dgvJuegos.Columns["FechaSalida"].Width = 200;
            dgvJuegos.Columns["Genero"].Width = 150;
            dgvJuegos.Columns["Ventas"].Width = 125;
            dgvJuegos.Columns["Precio"].Width = 125;

            // Renombrado columnas
            dgvJuegos.Columns["JuegoId"].HeaderText = "ID";
            dgvJuegos.Columns["FechaSalida"].HeaderText = "Fecha Salida";

            // Formato fecha en español
            dgvJuegos.Columns["FechaSalida"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Seleccionamos la primera fila del grid si existe
            SeleccionarFilaGrid(0);

        }

        public void SeleccionarFilaGrid(int i)
        {
            // Si hay alguna fila, seleccionamos la primera
            if (dgvJuegos.Rows.Count > i)
            {
                dgvJuegos.Rows[i].Selected = true;
            }
        }

        public void CargarInfoFilaSeleccionadaFormulario(DataGridViewRow filaSeleccionada)
        {
            numId.Value = (int)filaSeleccionada.Cells["JuegoId"].Value;
            txtTitulo.Text = filaSeleccionada.Cells["Titulo"].Value.ToString();
            dtpFechaSalida.Value = (DateTime)filaSeleccionada.Cells["FechaSalida"].Value;
            cbGenero.Text = filaSeleccionada.Cells["Genero"].Value.ToString();
            numVentas.Value = (int)filaSeleccionada.Cells["Ventas"].Value;
            txtPrecio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.crear;
            ModoPantallaEdicion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool correcto = false;

            if (InformacionObligatoriaCumplimentada())
            {
                Juego j = ObtenerInformacion();

                switch (modoEdicion)
                {
                    case ModoEdicion.crear:
                        correcto = Repositorio.CrearJuego(j);
                        break;
                    case ModoEdicion.modificar:
                        correcto = Repositorio.ModificarJuego(j);
                        break;
                }

                if (correcto)
                {
                    MessageBox.Show("la acción se ha realizado correctamente.");
                    modoEdicion = ModoEdicion.lectura;
                    ModoPantallaLectura();
                    CargarYConfigurarGrid();
                }

            }
            else
            {
                MessageBox.Show("Los campos Nombre y Teléfono son obligatorios.");
            }
        }



        public bool InformacionObligatoriaCumplimentada()
        {
            if (String.IsNullOrEmpty(txtTitulo.Text) && numId != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) 
                || (!char.IsControl(e.KeyChar) && e.KeyChar != '.' && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.lectura;
            ModoPantallaLectura();

            if (dgvJuegos.SelectedRows.Count == 1)
            {
                CargarInfoFilaSeleccionadaFormulario(dgvJuegos.SelectedRows[0]);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Juego j = ObtenerInformacion();
            Repositorio.EliminarJuego(j);
            CargarYConfigurarGrid();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}