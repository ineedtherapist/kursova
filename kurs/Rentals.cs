using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace kurs
{
    public partial class Rentals : Form
    {
        public enter en;
        
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Rental> collection;
        
        const string connectionString = "mongodb+srv://viktor:<password>@clustr.sc8jicj.mongodb.net/?retryWrites=true&w=majority&appName=clustr";
        

        public class Rental
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string Id { get; set; }
            
            public string InstName { get; set; }
            public string ClientName { get; set; }
            public string Date_start { get; set; }
            public string Data_end { get; set; }

            public Rental(string id, string instName, string clientName, string date_start, string data_end)
            {
                this.Id = id;
                this.InstName = instName;
                this.ClientName = clientName;
                this.Date_start = date_start;
                this.Data_end = data_end;
            }
        }
        public Rentals(enter e)
        {
            en = e;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        
    }
}