using DBLayer;
using EvaluationManagerV2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationManagerV2.Repositories
{
    public static class StudentRepository
    {
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            string sql = "SELECT * FROM Students";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Student student = CreateObject(reader);
                students.Add(student);
            }

            reader.Close();
            DB.CloseConnection();

            return students;
        }

        private static Student CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            int grade;
            int.TryParse(reader["Grade"].ToString(), out grade);

            var student = new Student
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Grade = grade
            };
            return student;
        }
    }
}
