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
        public string scor1;
        public string _echipa1, _echipa2;
        public int Id_Echipa1, Id_Echipa2;
        public AfisareScor(string _echipa1,string _echipa2,int Id_Echipa1,int Id_Echipa2)
        {

            InitializeComponent();

            SimulareMeci m = new SimulareMeci();
            Tuple<int, int> result = m.ScorRandom();
          
            AfisareScor1(result.Item1, result.Item2,_echipa1,_echipa2,Id_Echipa1,Id_Echipa2);

            int Item1Result = result.Item1;

            List<DateMarcator> item = new List<DateMarcator>();
           
            for (int x = 1; x <= Item1Result; x++)
            {
                Marcator M = new Marcator();
                var t1= M.Jucatori(Id_Echipa1, Id_Echipa2);

                item.Add(t1);
            }

            listBox2.DataSource = item;

            int ItemResultEchipa2 = result.Item2;
            List<DateMarcator> itemEchipa2 = new List<DateMarcator>();

            for (int x = 1; x <= ItemResultEchipa2; x++)
            {
                Marcator M = new Marcator();
                var t1 = M.Jucatori(Id_Echipa1, Id_Echipa2);

                itemEchipa2.Add(t1);
            }

            listBox3.DataSource = itemEchipa2;
        }

        private void PornesteUnMeci_Load(object sender, EventArgs e)
        {


        }

        public void AfisareScor1(int index, int index1,string _echipa1,string _echipa2,int Id_Echipa1,int Id_Echipa2)
        {
             scor1 = index + " - " + index1;
            List<string> _items = new List<string>();

            string NumeEchipa1 = _echipa1;
            string NumeEchipa2 = _echipa2;
            _items.Add(NumeEchipa1);
            _items.Add("  ");
            _items.Add("  ");
            _items.Add(NumeEchipa2);
            _items.Add("  ");
            _items.Add("  ");
            _items.Add(scor1);
            listBox1.DataSource = _items;
            SalveazaMeci save = new SalveazaMeci(scor1, _echipa1, _echipa2, Id_Echipa1, Id_Echipa2);

        }

       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
