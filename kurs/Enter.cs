using System;
using System.Windows.Forms;

namespace kurs
{
    public partial class Enter : Form 
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rentals r = new Rentals(this, null, null);
            r.Show();
            this.Hide();
        }
        
    }
}