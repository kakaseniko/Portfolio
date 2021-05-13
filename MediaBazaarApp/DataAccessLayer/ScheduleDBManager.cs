using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulesAndInterfaces;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    [Serializable]
    public class ScheduleDBManager
    {
        public static MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi387054;uid=dbi387054;password=password;");
        EmployeeDBManager edbm = new EmployeeDBManager();

        public void InsertToDB(Shift s)
        {
            try
            {
                
                string sqlShift = "INSERT INTO `shift`(`ShiftNumber`, `Date`, `Department`, `ShiftType`) VALUES (@shiftnumber, @date,@department,@shifttype)";
                MySqlCommand cmdShift = new MySqlCommand(sqlShift, conn);

                cmdShift.Parameters.AddWithValue("@shiftnumber", s.ShiftNumber);
                cmdShift.Parameters.AddWithValue("@date", s.DateTime);
                cmdShift.Parameters.AddWithValue("@department", s.EmployeeDepartment.ToString());
                cmdShift.Parameters.AddWithValue("@shifttype", s.ShiftType.ToString());

                conn.Open();
                foreach (Employee e in s.GetEmployees())
                {
                    string sqlSch = "INSERT INTO `schedule`(`ShiftNumber`, `EmployeeNumber`) VALUES (@shiftnum,@employeenum);";

                    MySqlCommand cmdSch = new MySqlCommand(sqlSch, conn);

                    cmdSch.Parameters.AddWithValue("@shiftnum", s.ShiftNumber);
                    cmdSch.Parameters.AddWithValue("@employeenum", e.EmployeeNumber);

                    cmdSch.ExecuteNonQuery();
                }
             
                cmdShift.ExecuteNonQuery();

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

        public List<Shift> ReadFromDB()
        {
            List<Employee> allemployees = edbm.ReadFromDB();
            List<ScheduleHelper> schelper = new List<ScheduleHelper>();
            List<Shift> shifts = new List<Shift>();
            try
            {
               
                string sqlShift = "SELECT schedule.ShiftNumber, EmployeeNumber, Date, Department, ShiftType FROM schedule INNER JOIN shift ON shift.ShiftNumber = schedule.ShiftNumber;";
                MySqlCommand cmd = new MySqlCommand(sqlShift, conn);

                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    int emplnum = Convert.ToInt32(dr[1]);
                    foreach(Employee e in allemployees)
                    {
                        if(e.EmployeeNumber == emplnum)
                        {
                            schelper.Add(new ScheduleHelper(Convert.ToInt32(dr[0]), emplnum));
                        }
                    }

                    Shift shift = new Shift((EmployeeDepartment)Enum.Parse(typeof(EmployeeDepartment), dr[3].ToString()), Convert.ToDateTime(dr[2]), (ShiftType)Enum.Parse(typeof(ShiftType),dr[4].ToString()), Convert.ToInt32(dr[0]));
                    shifts.Add(shift);
                }


                foreach(Shift s in shifts) //Eniko's signature
                {
                    foreach (ScheduleHelper helper in schelper)
                    {
                        foreach (Employee e in allemployees)
                        {
                            if (helper.ShiftNum == s.ShiftNumber)
                            {
                                if (helper.EmployeeNum == e.EmployeeNumber)
                                {
                                    s.AddEmployee(e);
                                }
                            }
                        }
                    }
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

            return shifts;


        }

        public List<Employee> ReadEmployeeFromDepartmentFromDB(EmployeeDepartment department)
        {
            List<Employee> employees = new List<Employee>();
            List<EmployeeContract> contracts = new List<EmployeeContract>();
            try
            {
                string sql = $"SELECT FirstName, LastName, employee.EmployeeNumber, Department,  DateOfBirth, City, Street, HouseNumber, HouseNumberAddition, PostCode, Email, Phone, BSN, ICEName, ICEPhone, Password FROM employee INNER JOIN employeeemploymentinfo ON employee.EmployeeNumber = employeeemploymentinfo.EmployeeNumber INNER JOIN empoyeepersonalinfo ON employee.EmployeeNumber = empoyeepersonalinfo.EmployeeNumber WHERE Department='{department}';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                string contract = "SELECT EmployeeNumber, FTE, Salary, StartDate, EndDate, EndReason, IsActive, ContractNumber FROM contract;";
                MySqlCommand cmdcontract = new MySqlCommand(contract, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Address adress = new Address(dr[6].ToString(), Convert.ToInt32(dr[7]), dr[8].ToString(), dr[9].ToString(), dr[5].ToString());
                    EmployeePersonalInfo persInfo = new EmployeePersonalInfo(Convert.ToDateTime(dr[4]), dr[11].ToString(), adress, dr[10].ToString(), dr[12].ToString(), dr[13].ToString(), dr[14].ToString(), dr[15].ToString());
                    EmployeeEmploymentInformation emplInfo = new EmployeeEmploymentInformation((EmployeeDepartment)Enum.Parse(typeof(EmployeeDepartment), dr[3].ToString()));
                    Employee e = new Employee(dr[0].ToString(), dr[1].ToString(), emplInfo, persInfo, Convert.ToInt32(dr[2]));
                    employees.Add(e);
                }
                dr.Close();

                MySqlDataReader drcontr = cmdcontract.ExecuteReader();
                while (drcontr.Read())
                {

                    if (Convert.ToBoolean(drcontr[6]))
                    {
                        EmployeeContract eca = new EmployeeContract(Convert.ToDouble(drcontr[1]), Convert.ToDouble(drcontr[2]), Convert.ToDateTime(drcontr[3]), Convert.ToInt32(drcontr[0]), drcontr[7].ToString());
                        contracts.Add(eca);
                    }
                    else
                    {
                        EmployeeContract ec = new EmployeeContract(Convert.ToDouble(drcontr[1]), Convert.ToDouble(drcontr[2]), Convert.ToDateTime(drcontr[3]), Convert.ToDateTime(drcontr[4]), drcontr[5].ToString(), Convert.ToBoolean(drcontr[6]), Convert.ToInt32(drcontr[0]), drcontr[7].ToString());
                        contracts.Add(ec);
                    }
                }
                dr.Close();


                foreach (EmployeeContract c in contracts)
                {
                    foreach (Employee e in employees)
                    {
                        if (e.EmployeeNumber == c.EmplNum)
                        {
                            e.employmentInfo.InitializeContractHistory(c);
                        }
                    }
                }
            }
            catch (MySqlException ex)
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
            return employees;
        }

        //public List<Employee> ReadfromDBforSpesDateTimeShift(DateTime dateTime, ShiftType shiftype)
        //{
        //    List<Employee> allemployees = edbm.ReadFromDB();
        //    List<Employee> employees = new List<Employee>();
        //    DateTime date = dateTime;
        //    ShiftType shift = shiftype;
        //    try
        //    {


        //        string Shift = $"SELECT schedule.ShiftNumber, EmployeeNumber, Date, Department, ShiftType FROM schedule INNER JOIN shift ON shift.ShiftNumber = schedule.ShiftNumber WHERE Date = '{date}'  AND ShiftType='{shift}';";
        //        MySqlCommand cmd = new MySqlCommand(Shift, conn);

        //        conn.Open();
        //        MySqlDataReader dr = cmd.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            int emplnum = Convert.ToInt32(dr[1]);
        //            foreach (Employee e in allemployees)
        //            {
        //                if (e.EmployeeNumber == emplnum)
        //                {
        //                    employees.Add(e);
        //                }
        //            }

        //        }
        //    }
            

        //    catch (MySqlException ex)
        //    {
        //        throw ex;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (conn != null)
        //        {
        //            conn.Close();
        //        }
        //    }





        //    return employees;
        //}

    }
}
