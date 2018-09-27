using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdaugaJucatorForm : Form
    {

        public AdaugaJucatorForm()
        {
            InitializeComponent();

            DbOperations op = new DbOperations();
            var list = op.DbListaEchipe();
            comboBox1.DataSource = list;
        }


        private void RenuntaButtonJucator(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButtonJucator(object sender, EventArgs e)
        {
            string Id_Echipa = comboBox1.Text;
            string Prenume = textBox2.Text;
            string Nume = textBox1.Text;
            string NumarTricou = textBox3.Text;
            string Varsta = textBox5.Text;
            string PiciorDeBaza = textBox4.Text;


            DbConnection();
        }

        public void DbConnection()
        {
            string ConnectionString = "Data Source=STSCV-01W028BIS;Initial Catalog=FifaManager;Integrated Security=True";

            string querry = "insert into JUCATOR(ID_Echipa,nume,prenume,numar_tricou,varsta,picioar_de_baza,nume_echipa) values (@Id_Echipa,@Nume,@Prenume,@NumarTricou,@Varsta,@PiciorDeBaza,@Echipa)";

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);


            SqlParameter param = new SqlParameter("@Nume", SqlDbType.VarChar); param.Value = textBox1.Text; cmd.Parameters.Add(param);
            SqlParameter param1 = new SqlParameter("@Prenume", SqlDbType.VarChar); param1.Value = textBox2.Text; cmd.Parameters.Add(param1);
            SqlParameter param3 = new SqlParameter("@NumarTricou", SqlDbType.VarChar); param3.Value = textBox3.Text; cmd.Parameters.Add(param3);
            SqlParameter param4 = new SqlParameter("@Varsta", SqlDbType.VarChar); param4.Value = textBox5.Text; cmd.Parameters.Add(param4);
            SqlParameter param5 = new SqlParameter("@PiciorDeBaza", SqlDbType.VarChar); param5.Value = textBox4.Text; cmd.Parameters.Add(param5);
            SqlParameter param6 = new SqlParameter("@Echipa", SqlDbType.VarChar); param6.Value = comboBox1.Text; cmd.Parameters.Add(param6);
            SqlParameter param7 = new SqlParameter("@Id_Echipa", SqlDbType.Int); param7.Value = (comboBox1.SelectedItem as Echipa).ID_Echipa; cmd.Parameters.Add(param7);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Jucator salvat cu succes!");
            this.Close();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
