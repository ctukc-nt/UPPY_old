using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using Core.Interfaces;
using MongoWork;
using WebService1C;

namespace _1CToMongoTransfer
{
    public partial class Form1 : Form
    {
        private readonly IDataManagerFactory dmFactory;

        public Form1(IDataManagerFactory factory)
        {
            InitializeComponent();
            dmFactory = factory;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Data1CToMongoDbTransfer transfer = new Data1CToMongoDbTransfer();
            DataFactory1C factory1C = new DataFactory1C();

            transfer.TransferData(factory1C, dmFactory);
            


        }
    }
}
