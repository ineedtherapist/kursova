using System;
using System.Windows.Forms;

namespace kurs
{
    public partial class instruments : Form
    {
                
        public Rentals r;
        public instruments(Rentals ren)
        {
            r = ren;
            InitializeComponent();
        }
        
        private void btngoback_Click(object sender, EventArgs e)
        {
           this.Hide();
           Rentals r = new Rentals(this);
           r.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}