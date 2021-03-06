USE [master]
GO
/****** Object:  Database [FinalProjectAbout(C#)]    Script Date: 4/10/2019 1:50:19 PM ******/
CREATE DATABASE [FinalProjectAbout(C#)]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FinalProjectAbout(C#)', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\FinalProjectAbout(C#).mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FinalProjectAbout(C#)_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\FinalProjectAbout(C#)_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FinalProjectAbout(C#)].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET ARITHABORT OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET  MULTI_USER 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [FinalProjectAbout(C#)]
GO
/****** Object:  Table [dbo].[BloodGroups]    Script Date: 4/10/2019 1:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BloodGroups](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BloodGroup] [nvarchar](50) NOT NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_BloodGroups] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EyeColors]    Script Date: 4/10/2019 1:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EyeColors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EyeColor] [nvarchar](50) NOT NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_EyeColors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FamilyStatus]    Script Date: 4/10/2019 1:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamilyStatus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FamilyStatus] [nvarchar](50) NOT NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_MilitaryStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genders]    Script Date: 4/10/2019 1:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GenderName] [nvarchar](50) NOT NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_Genders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MilitaryStatuss]    Script Date: 4/10/2019 1:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MilitaryStatuss](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MilitaryStatus] [nvarchar](50) NOT NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_MilitaryStatuss] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nationalitys]    Script Date: 4/10/2019 1:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nationalitys](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NationalityName] [nvarchar](50) NOT NULL,
	[DeletedTime] [datetime] NULL,
 CONSTRAINT [PK_Nationalitys] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 4/10/2019 1:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FatherName] [nvarchar](50) NULL,
	[BirthOfDate] [date] NULL,
	[BirthOfPlace] [nvarchar](50) NULL,
	[GenderID] [int] NULL,
	[NationalityID] [int] NULL,
	[FamilyStatusID] [int] NULL,
	[MilitaryStatusID] [int] NULL,
	[Height] [tinyint] NULL,
	[EyeColorID] [int] NULL,
	[BloodGroupID] [int] NULL,
	[LivingPlace] [nvarchar](50) NULL,
	[IssueDate] [date] NULL,
	[ExpiryDate] [date] NULL,
	[Series] [varchar](50) NULL,
	[Number] [nvarchar](50) NULL,
	[IssuingAuthority] [nvarchar](50) NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 4/10/2019 1:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 4/10/2019 1:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[RoleID] [int] NOT NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BloodGroups] ON 

INSERT [dbo].[BloodGroups] ([ID], [BloodGroup], [DeletedDate]) VALUES (1, N'I-', NULL)
INSERT [dbo].[BloodGroups] ([ID], [BloodGroup], [DeletedDate]) VALUES (2, N'I+', NULL)
INSERT [dbo].[BloodGroups] ([ID], [BloodGroup], [DeletedDate]) VALUES (3, N'II-', NULL)
INSERT [dbo].[BloodGroups] ([ID], [BloodGroup], [DeletedDate]) VALUES (4, N'II+', NULL)
INSERT [dbo].[BloodGroups] ([ID], [BloodGroup], [DeletedDate]) VALUES (5, N'III-', NULL)
INSERT [dbo].[BloodGroups] ([ID], [BloodGroup], [DeletedDate]) VALUES (6, N'III+', NULL)
INSERT [dbo].[BloodGroups] ([ID], [BloodGroup], [DeletedDate]) VALUES (7, N'IV-', NULL)
INSERT [dbo].[BloodGroups] ([ID], [BloodGroup], [DeletedDate]) VALUES (8, N'IV+', NULL)
SET IDENTITY_INSERT [dbo].[BloodGroups] OFF
SET IDENTITY_INSERT [dbo].[EyeColors] ON 

INSERT [dbo].[EyeColors] ([ID], [EyeColor], [DeletedDate]) VALUES (1, N'Red', NULL)
INSERT [dbo].[EyeColors] ([ID], [EyeColor], [DeletedDate]) VALUES (3, N'Yellow', NULL)
INSERT [dbo].[EyeColors] ([ID], [EyeColor], [DeletedDate]) VALUES (13, N'Gray', NULL)
INSERT [dbo].[EyeColors] ([ID], [EyeColor], [DeletedDate]) VALUES (14, N'Blue', NULL)
INSERT [dbo].[EyeColors] ([ID], [EyeColor], [DeletedDate]) VALUES (15, N'Brown', NULL)
INSERT [dbo].[EyeColors] ([ID], [EyeColor], [DeletedDate]) VALUES (16, N'Green', NULL)
INSERT [dbo].[EyeColors] ([ID], [EyeColor], [DeletedDate]) VALUES (17, N'Purple', NULL)
INSERT [dbo].[EyeColors] ([ID], [EyeColor], [DeletedDate]) VALUES (18, N'Pink', NULL)
SET IDENTITY_INSERT [dbo].[EyeColors] OFF
SET IDENTITY_INSERT [dbo].[FamilyStatus] ON 

INSERT [dbo].[FamilyStatus] ([ID], [FamilyStatus], [DeletedDate]) VALUES (1, N'Married', NULL)
INSERT [dbo].[FamilyStatus] ([ID], [FamilyStatus], [DeletedDate]) VALUES (2, N'Not Married', NULL)
SET IDENTITY_INSERT [dbo].[FamilyStatus] OFF
SET IDENTITY_INSERT [dbo].[Genders] ON 

INSERT [dbo].[Genders] ([ID], [GenderName], [DeletedDate]) VALUES (1, N'Male', NULL)
INSERT [dbo].[Genders] ([ID], [GenderName], [DeletedDate]) VALUES (2, N'Female', NULL)
INSERT [dbo].[Genders] ([ID], [GenderName], [DeletedDate]) VALUES (3, N'Other', NULL)
SET IDENTITY_INSERT [dbo].[Genders] OFF
SET IDENTITY_INSERT [dbo].[MilitaryStatuss] ON 

INSERT [dbo].[MilitaryStatuss] ([ID], [MilitaryStatus], [DeletedDate]) VALUES (1, N'Yes', NULL)
INSERT [dbo].[MilitaryStatuss] ([ID], [MilitaryStatus], [DeletedDate]) VALUES (7, N'No', NULL)
SET IDENTITY_INSERT [dbo].[MilitaryStatuss] OFF
SET IDENTITY_INSERT [dbo].[Nationalitys] ON 

INSERT [dbo].[Nationalitys] ([ID], [NationalityName], [DeletedTime]) VALUES (1, N'Azerbaijan', NULL)
INSERT [dbo].[Nationalitys] ([ID], [NationalityName], [DeletedTime]) VALUES (2, N'Turkish', NULL)
INSERT [dbo].[Nationalitys] ([ID], [NationalityName], [DeletedTime]) VALUES (6, N'Russian', NULL)
INSERT [dbo].[Nationalitys] ([ID], [NationalityName], [DeletedTime]) VALUES (7, N'Azerbaijann', CAST(N'2019-04-10T09:47:11.657' AS DateTime))
SET IDENTITY_INSERT [dbo].[Nationalitys] OFF
SET IDENTITY_INSERT [dbo].[Persons] ON 

INSERT [dbo].[Persons] ([ID], [FirstName], [LastName], [FatherName], [BirthOfDate], [BirthOfPlace], [GenderID], [NationalityID], [FamilyStatusID], [MilitaryStatusID], [Height], [EyeColorID], [BloodGroupID], [LivingPlace], [IssueDate], [ExpiryDate], [Series], [Number], [IssuingAuthority], [DeletedDate]) VALUES (1116, N'Iqbal', N'Hesenli', N'Zahid', CAST(N'1999-03-04' AS Date), N'Baki', 1, 1, 1, 1, 178, 3, 4, N'Baki', CAST(N'2019-04-10' AS Date), CAST(N'2043-03-04' AS Date), N'14458758', N'123456789987654321', N'Kelbecer RPS', NULL)
SET IDENTITY_INSERT [dbo].[Persons] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([ID], [RoleName], [DeletedDate]) VALUES (1, N'Admin', NULL)
INSERT [dbo].[Roles] ([ID], [RoleName], [DeletedDate]) VALUES (2, N'User', NULL)
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [Email], [Password], [RoleID], [DeletedDate]) VALUES (1, N'admin', N'kQ?1?]??????=?a???f>????', 1, NULL)
INSERT [dbo].[Users] ([ID], [Email], [Password], [RoleID], [DeletedDate]) VALUES (18, N'user', N'kQ?1?]??????=?a???f>????', 2, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_BloodGroups] FOREIGN KEY([BloodGroupID])
REFERENCES [dbo].[BloodGroups] ([ID])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_BloodGroups]
GO
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_EyeColors] FOREIGN KEY([EyeColorID])
REFERENCES [dbo].[EyeColors] ([ID])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_EyeColors]
GO
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_FamilyStatus] FOREIGN KEY([FamilyStatusID])
REFERENCES [dbo].[FamilyStatus] ([ID])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_FamilyStatus]
GO
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_Genders] FOREIGN KEY([GenderID])
REFERENCES [dbo].[Genders] ([ID])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_Genders]
GO
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_MilitaryStatuss] FOREIGN KEY([MilitaryStatusID])
REFERENCES [dbo].[MilitaryStatuss] ([ID])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_MilitaryStatuss]
GO
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_Nationalitys] FOREIGN KEY([NationalityID])
REFERENCES [dbo].[Nationalitys] ([ID])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_Nationalitys]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Users] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Users]
GO
USE [master]
GO
ALTER DATABASE [FinalProjectAbout(C#)] SET  READ_WRITE 
GO
