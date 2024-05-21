using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows.Forms;

namespace kurs
{
    public partial class addRental : Form
    {
        public Rentals rent;
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<BsonDocument> collection;
        
        public addRental(Rentals re)
        {
            InitializeComponent();
            rent = re;
            
            string connectionString = "mongodb+srv://v:qwe12@cluster0.fm9se2l.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
            client = new MongoClient(connectionString);
            db = client.GetDatabase("kurs");
            collection = db.GetCollection<BsonDocument>("rentals");
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            string client = btnAddClien.Text;
            string instr = btnAddInst.Text;
            string Date_start = Date_startAdd.Text;
            string Date_end = Date_endAdd.Text;
            string Price = PriceAdd.Text;
            
            var rentalDocument = new BsonDocument
            {
                { "InstName", client },
                { "ClientName", instr },  
                { "Date_start", Date_start },
                { "Date_end", Date_end },
                { "Price", Price }
            };

            collection.InsertOne(rentalDocument);

            MessageBox.Show("Замовлення успішно додано.");

            rent.RefreshRentals();

            this.Close();
        }

        private void btnAddClien_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients(null);
            clients.ClientSelected += ClientsForm_ClientSelected;
            clients.ShowDialog();
        }
        
        private void btnAddInst_Click(object sender, EventArgs e)
        {
            Instruments instruments = new Instruments(null);
            instruments.InstrSelected += InstrForm_InstrSelected;
            instruments.ShowDialog();
        }
        
        private void ClientsForm_ClientSelected(object sender, ClientSelectedEventArgs e)
        {
            btnAddClien.Text = e.SelectedClientName;
        }

        private void InstrForm_InstrSelected(object sender, InstrSelectedEventArgs e)
        {
            btnAddInst.Text = e.SelectedInstrName;
        }
        
    }
}