using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TransferDBOP
    {
        public List<Jucator> TransferDB()
        {
            string ConnectionString = "Data Source=STSCV-01W028BIS;Initial Catalog=FifaManager;Integrated Security=True";

            string querry = "select ID_Jucator,nume,prenume from Jucator ";

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            List<Jucator> jucatori = new List<Jucator>();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Jucator text = new Jucator();
                    text.Nume = dr.GetString(1);
                    text.Id_Jucator = dr.GetInt32(0);
                    jucatori.Add(text);
                }
            }
            return jucatori;
        }
    }
}
