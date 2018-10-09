using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SalveazaMeci
    {
        public SalveazaMeci(string Scor, string Echipa1,string Echipa2, int ID_Echipa1,int ID_Echipa2)
        {
            string ConnectionString = "Data Source=STSCV-01W028BIS;Initial Catalog=FifaManager;Integrated Security=True";

            string querry = "insert into Meci(Scor_meci,Echipa1,Echipa2,Id_Echipa1,Id_Echipa2) VALUES (@Scor,@Echipa1,@Echipa2,@ID_Echipa1,@ID_Echipa2)";


            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);

            SqlParameter param = new SqlParameter("@Scor", SqlDbType.VarChar); param.Value = Scor; cmd.Parameters.Add(param);
            SqlParameter param1 = new SqlParameter("@Echipa1", SqlDbType.VarChar); param1.Value = Echipa1; cmd.Parameters.Add(param1);
            SqlParameter param2 = new SqlParameter("@Echipa2", SqlDbType.VarChar); param2.Value = Echipa2; cmd.Parameters.Add(param2);
            SqlParameter param3 = new SqlParameter("@ID_Echipa1", SqlDbType.VarChar); param3.Value = ID_Echipa1; cmd.Parameters.Add(param3);
            SqlParameter param4 = new SqlParameter("@ID_Echipa2", SqlDbType.VarChar); param4.Value = ID_Echipa2; cmd.Parameters.Add(param4);

            cmd.ExecuteNonQuery();
            
        }

    }
}
