using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace PlayersManagerLib
{
    public interface IPlayerMapper
    {
        bool IsPlayerNameExistsInDb(string name);
        void AddNewPlayerIntoDb(string name);
    }
    public class PlayerMapper:IPlayerMapper
    {
        private readonly string _connectionString = "Data Source=DESKTOP-DJ3D3T0\\SQLSERVER;Initial Catalog=GameDB;Integrated Security=True";
        public virtual bool IsPlayerNameExistsInDb(string name)
        {
            using(SqlConnection conn=new SqlConnection(_connectionString))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select count(*) from player where Name=@name";
                    cmd.Parameters.AddWithValue("@name", name);
                    var existingPlayersCount = (int)cmd.ExecuteScalar();
                    return existingPlayersCount > 0;
                }
            }
        }
        public void AddNewPlayerIntoDb(string name)
        {
            using(SqlConnection conn=new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into Player ([Name]) values (@name)";
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
