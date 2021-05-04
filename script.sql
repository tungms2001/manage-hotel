USE [master]
GO
/****** Object:  Database [ManageHotel]    Script Date: 5/4/2021 7:43:36 PM ******/
CREATE DATABASE [ManageHotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ManageHotel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ManageHotel.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ManageHotel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ManageHotel_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ManageHotel] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ManageHotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ManageHotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ManageHotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ManageHotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ManageHotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ManageHotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [ManageHotel] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ManageHotel] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ManageHotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ManageHotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ManageHotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ManageHotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ManageHotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ManageHotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ManageHotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ManageHotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ManageHotel] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ManageHotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ManageHotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ManageHotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ManageHotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ManageHotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ManageHotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ManageHotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ManageHotel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ManageHotel] SET  MULTI_USER 
GO
ALTER DATABASE [ManageHotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ManageHotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ManageHotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ManageHotel] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ManageHotel]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 5/4/2021 7:43:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NULL,
	[kind] [nvarchar](255) NULL,
	[identityNumber] [varchar](50) NULL,
	[address] [nvarchar](255) NULL,
	[rentedDay] [datetime] NULL,
	[roomName] [nvarchar](255) NULL,
	[ordinalNumber] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 5/4/2021 7:43:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[account] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RoomCategories]    Script Date: 5/4/2021 7:43:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomCategories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[kind] [nvarchar](255) NULL,
	[note] [nvarchar](255) NULL,
	[price] [float] NULL,
	[roomStatus] [nvarchar](255) NULL,
	[countRented] [int] NULL,
	[rentedDay] [datetime] NULL,
	[total] [float] NULL,
	[ordinalNumber] [int] NULL,
 CONSTRAINT [pk_roomName] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RoomHistory]    Script Date: 5/4/2021 7:43:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomHistory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NULL,
	[kind] [nvarchar](255) NULL,
	[countRented] [int] NULL,
	[rentedDay] [datetime] NULL,
	[total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rules]    Script Date: 5/4/2021 7:43:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rules](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nRoomKind] [int] NOT NULL,
	[roomKindPrice] [nvarchar](255) NOT NULL,
	[nCustomerKind] [int] NOT NULL,
	[customerKindCoefficient] [nvarchar](255) NOT NULL,
	[maximumCustomer] [int] NOT NULL,
	[surchargeRatio] [float] NOT NULL,
	[surchargeBeginning] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([id], [name], [kind], [identityNumber], [address], [rentedDay], [roomName], [ordinalNumber]) VALUES (28, N'Sơn Tùng', N'Nước ngoài', N'342087151', N'Đồng  thap', CAST(N'2020-12-12 09:56:30.380' AS DateTime), N'002', 1)
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Manager] ON 

INSERT [dbo].[Manager] ([id], [name], [account], [password]) VALUES (1, N'Quản trị viên', N'admin', N'admin')
INSERT [dbo].[Manager] ([id], [name], [account], [password]) VALUES (2, N'Mai Sơn Tùng', N'tungms', N'1234')
SET IDENTITY_INSERT [dbo].[Manager] OFF
SET IDENTITY_INSERT [dbo].[RoomCategories] ON 

INSERT [dbo].[RoomCategories] ([id], [name], [kind], [note], [price], [roomStatus], [countRented], [rentedDay], [total], [ordinalNumber]) VALUES (24, N'001', N'A', N'vip', 300000, N'Trống', 0, NULL, 0, 1)
INSERT [dbo].[RoomCategories] ([id], [name], [kind], [note], [price], [roomStatus], [countRented], [rentedDay], [total], [ordinalNumber]) VALUES (25, N'002', N'B', N'', 200000, N'Đã được thuê', 1, CAST(N'2020-12-12 09:56:30.380' AS DateTime), 400000, 2)
INSERT [dbo].[RoomCategories] ([id], [name], [kind], [note], [price], [roomStatus], [countRented], [rentedDay], [total], [ordinalNumber]) VALUES (26, N'003', N'C', N'thường', 150000, N'Trống', 0, NULL, 0, 3)
SET IDENTITY_INSERT [dbo].[RoomCategories] OFF
SET IDENTITY_INSERT [dbo].[RoomHistory] ON 

INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (1, N'001', N'A', 1, CAST(N'2020-11-20 15:44:51.947' AS DateTime), 375000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (2, N'001', N'A', 1, CAST(N'2020-11-21 13:30:24.213' AS DateTime), 150000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (3, N'001', N'A', 1, CAST(N'2020-11-21 13:49:15.973' AS DateTime), 450000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (4, N'002', N'B', 1, CAST(N'2020-11-21 13:33:52.880' AS DateTime), 1020000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (5, N'001', N'A', 1, CAST(N'2020-11-22 22:30:01.413' AS DateTime), 1125000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (6, N'002', N'B', 1, CAST(N'2020-11-24 11:33:28.430' AS DateTime), 1530000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (7, N'001', N'A', 1, CAST(N'2020-11-24 15:48:42.137' AS DateTime), 450000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (8, N'002', N'A', 1, CAST(N'2020-11-24 15:48:42.137' AS DateTime), 900000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (9, N'001', N'A', 1, CAST(N'2020-11-26 09:56:28.723' AS DateTime), 150000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (10, N'002', N'B', 3771, CAST(N'2010-08-01 09:56:28.000' AS DateTime), 340000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (11, N'003', N'C', -246, CAST(N'2021-08-01 09:56:28.000' AS DateTime), 400000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (12, N'001', N'A', 2, CAST(N'2020-11-27 22:06:07.653' AS DateTime), 150000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (13, N'001', N'A', 1, CAST(N'2020-11-30 22:04:00.260' AS DateTime), 150000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (14, N'001', N'A', 8, CAST(N'2020-12-01 23:45:55.857' AS DateTime), 150000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (15, N'001', N'A', 1, CAST(N'2020-12-10 13:33:41.890' AS DateTime), 600000)
INSERT [dbo].[RoomHistory] ([id], [name], [kind], [countRented], [rentedDay], [total]) VALUES (16, N'001', N'A', 1, CAST(N'2020-12-10 23:14:45.487' AS DateTime), 300000)
SET IDENTITY_INSERT [dbo].[RoomHistory] OFF
SET IDENTITY_INSERT [dbo].[Rules] ON 

INSERT [dbo].[Rules] ([id], [nRoomKind], [roomKindPrice], [nCustomerKind], [customerKindCoefficient], [maximumCustomer], [surchargeRatio], [surchargeBeginning]) VALUES (1, 4, N'A,300000
B,200000
C,150000
D,100000', 3, N'Nội địa,1
Nước ngoài,2
Hai quốc tịch,3', 3, 1.5, 3)
SET IDENTITY_INSERT [dbo].[Rules] OFF
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [fk_room] FOREIGN KEY([roomName])
REFERENCES [dbo].[RoomCategories] ([name])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [fk_room]
GO
USE [master]
GO
ALTER DATABASE [ManageHotel] SET  READ_WRITE 
GO
