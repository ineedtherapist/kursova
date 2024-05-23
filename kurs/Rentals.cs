using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace kurs
{
    public partial class Rentals : Form
    {
        public Enter en;
        
        private bool choose;

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
            public string Price { get; set; }
            public string Date_start { get; set; }
            public string Date_end { get; set; }

            public Rental(string id, string instName, string clientName, string price, string date_start, string date_end)
            {
                this.Id = id;
                this.InstName = instName;
                this.ClientName = clientName;
                this.Price = price;
                this.Date_start = date_start;
                this.Date_end = date_end;
            }
            
        }

        public Rentals(Enter e , Instruments inst, Clients clie)
        {
            InitializeComponent();
            en = e;
            
            client = new MongoClient(connectionString);
            db = client.GetDatabase("kurs");
            collection = db.GetCollection<Rental>("rentals");
            
            RefreshRentals();

            rentalDataGrid.Columns["Id"].Visible = false;

            Dictionary<string, string> columnHeaders = new Dictionary<string, string>
            {
                { "ClientName", "Ім'я клієнта" },
                { "InstName", "Назва інструмента" },
                { "Price", "Ціна за місяць"},
                { "Date_start", "Початок оренди" },
                { "Date_end", "Кінець оренди" }
            };

            foreach (var columnHeader in columnHeaders)
            {
                if (rentalDataGrid.Columns.Contains(columnHeader.Key))
                {
                    rentalDataGrid.Columns[columnHeader.Key].HeaderText = columnHeader.Value;
                }
            }
        }
        
        public void RefreshRentals()
        {
            var rentals = collection.Find(new BsonDocument()).ToList();
            rentalDataGrid.DataSource = rentals;
        }

        private void rentalDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    var updaterental = rentalDataGrid.Rows[e.RowIndex].DataBoundItem as Rental;
                    updateRental uc = new updateRental(this, updaterental);
                    uc.ShowDialog();
                    RefreshRentals();
                }
            }
            
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

        private void addRentalBtn_Click(object sender, EventArgs e)
        {
            addRental re = new addRental(this);
            re.ShowDialog();
        }
        
    }
}