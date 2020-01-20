using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerProject
{
    public class DataLayerClass
    {
        public static DataSet RetrievePatientInformation()              //Business Layer Calls this method
        {
            SqlConnection ConnectiontoDB;       //Database Connection object
            string sqlQuery = null;             //Query String object
            SqlCommand sqlCommand;              //Read Command object
            SqlDataReader sqlDataReader;        //Data Cache for the Data read from Command

            DataTable dataTable = new DataTable();      //Database Table equivalent
            DataSet dataSet = new DataSet();            //Database view created from different tables equivalent

            var connectionString = ConfigurationManager.ConnectionStrings["RetrievePatientInformationConnection"].ConnectionString;
            ConnectiontoDB = new SqlConnection(connectionString);
            sqlQuery = "Select * from Patient_Details";

            ConnectiontoDB.Open();                //Connection to Database Opened

            sqlCommand = new SqlCommand(sqlQuery, ConnectiontoDB);      //Creating an object for the command

            sqlDataReader = sqlCommand.ExecuteReader();                 //Initializing Data Read

            dataTable.Load(sqlDataReader);      //Loading Data into table object

            dataSet.Tables.Add(dataTable);      //Add Additional tables to the Dataset

            sqlDataReader.Close();              //Terminating Data Read

            sqlCommand.Dispose();               //Clearing the SQL Command Details/Settings

            ConnectiontoDB.Close();               //Connection to Database Closed

            return dataSet;                     //Return Dataset to the Business Layer
        }
    }
}
