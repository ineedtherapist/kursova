using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows.Forms;

namespace kurs
{
    public partial class addInstrument : Form
    {
        public Instruments ins;
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<BsonDocument> collection;
        
        public addInstrument(Instruments i)
        {
            InitializeComponent();
            ins = i;
            
            string connectionString = "mongodb+srv://v:qwe12@cluster0.fm9se2l.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
            client = new MongoClient(connectionString);
            db = client.GetDatabase("kurs");
            collection = db.GetCollection<BsonDocument>("instruments");
        }

        private void AddInstBtn_Click(object sender, EventArgs e)
        {
            string instrName = InstrNameAdd.Text;
            string Desc = DescInstrAdd.Text;
            string Price = PriceInstrAdd.Text;
         
            var Instrument = new BsonDocument
            {
                { "InstName", instrName },
                { "Desc", Desc },
                { "Price", Price }
            };

            collection.InsertOne(Instrument);

            MessageBox.Show("Інструмент доданий успішно.");

            ins.RefreshInstruments();

            this.Close();
        }
    }
}