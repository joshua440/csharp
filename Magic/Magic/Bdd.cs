using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic
{
    static class Bdd
    {
        private static SqlConnection connection = new SqlConnection();

        public static void addBdd(String conexion)
        {
            connection.ConnectionString = conexion;
        }

        public static int selectScalar(String select)
        {
            int answer=0;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = select;
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            answer = (int)command.ExecuteScalar();
            connection.Close();
            return answer;
        }

        public static ArrayList selectColsReader(String select)
        {
            SqlDataReader table;
            ArrayList cols=new ArrayList();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = select;
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            table = command.ExecuteReader(CommandBehavior.Default);
            while (table.Read())
            {
                cols.Add( new Card(table.GetString(0), table.GetString(3)) );
            }
            connection.Close();
            return cols;
        }

    }
}
