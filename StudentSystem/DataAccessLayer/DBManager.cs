using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace StudentSystem
{
    public class DBManager
    {
        public static MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi387054;uid=dbi387054;password=password;");

        public DBManager()
        {

        }
        public Person[] ReadAll()
        {
            List<Person> people = new List<Person>();

            try
            {
                string sqlStu = "SELECT student.ID, Name, Age, PCN, yearsAtSchool, NumberOfECs FROM student INNER JOIN person ON student.ID = person.ID;";
                MySqlCommand cmdStu = new MySqlCommand(sqlStu, conn);
                string sqlTea = "SELECT teacher.ID, Name, Age, PCN, YearsAtSchool, Salary, Position FROM teacher INNER JOIN person ON teacher.ID = person.ID;";
                MySqlCommand cmdTea = new MySqlCommand(sqlTea, conn);
                conn.Open();

                MySqlDataReader drStu = cmdStu.ExecuteReader();
                
                while (drStu.Read())
                {
                    people.Add(new Student(Convert.ToInt32(drStu[0]), drStu[1].ToString(), Convert.ToInt32(drStu[2]),
                        Convert.ToInt32(drStu[3]), Convert.ToInt32(drStu[4]), Convert.ToInt32(drStu[5])));
                }
                drStu.Close();
                MySqlDataReader drTea = cmdTea.ExecuteReader();
                while (drTea.Read())
                {
                    people.Add(new Teacher(Convert.ToInt32(drTea[0]), drTea[1].ToString(), Convert.ToInt32(drTea[2]),
                        Convert.ToInt32(drTea[3]), Convert.ToInt32(drTea[4]), Convert.ToDouble(drTea[5]), (JobPosition)Enum.Parse(typeof(JobPosition), drTea[6].ToString())));
                }
                drTea.Close();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return people.ToArray();
        }
        public void Insert(Person p)
        {
            try
            {
                if(p is Student student)
                {
                    string sqlStu = "INSERT INTO student (ID, NumberOfECs) VALUES (@ID, @ECs)";
                    MySqlCommand cmdStu = new MySqlCommand(sqlStu, conn);
                    cmdStu.Parameters.AddWithValue("@ID", p.ID);
                    cmdStu.Parameters.AddWithValue("@ECs", student.nrOfECs);

                    string sqlPers = "INSERT INTO person (ID, Name, Age, PCN, YearsAtSchool) VALUES (@ID, @name, @age, @pcn, @years)";
                    MySqlCommand cmdPers = new MySqlCommand(sqlPers, conn);
                    cmdPers.Parameters.AddWithValue("@ID", p.ID);
                    cmdPers.Parameters.AddWithValue("@name", p.Name);
                    cmdPers.Parameters.AddWithValue("@age", p.age);
                    cmdPers.Parameters.AddWithValue("@pcn", p.Pcn);
                    cmdPers.Parameters.AddWithValue("@years", p.yearsAtSchool);

                    conn.Open();

                    cmdStu.ExecuteNonQuery();
                    cmdPers.ExecuteNonQuery();
                }
                else if (p is Teacher teacher)
                {
                    string sqlTea = "INSERT INTO teacher(ID, Position, Salary) VALUES (@ID, @position, @salary)";
                    MySqlCommand cmdTea = new MySqlCommand(sqlTea, conn);
                    cmdTea.Parameters.AddWithValue("@ID", p.ID);
                    cmdTea.Parameters.AddWithValue("@position", teacher.position.ToString());
                    cmdTea.Parameters.AddWithValue("@salary", teacher.salary);

                    string sqlPers = "INSERT INTO person (ID, Name, Age, PCN, YearsAtSchool) VALUES (@ID, @name, @age, @pcn, @years)";
                    MySqlCommand cmdPers = new MySqlCommand(sqlPers, conn);
                    cmdPers.Parameters.AddWithValue("@ID", p.ID);
                    cmdPers.Parameters.AddWithValue("@name", p.Name);
                    cmdPers.Parameters.AddWithValue("@age", p.age);
                    cmdPers.Parameters.AddWithValue("@PCN", p.Pcn);
                    cmdPers.Parameters.AddWithValue("@years", p.yearsAtSchool);

                    conn.Open();
                    cmdTea.ExecuteNonQuery();
                    cmdPers.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
