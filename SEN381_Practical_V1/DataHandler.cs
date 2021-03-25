using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Data.SqlTypes;
using System.Threading.Tasks;

namespace SEN381_Practical_V1
{
    class TechnicianDetails
    {
        //This class exists for testing purposes when getting data from multiple tables into a list of a single object - Albert Wolfaardt
        private string fullName;
        private string specialization;
        private double satisfactionScore;
        private string jobTitle;
        private string phone;

        public TechnicianDetails(string fullName, string specialization, double satisfactionScore, string jobTitle, string phone)
        {
            this.FullName = fullName;
            this.Specialization = specialization;
            this.SatisfactionScore = satisfactionScore;
            this.JobTitle = jobTitle;
            this.Phone = phone;
        }

        public string FullName { get => fullName; set => fullName = value; }
        public string Specialization { get => specialization; set => specialization = value; }
        public double SatisfactionScore { get => satisfactionScore; set => satisfactionScore = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public string Phone { get => phone; set => phone = value; }
    }

    class DataHandler
    {
        int iteration = 0; /*This constant is used in testing and will be removed in the final version - Albert Wolfaardt*/
        readonly string connectionString = @"Data Source=DESKTOP-S332AOK\SQLEXPRESS;Initial Catalog=PSSDB;Integrated Security=True"; /*Change the servers when testing on your own machines - Albert Wolfaardt*/

        #region Extras
        //This would have been much easier if we were allowed to use stored procedures...
        //This method might see use (and obvious adjustment) if the logic calls for it IDK we'll see....
        //public void ConnectDB()
        //{
        //SqlConnection cnn;
        //string connectionString = @"Data Source=DESKTOP-S332AOK\\SQLEXPRESS;Initial Catalog=PSSDB;Integrated Security=True";
        //}
        #endregion

        public int LoginCheck(string uname, string pwd)
        {
            #region IMPORTANT Notes
            /*
            So the security is really weak at the moment and I'm not 100% sure what it
            is I'm supposed to be checking here and what type of value needs to be returned...
            This needs to be discussed before this method can be used. I'll remove this note if
            a solution is found.
            - Albert Wolfaardt
            */
            #endregion

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT EmpID"
                    + ",Username"
                    + ",Password"
                    + "FROM dbo.Login"
                    + "WHERE Username='"
                    +uname
                    +"' AND Password='"
                    +pwd
                    +"'", connection))
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

        public DataTable SelectTechnician(int jobID)
        {
            #region Notes
            /*Technician Form -
            0 EmpName[Employee] WHERE JobID = *whatever the technicians ID is * ---> I assume you'll be searching via job ID? - Albert Wolfaardt
            0 EmpSurname[Employee]
            0 SpecialisationName[Specialisation]
            0 TicketID[Ticket]
            0 ProblemDescription[ProblemDetails]
            
            The last 3 things will pose a problem when trying to display them seeing as there can be multiple
            instances of each field, ie. tickets that are assigned to a single technician. I have some ideas where we can
            use a list or an array but thats outside of my current responsibilities, but I will discuss them regardless.
            - Albert Wolfaardt

            We can either return all the data from the DB as DataTables or we
            change the appropriate classes to better suit its role in the application
            I will bring this up in the next meeting but if you see this before that then congratulations, you win a chocolate chip cookie!
            - Albert Wolfaardt
            */
            #endregion

            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT dbo.Employee.EmpName, dbo.Employee.EmpSurname AS EmployeeName, dbo.Specialization.SpecializationName AS Specialization, dbo.Ticket.TicketID AS Ticket, dbo.ProblemDetails.ProblemDescription AS Problem"
                    + "FROM dbo.Employee INNER JOIN"
                    + "dbo.Ticket INNER JOIN"
                    + "dbo.ProblemDetails ON dbo.Ticket.ProblemID = dbo.ProblemDetails.ProblemID INNER JOIN"
                    + "dbo.TechnicianSchedule ON dbo.Ticket.TicketID = dbo.TechnicianSchedule.TicketID INNER JOIN"
                    + "dbo.TechnicianSpecialization INNER JOIN"
                    + "dbo.Specialization ON dbo.TechnicianSpecialization.SpecializationID = dbo.Specialization.SpecializationID INNER JOIN"
                    + "dbo.Technician ON dbo.TechnicianSpecialization.TechnicianID = dbo.Technician.EmpID ON dbo.TechnicianSchedule.EmpID = dbo.Technician.EmpID ON dbo.Employee.EmpID = dbo.Technician.EmpID"
                    + "WHERE JobID = "
                    + jobID, connection))
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
                    return table;
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void InsertClient(string clientName, string clientSurname, string email, string suburb, string postalCode,
            string province, string streetAddress, string problemDesc, string phone, int contractID, int clientType, int bankDetails, string unitNumber = null)
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


            */
            #endregion

            using (SqlConnection connection = new SqlConnection(connectionString))
            //using (SqlCommand command = new SqlCommand(("INSERT INTO dbo.Client (ClientName, ClientSurname, Phone, Email, StreetAddress, UnitNumber, Suburb, PostalCode, Province, ContractID, ClientType, BankDetails)VALUES'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", clientName, clientSurname, phone, email, streetAddress, unitNumber, suburb, postalCode, province, contractID, clientType, bankDetails),)
            using (SqlCommand command = new SqlCommand("INSERT INTO dbo.Client (ClientName, ClientSurname, Phone, Email, StreetAddress, UnitNumber, Suburb, PostalCode, Province, ContractID, ClientType, BankDetails)VALUES('" + clientName
                + "','" + clientSurname + "','" + phone + "','" + email + "','" + streetAddress + "','" + unitNumber + "','" + suburb + "','" + postalCode + "','" + province + "','" + contractID + "','" + clientType + "','" + bankDetails + "')", connection))
            {
                try
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.InsertCommand.ExecuteNonQuery();
                    }
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public void DeleteClient(int clientID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("DELETE FROM dbo.Client WHERE ClientID = "+clientID, connection))
            {
                try
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.DeleteCommand.ExecuteNonQuery();
                    }
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

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
                    + "WHERE ClientID = "
                    + clientID, connection))
            {
                try
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.UpdateCommand.ExecuteNonQuery();
                    }
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        public List<Job> TemplateMethod1()
        {
            #region Important Information
            //Here we populate a list of NAMED objects using data from a single table.
            //It Serves as a template for the rest of the methods by adapting the SQL command and constructors accordingly.
            //If you wish to adapt this template, please make sure you check out the data type cheat sheet I personally use:
            //https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
            //And remove the regions marked as "DebuggingCode" as I only made them to test the connection and data transmision.
            //Proper exception handling will be added at a later date.
            //
            // - Albert Wolfaardt
            #endregion
            List<Job> jobsList = new List<Job>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT JobID AS ID, JobName, Salary FROM dbo.Job", connection))
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
                            while (reader.Read())
                            {
                                #region Explanation
                                //We apply Explicit casting where necesarry.
                                //I'm going to be testing the potential of data loss at a later date but for this object specifically it appears fine
                                //- Albert Wolfaardt
                                #endregion
                                Job job = new(reader.GetInt32(reader.GetOrdinal("ID"))
                                    , (string)reader.GetSqlString(reader.GetOrdinal("JobName"))
                                    , (double)reader.GetSqlDouble(reader.GetOrdinal("Salary")));
                                jobsList.Add(job);
                                #region DebuggingCode
                                //Console.WriteLine("We're getting something from the table chief! iteration {0}",iteration);
                                //iteration++;
                                #endregion
                            }
                        }
                        return jobsList;
                    }
                }
                finally
                {
                    connection.Dispose();
                    connection.Close();
                    #region DebuggingCode
                    //if (connection.State == ConnectionState.Closed)
                    //{
                    //    Console.WriteLine("connection to DB succesfully closed");
                    //}
                    #endregion
                }
            }
        }

        public List<TechnicianDetails> TemplateMethod2()
        {
            #region Important Information
            //Here we populate a list of named objects using data from multiple tables.
            //It Serves as a template for other similar methods by adapting the SQL command and constructors accordingly.
            //If you wish to adapt this template, please make sure you check out the data type cheat sheet I personally use:
            //https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
            //And remove the regions marked as "DebuggingCode" as I only made them to test the connection and data transmision.
            //Proper exception handling will be added at a later date.
            //
            // - Albert Wolfaardt
            #endregion
            List<TechnicianDetails> technicianDetails = new List<TechnicianDetails>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT dbo.Employee.EmpName + dbo.Employee.EmpSurname AS FullName, dbo.Specialization.SpecializationName AS Specialization, dbo.Technician.SatisfactionScore, dbo.Job.JobName AS JobTitle, "
                                                       + "dbo.Employee.Phone "
                                                       + "FROM dbo.Employee INNER JOIN "
                                                       + "dbo.Job ON dbo.Employee.JobID = dbo.Job.JobID INNER JOIN "
                                                       + "dbo.Technician ON dbo.Employee.EmpID = dbo.Technician.EmpID INNER JOIN "
                                                       + "dbo.TechnicianSpecialization ON dbo.Technician.EmpID = dbo.TechnicianSpecialization.TechnicianID INNER JOIN "
                                                       + "dbo.Specialization ON dbo.TechnicianSpecialization.SpecializationID = dbo.Specialization.SpecializationID", connection))
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
                            while (reader.Read())
                            {
                                #region Explanation
                                //We apply Explicit casting where necesarry.
                                //I'm going to be testing the potential of data loss at a later date but for this object specifically it appears fine
                                //- Albert Wolfaardt
                                #endregion
                                TechnicianDetails technician = new TechnicianDetails((string)reader.GetSqlString(reader.GetOrdinal("FullName")),
                                                                                     (string)reader.GetSqlString(reader.GetOrdinal("Specialization")),
                                                                                     (double)reader.GetSqlDouble(reader.GetOrdinal("SatisfactionScore")),
                                                                                     (string)reader.GetSqlString(reader.GetOrdinal("JobTitle")),
                                                                                     (string)reader.GetSqlString(reader.GetOrdinal("Phone")));
                                technicianDetails.Add(technician);
                                #region DebuggingCode
                                //Console.WriteLine("We're getting something from the table chief! iteration {0}",iteration);
                                //++iteration;
                                #endregion
                            }
                        }
                        return technicianDetails;
                    }
                }
                finally
                {
                    connection.Dispose();
                    connection.Close();
                    #region DebuggingCode
                    //if (connection.State == ConnectionState.Closed)
                    //{
                    //    Console.WriteLine("connection to DB succesfully closed");
                    //}
                    #endregion
                }
            }
        }

    }
}
