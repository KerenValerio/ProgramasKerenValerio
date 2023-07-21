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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rocio2
{
    public partial class Form1 : Form
    {
        private DataGridView DTFASE2 = new DataGridView();

    
        private int gerenteCount;



        private DateTime fechaActual; 
        private TimeSpan horaSeleccionada; 
        public Form1()
        {
            InitializeComponent();



        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fASE1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fASE2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FASE1 proceso = new FASE1();
            proceso.ShowDialog();

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
     
      

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
         Form1 form = new Form1();
            form.ShowDialog();
        }
    

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fASE3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FASE3 fASE3 = new FASE3();
            fASE3 .ShowDialog();
            

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fASE4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FASE_4 fASE_4 = new FASE_4();
            fASE_4 .ShowDialog();   
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
