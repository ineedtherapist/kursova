using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows.Forms;

namespace kurs
{
    public partial class AddClient : Form
    {
        public Clients cli;
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<BsonDocument> collection;

        public AddClient(Clients c)
        {
            InitializeComponent();
            cli = c;
            
            string connectionString = "mongodb+srv://v:qwe12@cluster0.fm9se2l.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
            client = new MongoClient(connectionString);
            db = client.GetDatabase("kurs");
            collection = db.GetCollection<BsonDocument>("clients");
        }

        private void AddClieBtn_Click(object sender, EventArgs e)
        {
            string Name = ClieNameAdd.Text;
            string Datebirth = DBClieAdd.Text;
            string Phone = PhoneClieAdd.Text;
         
            var Client = new BsonDocument
            {
                { "Name", Name },
                { "Datebirth", Datebirth },
                { "Phone", Phone }
            };

            collection.InsertOne(Client);

            MessageBox.Show("Клієнт доданий успішно.");

            cli.RefreshClients();

            this.Close();
        }
    }
}