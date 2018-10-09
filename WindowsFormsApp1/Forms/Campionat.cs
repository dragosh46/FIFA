using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Forms
{
    public partial class Campionat : Form
    {
        private string _echipa1;
        private string _echipa2;
        private int _id_Echipa1;
        private int _id_Echipa2;

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
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _id_Echipa1 = (listBox1.SelectedItem as Echipa).ID_Echipa;
            _echipa1 = (listBox1.SelectedItem as Echipa).Nume;
        }

        private void ArataUltimeleRezultateBTN(object sender, EventArgs e)
        {
            try
            {
                RezultateDB Rez = new RezultateDB();
               Rez.Rezultatele(_id_Echipa1, _id_Echipa2);
            

                RezultateEchipe r = new RezultateEchipe(_id_Echipa1, _id_Echipa2);
                r.ShowDialog(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _id_Echipa2 = (listBox2.SelectedItem as Echipa).ID_Echipa;
            _echipa2 = (listBox2.SelectedItem as Echipa).Nume;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AfisareScor p = new AfisareScor(_echipa1,_echipa2);
            p.ShowDialog(this);
        }
    }
}
