using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        
       
        }

        private void AdaugaJucator(object sender, EventArgs e)
        {
           
            
            try
            {

                DbOperations lista = new DbOperations();

                AdaugaJucatorForm f = new AdaugaJucatorForm();
                f.ShowDialog(this);

                List<Jucator> Jucatori = new List<Jucator>();
                Jucator j1 = new Jucator();
                Jucatori.Add(j1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }


        private void AdaugaEchipa(object sender, EventArgs e)
        {
            try
            {
                AdaugaEchipaForm echipa = new AdaugaEchipaForm();
                echipa.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TransferaJucator(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.ShowDialog(this);

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

      

       
    }
    public class Jucator
    {
        public int Id_Jucator { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int NrTricou { get; set; }
        public int Varsta { get; set; }
        public string PicoirDeBaza { get; set; }

    }
    public class Echipa
    {
        public int ID_Echipa { get; set; }
        public string Nume { get; set; }
        public int An { get; set; }
        public string Imn { get; set; }
        public int Liga { get; set; }
        public int NrJucatori { get; set; }

    }
}
