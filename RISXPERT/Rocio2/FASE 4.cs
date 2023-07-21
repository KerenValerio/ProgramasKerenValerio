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
    public partial class FASE_4 : Form
    {
        public FASE_4()
        {
            InitializeComponent();
        }

        private void FASE_4_Load(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            FASE_4 guna = new FASE_4(); 
            guna.ShowDialog();
        }
    }
}
