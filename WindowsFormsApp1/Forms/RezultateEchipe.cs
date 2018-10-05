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

        public RezultateEchipe()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RezultateDB Rez = new RezultateDB();
            Rez.Rezultatele(_id_Echipa1, _id_Echipa2);
        }
    }
}
