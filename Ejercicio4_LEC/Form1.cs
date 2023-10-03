using System.Windows.Forms;

namespace Ejercicio4_LEC
{
    public partial class Form1 : Form
    {
        ListaEnlazadaDoble listaEstudiantes = new ListaEnlazadaDoble();
        public Form1()
        {
            InitializeComponent();
        }

        private void AgregarEstudiante_Click(object sender, EventArgs e)
        {
            if (int.TryParse(codigoTextBox.Text, out int codigo) && !string.IsNullOrWhiteSpace(nombresTextBox.Text) && double.TryParse(notaTextBox.Text, out double nota))
            {
                Estudiante nuevoEstudiante = new Estudiante
                {
                    Codigo = codigo,
                    Nombres = nombresTextBox.Text,
                    Nota = nota
                };

                listaEstudiantes.AgregarEstudiante(nuevoEstudiante);
                ActualizarDataGridView();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor ingresa datos v�lidos.");
            }
        }

        private void BuscarEstudiante_Click(object sender, EventArgs e)
        {
            if (int.TryParse(codigoBuscarTextBox.Text, out int codigoBusqueda))
            {
                // Buscar el estudiante por c�digo y resaltar la fila en el DataGridView
                DataGridViewRow filaEncontrada = null;

                foreach (DataGridViewRow fila in dataGridView.Rows)
                {
                    if (fila.Cells["Codigo"].Value != null && (int)fila.Cells["Codigo"].Value == codigoBusqueda)
                    {
                        filaEncontrada = fila;
                        break;
                    }
                }

                if (filaEncontrada != null)
                {
                    dataGridView.ClearSelection();
                    filaEncontrada.Selected = true;
                }
                else
                {
                    MessageBox.Show("Estudiante no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa un c�digo v�lido.");
            }
            codigoBuscarTextBox.Clear();
        }

        private void EliminarEstudiante_Click(object sender, EventArgs e)
        {
            if (int.TryParse(codigoEliminarTextBox.Text, out int codigoEliminar))
            {
                listaEstudiantes.EliminarEstudiante(codigoEliminar);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor ingresa un c�digo v�lido.");
            }
            codigoEliminarTextBox.Clear();
        }
        private void ActualizarDataGridView()
        {
            dataGridView.Rows.Clear();

            Nodo actual = listaEstudiantes.Primero;

            while (actual != null)
            {
                dataGridView.Rows.Add(actual.Codigo, actual.Nombres, actual.Nota);
                actual = actual.Siguiente;
            }
            totalAprobadosLabel.Text = "Aprobados: " + listaEstudiantes.Aprobados.ToString();
            totalDesaprobadosLabel.Text = "Desaprobados: " + listaEstudiantes.Desaprobados.ToString();
        }

        private void LimpiarCampos()
        {
            codigoTextBox.Clear();
            nombresTextBox.Clear();
            notaTextBox.Clear();
        }
    }
}