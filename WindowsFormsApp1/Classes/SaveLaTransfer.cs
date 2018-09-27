using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class SaveLaTransfer
    {
        public void SaveLaTransferJucator(int _selectedIdEchipa, int _selectedIdJucator)
        {

            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand cmd = default(SqlCommand);

                conn.ConnectionString = "Data Source=STSCV-01W028BIS;Initial Catalog=FifaManager;Integrated Security=True";
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlParameter param = new SqlParameter("@IdEchipa", SqlDbType.VarChar); param.Value = _selectedIdEchipa; cmd.Parameters.Add(param);
                SqlParameter param1 = new SqlParameter("@IdJucator", SqlDbType.VarChar); param1.Value = _selectedIdJucator; cmd.Parameters.Add(param1);
                cmd.CommandText = @"Update Jucator set Id_Echipa= @IdEchipa where ID_JUCATOR=@IdJucator";
                cmd.ExecuteNonQuery();
            }
        }
        
    }
   
}
