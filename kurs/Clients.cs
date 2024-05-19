using System;
using System.Windows.Forms;

namespace kurs
{
    public partial class Clients : Form
    {
        public Clients(Rentals ren)
        {
            r = ren;
            InitializeComponent();
        }
        public Rentals r;
        private void btngoback2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rentals r = new Rentals(null, null, this);
            r.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}