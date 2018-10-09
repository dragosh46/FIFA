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
    public partial class AfisareScor : Form
    {

        public AfisareScor(string _echipa1,string _echipa2)
        {

            InitializeComponent();

            SimulareMeci m = new SimulareMeci();
            Tuple<int, int> result = m.ScorRandom();
          
            AfisareScor1(result.Item1, result.Item2,_echipa1,_echipa2);
        }

        private void PornesteUnMeci_Load(object sender, EventArgs e)
        {


        }

        public void AfisareScor1(int index, int index1,string _echipa1,string _echipa2)
        {
            string scor1 = index + " - " + index1;
            List<string> _items = new List<string>();
           
            string NumeEchipe = _echipa1 + " - " + _echipa2;
            _items.Add(NumeEchipe);
            _items.Add(scor1);
            listBox1.DataSource = _items;


        }

       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
