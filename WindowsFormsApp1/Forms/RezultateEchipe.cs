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
    public partial class RezultateEchipe : Form
    {
        private int _id_Echipa1;
        private int _id_Echipa2;

        public RezultateEchipe(int _id_Echipa1,int _id_Echipa2)
        {
            InitializeComponent();
            RezultateDB Rez = new RezultateDB();
           
           
            var list = Rez.Rezultatele(_id_Echipa1, _id_Echipa2);
            listBox1.DataSource = list;
            Marcator Mar = new Marcator();
            
            var dateMarcator= Mar.Jucatori(_id_Echipa1, _id_Echipa2);
            listBox2.Items.Add(dateMarcator);
         
        }

     
        private void RezultateEchipe_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
