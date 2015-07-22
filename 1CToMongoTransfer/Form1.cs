using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoWork;
using WebService1C;

namespace _1CToMongoTransfer
{
    public partial class Form1 : Form
    {public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data1CToMongoDbTransfer transfer = new Data1CToMongoDbTransfer();
            DataFactory1C factory1C = new DataFactory1C();
            MongoWork.MongoDbInitializer dbInitializer = new MongoDbInitializer();
            dbInitializer.ConnectToDb();
            dbInitializer.InitDatabase();

            MongoDbConnector connector = new MongoDbConnector(dbInitializer.GetDbConnection());
            transfer.TransferData(factory1C, connector);
            


        }
    }
}
