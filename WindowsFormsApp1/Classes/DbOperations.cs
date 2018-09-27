using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DbOperations
    {
        public List<Echipa> DbListaEchipe()
        {
            string ConnectionString = "Data Source=STSCV-01W028BIS;Initial Catalog=FifaManager;Integrated Security=True";

            string querry = "select ID_Echipa,nume from Echipa ";

            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            List<Echipa> echipe = new List<Echipa>();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Echipa text = new Echipa();
                    text.Nume = dr.GetString(1);
                    text.ID_Echipa = dr.GetInt32(0);
                    echipe.Add(text);
                }
            }
            return echipe;
        }
    }
}
