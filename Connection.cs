using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProiectII
{
    class Connection
    {
        SqlConnection con;
        string connectionString = "Data Source=DESKTOP-50EC7V7;Initial Catalog=DentalApp1;Integrated Security=True";

        //raul:   ROG-GL703GM
        //adelin: DESKTOP-50EC7V7
        //iulian: DESKTOP-1LEIQIA

        public bool Open()
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show("Connection error!"+ex.Message,"Information");
            }
            return false;
        }

        public void Close()
        {
            con.Close();
            con.Dispose();
        }

        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet dataSet = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql,con);
                sqlDataAdapter.Fill(dataSet, "result");
                return dataSet;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public SqlDataReader ExecuteReader(string sql)
        {
            try
            {
                SqlDataReader reader;
                SqlCommand cmd = new SqlCommand(sql,con);
                reader = cmd.ExecuteReader();
                return reader;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                SqlTransaction sqlTransaction = con.BeginTransaction();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                sqlTransaction.Commit();
                return affected;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
    }
}
