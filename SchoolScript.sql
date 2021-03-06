USE [master]
GO
/****** Object:  Database [SchoolManagement]    Script Date: 02/28/2018 10:31:54 ******/
CREATE DATABASE [SchoolManagement] ON  PRIMARY 
( NAME = N'SchoolManagement', FILENAME = N'D:\Projects\aarsha\SchoolManagement.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SchoolManagement_log', FILENAME = N'D:\Projects\aarsha\SchoolManagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SchoolManagement] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolManagement] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SchoolManagement] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SchoolManagement] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SchoolManagement] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SchoolManagement] SET ARITHABORT OFF
GO
ALTER DATABASE [SchoolManagement] SET AUTO_CLOSE ON
GO
ALTER DATABASE [SchoolManagement] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SchoolManagement] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SchoolManagement] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SchoolManagement] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SchoolManagement] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SchoolManagement] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SchoolManagement] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SchoolManagement] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SchoolManagement] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SchoolManagement] SET  DISABLE_BROKER
GO
ALTER DATABASE [SchoolManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SchoolManagement] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SchoolManagement] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SchoolManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SchoolManagement] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SchoolManagement] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [SchoolManagement] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [SchoolManagement] SET  READ_WRITE
GO
ALTER DATABASE [SchoolManagement] SET RECOVERY SIMPLE
GO
ALTER DATABASE [SchoolManagement] SET  MULTI_USER
GO
ALTER DATABASE [SchoolManagement] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SchoolManagement] SET DB_CHAINING OFF
GO
USE [SchoolManagement]
GO
/****** Object:  Table [dbo].[PivotExample]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PivotExample](
	[Country] [nvarchar](50) NULL,
	[Year] [smallint] NOT NULL,
	[SalesAmount] [money] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'Australia', 2005, 1309047.1978)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'Germany', 2006, 521230.8475)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'United States', 2007, 2838512.3550)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'France', 2008, 922179.0400)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'Australia', 2007, 3033784.2131)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'France', 2005, 180571.6920)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'United Kingdom', 2006, 591586.8540)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'Canada', 2006, 621602.3823)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'United Kingdom', 2005, 291590.5194)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'United States', 2005, 1100549.4498)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'Canada', 2007, 535784.4624)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'France', 2007, 1026324.9692)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'Germany', 2007, 1058405.7305)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'Australia', 2006, 2154284.8835)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'United Kingdom', 2008, 1210286.2700)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'United States', 2008, 3324031.1600)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'Germany', 2008, 1076890.7700)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'United Kingdom', 2007, 1298248.5675)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'Australia', 2008, 2563884.2900)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'Canada', 2005, 146829.8074)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'Germany', 2005, 237784.9902)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'Canada', 2008, 673628.2100)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'United States', 2006, 2126696.5460)
INSERT [dbo].[PivotExample] ([Country], [Year], [SalesAmount]) VALUES (N'France', 2006, 514942.0131)
/****** Object:  Table [dbo].[AllInventories]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AllInventories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NULL,
	[UDF1] [nvarchar](50) NULL,
	[CreateDate] [nvarchar](50) NULL,
 CONSTRAINT [PK_AllInventories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AllInventories] ON
INSERT [dbo].[AllInventories] ([Id], [ItemName], [Description], [UDF1], [CreateDate]) VALUES (1, N'Books', N'For Class2', NULL, N'Feb 25 2018  5:04PM')
SET IDENTITY_INSERT [dbo].[AllInventories] OFF
/****** Object:  Table [dbo].[chk]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chk](
	[chk] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_TeacherInfo]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_TeacherInfo](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[FatherName] [nvarchar](50) NULL,
	[MotherName] [nvarchar](50) NULL,
	[DOB] [date] NULL,
	[Age] [nvarchar](50) NULL,
	[Designation] [nvarchar](50) NULL,
	[Nationality] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Qualification] [nvarchar](50) NULL,
	[EMailId] [nvarchar](50) NULL,
	[Address] [varchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Phone_Number] [nvarchar](50) NULL,
	[AadharCardNo] [nvarchar](50) NULL,
	[UDF1] [nvarchar](50) NULL,
	[UDF2] [nvarchar](50) NULL,
	[UDF3] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_TeacherInfo] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_StudentInfo]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_StudentInfo](
	[StdId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Stud_In_Class] [nvarchar](50) NULL,
	[Class] [nvarchar](50) NULL,
	[Session_Year] [nvarchar](50) NULL,
	[RollNumber] [nvarchar](50) NULL,
	[Addmission_Number] [int] NULL,
	[Admission_Date] [date] NULL,
	[Acc_Number] [nvarchar](50) NULL,
	[FatherName] [nvarchar](200) NULL,
	[MotherName] [nvarchar](200) NULL,
	[DOB] [date] NULL,
	[Gender] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[SiblingClass] [nvarchar](50) NULL,
	[SiblingSchool] [nvarchar](50) NULL,
	[Nationality] [nvarchar](50) NULL,
	[EmailId] [nvarchar](50) NULL,
	[Address1] [nvarchar](500) NULL,
	[Address2] [nvarchar](500) NULL,
	[City] [nvarchar](50) NULL,
	[PhoneRes] [nvarchar](50) NULL,
	[PhoneOff] [nvarchar](50) NULL,
	[AadharCardNo] [nvarchar](50) NULL,
	[SRN_No] [nvarchar](50) NULL,
	[CBSC_REG_No] [nvarchar](50) NULL,
	[BankAccount_No] [nvarchar](50) NULL,
	[IFSC] [nvarchar](50) NULL,
	[DiscountType] [nvarchar](50) NULL,
	[BloodGroup] [nvarchar](50) NULL,
	[BoarderRequired] [nvarchar](50) NULL,
	[Route_No] [nvarchar](50) NULL,
	[ORG_Adm_no] [nvarchar](50) NULL,
	[MobileSms] [nvarchar](50) NULL,
	[Stopage] [nvarchar](50) NULL,
	[Income] [nvarchar](50) NULL,
	[DND] [datetime] NULL,
	[BPL] [nvarchar](50) NULL,
	[DisabilityType] [nvarchar](50) NULL,
	[CWSN] [nvarchar](50) NULL,
	[HomeLessChild] [nvarchar](50) NULL,
	[Extra_Exam] [nvarchar](50) NULL,
	[Last_Exam_Appear] [nvarchar](50) NULL,
	[Last_Exam_Passed] [nvarchar](50) NULL,
	[Last_Exam_Percent] [nvarchar](50) NULL,
	[Stream_11] [nvarchar](50) NULL,
	[Free_Edu] [nvarchar](50) NULL,
	[Trade_Skill] [nvarchar](50) NULL,
	[DisAdvantages] [nvarchar](50) NULL,
	[MotherToung] [nvarchar](50) NULL,
	[Medium_of_Instruction] [nvarchar](50) NULL,
	[Previous_year_Att] [nvarchar](50) NULL,
	[Previous_Year_Status] [nvarchar](50) NULL,
	[Other_Info] [nvarchar](500) NULL,
	[UDF1] [nvarchar](50) NULL,
	[UDF2] [nvarchar](50) NULL,
	[UDF3] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_StudentInfo] PRIMARY KEY CLUSTERED 
(
	[StdId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_StudentInfo] ON
INSERT [dbo].[tbl_StudentInfo] ([StdId], [Name], [Stud_In_Class], [Class], [Session_Year], [RollNumber], [Addmission_Number], [Admission_Date], [Acc_Number], [FatherName], [MotherName], [DOB], [Gender], [Category], [SiblingClass], [SiblingSchool], [Nationality], [EmailId], [Address1], [Address2], [City], [PhoneRes], [PhoneOff], [AadharCardNo], [SRN_No], [CBSC_REG_No], [BankAccount_No], [IFSC], [DiscountType], [BloodGroup], [BoarderRequired], [Route_No], [ORG_Adm_no], [MobileSms], [Stopage], [Income], [DND], [BPL], [DisabilityType], [CWSN], [HomeLessChild], [Extra_Exam], [Last_Exam_Appear], [Last_Exam_Passed], [Last_Exam_Percent], [Stream_11], [Free_Edu], [Trade_Skill], [DisAdvantages], [MotherToung], [Medium_of_Instruction], [Previous_year_Att], [Previous_Year_Status], [Other_Info], [UDF1], [UDF2], [UDF3], [CreateDate], [ModifiedDate]) VALUES (1, N'Shashi Bhan Maurya', N'', N'Lkg', N'2017-2018', N'1', 1, CAST(0xEA3D0B00 AS Date), N'', N'Ram', N'Mala', CAST(0x690F0B00 AS Date), N'M', N'General', N'', N'', N'Indian', N'ee', N'add', N'ad2', N'delhi', N'', N'', N'12312131', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', CAST(0x0000A99500000000 AS DateTime), N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', NULL, NULL, NULL, CAST(0x0000A88F017ECA6C AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[tbl_StudentInfo] OFF
/****** Object:  Table [dbo].[tbl_StudentAnnualFeeStructure]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_StudentAnnualFeeStructure](
	[FeeId] [int] IDENTITY(1,1) NOT NULL,
	[Session] [nvarchar](50) NULL,
	[Addmission_Number] [nvarchar](50) NULL,
	[Name] [nvarchar](200) NULL,
	[Class] [nvarchar](50) NULL,
	[Acc_Number] [nvarchar](50) NULL,
	[RegistrationFee] [nvarchar](50) NULL,
	[AddmissionFee] [nvarchar](50) NULL,
	[AnnualCharges] [nvarchar](50) NULL,
	[TutionFee] [nvarchar](50) NULL,
	[QuaterlyFee] [nvarchar](50) NULL,
	[TransportFee] [nvarchar](50) NULL,
	[RegistrationFee_Disc] [nvarchar](50) NULL,
	[AddmissionFee_Disc] [nvarchar](50) NULL,
	[AnnualCharges_Disc] [nvarchar](50) NULL,
	[TutionFee_Disc] [nvarchar](50) NULL,
	[QuaterlyFee_Disc] [nvarchar](50) NULL,
	[TransportFee_Disc] [nvarchar](50) NULL,
	[Act_RegistrationFee] [nvarchar](50) NULL,
	[Act_AddmissionFee] [nvarchar](50) NULL,
	[Act_AnnualCharges] [nvarchar](50) NULL,
	[Act_TutionFee] [nvarchar](50) NULL,
	[Act_QuaterlyFee] [nvarchar](50) NULL,
	[Act_TransportFee] [nvarchar](50) NULL,
	[TotalAmount] [nvarchar](50) NULL,
	[UDF1] [nvarchar](50) NULL,
	[UDF2] [nvarchar](50) NULL,
	[UDF3] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_AnnualFee] PRIMARY KEY CLUSTERED 
(
	[FeeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_StudentAnnualFeeStructure] ON
INSERT [dbo].[tbl_StudentAnnualFeeStructure] ([FeeId], [Session], [Addmission_Number], [Name], [Class], [Acc_Number], [RegistrationFee], [AddmissionFee], [AnnualCharges], [TutionFee], [QuaterlyFee], [TransportFee], [RegistrationFee_Disc], [AddmissionFee_Disc], [AnnualCharges_Disc], [TutionFee_Disc], [QuaterlyFee_Disc], [TransportFee_Disc], [Act_RegistrationFee], [Act_AddmissionFee], [Act_AnnualCharges], [Act_TutionFee], [Act_QuaterlyFee], [Act_TransportFee], [TotalAmount], [UDF1], [UDF2], [UDF3], [CreateDate], [ModifiedDate]) VALUES (1, N'2017-2018', N'1', N'Shashi Bhan Maurya', N'Lkg', N'1', N'100', N'100', N'100', N'100', N'100', N'100', N'10', N'10', N'0.00', N'0.00', N'0.00', N'0.00', N'90', N'90', N'100', N'100', N'100', N'100', N'180', NULL, NULL, NULL, CAST(0x0000A88F017EF0F9 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[tbl_StudentAnnualFeeStructure] OFF
/****** Object:  Table [dbo].[tbl_Student_MonthlyFeeDeposit]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Student_MonthlyFeeDeposit](
	[FeeId] [int] IDENTITY(1,1) NOT NULL,
	[Session] [nvarchar](50) NULL,
	[MonthCount] [int] NULL,
	[PaidForMonths] [nvarchar](500) NULL,
	[PaidInMonth] [nvarchar](10) NULL,
	[Name] [nvarchar](100) NULL,
	[Addmission_Number] [nvarchar](50) NULL,
	[Class] [nvarchar](50) NULL,
	[Acc_Number] [nvarchar](50) NULL,
	[RegistrationFee] [float] NULL,
	[AddmissionFee] [float] NULL,
	[AnnualCharges] [float] NULL,
	[TutionFee] [float] NULL,
	[QuaterlyFee] [float] NULL,
	[TransportFee] [float] NULL,
	[RegistrationFee_Disc] [float] NULL,
	[AddmissionFee_Disc] [float] NULL,
	[AnnualCharges_Disc] [float] NULL,
	[TutionFee_Disc] [float] NULL,
	[QuaterlyFee_Disc] [float] NULL,
	[TransportFee_Disc] [float] NULL,
	[Act_RegistrationFee] [float] NULL,
	[Act_AddmissionFee] [float] NULL,
	[Act_AnnualCharges] [float] NULL,
	[Act_TutionFee] [float] NULL,
	[Act_QuaterlyFee] [float] NULL,
	[Act_TransportFee] [float] NULL,
	[MiscCharges] [float] NULL,
	[TotalAmount] [float] NULL,
	[PaidAmount] [float] NULL,
	[PaymentType] [nvarchar](50) NULL,
	[Balance] [float] NULL,
	[UDF1] [nvarchar](50) NULL,
	[UDF2] [nvarchar](50) NULL,
	[UDF3] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Student_MonthlyFee] PRIMARY KEY CLUSTERED 
(
	[FeeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Student_MonthlyFeeDeposit] ON
INSERT [dbo].[tbl_Student_MonthlyFeeDeposit] ([FeeId], [Session], [MonthCount], [PaidForMonths], [PaidInMonth], [Name], [Addmission_Number], [Class], [Acc_Number], [RegistrationFee], [AddmissionFee], [AnnualCharges], [TutionFee], [QuaterlyFee], [TransportFee], [RegistrationFee_Disc], [AddmissionFee_Disc], [AnnualCharges_Disc], [TutionFee_Disc], [QuaterlyFee_Disc], [TransportFee_Disc], [Act_RegistrationFee], [Act_AddmissionFee], [Act_AnnualCharges], [Act_TutionFee], [Act_QuaterlyFee], [Act_TransportFee], [MiscCharges], [TotalAmount], [PaidAmount], [PaymentType], [Balance], [UDF1], [UDF2], [UDF3], [CreateDate], [ModifiedDate]) VALUES (1, N'2017-2018', 11, N'April,May,June,July,August,September,October,November,December,January,February', N'Apr', N'Shashi Bhan Maurya', N'1', N'Lkg', N'1', 100, 100, 100, 100, 100, 100, 10, 10, 0, 0, 0, 0, 90, 90, 100, 1100, 100, 100, 100, 1680, 1600, N'  Cash', 80, NULL, NULL, NULL, CAST(0x0000A890000006C7 AS DateTime), CAST(0x0000A890000006C7 AS DateTime))
INSERT [dbo].[tbl_Student_MonthlyFeeDeposit] ([FeeId], [Session], [MonthCount], [PaidForMonths], [PaidInMonth], [Name], [Addmission_Number], [Class], [Acc_Number], [RegistrationFee], [AddmissionFee], [AnnualCharges], [TutionFee], [QuaterlyFee], [TransportFee], [RegistrationFee_Disc], [AddmissionFee_Disc], [AnnualCharges_Disc], [TutionFee_Disc], [QuaterlyFee_Disc], [TransportFee_Disc], [Act_RegistrationFee], [Act_AddmissionFee], [Act_AnnualCharges], [Act_TutionFee], [Act_QuaterlyFee], [Act_TransportFee], [MiscCharges], [TotalAmount], [PaidAmount], [PaymentType], [Balance], [UDF1], [UDF2], [UDF3], [CreateDate], [ModifiedDate]) VALUES (2, N'2017-2018', 11, N'April,May,June,July,August,September,October,November,December,January,February', N'May', N'Shashi Bhan Maurya', N'1', N'Lkg', N'1', 100, 100, 100, 100, 100, 100, 10, 10, 0, 0, 0, 0, 90, 90, 100, 1100, 100, 100, 100, 1680, 1600, N'  Cash', 80, NULL, NULL, NULL, CAST(0x0000A890000006C7 AS DateTime), CAST(0x0000A890000006C7 AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_Student_MonthlyFeeDeposit] OFF
/****** Object:  Table [dbo].[tbl_Student_AnnualOneTimeFeeDeposit]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Student_AnnualOneTimeFeeDeposit](
	[FeeId] [int] IDENTITY(1,1) NOT NULL,
	[Addmission_Number] [nvarchar](50) NULL,
	[Class] [nvarchar](50) NULL,
	[Acc_Number] [nvarchar](50) NULL,
	[RegistrationFee] [nvarchar](50) NULL,
	[AddmissionFee] [nvarchar](50) NULL,
	[AnnualCharges] [nvarchar](50) NULL,
	[TutionFee] [nvarchar](50) NULL,
	[QuaterlyFee] [nvarchar](50) NULL,
	[TransportFee] [nvarchar](50) NULL,
	[RegistrationFee_Disc] [nvarchar](50) NULL,
	[AddmissionFee_Disc] [nvarchar](50) NULL,
	[AnnualCharges_Disc] [nvarchar](50) NULL,
	[TutionFee_Disc] [nvarchar](50) NULL,
	[QuaterlyFee_Disc] [nvarchar](50) NULL,
	[TransportFee_Disc] [nvarchar](50) NULL,
	[Act_RegistrationFee] [nvarchar](50) NULL,
	[Act_AddmissionFee] [nvarchar](50) NULL,
	[Act_AnnualCharges] [nvarchar](50) NULL,
	[Act_TutionFee] [nvarchar](50) NULL,
	[Act_QuaterlyFee] [nvarchar](50) NULL,
	[Act_TransportFee] [nvarchar](50) NULL,
	[TotalAmount] [nvarchar](50) NULL,
	[UDF1] [nvarchar](50) NULL,
	[UDF2] [nvarchar](50) NULL,
	[UDF3] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Student_AnnualOneTimeFee] PRIMARY KEY CLUSTERED 
(
	[FeeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_OtherExpenses]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_OtherExpenses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Expenses] [nvarchar](100) NULL,
	[UDF1] [nvarchar](50) NULL,
	[UDF2] [nvarchar](50) NULL,
	[UDF3] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_OtherExpenses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_InvestmentForOtherPurposes]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_InvestmentForOtherPurposes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Purpose] [nvarchar](50) NULL,
	[Quantity] [nvarchar](50) NULL,
	[Amount] [nvarchar](50) NULL,
	[Date] [nvarchar](50) NULL,
	[UDF1] [nvarchar](50) NULL,
	[UDF2] [nvarchar](50) NULL,
	[UDF3] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_InvestmentForOtherPurposes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_InvestmentForOtherPurposes] ON
INSERT [dbo].[tbl_InvestmentForOtherPurposes] ([Id], [Purpose], [Quantity], [Amount], [Date], [UDF1], [UDF2], [UDF3], [CreatedDate]) VALUES (1, N'--Select--', N'test', N'32', N'2/25/2018 3:58:40 PM', NULL, NULL, NULL, CAST(0x0000A892010767CF AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_InvestmentForOtherPurposes] OFF
/****** Object:  Table [dbo].[tbl_Inventory]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Inventory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](50) NULL,
	[Quantity] [nvarchar](50) NULL,
	[Amount] [nvarchar](50) NULL,
	[InventoryType] [nvarchar](50) NULL,
	[Date] [date] NULL,
	[UDF1] [nvarchar](50) NULL,
	[UDF2] [nvarchar](50) NULL,
	[UDF3] [nvarchar](50) NULL,
	[CreatedDate] [nvarchar](50) NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Inventory] ON
INSERT [dbo].[tbl_Inventory] ([Id], [ItemName], [Quantity], [Amount], [InventoryType], [Date], [UDF1], [UDF2], [UDF3], [CreatedDate]) VALUES (1, N'Books', N'200', N'2500', N'IN', CAST(0xED3D0B00 AS Date), N'Description Test', NULL, NULL, N'Feb 25 2018  5:05PM')
INSERT [dbo].[tbl_Inventory] ([Id], [ItemName], [Quantity], [Amount], [InventoryType], [Date], [UDF1], [UDF2], [UDF3], [CreatedDate]) VALUES (2, N'--Select--', N'', N'', N'', CAST(0xEE3D0B00 AS Date), N'', NULL, NULL, N'Feb 26 2018 11:16PM')
SET IDENTITY_INSERT [dbo].[tbl_Inventory] OFF
/****** Object:  Table [dbo].[tbl_EmployeeSalarySlip]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_EmployeeSalarySlip](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[BasicSalary] [nvarchar](50) NULL,
	[DearnessAllowance] [nvarchar](50) NULL,
	[MedicalAllowance] [nvarchar](50) NULL,
	[TransportAllowance] [nvarchar](50) NULL,
	[ProfessionTax] [nvarchar](50) NULL,
	[ProvidentFund] [nvarchar](50) NULL,
	[IncomeTax] [nvarchar](50) NULL,
	[UDF1] [nvarchar](50) NULL,
	[UDF2] [nvarchar](50) NULL,
	[UDF3] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_EmployeeSalarySlip] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_EmployeeInfo]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_EmployeeInfo](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[FatherName] [nvarchar](100) NULL,
	[MotherName] [nvarchar](50) NULL,
	[DOB] [datetime] NULL,
	[Age] [nvarchar](50) NULL,
	[MaritalStatus] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Nationality] [nvarchar](50) NULL,
	[Salary] [nvarchar](50) NULL,
	[Department] [nvarchar](50) NULL,
	[HireDate] [datetime] NULL,
	[Address1] [nvarchar](200) NULL,
	[Address2] [nvarchar](200) NULL,
	[City] [nvarchar](50) NULL,
	[ResignationDate] [datetime] NULL,
	[JobTitle] [nvarchar](50) NULL,
	[Qualification] [nvarchar](50) NULL,
	[ExperienceInYear] [nvarchar](50) NULL,
	[AadharCardNo] [nvarchar](50) NULL,
	[UDF1] [nvarchar](50) NULL,
	[UDF2] [nvarchar](50) NULL,
	[UDF3] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_Employee] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ClasswiseAnnualFeeStructure]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ClasswiseAnnualFeeStructure](
	[StdId] [int] IDENTITY(1,1) NOT NULL,
	[SessionYear] [nvarchar](50) NULL,
	[Class] [nvarchar](50) NULL,
	[RegistrationFee] [nvarchar](50) NULL,
	[AdmissionFee] [nvarchar](50) NULL,
	[AnnualCharge] [nvarchar](50) NULL,
	[TutionFee] [nvarchar](50) NULL,
	[ChildFund] [nvarchar](50) NULL,
	[Misc] [nvarchar](50) NULL,
	[ComputerFee] [nvarchar](50) NULL,
	[ExamFee] [nvarchar](50) NULL,
	[LateFee] [nvarchar](50) NULL,
	[SecurityDeposite] [nvarchar](50) NULL,
	[TransportFee] [nvarchar](50) NULL,
	[ScienceFee] [nvarchar](50) NULL,
	[SportsFee] [nvarchar](50) NULL,
	[LibraryFee] [nvarchar](50) NULL,
	[IsActive] [nvarchar](50) NULL,
	[ReportCardFee] [nvarchar](50) NULL,
	[UDF1] [nvarchar](50) NULL,
	[UDF2] [nvarchar](50) NULL,
	[UDF3] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_Fee] PRIMARY KEY CLUSTERED 
(
	[StdId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_ClasswiseAnnualFeeStructure] ON
INSERT [dbo].[tbl_ClasswiseAnnualFeeStructure] ([StdId], [SessionYear], [Class], [RegistrationFee], [AdmissionFee], [AnnualCharge], [TutionFee], [ChildFund], [Misc], [ComputerFee], [ExamFee], [LateFee], [SecurityDeposite], [TransportFee], [ScienceFee], [SportsFee], [LibraryFee], [IsActive], [ReportCardFee], [UDF1], [UDF2], [UDF3], [CreateDate], [ModifiedDate]) VALUES (1, N'2017-2018', N'Lkg', N'56', N'65', N'6', N'56', N'56', N'5', N'', N'', N'', N'', N'', N'', N'', N'', NULL, N'', NULL, NULL, NULL, CAST(0x0000A89200D6402D AS DateTime), NULL)
INSERT [dbo].[tbl_ClasswiseAnnualFeeStructure] ([StdId], [SessionYear], [Class], [RegistrationFee], [AdmissionFee], [AnnualCharge], [TutionFee], [ChildFund], [Misc], [ComputerFee], [ExamFee], [LateFee], [SecurityDeposite], [TransportFee], [ScienceFee], [SportsFee], [LibraryFee], [IsActive], [ReportCardFee], [UDF1], [UDF2], [UDF3], [CreateDate], [ModifiedDate]) VALUES (2, N'2017-2018', N'Lkg', N'565', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', NULL, N'', NULL, NULL, NULL, CAST(0x0000A89200D66540 AS DateTime), NULL)
INSERT [dbo].[tbl_ClasswiseAnnualFeeStructure] ([StdId], [SessionYear], [Class], [RegistrationFee], [AdmissionFee], [AnnualCharge], [TutionFee], [ChildFund], [Misc], [ComputerFee], [ExamFee], [LateFee], [SecurityDeposite], [TransportFee], [ScienceFee], [SportsFee], [LibraryFee], [IsActive], [ReportCardFee], [UDF1], [UDF2], [UDF3], [CreateDate], [ModifiedDate]) VALUES (3, N'2017-2018', N'Lkg', N'56', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', NULL, N'', NULL, NULL, NULL, CAST(0x0000A89200D7211E AS DateTime), NULL)
INSERT [dbo].[tbl_ClasswiseAnnualFeeStructure] ([StdId], [SessionYear], [Class], [RegistrationFee], [AdmissionFee], [AnnualCharge], [TutionFee], [ChildFund], [Misc], [ComputerFee], [ExamFee], [LateFee], [SecurityDeposite], [TransportFee], [ScienceFee], [SportsFee], [LibraryFee], [IsActive], [ReportCardFee], [UDF1], [UDF2], [UDF3], [CreateDate], [ModifiedDate]) VALUES (4, N'2017-2018', N'Lkg', N'56', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', NULL, N'', NULL, NULL, NULL, CAST(0x0000A89200D827A8 AS DateTime), NULL)
INSERT [dbo].[tbl_ClasswiseAnnualFeeStructure] ([StdId], [SessionYear], [Class], [RegistrationFee], [AdmissionFee], [AnnualCharge], [TutionFee], [ChildFund], [Misc], [ComputerFee], [ExamFee], [LateFee], [SecurityDeposite], [TransportFee], [ScienceFee], [SportsFee], [LibraryFee], [IsActive], [ReportCardFee], [UDF1], [UDF2], [UDF3], [CreateDate], [ModifiedDate]) VALUES (5, N'2017-2018', N'Lkg', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', NULL, N'', NULL, NULL, NULL, CAST(0x0000A893017EDE9B AS DateTime), NULL)
INSERT [dbo].[tbl_ClasswiseAnnualFeeStructure] ([StdId], [SessionYear], [Class], [RegistrationFee], [AdmissionFee], [AnnualCharge], [TutionFee], [ChildFund], [Misc], [ComputerFee], [ExamFee], [LateFee], [SecurityDeposite], [TransportFee], [ScienceFee], [SportsFee], [LibraryFee], [IsActive], [ReportCardFee], [UDF1], [UDF2], [UDF3], [CreateDate], [ModifiedDate]) VALUES (6, N'2017-2018', N'Lkg', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', NULL, N'', NULL, NULL, NULL, CAST(0x0000A893017EEFAA AS DateTime), NULL)
INSERT [dbo].[tbl_ClasswiseAnnualFeeStructure] ([StdId], [SessionYear], [Class], [RegistrationFee], [AdmissionFee], [AnnualCharge], [TutionFee], [ChildFund], [Misc], [ComputerFee], [ExamFee], [LateFee], [SecurityDeposite], [TransportFee], [ScienceFee], [SportsFee], [LibraryFee], [IsActive], [ReportCardFee], [UDF1], [UDF2], [UDF3], [CreateDate], [ModifiedDate]) VALUES (7, N'2017-2018', N'Lkg', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', NULL, N'', NULL, NULL, NULL, CAST(0x0000A893017EFE75 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[tbl_ClasswiseAnnualFeeStructure] OFF
/****** Object:  Table [dbo].[StudentStatementToPrintCrystalReport]    Script Date: 02/28/2018 10:31:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentStatementToPrintCrystalReport](
	[Addmission_Number] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[FatherName] [nvarchar](50) NULL,
	[PhoneOff] [nvarchar](50) NULL,
	[Apr] [nvarchar](10) NOT NULL,
	[May] [nvarchar](10) NOT NULL,
	[Jun] [nvarchar](10) NOT NULL,
	[Jul] [nvarchar](10) NOT NULL,
	[Aug] [nvarchar](10) NOT NULL,
	[Sep] [nvarchar](10) NOT NULL,
	[Oct] [nvarchar](10) NOT NULL,
	[Nov] [nvarchar](10) NOT NULL,
	[Dec] [nvarchar](10) NOT NULL,
	[Jan] [nvarchar](10) NOT NULL,
	[Feb] [nvarchar](10) NOT NULL,
	[Mar] [nvarchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[StudentInfo_SelectOneBySession]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[StudentInfo_SelectOneBySession]
(
@Addmission_Number int
,@Session nvarchar(50)
)
as
begin
select top (1) Name,Stud_In_Class,Class,Session_Year ,RollNumber,Addmission_Number,Admission_Date,Acc_Number,FatherName,MotherName,Gender,DOB,
Category,SiblingClass,SiblingSchool,Nationality,EmailId,Address1 ,Address2 ,City,PhoneRes ,PhoneOff ,AadharCardNo ,SRN_No ,CBSC_REG_No ,
BankAccount_No,IFSC ,DiscountType ,BloodGroup ,BoarderRequired,Route_No,ORG_Adm_no ,MobileSms ,Stopage ,Income ,DND ,BPL ,DisabilityType,CWSN ,HomeLessChild ,
Extra_Exam ,Last_Exam_Appear ,Last_Exam_Passed ,Last_Exam_Percent ,Stream_11 ,Free_Edu ,Trade_Skill,DisAdvantages,MotherToung ,Medium_of_Instruction ,
Previous_year_Att ,Previous_Year_Status ,Other_Info ,UDF1 ,UDF2,UDF3 from tbl_StudentInfo 
where Addmission_Number=@Addmission_Number 
 and Session_Year=@Session 
order by CreateDate desc 
end
-- exec StudentInfo_SelectOneBySession 3, '2017-2018'
GO
/****** Object:  StoredProcedure [dbo].[StudentInfo_SelectOne]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[StudentInfo_SelectOne]
(
@Addmission_Number nvarchar(50)
)
as
begin
select top (1) Name,Stud_In_Class,Class,Session_Year ,RollNumber,Addmission_Number,Admission_Date,Acc_Number,FatherName,MotherName,Gender,DOB,
Category,SiblingClass,SiblingSchool,Nationality,EmailId,Address1 ,Address2 ,City,PhoneRes ,PhoneOff ,AadharCardNo ,SRN_No ,CBSC_REG_No ,
BankAccount_No,IFSC ,DiscountType ,BloodGroup ,BoarderRequired,Route_No,ORG_Adm_no ,MobileSms ,Stopage ,Income ,DND ,BPL ,DisabilityType,CWSN ,HomeLessChild ,
Extra_Exam ,Last_Exam_Appear ,Last_Exam_Passed ,Last_Exam_Percent ,Stream_11 ,Free_Edu ,Trade_Skill,DisAdvantages,MotherToung ,Medium_of_Instruction ,
Previous_year_Att ,Previous_Year_Status ,Other_Info ,UDF1 ,UDF2,UDF3 from tbl_StudentInfo where Addmission_Number=@Addmission_Number order by CreateDate desc 
end
-- exec StudentInfo_SelectOne 4
GO
/****** Object:  StoredProcedure [dbo].[StudentInfo_SelectAll]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[StudentInfo_SelectAll]
AS
Begin
select Name,Stud_In_Class,Class,Session_Year ,RollNumber,Addmission_Number,Admission_Date,Acc_Number,FatherName,MotherName,Gender,DOB,
Category,SiblingClass,SiblingSchool,Nationality,EmailId,Address1 ,Address2 ,City,PhoneRes ,PhoneOff ,AadharCardNo ,SRN_No ,CBSC_REG_No ,
BankAccount_No,IFSC ,DiscountType ,BloodGroup ,BoarderRequired,Route_No,ORG_Adm_no ,MobileSms ,Stopage ,Income ,DND ,BPL ,DisabilityType,CWSN ,HomeLessChild ,
Extra_Exam ,Last_Exam_Appear ,Last_Exam_Passed ,Last_Exam_Percent ,Stream_11 ,Free_Edu ,Trade_Skill,DisAdvantages,MotherToung ,Medium_of_Instruction ,
Previous_year_Att ,Previous_Year_Status ,Other_Info ,UDF1 ,UDF2,UDF3 from tbl_StudentInfo
End
GO
/****** Object:  StoredProcedure [dbo].[StudentInfo_SearchForFeeDeposit]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[StudentInfo_SearchForFeeDeposit]  
(  
@SearchPhrase nvarchar(50)  
,@Class nvarchar(50)  
,@Session nvarchar(50)  
  
)  
as  
begin  
if(@SearchPhrase!='')  
begin  
select Addmission_Number,Name,Class,Session_Year ,RollNumber,Addmission_Number,  
Admission_Date,Acc_Number,FatherName,MotherName,Gender,DOB  
from tbl_StudentInfo   
where Class=@Class and Session_Year=@Session and Name like '%'+@SearchPhrase+'%'   
order by CreateDate desc   
end  
else  
begin  
select Addmission_Number,Name,Class,Session_Year ,RollNumber,  
Admission_Date,Acc_Number,FatherName,MotherName,Gender,DOB  
from tbl_StudentInfo   
where Class=@Class and Session_Year=@Session  
order by CreateDate desc   
end  
end  
-- exec StudentInfo_SearchForFeeDeposit '','Lkg', '2017-2018'
GO
/****** Object:  StoredProcedure [dbo].[StudentInfo_Insert]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[StudentInfo_Insert]  
(  
@StdId int out,  
@Name nvarchar(200),  
@Stud_In_Class nvarchar(50),  
@Class nvarchar(50),  
@Session_Year nvarchar(50),  
@RollNumber nvarchar(50),  
@Addmission_Number int,  
@Admission_Date datetime,  
@Acc_Number nvarchar(50),  
@FatherName nvarchar(200),  
@MotherName nvarchar(200),  
@Gender nvarchar(50),  
@DOB datetime,  
@Category nvarchar(50),  
@SiblingClass nvarchar(50),  
@SiblingSchool nvarchar(50),  
@Nationality nvarchar(50),  
@EmailId nvarchar(50),  
@Address1 nvarchar(500),  
@Address2 nvarchar(500),  
@City nvarchar(50),  
@PhoneRes nvarchar(50),  
@PhoneOff nvarchar(50),  
@AadharCardNo nvarchar(50),  
@SRN_No nvarchar(50),  
@CBSC_REG_No nvarchar(50),  
@BankAccount_No nvarchar(50),  
@IFSC nvarchar(50),  
@DiscountType nvarchar(50),  
@BloodGroup nvarchar(50),  
@BoarderRequired nvarchar(50),  
@Route_No nvarchar(50),  
@ORG_Adm_no nvarchar(50),  
@MobileSms nvarchar(50),  
@Stopage nvarchar(50),  
@Income nvarchar(50),  
@DND nvarchar(50),  
@BPL nvarchar(50),  
@DisabilityType nvarchar(50),  
@CWSN nvarchar(50),  
@HomeLessChild nvarchar(50),  
@Extra_Exam nvarchar(50),  
@Last_Exam_Appear nvarchar(50),  
@Last_Exam_Passed nvarchar(50),  
@Last_Exam_Percent nvarchar(50),  
@Stream_11 nvarchar(50),  
@Free_Edu nvarchar(50),  
@Trade_Skill nvarchar(50),  
@DisAdvantages nvarchar(50),  
@MotherToung nvarchar(50),  
@Medium_of_Instruction nvarchar(50),  
@Previous_year_Att nvarchar(50),  
@Previous_Year_Status nvarchar(50),  
@Other_Info nvarchar(50),  
@UDF1 nvarchar(50),  
@UDF2 nvarchar(50),  
@UDF3 nvarchar(50)  
)  
AS  
Begin  
insert into tbl_StudentInfo(Name,Stud_In_Class,Class,Session_Year ,RollNumber,Addmission_Number,Admission_Date,Acc_Number,FatherName,MotherName,Gender,DOB,  
Category,SiblingClass,SiblingSchool,Nationality,EmailId,Address1 ,Address2 ,City,PhoneRes ,PhoneOff ,AadharCardNo ,SRN_No ,CBSC_REG_No ,  
BankAccount_No,IFSC ,DiscountType ,BloodGroup ,BoarderRequired,Route_No,ORG_Adm_no ,MobileSms ,Stopage ,Income ,DND ,BPL ,DisabilityType,CWSN ,HomeLessChild ,  
Extra_Exam ,Last_Exam_Appear ,Last_Exam_Passed ,Last_Exam_Percent ,Stream_11 ,Free_Edu ,Trade_Skill,DisAdvantages,MotherToung ,Medium_of_Instruction ,  
Previous_year_Att ,Previous_Year_Status ,Other_Info ,UDF1 ,UDF2,UDF3 )values  
 (@Name,@Stud_In_Class,@Class,@Session_Year ,@RollNumber,@Addmission_Number,@Admission_Date,@Acc_Number,@FatherName,@MotherName,@Gender,@DOB,  
@Category,@SiblingClass,@SiblingSchool,@Nationality,@EmailId,@Address1 ,@Address2 ,@City,@PhoneRes ,@PhoneOff ,@AadharCardNo ,@SRN_No ,@CBSC_REG_No ,  
@BankAccount_No,@IFSC ,@DiscountType ,@BloodGroup ,@BoarderRequired,@Route_No,@ORG_Adm_no ,@MobileSms ,@Stopage ,@Income ,@DND ,@BPL ,@DisabilityType,@CWSN ,@HomeLessChild ,  
@Extra_Exam ,@Last_Exam_Appear ,@Last_Exam_Passed ,@Last_Exam_Percent ,@Stream_11 ,@Free_Edu ,@Trade_Skill,@DisAdvantages,@MotherToung ,@Medium_of_Instruction ,  
@Previous_year_Att ,@Previous_Year_Status ,@Other_Info ,@UDF1 ,@UDF2,@UDF3)  
SET @StdId = SCOPE_IDENTITY()  
end
GO
/****** Object:  StoredProcedure [dbo].[StudentAnnualFeeStructureSelectOne]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE proc [dbo].[StudentAnnualFeeStructureSelectOne]
@Admission_Number int,

@Session nvarchar(50)
as
SELECT [FeeId]
      ,[Session]
      ,[Addmission_Number]
      ,[Name]
      ,[Class]
      ,[Acc_Number]
      ,[RegistrationFee]
      ,[AddmissionFee]
      ,[AnnualCharges]
      ,[TutionFee]
      ,[QuaterlyFee]
      ,[TransportFee]
      ,[RegistrationFee_Disc]
      ,[AddmissionFee_Disc]
      ,[AnnualCharges_Disc]
      ,[TutionFee_Disc]
      ,[QuaterlyFee_Disc]
      ,[TransportFee_Disc]
      ,[Act_RegistrationFee]
      ,[Act_AddmissionFee]
      ,[Act_AnnualCharges]
      ,[Act_TutionFee]
      ,[Act_QuaterlyFee]
      ,[Act_TransportFee]
      ,[TotalAmount]
      ,[UDF1]
      ,[UDF2]
      ,[UDF3]
      ,[CreateDate]
      ,[ModifiedDate]
  FROM [SchoolManagement].[dbo].[tbl_StudentAnnualFeeStructure]
  where [Session]=@Session and Addmission_Number=@Admission_Number

 --exec StudentAnnualFeeStructureSelectOne '2017-2018',3
GO
/****** Object:  StoredProcedure [dbo].[StudentAnnualFeeStructure_Insert]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[StudentAnnualFeeStructure_Insert]  
(  
@FeeId int,  
@Session nvarchar(50),  
  
@Addmission_Number nvarchar(50),  
@Class nvarchar(50),  
@Acc_Number nvarchar(50),  
@RegistrationFee nvarchar(50),  
@AddmissionFee nvarchar(50),  
@AnnualCharges nvarchar(50),  
@TutionFee nvarchar(50),  
@QuaterlyFee nvarchar(50),  
@TransportFee nvarchar(50),  
@RegistrationFee_Disc nvarchar(50),  
@AddmissionFee_Disc nvarchar(50),  
@AnnualCharges_Disc nvarchar(50),  
@TutionFee_Disc nvarchar(50),  
@QuaterlyFee_Disc nvarchar(50),  
@TransportFee_Disc nvarchar(50),  
@Act_RegistrationFee nvarchar(50),  
@Act_AddmissionFee nvarchar(50),  
@Act_AnnualCharges nvarchar(50),  
@Act_TutionFee nvarchar(50),  
@Act_QuaterlyFee nvarchar(50),  
@Act_TransportFee nvarchar(50),  
@TotalAmount nvarchar(50),  
@Name nvarchar(200),  
@UDF1 nvarchar(50),  
@UDF2 nvarchar(50),  
@UDF3 nvarchar(50)  
)  
AS  
BEGIN  
insert into tbl_StudentAnnualFeeStructure([Session],Addmission_Number,Class,Acc_Number,RegistrationFee,AddmissionFee,AnnualCharges,TutionFee,QuaterlyFee,TransportFee,RegistrationFee_Disc,  
AddmissionFee_Disc,AnnualCharges_Disc,TutionFee_Disc,QuaterlyFee_Disc,TransportFee_Disc,Act_RegistrationFee,Act_AddmissionFee,  
Act_AnnualCharges,Act_TutionFee,Act_QuaterlyFee,Act_TransportFee,TotalAmount,Name,UDF1,UDF2,UDF3)  
values  
(@Session,@Addmission_Number,@Class,@Acc_Number,@RegistrationFee,@AddmissionFee,@AnnualCharges,@TutionFee,@QuaterlyFee,@TransportFee,@RegistrationFee_Disc,  
@AddmissionFee_Disc,@AnnualCharges_Disc,@TutionFee_Disc,@QuaterlyFee_Disc,@TransportFee_Disc,@Act_RegistrationFee,  
@Act_AddmissionFee,@Act_AnnualCharges,@Act_TutionFee,@Act_QuaterlyFee,@Act_TransportFee,@TotalAmount,@Name,@UDF1,@UDF2,@UDF3  
)  
SET @FeeId = SCOPE_IDENTITY()  
END
GO
/****** Object:  StoredProcedure [dbo].[Student_MonthlyFee_Insert]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Student_MonthlyFee_Insert]
(
@FeeId int out,
@Session nvarchar(50),
@MonthCount int,
@Addmission_Number nvarchar(50),
@Class nvarchar(50),
@Acc_Number nvarchar(50),
@RegistrationFee float,
@AddmissionFee float,
@AnnualCharges float,
@TutionFee float,
@QuaterlyFee float,
@TransportFee float,
@RegistrationFee_Disc float,
@AddmissionFee_Disc float,
@AnnualCharges_Disc float,
@TutionFee_Disc float,
@QuaterlyFee_Disc float,
@TransportFee_Disc float,
@Act_RegistrationFee float,
@Act_AddmissionFee float,
@Act_AnnualCharges float,
@Act_TutionFee float,
@Act_QuaterlyFee float,
@Act_TransportFee float,
@TotalAmount float,
@Name nvarchar(200),
@UDF1 nvarchar(50),
@UDF2 nvarchar(50),
@UDF3 nvarchar(50),
@PaidForMonths nvarchar(500),
@MiscCharges float,
@PaidAmount float,
@PaymentType nvarchar(50),
@Balance float

)
AS
BEGIN
insert into tbl_Student_MonthlyFeeDeposit(
[Session],
MonthCount,
Addmission_Number,
Class,
Acc_Number,
RegistrationFee,
AddmissionFee,
AnnualCharges,
TutionFee,
QuaterlyFee,
TransportFee,
RegistrationFee_Disc,
AddmissionFee_Disc,
AnnualCharges_Disc,
TutionFee_Disc,
QuaterlyFee_Disc,
TransportFee_Disc,
Act_RegistrationFee,
Act_AddmissionFee,
Act_AnnualCharges,
Act_TutionFee,
Act_QuaterlyFee,
Act_TransportFee,
TotalAmount,
Name,
UDF1,
UDF2,
UDF3,
PaidForMonths,
MiscCharges,
PaymentType,
Balance,
PaidAmount)
values
(
@Session,
@MonthCount,
@Addmission_Number,
@Class,
@Acc_Number,
@RegistrationFee,
@AddmissionFee,
@AnnualCharges,
@TutionFee,
@QuaterlyFee,
@TransportFee,
@RegistrationFee_Disc,
@AddmissionFee_Disc,
@AnnualCharges_Disc,
@TutionFee_Disc,
@QuaterlyFee_Disc,
@TransportFee_Disc,
@Act_RegistrationFee,
@Act_AddmissionFee,
@Act_AnnualCharges,
@Act_TutionFee,
@Act_QuaterlyFee,
@Act_TransportFee,
@TotalAmount,
@Name,
@UDF1,
@UDF2,
@UDF3,
@PaidForMonths,
@MiscCharges,
@PaymentType,
@Balance,
@PaidAmount
)
SET @FeeId = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[Student_FeeStatementBySessionAndClass]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Student_FeeStatementBySessionAndClass]
@Session nvarchar(50)
,@Class nvarchar(50)
as
WITH StudentStatement AS (   
select 
m.Addmission_Number,m.[name],m.PaidAmount,m.PaidInMonth,s.FatherName,s.PhoneOff
from tbl_Student_MonthlyFeeDeposit m inner join  
tbl_StudentInfo s on m.Addmission_Number=s.Addmission_Number
where m.Session=@Session and m.Class=@Class
)
SELECT *,
(ISNULL ([Apr],0)+ISNULL ([May],0)+ISNULL ([Jun],0)+ISNULL ([Jul],0)+ISNULL ([Aug],0)+ISNULL ([Sep],0)
+ISNULL ([Oct],0)+ISNULL ([Nov],0)+ISNULL ([Dec],0)+ISNULL ([Jan],0)+ISNULL ([Feb],0)+ISNULL ([Mar],0))
as GrandTotal FROM StudentStatement
pivot
(
sum(PaidAmount) for [PaidInMonth] in 

(
  [Apr]
,[May]
,[Jun]
,[Jul]
,[Aug]
,[Sep]
,[Oct]
,[Nov]
,[Dec]
,[Jan]
,[Feb]
,[Mar]
)
) as p
GO
/****** Object:  StoredProcedure [dbo].[SelectOneMonthlyFeeForStudent]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/  
CREATE proc [dbo].[SelectOneMonthlyFeeForStudent]  
@ReceiptNo int 
  
 
as  
SELECT 
FeeId
,[Session]
,MonthCount
,PaidForMonths
,Name
,Addmission_Number
,Class
,Acc_Number
,RegistrationFee
,AddmissionFee
,AnnualCharges
,TutionFee
,QuaterlyFee
,TransportFee
,RegistrationFee_Disc
,AddmissionFee_Disc
,AnnualCharges_Disc
,TutionFee_Disc
,QuaterlyFee_Disc
,TransportFee_Disc
,Act_RegistrationFee
,Act_AddmissionFee
,Act_AnnualCharges
,Act_TutionFee
,Act_QuaterlyFee
,Act_TransportFee
,MiscCharges
,TotalAmount
,PaidAmount
,PaymentType
,Balance
,UDF1
,UDF2
,UDF3
,CreateDate
,ModifiedDate
  FROM [SchoolManagement].[dbo].tbl_Student_MonthlyFeeDeposit  
  where FeeId=@ReceiptNo   
  
 --exec numberOfTotalMonthsPaidCountForMonthlyFee '2017-2018',3
GO
/****** Object:  StoredProcedure [dbo].[SelectMonthlyFeeForStudent]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/  
CREATE proc [dbo].[SelectMonthlyFeeForStudent]  
@Admission_Number int,  
  
@Session nvarchar(50)  
as  
SELECT 
FeeId
,[Session]
,MonthCount
,PaidForMonths
,Name
,Addmission_Number
,Class
,Acc_Number
,RegistrationFee
,AddmissionFee
,AnnualCharges
,TutionFee
,QuaterlyFee
,TransportFee
,RegistrationFee_Disc
,AddmissionFee_Disc
,AnnualCharges_Disc
,TutionFee_Disc
,QuaterlyFee_Disc
,TransportFee_Disc
,Act_RegistrationFee
,Act_AddmissionFee
,Act_AnnualCharges
,Act_TutionFee
,Act_QuaterlyFee
,Act_TransportFee
,MiscCharges
,TotalAmount
,PaidAmount
,PaymentType
,Balance
,UDF1
,UDF2
,UDF3
,CreateDate
,ModifiedDate
  FROM [SchoolManagement].[dbo].tbl_Student_MonthlyFeeDeposit  
  where [Session]=@Session and Addmission_Number=@Admission_Number  
  
 --exec numberOfTotalMonthsPaidCountForMonthlyFee '2017-2018',3
GO
/****** Object:  StoredProcedure [dbo].[TeacherInfo_Insert]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TeacherInfo_Insert]
(
@EmpId int,
@Name nvarchar(50),
@Age nvarchar(50),
@Qualification nvarchar(50),
@Designation nvarchar(50),
@FatherName nvarchar(50),
@MotherName nvarchar(50),
@Gender nvarchar(50),
@DOB date,
@Nationality nvarchar(50),
@EMailId nvarchar(50),
@Address nvarchar(50),
@City nvarchar(50),
@Phone_Number nvarchar(50),
@AadharCardNo nvarchar(50),
@UDF1 nvarchar(50),
@UDF2 nvarchar(50),
@UDF3 nvarchar(50)
)
AS
Begin
insert into tbl_TeacherInfo(Name,FatherName,MotherName,DOB,Age,Designation,Nationality,
Gender,Qualification,EMailId,Address,City,Phone_Number,AadharCardNo,UDF1,UDF2,UDF3)values(@Name,@FatherName,@MotherName,@DOB,@Age,@Designation,@Nationality,
@EMailId,@Gender,@Qualification,@Address,@City,@Phone_Number,@AadharCardNo,@UDF1,@UDF2,@UDF3)
SET @EmpId = SCOPE_IDENTITY()
end
GO
/****** Object:  StoredProcedure [dbo].[EmployeeSalary_Insert]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EmployeeSalary_Insert]
(
@EmpId int,
@Name nvarchar(50),
@BasicSalary nvarchar(50),
@DearnessAllowance nvarchar(50),
@MedicalAllowance nvarchar(50),
@TransportAllowance nvarchar(50),
@ProfessionTax nvarchar(50),
@ProvidentFund nvarchar(50),
@IncomeTax nvarchar(50),
@UDF1 nvarchar(50),
@UDF2 nvarchar(50),
@UDF3 nvarchar(50)
)
as begin
insert into tbl_EmployeeSalarySlip(Name,BasicSalary,DearnessAllowance,MedicalAllowance,TransportAllowance,
ProfessionTax,ProvidentFund,IncomeTax,UDF1,UDF2,UDF3)values(@Name,@BasicSalary,@DearnessAllowance,@MedicalAllowance,@TransportAllowance,@ProfessionTax,
@ProvidentFund,@IncomeTax,@UDF1,@UDF2,@UDF3)
set @EmpId=SCOPE_IDENTITY()
end
GO
/****** Object:  StoredProcedure [dbo].[EmployeeInfo_SelectOneBySession]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EmployeeInfo_SelectOneBySession]
(
@EmpId int,
@Name nvarchar(50)
)
as
begin
select top (1) Name from tbl_TeacherInfo 
where EmpId=@EmpId 
 
 
end
-- exec StudentInfo_SelectOneBySession 3, '2017-2018'
GO
/****** Object:  StoredProcedure [dbo].[EmployeeInfo_Insert]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EmployeeInfo_Insert]
(
@EmpId int,
@Name nvarchar(50),
@FatherName nvarchar(50),
@MotherName nvarchar(50),
@DOB date,
@Age nvarchar(50),
@MaritalStatus nvarchar(50),
@Gender nvarchar(50),
@EMail nvarchar(50),
@PhoneNumber nvarchar(50),
@Address1 nvarchar(50),
@City nvarchar(50),
@JobTitle nvarchar(50),
@Qualification nvarchar(50),
@ExperienceInYear nvarchar(50),
@Salary nvarchar(50),
@JoiningDate date,
@Nationality nvarchar(50),
@AadharCardNo nvarchar(50),
@UDF1 nvarchar(50),
@UDF2 nvarchar(50),
@UDF3 nvarchar(50)
)
AS
Begin
insert into tbl_EmployeeInfo(Name,FatherName,MotherName,DOB,Age,MaritalStatus,Gender,Email,PhoneNumber,Address1,City,JobTitle,Qualification,
ExperienceInYear,Salary,HireDate,Nationality,AadharCardNo,UDF1,UDF2,UDF3)
values(@Name,@FatherName,@MotherName,@DOB,@Age,@MaritalStatus,@Gender,@Email,@PhoneNumber,
@Address1,@City,@JobTitle,@Qualification,@ExperienceInYear,@Salary,@JoiningDate,@Nationality,@AadharCardNo,@UDF1,@UDF2,@UDF3)
SET @EmpId = SCOPE_IDENTITY()
end
GO
/****** Object:  StoredProcedure [dbo].[ClasswiseAnnualFeeStructure_SelectAllBySession]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[ClasswiseAnnualFeeStructure_SelectAllBySession]
@Session nvarchar(50)
As
Begin
select SessionYear,Class,RegistrationFee,AdmissionFee,AnnualCharge,TutionFee,ChildFund,Misc,ComputerFee,
ExamFee,LateFee,SecurityDeposite,TransportFee,ScienceFee,SportsFee,LibraryFee,
IsActive,ReportCardFee,UDF1,UDF2,UDF3 from tbl_ClasswiseAnnualFeeStructure
where SessionYear=@Session
End
GO
/****** Object:  StoredProcedure [dbo].[ClasswiseAnnualFeeStructure_SelectAllByClassAndSession]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ClasswiseAnnualFeeStructure_SelectAllByClassAndSession]  
@Session nvarchar(50),  
@Class nvarchar(50)  
As  
Begin  
select SessionYear,Class,RegistrationFee,AdmissionFee,AnnualCharge,TutionFee,ChildFund,Misc,ComputerFee,  
ExamFee,LateFee,SecurityDeposite,TransportFee,ScienceFee,SportsFee,LibraryFee,  
IsActive,ReportCardFee,UDF1,UDF2,UDF3 from tbl_ClasswiseAnnualFeeStructure  
where SessionYear=@Session and Class=@Class  
End
GO
/****** Object:  StoredProcedure [dbo].[ClasswiseAnnualFeeStructure_SelectAllByClass]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[ClasswiseAnnualFeeStructure_SelectAllByClass]
@Class nvarchar(50)
As
Begin
select SessionYear,Class,RegistrationFee,AdmissionFee,AnnualCharge,TutionFee,ChildFund,Misc,ComputerFee,
ExamFee,LateFee,SecurityDeposite,TransportFee,ScienceFee,SportsFee,LibraryFee,
IsActive,ReportCardFee,UDF1,UDF2,UDF3 from tbl_ClasswiseAnnualFeeStructure
where Class=@Class
End
GO
/****** Object:  StoredProcedure [dbo].[ClasswiseAnnualFeeStructure_SelectAll]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ClasswiseAnnualFeeStructure_SelectAll]
As
Begin
select Session_Year,Class,RegistrationFee,AdmissionFee,Annual_Dev_Fee,TutionFee,ChildFund,Misc,ComputerFee,
ExamFee,LateFee,SecurityDeposite,Assn_fee,ScienceFee,SportsFee,LibraryFee,
IsActive,Report_Card_Fee,UDF1,UDF2,UDF3 from tbl_ClasswiseAnnualFeeStructure
End
GO
/****** Object:  StoredProcedure [dbo].[ClasswiseAnnualFeeStructure_Insert]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ClasswiseAnnualFeeStructure_Insert]  
(  
@FeeId int,  
@SessionYear nvarchar(50),  
@Class nvarchar(50),  
@RegistrationFee nvarchar(50),  
@AdmissionFee nvarchar(50),  
@AnnualCharge nvarchar(50),  
@TutionFee nvarchar(50),  
@ChildFund nvarchar(50),  
@Misc nvarchar(50),  
@ComputerFee nvarchar(50),  
@ExamFee nvarchar(50),  
@LateFee nvarchar(50),  
@SecurityDeposite nvarchar(50),  
@TransportFee nvarchar(50),  
@ScienceFee nvarchar(50),  
@SportsFee nvarchar(50),  
@LibraryFee nvarchar(50),  
@IsActive nvarchar(50),  
@ReportCardFee nvarchar(50),  
@UDF1 nvarchar(50),  
@UDF2 nvarchar(50),  
@UDF3 nvarchar(50)  
)  
AS  
BEGIN  
insert into tbl_ClasswiseAnnualFeeStructure(SessionYear,Class,RegistrationFee,AdmissionFee,AnnualCharge,TutionFee,ChildFund,Misc,ComputerFee,  
ExamFee,LateFee,SecurityDeposite,TransportFee,ScienceFee,SportsFee,LibraryFee,  
IsActive,ReportCardFee,UDF1,UDF2,UDF3)  
values  
(@SessionYear,@Class,@RegistrationFee,@AdmissionFee,@AnnualCharge,@TutionFee,@ChildFund,@Misc,@ComputerFee,  
@ExamFee,@LateFee,@SecurityDeposite,@TransportFee,@ScienceFee,@SportsFee,@LibraryFee,  
@IsActive,@ReportCardFee,@UDF1,@UDF2,@UDF3  
)  
SET @FeeId = SCOPE_IDENTITY()  
END
GO
/****** Object:  StoredProcedure [dbo].[AllInventories_Insert]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AllInventories_Insert]
(
@Id int,
@ItemName nvarchar(100),
@Description nvarchar(200),
@UDF1 nvarchar(50)
)
AS
BEGIN
insert into AllInventories(ItemName,Description,UDF1)
values
(@ItemName,@Description,@UDF1
)
SET @Id = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[OtherExpenses_Insert]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OtherExpenses_Insert]
(
@Id int,
@Expenses nvarchar(100),
@UDF1 nvarchar(50),
@UDF2 nvarchar(50),
@UDF3 nvarchar(50)
)
AS
BEGIN
insert into tbl_OtherExpenses(Expenses,UDF1,UDF2,UDF3)
values
(@Expenses,@UDF1,@UDF2,@UDF3
)
SET @Id = SCOPE_IDENTITY()
END
--To Select Value For Dropdown
Begin
select Expenses from tbl_OtherExpenses where Id=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[numberOfTotalMonthsPaidCountForMonthlyFee]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE proc [dbo].[numberOfTotalMonthsPaidCountForMonthlyFee]
@Admission_Number int,

@Session nvarchar(50)
as
SELECT COUNT(feeid) as MonthCount  FROM [SchoolManagement].[dbo].tbl_Student_MonthlyFeeDeposit
  where [Session]=@Session and Addmission_Number=@Admission_Number

 --exec numberOfTotalMonthsPaidCountForMonthlyFee '2017-2018',3
GO
/****** Object:  StoredProcedure [dbo].[InvestmentForOtherPurposes_Insert]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InvestmentForOtherPurposes_Insert]
(
@Id int,
@Purpose nvarchar(100),
@Quantity nvarchar(50),
@Amount nvarchar(50),
@Date nvarchar(50),
@UDF1 nvarchar(50),
@UDF2 nvarchar(50),
@UDF3 nvarchar(50)
)
AS
BEGIN
insert into tbl_InvestmentForOtherPurposes(Purpose,Quantity,Amount,Date,UDF1,UDF2,UDF3)
values
(@Purpose,@Quantity,@Amount,@Date,@UDF1,@UDF2,@UDF3
)
SET @Id = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[Inventory_Insert]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Inventory_Insert]
(
@Id int,
@ItemName nvarchar(100),
@Quantity nvarchar(50),
@Amount nvarchar(50),
@InventoryType nvarchar(50),
@Date datetime,
@UDF1 nvarchar(50),
@UDF2 nvarchar(50),
@UDF3 nvarchar(50)
)
AS
BEGIN
insert into tbl_Inventory(ItemName,Quantity,Amount,InventoryType,Date,UDF1,UDF2,UDF3)
values
(
@ItemName,@Quantity,@Amount,@InventoryType,@Date,@UDF1,@UDF2,@UDF3
)
SET @Id = SCOPE_IDENTITY()
END
--To Select Value For Dropdown
Begin
select ItemName from tbl_Inventory where Id=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetRegistrationNumber]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetRegistrationNumber]
@Session nvarchar(50)
as 
select (MAX (Addmission_Number))+1 as RegNo from tbl_StudentInfo where Session_Year=@Session

--exec GetRegistrationNumber '2017-18'
GO
/****** Object:  StoredProcedure [dbo].[GetClassForFeeStructure]    Script Date: 02/28/2018 10:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetClassForFeeStructure]
@FeeId nvarchar(50)
as 
select Class from  ClasswiseAnnualFeeStructure_Insert where StdId=@FeeId

--exec GetRegistrationNumber '2017-18'
GO
/****** Object:  Default [DF_AllInventories_CreateDate]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[AllInventories] ADD  CONSTRAINT [DF_AllInventories_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_tbl_StudentInfo_CreateDate]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[tbl_StudentInfo] ADD  CONSTRAINT [DF_tbl_StudentInfo_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_tbl_AnnualFee_CreateDate]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[tbl_StudentAnnualFeeStructure] ADD  CONSTRAINT [DF_tbl_AnnualFee_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_tbl_Student_MonthlyFee_CreateDate]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[tbl_Student_MonthlyFeeDeposit] ADD  CONSTRAINT [DF_tbl_Student_MonthlyFee_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_tbl_Student_MonthlyFeeDeposit_ModifiedDate]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[tbl_Student_MonthlyFeeDeposit] ADD  CONSTRAINT [DF_tbl_Student_MonthlyFeeDeposit_ModifiedDate]  DEFAULT (getdate()) FOR [ModifiedDate]
GO
/****** Object:  Default [DF_tbl_Student_AnnualOneTimeFee_CreateDate]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[tbl_Student_AnnualOneTimeFeeDeposit] ADD  CONSTRAINT [DF_tbl_Student_AnnualOneTimeFee_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_OtherExpenses_CreatedDate]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[tbl_OtherExpenses] ADD  CONSTRAINT [DF_OtherExpenses_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_InvestmentForOtherPurposes_CreatedDate]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[tbl_InvestmentForOtherPurposes] ADD  CONSTRAINT [DF_tbl_InvestmentForOtherPurposes_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_Inventory_CreatedDate]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[tbl_Inventory] ADD  CONSTRAINT [DF_Inventory_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_Employee_CreatedDate]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[tbl_EmployeeInfo] ADD  CONSTRAINT [DF_tbl_Employee_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF_tbl_Fee_CreateDate]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[tbl_ClasswiseAnnualFeeStructure] ADD  CONSTRAINT [DF_tbl_Fee_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_StudentStatementToPrintCrystalReport_Apr]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[StudentStatementToPrintCrystalReport] ADD  CONSTRAINT [DF_StudentStatementToPrintCrystalReport_Apr]  DEFAULT ('0') FOR [Apr]
GO
/****** Object:  Default [DF_Table_1_Apr1]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[StudentStatementToPrintCrystalReport] ADD  CONSTRAINT [DF_Table_1_Apr1]  DEFAULT ('0') FOR [May]
GO
/****** Object:  Default [DF_Table_1_Apr2]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[StudentStatementToPrintCrystalReport] ADD  CONSTRAINT [DF_Table_1_Apr2]  DEFAULT ('0') FOR [Jun]
GO
/****** Object:  Default [DF_Table_1_Apr3]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[StudentStatementToPrintCrystalReport] ADD  CONSTRAINT [DF_Table_1_Apr3]  DEFAULT ('0') FOR [Jul]
GO
/****** Object:  Default [DF_Table_1_Apr4]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[StudentStatementToPrintCrystalReport] ADD  CONSTRAINT [DF_Table_1_Apr4]  DEFAULT ('0') FOR [Aug]
GO
/****** Object:  Default [DF_Table_1_Apr5]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[StudentStatementToPrintCrystalReport] ADD  CONSTRAINT [DF_Table_1_Apr5]  DEFAULT ('0') FOR [Sep]
GO
/****** Object:  Default [DF_Table_1_Apr6]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[StudentStatementToPrintCrystalReport] ADD  CONSTRAINT [DF_Table_1_Apr6]  DEFAULT ('0') FOR [Oct]
GO
/****** Object:  Default [DF_Table_1_Apr7]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[StudentStatementToPrintCrystalReport] ADD  CONSTRAINT [DF_Table_1_Apr7]  DEFAULT ('0') FOR [Nov]
GO
/****** Object:  Default [DF_Table_1_Apr8]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[StudentStatementToPrintCrystalReport] ADD  CONSTRAINT [DF_Table_1_Apr8]  DEFAULT ('0') FOR [Dec]
GO
/****** Object:  Default [DF_Table_1_Apr9]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[StudentStatementToPrintCrystalReport] ADD  CONSTRAINT [DF_Table_1_Apr9]  DEFAULT ('0') FOR [Jan]
GO
/****** Object:  Default [DF_Table_1_Apr10]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[StudentStatementToPrintCrystalReport] ADD  CONSTRAINT [DF_Table_1_Apr10]  DEFAULT ('0') FOR [Feb]
GO
/****** Object:  Default [DF_Table_1_Apr11]    Script Date: 02/28/2018 10:31:56 ******/
ALTER TABLE [dbo].[StudentStatementToPrintCrystalReport] ADD  CONSTRAINT [DF_Table_1_Apr11]  DEFAULT ('0') FOR [Mar]
GO
