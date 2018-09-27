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
    public partial class AdaugaEchipaForm : Form
    {
        public AdaugaEchipaForm()
        {
            InitializeComponent();
        }
       
        private void AdaugaEchipa_Load(object sender, EventArgs e)
        {

        }
        public void DbConnectionEchipa()
        {
            string ConnectionString = "Data Source=STSCV-01W028BIS;Initial Catalog=FifaManager;Integrated Security=True";

            string querry = "insert into ECHIPA(nume,an,imn,liga,nu_jucatori) values (@Nume,@An,@Imn,@Liga,@NumarJucatori)";

            System.Data.SqlClient.SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);


            SqlParameter param = new SqlParameter("@Nume", SqlDbType.VarChar); param.Value = textBox1.Text; cmd.Parameters.Add(param);
            SqlParameter param1 = new SqlParameter("@An", SqlDbType.VarChar); param1.Value = textBox2.Text; cmd.Parameters.Add(param1);
            SqlParameter param3 = new SqlParameter("@Imn", SqlDbType.VarChar); param3.Value = textBox4.Text; cmd.Parameters.Add(param3);
            SqlParameter param4 = new SqlParameter("@Liga", SqlDbType.VarChar); param4.Value = textBox3.Text; cmd.Parameters.Add(param4);
            SqlParameter param5 = new SqlParameter("@NumarJucatori", SqlDbType.VarChar); param5.Value = textBox5.Text; cmd.Parameters.Add(param5);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Echipa salvata cu succes!");
            this.Close();
        }

        private void SaveButtonJucator(object sender, EventArgs e)
        {
            string An = textBox2.Text;
            string Nume = textBox1.Text;
            string Liga = textBox3.Text;
            string NumarJucatori = textBox5.Text;
            string Imn = textBox4.Text;
            DbConnectionEchipa();



        }

        private void RenuntaButtonJucator(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
