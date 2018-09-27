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

namespace WindowsFormsApp1
{
    public partial class Transfer : Form
    {

        private int _selectedIdJucator;
        private int _selectedIdEchipa;

        public Transfer()
        {
            InitializeComponent();
            DbOperations op = new DbOperations();
            var list = op.DbListaEchipe();
            comboBox2.DataSource = list;

            TransferDBOP tr = new TransferDBOP();
            var listTransfer = tr.TransferDB();
            comboBox1.DataSource = listTransfer;

        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedIdJucator = (comboBox1.SelectedItem as Jucator).Id_Jucator;
        }
        public void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _selectedIdEchipa = (comboBox2.SelectedItem as Echipa).ID_Echipa;
        }
        private void RenuntaButtonTransfer(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButtonTransfer(object sender, EventArgs e)
        {
            SaveLaTransfer Tr = new SaveLaTransfer();
            Tr.SaveLaTransferJucator(_selectedIdEchipa, _selectedIdJucator);
            this.Close();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }
    }
}
