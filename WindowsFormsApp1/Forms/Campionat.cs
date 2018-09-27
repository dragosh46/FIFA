using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Campionat : Form
    {
        private string _echipa1;
        private int _id_Echipa1;

        public Campionat()
        {
            InitializeComponent();

            DbOperations op = new DbOperations();
            var list = op.DbListaEchipe();
            listBox1.DataSource = list;
            var list1 = op.DbListaEchipe();
            listBox2.DataSource = list1;
        }

        private void Campionat_Load(object sender, EventArgs e)
        {
            _id_Echipa1 = (listBox2.SelectedItem as Echipa).ID_Echipa;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
           _echipa1=(listBox1.SelectedItem as Echipa).Nume;
        }
    }
}
