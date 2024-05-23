using System;
using System.Windows.Forms;
using MongoDB.Driver;

namespace kurs
{
    public partial class updateRental : Form
    {
        public Rentals ren;
        
        private bool choose;
        
        public Rentals.Rental updaterental;
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Rentals.Rental> collection;
        
        public updateRental(Rentals r, Rentals.Rental person)
        {
            InitializeComponent();
            ren = r;
            updaterental = person;
            
            string connectionString = "mongodb+srv://v:qwe12@cluster0.fm9se2l.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
            client = new MongoClient(connectionString);
            db = client.GetDatabase("kurs");
            collection = db.GetCollection<Rentals.Rental>("rentals");
            
            updInstName.Text = updaterental.InstName;
            updClieName.Text = updaterental.ClientName;
            PriceUpd.Text = updaterental.Price;
            Date_startUpd.Text = updaterental.Date_start;
            Date_endAdd.Text = updaterental.Date_end;
        }

        private void UpdinstBtn_Click(object sender, EventArgs e)
        {
            string instName = updInstName.Text;
            string clientName = updClieName.Text;
            string price = PriceUpd.Text;
            string date_start = Date_startUpd.Text;
            string date_end = Date_endAdd.Text;

            var filter = Builders<Rentals.Rental>.Filter.Eq(c => c.Id, updaterental.Id);
            var update = Builders<Rentals.Rental>.Update
                .Set(c => c.InstName, instName)
                .Set(c => c.ClientName, clientName)
                .Set(c => c.Price, price)
                .Set(c => c.Date_start, date_start)
                .Set(c => c.Date_end, date_end);
            
            var updateResult = collection.UpdateOne(filter, update);
        
            if (updateResult.ModifiedCount > 0)
            {
                MessageBox.Show("Дані про оренду успішно оновлено.");
            }
            else
            {
                MessageBox.Show("Не вдалось оновити дані про оренду.");
            }
        
            ren.RefreshRentals();

            this.Close();
        }
    }
}