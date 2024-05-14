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
        
        
    }
}