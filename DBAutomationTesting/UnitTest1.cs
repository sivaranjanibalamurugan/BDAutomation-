/*
    ** Project = validation for  DBAutomation
    ** Author = Siva Ranjani.B
    ** Created Date = 19/08/2021
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DBAutomationTesting
{
    [TestClass]
    public class DBTesting
    {
        SqlConnection conn = new SqlConnection();
        [TestInitialize]
        public void setup()
        {
            conn.ConnectionString = @"Server=(localdb)\MSSQLLocalDB; Database = DBAutomation; Trusted_Connection = True";
        }
       
        [TestMethod]
        public void RetreivedRecord()
        {
            conn.Open();
           
            
            SqlCommand command = new SqlCommand("SELECT TOP(1)  [FirstColumn] FROM  DBAutomation  ", conn);
            SqlCommand command1 = new SqlCommand("Select * from  Columns", conn);
            SqlDataReader reader1;
            reader1 = command1.ExecuteReader();
            Assert.AreEqual(-1, reader1.RecordsAffected);
        }
        
        [TestMethod]
        public void insertRecords()
        {
            conn.Open();
           

            SqlCommand insertComand3 = new SqlCommand("INSERT INTO Columns(FirstColumn,SecondColumn,ThirdColumn,FourthColumn) VALUES (@0,@1,@2,@3)", conn);
            insertComand3.Parameters.Add(new SqlParameter("0", "3"));
            insertComand3.Parameters.Add(new SqlParameter("1", "TestColumn4"));
            insertComand3.Parameters.Add(new SqlParameter("2", DateTime.Now));
            insertComand3.Parameters.Add(new SqlParameter("3", "0"));

            
            int rows = insertComand3.ExecuteNonQuery();
            Assert.AreEqual(1, rows);
        

        }
        
    }
}

