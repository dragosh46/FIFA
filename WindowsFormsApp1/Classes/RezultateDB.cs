using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class RezultateDB
    {

        public List<Rezultate> Rezultatele(int _id_Echipa1, int _id_Echipa2)
        {
            SqlConnection conn = new SqlConnection();

            SqlCommand cmd = default(SqlCommand);

            conn.ConnectionString = "Data Source=STSCV-01W028BIS;Initial Catalog=FifaManager;Integrated Security=True";
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;

            SqlParameter param = new SqlParameter("@IdEchipa1", SqlDbType.VarChar); param.Value = _id_Echipa1; cmd.Parameters.Add(param);
            SqlParameter param1 = new SqlParameter("@IdEchipa2", SqlDbType.VarChar); param1.Value = _id_Echipa2; cmd.Parameters.Add(param1);
            cmd.CommandText = @"select Scor_meci from Meci where @IdEchipa1 = Id_Echipa1 And @IdEchipa2 = Id_Echipa2";
            cmd.ExecuteNonQuery();
            List<Rezultate> rez = new List<Rezultate>();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Rezultate r = new Rezultate();
                    r.NumeEchipa1 = dr.GetString(0);
                    r.NumeEchipa2 = dr.GetString(1);
                    rez.Add(r);
                }
            }

            return rez;
        }
    }
}

