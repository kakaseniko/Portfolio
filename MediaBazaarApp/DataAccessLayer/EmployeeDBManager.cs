using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulesAndInterfaces;

namespace DataAccessLayer
{
    public class EmployeeDBManager
    {
        public static MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi387054;uid=dbi387054;password=password;");
        public void InsertToDB(Employee e)
        {
            try
            {
                //Instert e to Employee table
                string sqlEmpl = "INSERT INTO employee(EmployeeNumber, FirstName, LastName) VALUES(@emplNum,@fname,@lname);";
                MySqlCommand cmdEmpl = new MySqlCommand(sqlEmpl, conn);
                cmdEmpl.Parameters.AddWithValue("@emplNum", e.EmployeeNumber);
                cmdEmpl.Parameters.AddWithValue("@fname", e.FirstName);
                cmdEmpl.Parameters.AddWithValue("@lname", e.LastName);

                //Insert e to EmployeePersonalInfo table
                string sqlPers = "INSERT INTO empoyeepersonalinfo(EmployeeNumber, DateOfBirth, City, Street, HouseNumber, HouseNumberAddition, PostCode, Email, Phone, BSN, ICEName, ICEPhone, Password) VALUES (@emplNum,@birthDate,@city,@street,@houseNum,@houseNumAdd,@postcode,@email,@phone,@bsn,@iceName,@icePhone,@password);";
                MySqlCommand cmdPers = new MySqlCommand(sqlPers, conn);
                cmdPers.Parameters.AddWithValue("@emplNum", e.EmployeeNumber);
                cmdPers.Parameters.AddWithValue("@birthDate", e.personalInfo.DateOfBirth);
                cmdPers.Parameters.AddWithValue("@city", e.personalInfo.Address.City);
                cmdPers.Parameters.AddWithValue("@street", e.personalInfo.Address.StreetName);
                cmdPers.Parameters.AddWithValue("@houseNum", e.personalInfo.Address.StreetNum);
                cmdPers.Parameters.AddWithValue("@houseNumAdd", e.personalInfo.Address.StreetNumAddition);
                cmdPers.Parameters.AddWithValue("@postcode", e.personalInfo.Address.Postcode);
                cmdPers.Parameters.AddWithValue("@email", e.personalInfo.Email);
                cmdPers.Parameters.AddWithValue("@phone", e.personalInfo.PhoneNumber);
                cmdPers.Parameters.AddWithValue("@bsn", e.personalInfo.BSN);
                cmdPers.Parameters.AddWithValue("@iceName", e.personalInfo.ICEName);
                cmdPers.Parameters.AddWithValue("@icePhone", e.personalInfo.ICEPhone);
                cmdPers.Parameters.AddWithValue("@password", e.personalInfo.Password);

                //Insert e to EmployeeEmploymentInfo table
                string sqlEmplInfo = "INSERT INTO employeeemploymentinfo(EmployeeNumber, Department) VALUES (@emplNum,@dep);";
                MySqlCommand cmdEmplInfo = new MySqlCommand(sqlEmplInfo, conn);

                cmdEmplInfo.Parameters.AddWithValue("@emplNum", e.EmployeeNumber);
                cmdEmplInfo.Parameters.AddWithValue("@dep", e.employmentInfo.EmployeeDepartment.ToString());

                //Insert e contracts to contract table

                conn.Open();
                foreach (EmployeeContract c in e.employmentInfo.GetContractHistory())
                {
                    string sqlContr = "INSERT INTO contract(ContractNumber, EmployeeNumber, FTE, Salary, StartDate, EndDate, EndReason, IsActive) VALUES(@contractNum, @emplNum,@fte,@sal,@startDate,@endDate,@endreason,@isActive);";
                    MySqlCommand cmdContr = new MySqlCommand(sqlContr, conn);
                    cmdContr.Parameters.AddWithValue("@contractNum", c.ContractNum);
                    cmdContr.Parameters.AddWithValue("@emplNum", c.EmplNum);
                    cmdContr.Parameters.AddWithValue("@fte", c.FTE);
                    cmdContr.Parameters.AddWithValue("@sal", c.Salary);
                    cmdContr.Parameters.AddWithValue("@startDate", c.StartDate);
                    cmdContr.Parameters.AddWithValue("@endDate", c.EndDate);
                    cmdContr.Parameters.AddWithValue("@endreason", c.EndReason);
                    cmdContr.Parameters.AddWithValue("@isActive", c.IsActive);
                    cmdContr.ExecuteNonQuery();
                }


                cmdEmpl.ExecuteNonQuery();
                cmdPers.ExecuteNonQuery();
                cmdEmplInfo.ExecuteNonQuery();

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
        public void InsertNewContractToDB(EmployeeContract c)
        {

            string sqlContr = "INSERT INTO contract(ContractNumber, EmployeeNumber, FTE, Salary, StartDate, EndDate, EndReason, IsActive) VALUES(@contractNum, @emplNum,@fte,@sal,@startDate,@endDate,@endreason,@isActive);";
            MySqlCommand cmdContr = new MySqlCommand(sqlContr, conn);
            cmdContr.Parameters.AddWithValue("@contractNum", c.ContractNum);
            cmdContr.Parameters.AddWithValue("@emplNum", c.EmplNum);
            cmdContr.Parameters.AddWithValue("@fte", c.FTE);
            cmdContr.Parameters.AddWithValue("@sal", c.Salary);
            cmdContr.Parameters.AddWithValue("@startDate", c.StartDate);
            cmdContr.Parameters.AddWithValue("@endDate", c.EndDate);
            cmdContr.Parameters.AddWithValue("@endreason", c.EndReason);
            cmdContr.Parameters.AddWithValue("@isActive", c.IsActive);
            conn.Open();
            cmdContr.ExecuteNonQuery();

        }

        public List<Employee> ReadFromDB()
        {
            List<Employee> employees = new List<Employee>();
            List<EmployeeContract> contracts = new List<EmployeeContract>();
            try
            {
                string sql = "SELECT FirstName, LastName, employee.EmployeeNumber, Department,  DateOfBirth, City, Street, HouseNumber, HouseNumberAddition, PostCode, Email, Phone, BSN, ICEName, ICEPhone, Password FROM employee INNER JOIN employeeemploymentinfo ON employee.EmployeeNumber = employeeemploymentinfo.EmployeeNumber INNER JOIN empoyeepersonalinfo ON employee.EmployeeNumber = empoyeepersonalinfo.EmployeeNumber;";
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

        public void UpdateDB(Employee e)
        {
            try
            {


                //update employee table
                string sql = "UPDATE employee SET FirstName=@fname,LastName=@lname WHERE EmployeeNumber=@emplNum";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@emplNum", e.EmployeeNumber);
                cmd.Parameters.AddWithValue("@fname", e.FirstName);
                cmd.Parameters.AddWithValue("@lname", e.LastName);

                //update persInfo table

                string sqlPers = "UPDATE empoyeepersonalinfo SET DateOfBirth=@birthDate,City=@city,Street=@street,HouseNumber=@houseNum,HouseNumberAddition=@houseNumadd,PostCode=@postcode,Email=@email,Phone=@phone,BSN=@bsn,ICEName=@iceName,ICEPhone=icePhone,Password=@password WHERE EmployeeNumber = @emplNum";
                MySqlCommand cmdPers = new MySqlCommand(sqlPers, conn);

                cmdPers.Parameters.AddWithValue("@emplNum", e.EmployeeNumber);
                cmdPers.Parameters.AddWithValue("@birthDate", e.personalInfo.DateOfBirth);
                cmdPers.Parameters.AddWithValue("@city", e.personalInfo.Address.City);
                cmdPers.Parameters.AddWithValue("@street", e.personalInfo.Address.StreetName);
                cmdPers.Parameters.AddWithValue("@houseNum", e.personalInfo.Address.StreetNum);
                cmdPers.Parameters.AddWithValue("@houseNumadd", e.personalInfo.Address.StreetNumAddition);
                cmdPers.Parameters.AddWithValue("@postcode", e.personalInfo.Address.Postcode);
                cmdPers.Parameters.AddWithValue("@email", e.personalInfo.Email);
                cmdPers.Parameters.AddWithValue("@phone", e.personalInfo.PhoneNumber);
                cmdPers.Parameters.AddWithValue("@bsn", e.personalInfo.BSN);
                cmdPers.Parameters.AddWithValue("@iceName", e.personalInfo.ICEName);
                cmdPers.Parameters.AddWithValue("@icePhone", e.personalInfo.ICEPhone);
                cmdPers.Parameters.AddWithValue("@password", e.personalInfo.Password);

                //update emplInof table

                string sqlEmplInfo = "UPDATE employeeemploymentinfo SET Department=@dep WHERE EmployeeNumber = @emplNum";
                MySqlCommand cmdEmplInfo = new MySqlCommand(sqlEmplInfo, conn);

                cmdEmplInfo.Parameters.AddWithValue("@emplNum", e.EmployeeNumber);
                cmdEmplInfo.Parameters.AddWithValue("@dep", e.employmentInfo.EmployeeDepartment.ToString());

                //update contract table
                conn.Open();

                foreach (EmployeeContract c in e.employmentInfo.GetContractHistory())
                {
                    string sqlContr = "UPDATE contract SET FTE=@fte, Salary=@salary, StartDate=@startDate, EndDate=@endDate, EndReason=@reason, IsActive=@isActive WHERE ContractNumber = @contractNum";

                    MySqlCommand cmdContr = new MySqlCommand(sqlContr, conn);
                    cmdContr.Parameters.AddWithValue("@contractNum", c.ContractNum);
                    cmdContr.Parameters.AddWithValue("@fte", c.FTE);
                    cmdContr.Parameters.AddWithValue("@salary", c.Salary);
                    cmdContr.Parameters.AddWithValue("@startDate", c.StartDate);
                    cmdContr.Parameters.AddWithValue("@endDate", c.EndDate);
                    cmdContr.Parameters.AddWithValue("@reason", c.EndReason);
                    cmdContr.Parameters.AddWithValue("@isActive", c.IsActive);
                    cmdContr.ExecuteNonQuery();
                }


                cmd.ExecuteNonQuery();
                cmdPers.ExecuteNonQuery();
                cmdEmplInfo.ExecuteNonQuery();

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
