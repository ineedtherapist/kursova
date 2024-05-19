using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace kurs
{
    public partial class Rentals : Form
    {
        public Enter en;
        // public Instruments rr;
        // public Clients rrr;

        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Rental> collection;

        const string connectionString = "mongodb+srv://v:qwe12@cluster0.fm9se2l.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

        public class Rental
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string Id { get; set; }

            public string InstName { get; set; }
            public string ClientName { get; set; }
            public string Date_start { get; set; }
            public string Data_end { get; set; }
            public string Price { get; set; }

            public Rental(string id, string instName, string clientName, string date_start, string data_end,
                string price)
            {
                this.Id = id;
                this.InstName = instName;
                this.ClientName = clientName;
                this.Date_start = date_start;
                this.Data_end = data_end;
                this.Price = price;
            }
        }

        public Rentals(Enter e , Instruments inst, Clients clie)
        {
            client = new MongoClient(connectionString);
            db = client.GetDatabase("kurs");
            collection = db.GetCollection<Rental>("rentals");

            InitializeComponent();
            en = e;
            // rr = inst;
            // rrr = clie;
        }
    

        private void butShowInst_Click(object sender, EventArgs e)
        {
                Instruments i = new Instruments(this);
                i.Show();
                this.Hide();
        }

        private void bntShowClien_Click(object sender, EventArgs e)
        {
            Clients c = new Clients(this);
            c.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
    }
}