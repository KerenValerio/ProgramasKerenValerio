using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocio2
{
    public partial class FASE1 : Form
    {
        int idCounter = 1;
        private DataGridView DTFASE2 = new DataGridView();


        private int gerenteCount;

        public event EventHandler<string> TextoActualizado;

        private DateTime fechaActual;
        private TimeSpan horaSeleccionada;

        public FASE1()
        {
            InitializeComponent();
           

        }
        public void ActualizarTexto(string texto)
        {
            TextoActualizado?.Invoke(this, texto);

            txtFASE1.Text = texto;
        }
        public string TextoEnFASE1
        {
            get { return txtFASE1.Text; }
            set { txtFASE1.Text = value; }
        }

        private void AgregarNuevaFila(string nombre, int edad)
        {
        
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private int GenerarNuevoID()
        {
            return idCounter++;
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void AgregarDatoAlDataGridView(string dato)
        {
           
            gunaDataGridView1.Rows.Add(dato);
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
         FASE1 fASE1 = new FASE1();
            fASE1.ShowDialog();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void FASE1_Load(object sender, EventArgs e)
        {
           

        }

        private void gunaDataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
           


            if (e.KeyCode == Keys.Enter)
            {
                // Guarda los cambios en la celda actual.
                gunaDataGridView1.EndEdit();

                // Obtiene el índice de la fila actual.
                int currentRowIndex = gunaDataGridView1.CurrentRow.Index;

                // Si la fila actual es la última fila, agrega una nueva fila al final.
                if (currentRowIndex == gunaDataGridView1.Rows.Count - 1)
                {
                    gunaDataGridView1.Rows.Add();
                }

                // Mueve el foco a la siguiente fila.
                gunaDataGridView1.CurrentCell = gunaDataGridView1.Rows[currentRowIndex + 1].Cells[0];
            }
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }
        private void tmTiempo_Tick(object sender, EventArgs e)
        {
           


        }
    }
}
