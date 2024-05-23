using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace kurs
{
    public partial class Instruments : Form
    {
        public Rentals r;
        
        private bool choose;
        
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Instrument> collection;
        
        public event EventHandler<InstrSelectedEventArgs> InstrSelected; 

        const string connectionString = "mongodb+srv://v:qwe12@cluster0.fm9se2l.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

        public class Instrument
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string Id { get; set; }
            public string InstName { get; set; }
            public string Desc { get; set; }
            public string Price { get; set; }

            public Instrument(string id, string instName, string desc, string price)
            {
                this.Id = id;
                this.InstName = instName;
                this.Desc = desc;
                this.Price = price;
            }
        }

        public Instruments(Rentals ren)
        {
            InitializeComponent();
            r = ren;
            
            this.choose = choose;

            client = new MongoClient(connectionString);
            db = client.GetDatabase("kurs");
            collection = db.GetCollection<Instrument>("instruments");

            RefreshInstruments();

            instrDataGrid.Columns["Id"].Visible = false;

            Dictionary<string, string> columnHeaders = new Dictionary<string, string>
            {
                { "InstName", "Назва інструмента" },
                { "Desc", "Опис" },
                { "Price", "Ціна за місяць" }
            };

            foreach (var columnHeader in columnHeaders)
            {
                if (instrDataGrid.Columns.Contains(columnHeader.Key))
                {
                    instrDataGrid.Columns[columnHeader.Key].HeaderText = columnHeader.Value;
                }
            }
        }

        public void RefreshInstruments()
        {
            var instruments = collection.Find(new BsonDocument()).ToList();
            instrDataGrid.DataSource = instruments;
        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rentals r = new Rentals(null, this, null);
            r.Show();
        }
        

        private void btnAddInstr_Click(object sender, EventArgs e)
        {
            addInstrument aI = new addInstrument(this);
            aI.ShowDialog();
        }
        

        private void instrDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (choose == false)
            {
                if (e.RowIndex >= 0)
                {
                    var updateinstrument = instrDataGrid.Rows[e.RowIndex].DataBoundItem as Instrument;
                    updateInstrument uc = new updateInstrument(this, updateinstrument);
                    uc.ShowDialog();
                    RefreshInstruments();
                }
            }
            else
            {
                if (instrDataGrid.CurrentRow != null)
                {
                    string instName = instrDataGrid.CurrentRow.Cells["InstName"].Value.ToString();
            
                    InstrSelected?.Invoke(this, new InstrSelectedEventArgs(instName));

                    this.Close();
                }  
            }
        }
    }
}

public class InstrSelectedEventArgs : EventArgs
{
    public string SelectedInstrName { get; set; }

    public InstrSelectedEventArgs(string name)
    {
        SelectedInstrName = name;
    }
}