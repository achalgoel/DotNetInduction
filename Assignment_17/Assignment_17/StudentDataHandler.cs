using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Assignment_17
{
    public class StudentDataHandler
    {
        public bool AddStudent(string FirstName,
                                string LastName,
                                int EnrollmentNo,
                                int Class,
                                string Stream,
                                string State)
        {
            int i=0;
            try
            {
                string strConnection = ("Server=localhost;Database=Student;Integrated Security=SSPI");
                SqlConnection con = new SqlConnection(strConnection);
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.CommandText = "INSERT INTO StudentDetails Values('" + FirstName + "','" + LastName + "'," +                       EnrollmentNo + ","+ Class + ",'" + Stream + "','" + State + "')";
                cmd.Connection = con;

                i = cmd.ExecuteNonQuery();
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }


            if(i>0)
                return true;
            else
                return false;

        }
        public bool UpdateStudent(
                                int EnrollmentNo,
                                int Class,
                                string Stream,
                                string State)
        {
            int i = 0;
            try
            {
                string strConnection = ("Server=localhost;Database=Student;Integrated Security=SSPI");
                SqlConnection con = new SqlConnection(strConnection);
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.CommandText = "UPDATE StudentDetails SET Class= " + Class + ",Stream= '" + Stream + "',StudentState= '" + State + "' WHERE EnrollmentNo= "+EnrollmentNo;
                cmd.Connection = con;

                i = cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }


            if (i > 0)
                return true;
            else
                return false;

        }
        public DataSet DisplayStudent(string stream)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string strConnection = ("Server=localhost;Database=Student;Integrated Security=SSPI");
            SqlConnection con = new SqlConnection(strConnection);
            da.SelectCommand = new SqlCommand(@"SELECT * FROM StudentDetails WHERE Stream ="+stream, con);
            da.Fill(ds, "StudentDetails");
            dt = ds.Tables["StudentDetails"];
            return ds;
        }
        
    }
}
