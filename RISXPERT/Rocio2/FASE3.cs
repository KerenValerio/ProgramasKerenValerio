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
    public partial class FASE3 : Form
    {
        private DataGridView DTFASE2 = new DataGridView();


        private int gerenteCount;


        private DateTime fechaActual;
        private TimeSpan horaSeleccionada;
        public FASE3()
        {
            InitializeComponent();
            Timer tmTiempo = new Timer();
            tmTiempo.Interval = 1000;
            tmTiempo.Tick += new EventHandler(tmTiempo_Tick);
            tmTiempo.Start();


            gunaDateTimePicker1.Format = DateTimePickerFormat.Custom;
            gunaDateTimePicker1.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged);


            fechaActual = DateTime.Now.Date;
            horaSeleccionada = DateTime.Now.TimeOfDay;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FASE3_Load(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            horaSeleccionada = gunaDateTimePicker1.Value.TimeOfDay;
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            FASE3 fASE3 = new FASE3();
            fASE3.ShowDialog();
        }

        private void tmTiempo_Tick(object sender, EventArgs e)
        {
           

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
