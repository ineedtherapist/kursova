using System;
using System.Windows.Forms;
using MongoDB.Driver;

namespace kurs
{
    public partial class updateClient : Form
    {
        public Clients cli;
        
        private bool choose;
        
        public Clients.Client updateclient;
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Clients.Client> collection;
        
        
        public updateClient(Clients c, Clients.Client person)
        {
            InitializeComponent();
            cli = c;
            updateclient = person;
            
            string connectionString = "mongodb+srv://v:qwe12@cluster0.fm9se2l.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
            client = new MongoClient(connectionString);
            db = client.GetDatabase("kurs");
            collection = db.GetCollection<Clients.Client>("clients");
            
            ClieNameUpd.Text = updateclient.Name;
            DBClieUpd.Text = updateclient.Datebirth;
            PhoneClieUpd.Text = updateclient.Phone;
        }

        
        private void UpdClieBtn_Click(object sender, EventArgs e)
        {
            string name = ClieNameUpd.Text;
            string datebirth = DBClieUpd.Text;
            string phone = PhoneClieUpd.Text;

            var filter = Builders<Clients.Client>.Filter.Eq(c => c.Id, updateclient.Id);
            var update = Builders<Clients.Client>.Update
                .Set(c => c.Name, name)
                .Set(c => c.Datebirth, datebirth)
                .Set(c => c.Phone, phone);
            
            var updateResult = collection.UpdateOne(filter, update);
        
            if (updateResult.ModifiedCount > 0)
            {
                MessageBox.Show("Дані про клієнта успішно оновлено.");
            }
            else
            {
                MessageBox.Show("Не вдалось оновити дані про клієнта.");
            }
        
            cli.RefreshClients();

            this.Close();

        }
        
        private void DeletClie_Click(object sender, EventArgs e)
        {
            if (updateclient != null)
            {
                if (MessageBox.Show("Ви впевнені, що хочете видалити дані про клієнта?",
                        "Підтвердження видалення",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var filter = Builders<Clients.Client>.Filter.Eq(c => c.Id, updateclient.Id);
                    var deleteResult = collection.DeleteOne(filter);
                
                    if (deleteResult.DeletedCount > 0)
                    {
                        MessageBox.Show("Дані про клієнта успішно видалено.");

                    }
                    else
                    {
                        MessageBox.Show("Не вдалось видалити дані про клієнта.");
                    }

                    cli.RefreshClients();

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Клієнта не вибрано.");
            }
        }
    }
}