using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;

namespace DBAutomationTesting
{
    [TestClass]
    public class DBTesting
    {
        [TestMethod]
        public void insertRecords()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=(localdb)\MSSQLLocalDB; Database = DBAutomation; Trusted_Connection = True";
            conn.Open();

            SqlCommand insertComand = new SqlCommand("INSERT INTO Columns(FirstColumn,SecondColumn,ThirdColumn,FourthColumn) VALUES (@0,@1,@2,@3)", conn);
            insertComand.Parameters.Add(new SqlParameter("0", "5"));
            insertComand.Parameters.Add(new SqlParameter("1", "TestColumn4"));
            insertComand.Parameters.Add(new SqlParameter("2", "DateTime.Now"));
            insertComand.Parameters.Add(new SqlParameter("3", "0"));
            int rows = insertComand.ExecuteNonQuery();
            Assert.AreEqual(1, rows);

        }
    }
}
