using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    class DataHandler
    {
        /*readonly string connectionString = @"Data Source=KEVINPC\SQLEXPRESS;Initial Catalog=PSSDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";//Kevin's PC*/
        //readonly string connectionString = @"Data Source=DESKTOP-S332AOK\SQLEXPRESS;Initial Catalog=PSSDB;Integrated Security=True";//Albert's PC
        readonly string connectionString = @"Data Source=DESKTOP-FH90QR9;Initial Catalog=PSSDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; /*Stefan Server*/


        #region Insert Methods

        //Template
        //--------------------------------------------------------------
        public void InsertTemplate()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "START TRANSACTION "
                    + " "
                    + " "
                    + " "
                    + " "
                    + " "
                    + " "
                    + " "
                    + "COMMIT";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }
        //--------------------------------------------------------------

        public void InsertLoginWIP()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO dbo.Login(EmpID) "
                    + " "
                    + " "
                    + " "
                    + " "
                    + " "
                    + " "
                    + " ";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void InsertContract(string contractID, string contractType, string contractDesc, float price, string deviceID, int isActive)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = " "
                    + "INSERT INTO dbo.Contract (ContractID, ContractType, ContractDescription, Price, DeviceID, IsActive) "
                    + "VALUES ('" + contractID + "','" + contractType + "', '" + contractDesc + "'," + price + ", '" + deviceID + "', " + isActive + ") "
                    + "";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void InsertTicket(string ticketID, string callID, string problem)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = ""
                    + "INSERT INTO dbo.Ticket (TicketID, CallID, ClientSatisfaction, Completed, DateCompleted, DateStarted, ProblemDetails) "
                    + "VALUES ('" + ticketID + "', '" + callID + "','' , " + 0 + ", '', '2020-12-13', '" + problem + "') "
                    + "";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void InsertClient(string clientID, string clientName, string clientSurname, string phone, string email, string streetAddress, string suburb, string postalCode, string province, string contractID, int clientType, string bankDetails, string unitNumber = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO dbo.Client(ClientID, ClientName, ClientSurname, Phone, Email, StreetAddress, UnitNumber, Suburb, PostalCode, Province, ContractID, ClientType, BankDetails) VALUES "
                    + "('" + clientID + "' ,'" + clientName + "' ,'" + clientSurname + "' ,'" + phone + "' ,'" + email + "' ,'" + streetAddress + "' ,'" + unitNumber + "' ,'" + suburb + "' ,'" + postalCode + "' ,'" + province + "' ,'" + contractID + "' ," + clientType + " ,'" + bankDetails + "')";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void InsertEmployee(int id, string firstname, string surname, string phone, string email, string postaladdress, string streetname, string suburb, string city, string postalcode, string province, string dateHired, int jobID, int leaveDays, string maritalStatus, string apartmentNumber = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "START TRANSACTION "
                    + "INSERT INTO dbo.Employee(EmpID, EmpName, EmpSurname, Phone, Email, PostalAddress, StreetName, ApartmentNumber, Suburb, City, PostalCode, Province, DateHired, JobID, LeaveDays, MaritalStatus) "
                    + "VALUES (" + id + ", '" + firstname + "', '" + surname + "', '" + phone + "', '" + email + "', '" + postaladdress + "', '" + streetname + "', '" + apartmentNumber + "', '" + suburb + "', '" + city + "', '" + postalcode + "', '" + province + "', CONVERT(DATETIME, '" + dateHired + "', 5), " + jobID + ", " + leaveDays + ", '" + maritalStatus + "') "
                    + "COMMIT";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void InsertJob(int jobID, string name, double salary)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText ="INSERT INTO dbo.Job(JobID, JobName, Salary) "
                    + "VALUES(" + jobID + ", '" + name + "', " + salary + ") ";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void InsertSpecialization(int id, string specializationName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "START TRANSACTION "
                    + "INSERT INTO dbo.Specialization (SpecializationID, SpecializationName) "
                    + "VALUES (" + id + ", '" + specializationName + "') "
                    + "COMMIT";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void InsertDevice(string id, string manufacturer, string model)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = ""
                    + "INSERT INTO dbo.Device(DeviceID, Manufacturer, Model) "
                    + "VALUES ('" + id + "', '" + manufacturer + "', '" + model + "')";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void InsertService(string serviceID, string serviceDesc, double price, int serviceDays = 0)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "START TRANSACTION"
                    + "INSERT INTO dbo.Service (ServiceID, ServiceDescription, Price, ServiceDays)"
                    + "VALUES ('" + serviceID + "', '" + serviceDesc + "', " + price + ", " + serviceDays + ")"
                    + "COMMIT";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void InsertBankDetails(string bdID, string paymentType, string bankName, string branchNum, string accountNum)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO dbo.BankDetails (BankDetailsID, PaymentType, BankName, BranchNum, AccountNum)"
                    + "VALUES ('" + bdID + "', '" + paymentType + "', '" + bankName + "', '" + branchNum + "', '" + accountNum + "')";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void InsertCall(string callID, int callDuration, string date, int empID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "START TRANSACTION"
                    + "INSERT INTO dbo.Call (CallID, CallDuration, CallDate, EmpID)"
                    + "VALUES ('" + callID + "', " + callDuration + ", CONVERT(DATETIME,'" + date + "',5), " + empID + ") "
                    + "COMMIT";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void InsertTechnicianSchedule(string empID, string ticketID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                int empidddd = int.Parse(empID);
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = " "
                    + "INSERT INTO dbo.TechnicianSchedule (EmpID, TicketID) "
                    + "VALUES (" + empidddd + ",'" + ticketID + "') "
                    + "";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        #endregion

        #region Update Methods

        //template
        //----------------------------------------------------------
        public void UpdateTemplate()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE dbo.TableName "
                + "SET ColumnValue = 'NewValue'"
                + " WHERE Value = Value";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }
        //----------------------------------------------------------

        public void UpdateClient(string clientID, string clientName, string clientSurname, string email, string suburb, string postalCode,
           string province, string streetAddress, string phone, string contractID, int clientType, string bankDetails, string unitNumber = "N/A")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE dbo.Client"
                    + " SET"
                    + " ClientName = '"
                    + clientName
                    + "', ClientSurname = '"
                    + clientSurname
                    + "', Phone = '"
                    + phone
                    + "', Email = '"
                    + email
                    + "', StreetAddress = '"
                    + streetAddress
                    + "', UnitNumber = '"
                    + unitNumber
                    + "', Suburb = '"
                    + suburb
                    + "', PostalCode = '"
                    + postalCode
                    + "' , Province = '"
                    + province
                    + "', ContractID = '"
                    + contractID
                    + "' , ClientType = "
                    + clientType
                    + " , BankDetails = '"
                    + bankDetails
                    + "' WHERE ClientID = '"
                    + clientID
                    + "'";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void UpdateBankDetails(string bankDetailsID, string paymentType, string bankname, string branchNum, string accountNum)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE dbo.BankDetails "
                + "SET [PaymentType] = '" + paymentType + "'"
                + " ,[BankName] = '" + bankname + "'"
                + " ,[BranchNum] = '" + branchNum + "'"
                + ",[AccountNum] = '" + accountNum + "'"
                + " WHERE BankDetailsID = '" + bankDetailsID + "'";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void UpdateTechnician(float satisfactionScore, int lifetimeRatedTickets, float totalScore, int empID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE dbo.Technician "
                                + "SET SatisfactionScore = "
                                + satisfactionScore
                                + " ,LifetimeTickets = "
                                + lifetimeRatedTickets
                                + " ,TotalScore = "
                                + totalScore
                                + " WHERE EmpID = "
                                + empID;
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void UpdateContractState(int isActive, string contractID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE dbo.Contract "
                + "SET IsActive = "
                + isActive
                + " WHERE ContractID = '"
                + contractID
                + "'";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        //used when assiging a ticket to a new technician
        public void UpdateTechnicianSchedule(int empID, string ticketID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE dbo.TechnicianSchedule "
                + "SET EmpID = "
                + empID
                + " WHERE TicketID = '"
                + ticketID
                + "'";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void UpdateTicket(string ticketID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                DateTime time = DateTime.Now;
                string format = "yyyy-MM-dd HH:mm:ss";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE [dbo].[Ticket] "
                    + "SET [Completed] = 1"
                    + ",[DateCompleted] = '"
                    + time.ToString(format)
                    + "' WHERE TicketID = '"
                    + ticketID
                    + "'";
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        #endregion

        #region Select Methods

        public DataTable ClientTreeView()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(@" SELECT dbo.Client.ClientID, CONCAT(dbo.Client.ClientName,' ',dbo.Client.ClientSurname) AS FullName, dbo.Client.Phone, dbo.Client.Email, dbo.Client.StreetAddress, dbo.Client.UnitNumber, dbo.Client.Suburb, dbo.Client.PostalCode, dbo.Client.Province, 
                                                        dbo.Client.ContractID, dbo.Client.ClientType, dbo.Client.BankDetails, dbo.BankDetails.PaymentType, dbo.BankDetails.BankName, dbo.BankDetails.BranchNum, dbo.BankDetails.AccountNum, dbo.Contract.ContractDescription, dbo.Contract.ContractType,
                                                        dbo.Contract.ContractID, dbo.Contract.DeviceID, dbo.Contract.IsActive, dbo.Contract.Price FROM dbo.Client INNER JOIN dbo.BankDetails 
                                                        ON  dbo.Client.BankDetails = dbo.BankDetails.BankDetailsID INNER JOIN dbo.Contract ON dbo.Client.ContractID = dbo.Contract.ContractID ", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }


        public DataTable SelectContractForCallCenter()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT* FROM dbo.Contract", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        //needs to be updated
        public DataTable SelectContract(string contractID)
        {
            #region Notes
            /*
            */
            #endregion

            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(@"
                SELECT  dbo.Contract.ContractID, dbo.Contract.ContractType, dbo.Contract.ContractDescription, dbo.Contract.Price, dbo.Package.PackageName, dbo.Service.ServiceDescritpion
                FROM    dbo.Contract INNER JOIN
                        dbo.ContractPackage ON dbo.Contract.ContractID = dbo.ContractPackage.ContractID AND dbo.Contract.ContractID = dbo.ContractPackage.ContractID INNER JOIN
                        dbo.Package ON dbo.ContractPackage.PackageID = dbo.Package.PackageID INNER JOIN
                        dbo.ServicePackage ON dbo.Package.PackageID = dbo.ServicePackage.PackageID INNER JOIN
                        dbo.Service ON dbo.ServicePackage.ServiceID = dbo.Service.ServiceID
                WHERE   dbo.Contract.ContractID = '"
                    + contractID + "'", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }
        public DataTable SelectAllContracts()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(@"
                SELECT  *
                FROM    dbo.Contract   '"
                    , connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }
        public DataTable SelectContractType(string contractType)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(@"
                SELECT  *
                FROM    dbo.Contract 
                WHERE   dbo.Contract.ContractType = '"
                    + contractType + "'", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        public DataTable SelectContractTypes()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT SUBSTRING(ContractID, 5,1) AS ContractTypes FROM Contract;", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        public DataTable SelectTechnicianView1(int empID)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(@"SELECT dbo.TechnicianSchedule.TicketID, dbo.Client.ClientName, dbo.Client.ClientSurname, dbo.ClientType.ClientDescription, dbo.Ticket.ProblemDetails
                        FROM dbo.Call INNER JOIN
                         dbo.ClientCall ON dbo.Call.CallID = dbo.ClientCall.CallID INNER JOIN
                         dbo.Client ON dbo.ClientCall.ClientID = dbo.Client.ClientID INNER JOIN
                         dbo.Ticket ON dbo.Call.CallID = dbo.Ticket.CallID INNER JOIN
                         dbo.TechnicianSchedule ON dbo.Ticket.TicketID = dbo.TechnicianSchedule.TicketID INNER JOIN
                         dbo.ClientType ON dbo.Client.ClientType = dbo.ClientType.ClientType
                        WHERE (dbo.TechnicianSchedule.EmpID = " + empID + ")"
                    , connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        public DataTable SelectTechnician(int ticketID)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(@"SELECT dbo.Technician.EmpID, dbo.Technician.LifetimeTickets, dbo.Technician.TotalScore 
FROM dbo.Technician INNER JOIN 
dbo.TechnicianSchedule ON dbo.Technician.EmpID = dbo.TechnicianSchedule.EmpID 
WHERE (dbo.TechnicianSchedule.TicketID = '" + ticketID + "')", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        public DataTable SelectClient(string email)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.Client WHERE dbo.Client.Email = '"
                    + email + "'", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        public DataTable SelectClientDetails(string email)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT dbo.Client.ClientID, dbo.Client.ClientName, dbo.Client.ClientSurname, dbo.Client.Phone, dbo.Client.Email, dbo.Client.StreetAddress, dbo.Client.UnitNumber, dbo.Client.Suburb, dbo.Client.PostalCode, dbo.Client.Province, dbo.Client.ContractID, dbo.Client.ClientType, dbo.Client.BankDetails, dbo.BankDetails.PaymentType, dbo.BankDetails.BankName, dbo.BankDetails.BranchNum, dbo.BankDetails.AccountNum FROM dbo.Client INNER JOIN dbo.BankDetails ON  dbo.Client.BankDetails = dbo.BankDetails.BankDetailsID WHERE dbo.Client.Email = '" + email + "'", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        public DataTable SelectTechnicianView2(int empID)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT dbo.Client.UnitNumber, dbo.Client.StreetAddress, dbo.Client.Suburb, dbo.Client.Email, dbo.Client.Phone "
                        + "FROM dbo.Ticket INNER JOIN "
                        + "dbo.Client INNER JOIN "
                        + "dbo.ClientCall ON dbo.Client.ClientID = dbo.ClientCall.ClientID INNER JOIN "
                        + "dbo.Call ON dbo.ClientCall.CallID = dbo.Call.CallID ON dbo.Ticket.CallID = dbo.Call.CallID INNER JOIN "
                        + "dbo.TechnicianSchedule ON dbo.Ticket.TicketID = dbo.TechnicianSchedule.TicketID "
                        + "WHERE dbo.TechnicianSchedule.EmpID = "
                        + empID, connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        public DataTable SelectPackages()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(@"
                    SELECT dbo.Package.PackageName, dbo.Service.ServiceDescritpion, dbo.Service.Price, dbo.Service.ServiceDays
                    FROM dbo.Package INNER JOIN
                         dbo.ServicePackage ON dbo.Package.PackageID = dbo.ServicePackage.PackageID INNER JOIN
                         dbo.Service ON dbo.ServicePackage.ServiceID = dbo.Service.ServiceID", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        //select uncompleted tickects and the contract id
        public DataTable SelectUncompletedTickets(string ticketID)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT dbo.Ticket.TicketID, dbo.ClientContract.ContractID "
                        + " FROM dbo.Call INNER JOIN "
                        + " dbo.ClientCall ON dbo.Call.CallID = dbo.ClientCall.CallID INNER JOIN "
                        + " dbo.Client ON dbo.ClientCall.ClientID = dbo.Client.ClientID INNER JOIN "
                        + " dbo.ClientContract ON dbo.Client.ClientID = dbo.ClientContract.ClientID INNER JOIN "
                        + " dbo.Ticket ON dbo.Call.CallID = dbo.Ticket.CallID "
                        + " WHERE (dbo.Ticket.TicketID = '" + ticketID + "')", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        //select technician schedule where UNCOMPLETED TICKETS =< 5 AND where satisfaction >= @score
        //checking the amount of tickets will come a bit later because thats a different query that will run against the results of this one - Albert Wolfaardt
        public DataTable SelectTicketsAndSatisfactionScore(int minScore)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT dbo.TechnicianSchedule.EmpID, dbo.TechnicianSchedule.TicketID "
                        + "FROM dbo.Technician INNER JOIN "
                        + "dbo.TechnicianSchedule ON dbo.Technician.EmpID = dbo.TechnicianSchedule.EmpID INNER JOIN "
                        + "dbo.Ticket ON dbo.TechnicianSchedule.TicketID = dbo.Ticket.TicketID "
                        + "WHERE (dbo.Ticket.Completed = 0) AND (dbo.Technician.SatisfactionScore >= " + minScore + ")", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        public DataTable SelectAvailableTechnician(int minScore, int techIdToExclude)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(
                    "SELECT dbo.TechnicianSchedule.EmpID, dbo.TechnicianSchedule.TicketID "
                    + "FROM dbo.Technician INNER JOIN "
                    + " dbo.TechnicianSchedule ON dbo.Technician.EmpID = dbo.TechnicianSchedule.EmpID INNER JOIN "
                    + " dbo.Ticket ON dbo.TechnicianSchedule.TicketID = dbo.Ticket.TicketID "
                    + "WHERE (dbo.Technician.SatisfactionScore >= "
                    + minScore
                    + ") AND (dbo.TechnicianSchedule.EmpID != '"
                    + techIdToExclude
                    + "') "
                    + "GROUP BY dbo.TechnicianSchedule.EmpID, dbo.TechnicianSchedule.TicketID "
                    + "HAVING (COUNT(dbo.TechnicianSchedule.EmpID) < 5)", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        public DataTable SelectUnassignedTickets()
        {
            //returns datatable of tickets that are unnasigned with no other checks
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(
                    "SELECT TicketID "
                    + "FROM dbo.Ticket "
                    + "WHERE TicketID NOT IN (SELECT TicketID FROM TechnicianSchedule)"
                    , connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        #endregion

        #region Delete Methods

        public void DeleteClient(int clientID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("DELETE FROM dbo.Client WHERE ClientID = '" + clientID + "'", connection))
            {
                try
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.DeleteCommand.ExecuteNonQuery();
                    }
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        #endregion

        #region Extras
        //If it doesn't say Insert, Update, Delete or Select in the method name, then you'll probably find it here

        public DataTable LoginCheck(string uname, string pwd)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT dbo.Employee.JobID, dbo.Employee.EmpID "
                        + "FROM dbo.Employee INNER JOIN "
                        + "dbo.Login ON dbo.Employee.EmpID = dbo.Login.EmpID "
                        + "WHERE(dbo.Login.Username = '" + uname + "') AND(dbo.Login.Password = '" + pwd + "')", connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        public bool ClientIDChecker(string newID)
        {
            #region Notes
            /*
             * So this method will be used to check if a given clientID already exists within the database
             * and the method will return a boolean value. This method can be adapted to check for any existing
             * records within the database, given that you addapt the SQL queries' VALUES
             * and match the datatypes.
             * - Albert Wolfaardt
            */
            #endregion

            bool Exists = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(
                "DECLARE @ClientID VARCHAR(9) = '"
                + newID
                + "' "
                + "SELECT(CASE WHEN EXISTS(SELECT 1 FROM dbo.Client WITH(NOLOCK) "
                + "WHERE ClientID = @ClientID) THEN '1' "
                + "ELSE '0' END) AS [Result] "
                , connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string recievedInt = (string)reader.GetString(reader.GetOrdinal("Result"));
                                if (recievedInt == "1")
                                {
                                    Exists = true;
                                }
                            }
                        }

                    }
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine("An Error occured and no I won't go into details, deal with it: " + sqle.ToString());
                }
                finally
                {

                    command.Dispose();
                    connection.Close();

                }
                return Exists;
            }
        }

        public bool TicketAssignedChecker(string TicketId)
        {
            bool Exists = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(
                "DECLARE @Ticket NCHAR(100) = '"
                + TicketId
                + "' "
                + "SELECT(CASE WHEN EXISTS(SELECT 1 FROM dbo.TechincianSchedule WITH(NOLOCK) "
                + "WHERE TicketID = @Ticket) THEN '1' "
                + "ELSE '0' END) AS [Result] "
                , connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string recievedInt = (string)reader.GetString(reader.GetOrdinal("Result"));
                                if (recievedInt == "1")
                                {
                                    Exists = true;
                                }
                            }
                        }

                    }
                }
                catch (SqlException sqle)
                {
                    Console.WriteLine("An Error occured and no I won't go into details, deal with it: " + sqle.ToString());
                }
                finally
                {

                    command.Dispose();
                    connection.Close();

                }
                return Exists;
            }
        }

        public DataTable SelectAllTech()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT dbo.Employee.EmpID, dbo.Employee.EmpName, dbo.Employee.EmpSurname, dbo.Employee.Phone, dbo.Employee.Email, dbo.Technician.SatisfactionScore "
            + " FROM dbo.Employee INNER JOIN "
            + " dbo.Technician ON dbo.Employee.EmpID = dbo.Technician.EmpID", connection)) 
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        public DataTable SelectTech(int TechID)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT dbo.Employee.EmpID, dbo.Employee.EmpName, dbo.Employee.EmpSurname, dbo.Employee.Phone, dbo.Employee.Email, dbo.Technician.SatisfactionScore "
            + " FROM dbo.Employee INNER JOIN "
            + " dbo.Technician ON dbo.Employee.EmpID = dbo.Technician.EmpID "
            + "WHERE dbo.Employee.EmpID = "+TechID , connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.ToString());
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
                return table;
            }
        }

        #endregion

        // Templates that are now obsolete. Will remove a bit later - Albert Wolfaardt
        //public List<Job> TemplateMethod1()
        //{
        //    #region Important Information
        //    //Here we populate a list of NAMED objects using data from a single table.
        //    //It Serves as a template for the rest of the methods by adapting the SQL command and constructors accordingly.
        //    //If you wish to adapt this template, please make sure you check out the data type cheat sheet I personally use:
        //    //https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
        //    //And remove the regions marked as "DebuggingCode" as I only made them to test the connection and data transmision.
        //    //Proper exception handling will be added at a later date.
        //    //
        //    // - Albert Wolfaardt
        //    #endregion
        //    List<Job> jobsList = new List<Job>();
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    using (SqlCommand command = new SqlCommand("SELECT JobID AS ID, JobName, Salary FROM dbo.Job", connection))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            #region DebuggingCode
        //            //if (connection.State == ConnectionState.Open)
        //            //{
        //            //    Console.WriteLine("connection succesfully established!");
        //            //}
        //            #endregion
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.HasRows)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        #region Explanation
        //                        //We apply Explicit casting where necesarry.
        //                        //I'm going to be testing the potential of data loss at a later date but for this object specifically it appears fine
        //                        //- Albert Wolfaardt
        //                        #endregion
        //                        Job job = new Job(reader.GetInt32(reader.GetOrdinal("ID"))
        //                            , (string)reader.GetSqlString(reader.GetOrdinal("JobName"))
        //                            , (double)reader.GetSqlDouble(reader.GetOrdinal("Salary")));
        //                        jobsList.Add(job);
        //                        #region DebuggingCode
        //                        //Console.WriteLine("We're getting something from the table chief! iteration {0}",iteration);
        //                        //iteration++;
        //                        #endregion
        //                    }
        //                }
        //                return jobsList;
        //            }
        //        }
        //        finally
        //        {
        //            connection.Dispose();
        //            connection.Close();
        //            #region DebuggingCode
        //            //if (connection.State == ConnectionState.Closed)
        //            //{
        //            //    Console.WriteLine("connection to DB succesfully closed");
        //            //}
        //            #endregion
        //        }
        //    }
        //}

        //public List<TechnicianDetails> TemplateMethod2()
        //{
        //    #region Important Information
        //    //Here we populate a list of named objects using data from multiple tables.
        //    //It Serves as a template for other similar methods by adapting the SQL command and constructors accordingly.
        //    //If you wish to adapt this template, please make sure you check out the data type cheat sheet I personally use:
        //    //https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
        //    //And remove the regions marked as "DebuggingCode" as I only made them to test the connection and data transmision.
        //    //Proper exception handling will be added at a later date.
        //    //
        //    // - Albert Wolfaardt
        //    #endregion
        //    List<TechnicianDetails> technicianDetails = new List<TechnicianDetails>();
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    using (SqlCommand command = new SqlCommand("SELECT dbo.Employee.EmpName + dbo.Employee.EmpSurname AS FullName, dbo.Specialization.SpecializationName AS Specialization, dbo.Technician.SatisfactionScore, dbo.Job.JobName AS JobTitle, "
        //                                               + "dbo.Employee.Phone "
        //                                               + "FROM dbo.Employee INNER JOIN "
        //                                               + "dbo.Job ON dbo.Employee.JobID = dbo.Job.JobID INNER JOIN "
        //                                               + "dbo.Technician ON dbo.Employee.EmpID = dbo.Technician.EmpID INNER JOIN "
        //                                               + "dbo.TechnicianSpecialization ON dbo.Technician.EmpID = dbo.TechnicianSpecialization.TechnicianID INNER JOIN "
        //                                               + "dbo.Specialization ON dbo.TechnicianSpecialization.SpecializationID = dbo.Specialization.SpecializationID", connection))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            #region DebuggingCode
        //            //if (connection.State == ConnectionState.Open)
        //            //{
        //            //    Console.WriteLine("connection succesfully established!");
        //            //}
        //            #endregion
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.HasRows)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        #region Explanation
        //                        //We apply Explicit casting where necesarry.
        //                        //I'm going to be testing the potential of data loss at a later date but for this object specifically it appears fine
        //                        //- Albert Wolfaardt
        //                        #endregion
        //                        TechnicianDetails technician = new TechnicianDetails((string)reader.GetSqlString(reader.GetOrdinal("FullName")),
        //                                                                             (string)reader.GetSqlString(reader.GetOrdinal("Specialization")),
        //                                                                             (double)reader.GetSqlDouble(reader.GetOrdinal("SatisfactionScore")),
        //                                                                             (string)reader.GetSqlString(reader.GetOrdinal("JobTitle")),
        //                                                                             (string)reader.GetSqlString(reader.GetOrdinal("Phone")));
        //                        technicianDetails.Add(technician);
        //                        #region DebuggingCode
        //                        //Console.WriteLine("We're getting something from the table chief! iteration {0}",iteration);
        //                        //++iteration;
        //                        #endregion
        //                    }
        //                }
        //                return technicianDetails;
        //            }
        //        }
        //        finally
        //        {
        //            connection.Dispose();
        //            connection.Close();
        //            #region DebuggingCode
        //            //if (connection.State == ConnectionState.Closed)
        //            //{
        //            //    Console.WriteLine("connection to DB succesfully closed");
        //            //}
        //            #endregion
        //        }
        //    }
        //}



    }
}
