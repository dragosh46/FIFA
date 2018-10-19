using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Marcator
    {

        public DateMarcator Jucatori(int _id_Echipa1, int _id_Echipa2)
        {
            SqlConnection conn = new SqlConnection();

            SqlCommand cmd = default(SqlCommand);

            conn.ConnectionString = "Data Source=STSCV-01W028BIS;Initial Catalog=FifaManager;Integrated Security=True";
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;

            SqlParameter param = new SqlParameter("@IdEchipa1", SqlDbType.VarChar); param.Value = _id_Echipa1; cmd.Parameters.Add(param);
            SqlParameter param1 = new SqlParameter("@IdEchipa2", SqlDbType.VarChar); param1.Value = _id_Echipa2; cmd.Parameters.Add(param1);
            cmd.CommandText = @"select nume,prenume from JUCATOR where ID_Echipa IN (@IdEchipa1,@IdEchipa2)";
            cmd.ExecuteNonQuery();
            List<DateMarcator> rez = new List<DateMarcator>();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    DateMarcator r = new DateMarcator();
                    r.Nume = dr.GetString(0) +" "+ dr.GetString(1);
                   
                    rez.Add(r);
                }
            }

                var random = new Random();
                
                int index = random.Next(rez.Count);
            var t1 = rez[index];


            return t1;
        }

       

    }
}
