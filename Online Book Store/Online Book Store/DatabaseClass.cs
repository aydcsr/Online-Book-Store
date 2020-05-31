using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store
{
    class DatabaseClass
    {
        private static SqlConnection con;
        private static DatabaseClass obj;
        //singleton tasarım kalıbı.
        private DatabaseClass(){}
        public static DatabaseClass createConnection(string databaseName)
        {
            con = new SqlConnection("Data Source=.; Initial Catalog=" + databaseName + "; Integrated Security=true");
            if (obj == null)
                obj = new DatabaseClass();
            return obj;
        }
        public void insertLog(LogClass log)
        {
            con.Open();
            string sorgu = "insert into LogTable (customerId,butonName,formName,date) values ('" + log.Customerid + "','" + log.BtnName + "','" + log.FrmName + "','" + log.Date + "'";
            SqlCommand cmd = new SqlCommand(sorgu, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable getData(string columnName,string tableName)
        {
            con.Open();
            DataTable table = new DataTable();
            string query = "SELECT "+ columnName+" FROM "+tableName;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            con.Close();
            return table;
        }
        public DataTable getData(string query)
        {
            con.Open();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            con.Close();
            return table;
        }
        public void insertData(string tableName,string columnName,string values)
        {
            con.Open();
            string sorgu = "insert into " + tableName + " (" + columnName + ")" + "values (" + values + ")";
            SqlCommand cmd = new SqlCommand(sorgu,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateData(string tableName,string columns,string values,string condition)
        {
            string queryValues=null;
            string[] columnNames = columns.Split(',');
            string[] columnValues = values.Split(',');
            if(columnNames.Length!=columnValues.Length) 
                return;
            con.Open();
            int i = 0;
            foreach (string item in columnNames)
            {
                if (queryValues != null)
                    queryValues += ',';
                queryValues += item + "=" + columnValues[i++];
            }
            string query = "UPDATE " + tableName + " SET " + queryValues + " WHERE " + condition;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void deleteData(string tableName,string condition)
        {
            con.Open();
            string query = "update " + tableName + " set visibility =0 where " + condition;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
