using System;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.SystemData
{
    public class Main
    {
        private OleDbConnection _connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Projects\CSharpCourse\CSharpCourse\CSharpCourse.SystemData\SampleDatabase.accdb;Persist Security Info=False;");

        private void Connect()
        {
            OleDbTransaction transaction = null;
            try
            {
                _connection.Open();
                transaction = _connection.BeginTransaction();

                OleDbCommand command = new OleDbCommand("INSERT INTO Clients (Id , Name) VALUES (@id, @name)", _connection, transaction);

                command.Parameters.Add(new OleDbParameter("@id", 1));
                command.Parameters.Add(new OleDbParameter("@name", "Pepe"));

                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }                        
        }

        private void Select()
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT Id,Name FROM Clients", _connection);

            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            var id = (int)ds.Tables["Clients"].Rows[0]["Id"];
                                   
            OleDbCommand command = new OleDbCommand("Select Id,Name From Clients", _connection);
            OleDbDataReader dataReader = command.ExecuteReader();

            var table = dataReader.GetSchemaTable();
            
            while(dataReader.Read())
            {
                string name = dataReader.GetString(dataReader.GetOrdinal("Name"));
            }

        }
                                          
        //OleDbConnection

        //OleDbCommand

        //OleDbDataAdapter
        //OleDbDataReader

        //OleDbTransaction
    }
}
