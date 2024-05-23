using System;
using System.Windows.Forms;
using MongoDB.Driver;

namespace kurs
{
    public partial class updateInstrument : Form
    {
        public Instruments inst;
        
        private bool choose;
        
        public Instruments.Instrument updateinstrument;
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Instruments.Instrument> collection;
        
        public updateInstrument(Instruments i, Instruments.Instrument person)
        {
            InitializeComponent();
            inst = i;
            updateinstrument = person;
            
            string connectionString = "mongodb+srv://v:qwe12@cluster0.fm9se2l.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
            client = new MongoClient(connectionString);
            db = client.GetDatabase("kurs");
            collection = db.GetCollection<Instruments.Instrument>("instruments");
            
            InstrNameUpd.Text = updateinstrument.InstName;
            DescInstrUpd.Text = updateinstrument.Desc;
            PriceInstrUpd.Text = updateinstrument.Price;
        }

        private void UpdinstBtn_Click(object sender, EventArgs e)
        {
            string instName = InstrNameUpd.Text;
            string desc = DescInstrUpd.Text;
            string price = PriceInstrUpd.Text;

            var filter = Builders<Instruments.Instrument>.Filter.Eq(c => c.Id, updateinstrument.Id);
            var update = Builders<Instruments.Instrument>.Update
                .Set(c => c.InstName, instName)
                .Set(c => c.Desc, desc)
                .Set(c => c.Price, price);
            
            var updateResult = collection.UpdateOne(filter, update);
        
            if (updateResult.ModifiedCount > 0)
            {
                MessageBox.Show("Дані про клієнта успішно оновлено.");
            }
            else
            {
                MessageBox.Show("Не вдалось оновити дані про клієнта.");
            }
        
            inst.RefreshInstruments();

            this.Close();
        }

        private void Deletinst_Click(object sender, EventArgs e)
        {
            if (updateinstrument != null)
            {
                if (MessageBox.Show("Ви впевнені, що хочете видалити дані про інструмента?",
                        "Підтвердження видалення",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var filter = Builders<Instruments.Instrument>.Filter.Eq(c => c.Id, updateinstrument.Id);
                    var deleteResult = collection.DeleteOne(filter);
                
                    if (deleteResult.DeletedCount > 0)
                    {
                        MessageBox.Show("Дані про інструмент успішно видалено.");

                    }
                    else
                    {
                        MessageBox.Show("Не вдалось видалити дані про інструмента.");
                    }

                    inst.RefreshInstruments();

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("інструмент не вибрано.");
            }
        }
    }
}