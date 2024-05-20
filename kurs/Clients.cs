using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace kurs
{
    public partial class Clients : Form
    {
        private Rentals r;

        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Client> collection;

        const string connectionString = "mongodb+srv://v:qwe12@cluster0.fm9se2l.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

        public class Client
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string Id { get; set; }
            public string Name { get; set; }
            public string Datebirth { get; set; }
            public string Phone { get; set; }

            public Client(string id, string name, string datebirth, string phone)
            {
                this.Id = id;
                this.Name = name;
                this.Datebirth = datebirth;
                this.Phone = phone;
            }
        }

        public Clients(Rentals ren)
        {
            InitializeComponent();
            r = ren;

            client = new MongoClient(connectionString);
            db = client.GetDatabase("kurs");
            collection = db.GetCollection<Client>("clients");

            RefreshClients();

            clientDataGrid.Columns["Id"].Visible = false;

            Dictionary<string, string> columnHeaders = new Dictionary<string, string>
            {
                { "Name", "Імя та прізвище клієнта" },
                { "Datebirth", "День народження" },
                { "Phone", "Номер телефону" }
            };

            foreach (var columnHeader in columnHeaders)
            {
                if (clientDataGrid.Columns.Contains(columnHeader.Key))
                {
                    clientDataGrid.Columns[columnHeader.Key].HeaderText = columnHeader.Value;
                }
            }
        }

        public void RefreshClients()
        {
            var clients = collection.Find(new BsonDocument()).ToList();
            clientDataGrid.DataSource = clients;
        }
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