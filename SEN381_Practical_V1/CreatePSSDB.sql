USE [PSSDB]
GO
/****** Object:  Table [dbo].[BankDetails]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankDetails](
	[BankDetailsID] [nchar](40) NOT NULL,
	[PaymentType] [varchar](40) NOT NULL,
	[BankName] [varchar](40) NOT NULL,
	[BranchNum] [varchar](40) NOT NULL,
	[AccountNum] [varchar](40) NOT NULL,
 CONSTRAINT [PK_BankDetails] PRIMARY KEY CLUSTERED 
(
	[BankDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Call]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Call](
	[CallID] [nchar](10) NOT NULL,
	[CallDuration] [nchar](10) NOT NULL,
	[CallDate] [date] NOT NULL,
	[EmpID] [int] NOT NULL,
 CONSTRAINT [PK_Call] PRIMARY KEY CLUSTERED 
(
	[CallID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientID] [nchar](10) NOT NULL,
	[ClientName] [varchar](40) NOT NULL,
	[ClientSurname] [varchar](40) NOT NULL,
	[Phone] [nchar](10) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[StreetAddress] [varchar](40) NOT NULL,
	[UnitNumber] [nchar](10) NULL,
	[Suburb] [varchar](50) NOT NULL,
	[PostalCode] [nchar](4) NOT NULL,
	[Province] [varchar](50) NOT NULL,
	[ContractID] [int] NOT NULL,
	[ClientType] [int] NOT NULL,
	[BankDetails] [nchar](40) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_ClientEmail] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_ClientPhone] UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientCall]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientCall](
	[CallID] [nchar](10) NOT NULL,
	[ClientID] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientContract]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientContract](
	[ClientID] [nchar](10) NOT NULL,
	[ContractID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientType]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientType](
	[ClientType] [int] NOT NULL,
	[ClientID] [nchar](10) NOT NULL,
	[ClientDescription] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ClientType] PRIMARY KEY CLUSTERED 
(
	[ClientType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contract]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract](
	[ContractID] [int] NOT NULL,
	[ContractType] [varchar](40) NOT NULL,
	[ContractDescription] [varchar](40) NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED 
(
	[ContractID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractPackage]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractPackage](
	[ContractID] [int] NOT NULL,
	[PackageID] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpID] [int] NOT NULL,
	[EmpName] [varchar](50) NOT NULL,
	[EmpSurname] [varchar](50) NOT NULL,
	[Phone] [nchar](10) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[PostalAddress] [nchar](10) NOT NULL,
	[StreetName] [varchar](50) NOT NULL,
	[ApartmentNumber] [nchar](10) NULL,
	[Suburb] [varchar](50) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[PostalCode] [nchar](10) NOT NULL,
	[Province] [varchar](50) NOT NULL,
	[DateHired] [date] NOT NULL,
	[JobID] [nchar](10) NOT NULL,
	[LeaveDays] [int] NOT NULL,
	[MaritalStatus] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_EmployeeEmail] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_EmployeePhone] UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[JobID] [nchar](10) NOT NULL,
	[JobName] [varchar](50) NOT NULL,
	[Salary] [float] NOT NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Package]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Package](
	[PackageID] [nchar](10) NOT NULL,
	[PackageName] [varchar](40) NOT NULL,
 CONSTRAINT [PK_Package] PRIMARY KEY CLUSTERED 
(
	[PackageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProblemDetails]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProblemDetails](
	[ProblemID] [nchar](40) NOT NULL,
	[ProblemDescription] [varchar](100) NOT NULL,
	[TicketID] [nchar](100) NOT NULL,
 CONSTRAINT [PK_ProblemDetails] PRIMARY KEY CLUSTERED 
(
	[ProblemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServicePackage]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServicePackage](
	[PackageID] [nchar](10) NOT NULL,
	[ServiceID] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[ServiceID] [nchar](10) NOT NULL,
	[ServiceDescritpion] [varchar](40) NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialization]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialization](
	[SpecializationID] [int] NOT NULL,
	[SpecializationName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Specialization] PRIMARY KEY CLUSTERED 
(
	[SpecializationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Technician]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Technician](
	[EmpID] [int] NOT NULL,
	[SatisfactionScore] [float] NOT NULL,
 CONSTRAINT [PK_Technician] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TechnicianSchedule]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechnicianSchedule](
	[EmpID] [int] NOT NULL,
	[TicketID] [nchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TechnicianSpecialization]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechnicianSpecialization](
	[TechnicianID] [int] NOT NULL,
	[SpecializationID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 2021/03/25 10:50:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[TicketID] [nchar](100) NOT NULL,
	[ProblemID] [nchar](40) NOT NULL,
	[CallID] [nchar](10) NOT NULL,
	[ClientSatisfaction] [float] NULL,
	[Completed] [bit] NOT NULL,
	[DateCompleted] [date] NOT NULL,
	[DateStarted] [date] NOT NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[TicketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_BankDetails] FOREIGN KEY([BankDetails])
REFERENCES [dbo].[BankDetails] ([BankDetailsID])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_BankDetails]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_ClientType] FOREIGN KEY([ClientType])
REFERENCES [dbo].[ClientType] ([ClientType])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_ClientType]
GO
ALTER TABLE [dbo].[ClientCall]  WITH CHECK ADD  CONSTRAINT [FK_ClientCall_Call] FOREIGN KEY([CallID])
REFERENCES [dbo].[Call] ([CallID])
GO
ALTER TABLE [dbo].[ClientCall] CHECK CONSTRAINT [FK_ClientCall_Call]
GO
ALTER TABLE [dbo].[ClientCall]  WITH CHECK ADD  CONSTRAINT [FK_ClientCall_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[ClientCall] CHECK CONSTRAINT [FK_ClientCall_Client]
GO
ALTER TABLE [dbo].[ClientContract]  WITH CHECK ADD  CONSTRAINT [FK_ClientContract_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[ClientContract] CHECK CONSTRAINT [FK_ClientContract_Client]
GO
ALTER TABLE [dbo].[ClientContract]  WITH CHECK ADD  CONSTRAINT [FK_ClientContract_Contract] FOREIGN KEY([ContractID])
REFERENCES [dbo].[Contract] ([ContractID])
GO
ALTER TABLE [dbo].[ClientContract] CHECK CONSTRAINT [FK_ClientContract_Contract]
GO
ALTER TABLE [dbo].[ContractPackage]  WITH CHECK ADD  CONSTRAINT [FK_ContractPackage_Contract] FOREIGN KEY([ContractID])
REFERENCES [dbo].[Contract] ([ContractID])
GO
ALTER TABLE [dbo].[ContractPackage] CHECK CONSTRAINT [FK_ContractPackage_Contract]
GO
ALTER TABLE [dbo].[ContractPackage]  WITH CHECK ADD  CONSTRAINT [FK_ContractPackage_Package] FOREIGN KEY([PackageID])
REFERENCES [dbo].[Package] ([PackageID])
GO
ALTER TABLE [dbo].[ContractPackage] CHECK CONSTRAINT [FK_ContractPackage_Package]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Job] FOREIGN KEY([JobID])
REFERENCES [dbo].[Job] ([JobID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Job]
GO
ALTER TABLE [dbo].[ServicePackage]  WITH CHECK ADD  CONSTRAINT [FK_ServicePackage_Package] FOREIGN KEY([PackageID])
REFERENCES [dbo].[Package] ([PackageID])
GO
ALTER TABLE [dbo].[ServicePackage] CHECK CONSTRAINT [FK_ServicePackage_Package]
GO
ALTER TABLE [dbo].[ServicePackage]  WITH CHECK ADD  CONSTRAINT [FK_ServicePackage_Services] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Services] ([ServiceID])
GO
ALTER TABLE [dbo].[ServicePackage] CHECK CONSTRAINT [FK_ServicePackage_Services]
GO
ALTER TABLE [dbo].[Technician]  WITH CHECK ADD  CONSTRAINT [FK_Technician_Employee] FOREIGN KEY([EmpID])
REFERENCES [dbo].[Employee] ([EmpID])
GO
ALTER TABLE [dbo].[Technician] CHECK CONSTRAINT [FK_Technician_Employee]
GO
ALTER TABLE [dbo].[TechnicianSchedule]  WITH CHECK ADD  CONSTRAINT [FK_TechnicianSchedule_Technician] FOREIGN KEY([EmpID])
REFERENCES [dbo].[Technician] ([EmpID])
GO
ALTER TABLE [dbo].[TechnicianSchedule] CHECK CONSTRAINT [FK_TechnicianSchedule_Technician]
GO
ALTER TABLE [dbo].[TechnicianSchedule]  WITH CHECK ADD  CONSTRAINT [FK_TechnicianSchedule_Ticket] FOREIGN KEY([TicketID])
REFERENCES [dbo].[Ticket] ([TicketID])
GO
ALTER TABLE [dbo].[TechnicianSchedule] CHECK CONSTRAINT [FK_TechnicianSchedule_Ticket]
GO
ALTER TABLE [dbo].[TechnicianSpecialization]  WITH CHECK ADD  CONSTRAINT [FK_TechnicianSpecialization_Specialization] FOREIGN KEY([SpecializationID])
REFERENCES [dbo].[Specialization] ([SpecializationID])
GO
ALTER TABLE [dbo].[TechnicianSpecialization] CHECK CONSTRAINT [FK_TechnicianSpecialization_Specialization]
GO
ALTER TABLE [dbo].[TechnicianSpecialization]  WITH CHECK ADD  CONSTRAINT [FK_TechnicianSpecialization_Technician] FOREIGN KEY([TechnicianID])
REFERENCES [dbo].[Technician] ([EmpID])
GO
ALTER TABLE [dbo].[TechnicianSpecialization] CHECK CONSTRAINT [FK_TechnicianSpecialization_Technician]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Call] FOREIGN KEY([CallID])
REFERENCES [dbo].[Call] ([CallID])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Call]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_ProblemDetails] FOREIGN KEY([ProblemID])
REFERENCES [dbo].[ProblemDetails] ([ProblemID])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_ProblemDetails]
GO
