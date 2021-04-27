using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    //class TechnicianDetails
    //{
    //    //This class exists for testing purposes when getting data from multiple tables into a list of a single object - Albert Wolfaardt
    //    private string fullName;
    //    private string specialization;
    //    private double satisfactionScore;
    //    private string jobTitle;
    //    private string phone;
    //
    //    public TechnicianDetails(string fullName, string specialization, double satisfactionScore, string jobTitle, string phone)
    //    {
    //        this.FullName = fullName;
    //        this.Specialization = specialization;
    //        this.SatisfactionScore = satisfactionScore;
    //        this.JobTitle = jobTitle;
    //        this.Phone = phone;
    //    }
    //
    //    public string FullName { get => fullName; set => fullName = value; }
    //    public string Specialization { get => specialization; set => specialization = value; }
    //    public double SatisfactionScore { get => satisfactionScore; set => satisfactionScore = value; }
    //    public string JobTitle { get => jobTitle; set => jobTitle = value; }
    //    public string Phone { get => phone; set => phone = value; }
    //}

    class DataHandler
    {
        //int iteration = 0; /*This constant is used in testing and will be removed in the final version - Albert Wolfaardt*/
        readonly string connectionString = @"Data Source=DESKTOP-S332AOK\SQLEXPRESS;Initial Catalog=PSSDB;Integrated Security=True"; /*Change the servers when testing on your own machines - Albert Wolfaardt*/

        #region Insert Methods

        public void InsertClient(string clientID, string clientName, string clientSurname, string phone, string email, string streetAddress, string suburb, string postalCode, string province, string contractID, string clientType, string bankDetails, string unitNumber = null)
        {
            #region Notes
            /*
            Form - NewCustomer
            0 Customer Name         ClientName [Client]
            0 Customer Surname	    ClientSurname [Client]
            0 Email			        Email [Client]
            0 Unit Number		    UnitNumber [Client]
            0 Suburb			    Suburb [Client]
            0 Postal Code		    PostalCode [Client]
            0 Province		        Province [Client]
            0 Street Address		StreetAddress [Client]
            0 Problem Description	ProblemDescription [ProblemDetails]

            Inserting everything into the Client table should be fine but adding
            a new problem description everytime is redundent. We can provide a few premade
            problem descriptions for the client to select from and then fill in a text box
            if the answer is "None of the above", and only then creating a seperate method
            to insert that problem into the DB. IDK I'll discuss this at the next meeting.
            - Albert Wolfaardt

            Stuff has been kindoff resolved but I still need to discuss the changes
            (In case I forget There will be an insert for every major table and multiple insert methods will be called each sending the data to the DB based on the BL)
            - Albert Wolfaardt
            */
            #endregion

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO dbo.Client(ClientID, ClientName, ClientSurname, Phone, Email, StreetAddress, UnitNumber, Suburb, PostalCode, Province, ContractID, ClientType, BankDetails) VALUES "
                    + "('" + clientID + "' ,'" + clientName + "' ,'" + clientSurname + "' ,'" + phone + "' ,'" + email + "' ,'" + streetAddress + "' ,'" + unitNumber + "' ,'" + suburb + "' ,'" + postalCode + "' ,'" + province + "' ,'" + contractID + "' ,'" + clientType + "' ,'" + bankDetails + "')";
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

        //removed in final version
        public void InsertTemplate()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "START TRANSACTION"
                    +""
                    +""
                    +""
                    +""
                    +""
                    +""
                    +""
                    +"COMMIT";
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

        public void InsertService(string serviceID, string serviceDesc, double price, int serviceDays = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "START TRANSACTION"
                    +"INSERT INTO dbo.Service (ServiceID, ServiceDescription, Price, ServiceDays)"
                    +"VALUES ('"+serviceID+"', '"+serviceDesc+"', "+price+", "+serviceDays+")"
                    +"COMMIT";
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
                command.CommandText = "START TRANSACTION"
                    +"INSERT INTO dbo.BankDetails (BankDetailsID, PaymentType, BankName, BranchNum, AccountNum)"
                    +"VALUES ('"+bdID+"', '"+paymentType+"', '"+bankName+"', '"+branchNum+"', '"+accountNum+"')"
                    +"COMMIT";
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
                    +"INSERT INTO dbo.Call (CallID, CallDuration, CallDate, EmpID)"
                    +"VALUES ('"+callID+"', "+callDuration+", CONVERT(DATETIME,'"+date+"',5), "+empID+") "
                    +"COMMIT";
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

        public void UpdateClient(int clientID, string clientName, string clientSurname, string email, string suburb, string postalCode,
           string province, string streetAddress, string problemDesc, string phone, int contractID, int clientType, int bankDetails, string unitNumber = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("UPDATE [dbo].[Client]"
                    + "SET"
                    + "[ClientName] = '"
                    + clientName
                    + "'"
                    + ",[ClientSurname] = '"
                    + clientSurname
                    + "'"
                    + ",[Phone] = '"
                    + phone
                    + "'"
                    + ",[Email] = '"
                    + email
                    + "'"
                    + ",[StreetAddress] = '"
                    + streetAddress
                    + "'"
                    + ",[UnitNumber] = '"
                    + unitNumber
                    + "'"
                    + ",[Suburb] = '"
                    + suburb
                    + "'"
                    + ",[PostalCode] = '"
                    + postalCode
                    + "'"
                    + ",[Province] = '"
                    + province
                    + "'"
                    + ",[ContractID] = "
                    + contractID
                    + ",[ClientType] = "
                    + clientType
                    + ",[BankDetails] = "
                    + bankDetails
                    + "WHERE ClientID = '"
                    + clientID
                    + "'"
                    , connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.UpdateCommand.ExecuteNonQuery();
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

        #region Select Methods

        //needs to be updated
        public DataTable SelectContract(int jobID)
        {
            #region Notes
            /*
            */
            #endregion

            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(@"
                SELECT  dbo.Contract.ContractID, dbo.Contract.ContractType, dbo.Contract.ContractDescription, dbo.Contract.Price, dbo.Package.PackageName, dbo.Services.ServiceDescritpion
                FROM    dbo.Contract INNER JOIN
                        dbo.ContractPackage ON dbo.Contract.ContractID = dbo.ContractPackage.ContractID AND dbo.Contract.ContractID = dbo.ContractPackage.ContractID INNER JOIN
                        dbo.Package ON dbo.ContractPackage.PackageID = dbo.Package.PackageID INNER JOIN
                        dbo.ServicePackage ON dbo.Package.PackageID = dbo.ServicePackage.PackageID INNER JOIN
                        dbo.Services ON dbo.ServicePackage.ServiceID = dbo.Services.ServiceID
                WHERE   dbo.Contract.ContractID = '"
                    + jobID + "'", connection))
            {
                try
                {
                    connection.Open();
                    #region DebuggingCode
                    //if (connection.State == ConnectionState.Open)
                    //{
                    //    Console.WriteLine("connection succesfully established!");
                    //}
                    #endregion
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
            using (SqlCommand command = new SqlCommand("SELECT dbo.Employee.EmpName, dbo.Employee.EmpSurname, dbo.ClientType.ClientDescription, dbo.Ticket.TicketID, dbo.Ticket.ProblemDetails "
                        +"FROM dbo.Client INNER JOIN "
                        +"dbo.ClientCall ON dbo.Client.ClientID = dbo.ClientCall.ClientID INNER JOIN "
                        +"dbo.Call ON dbo.ClientCall.CallID = dbo.Call.CallID INNER JOIN "
                        +"dbo.ClientType ON dbo.Client.ClientType = dbo.ClientType.ClientType INNER JOIN "
                        +"dbo.Employee ON dbo.Call.EmpID = dbo.Employee.EmpID INNER JOIN "
                        +"dbo.Technician ON dbo.Employee.EmpID = dbo.Technician.EmpID INNER JOIN "
                        +"dbo.TechnicianSchedule ON dbo.Technician.EmpID = dbo.TechnicianSchedule.EmpID INNER JOIN "
                        +"dbo.Ticket ON dbo.Call.CallID = dbo.Ticket.CallID AND dbo.TechnicianSchedule.TicketID = dbo.Ticket.TicketID "
                        +"WHERE dbo.Employee.EmpID = "
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

        public DataTable SelectTechnicianView2(int empID)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT dbo.Client.UnitNumber, dbo.Client.StreetAddress, dbo.Client.Suburb, dbo.Client.Email, dbo.Client.Phone "
                        +"FROM dbo.Ticket INNER JOIN "
                        +"dbo.Client INNER JOIN "
                        +"dbo.ClientCall ON dbo.Client.ClientID = dbo.ClientCall.ClientID INNER JOIN "
                        +"dbo.Call ON dbo.ClientCall.CallID = dbo.Call.CallID ON dbo.Ticket.CallID = dbo.Call.CallID "
                        +"dbo.TechnicianSchedule ON dbo.Ticket.TicketID = dbo.TechnicianSchedule.TicketID "
                        +"WHERE dbo.TechnicianSchedule.EmpID = "
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

        #endregion

        #region Delete Methods

        //Definitly needs to be updated as this will not work upon further inspection - Albert Wolfaardt
        public void DeleteClient(int clientID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("DELETE FROM dbo.Client WHERE ClientID = " + clientID, connection))
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

        public int LoginCheck(string uname, string pwd)
        {
            #region IMPORTANT Notes (UPDATED NOT FIXED)
            /*
            So the security is really weak at the moment and I'm not 100% sure what it
            is I'm supposed to be checking here and what type of value needs to be returned...
            This needs to be discussed before this method can be used. I'll remove this note if
            a solution is found.
            - Albert Wolfaardt

            Not fixed yet but I have some ideas where you run 3 seperate queries with conditions to check these things.
            Will be Made an tested on April 25 untill April 26
            - Albert Wolfaardt
            */
            #endregion

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT EmpID"
                    + ",Username"
                    + ",Password"
                    + "FROM dbo.Login"
                    + "WHERE Username='"
                    + uname
                    + "' AND Password='"
                    + pwd
                    + "'", connection))
            {
                try
                {
                    connection.Open();
                    #region DebuggingCode
                    //if (connection.State == ConnectionState.Open)
                    //{
                    //    Console.WriteLine("connection succesfully established!");
                    //}
                    #endregion
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return reader.GetInt32(reader.GetOrdinal("EmpID"));
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
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
