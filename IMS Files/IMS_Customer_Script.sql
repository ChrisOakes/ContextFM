USE [master]
GO
/****** Object:  Database [MapleWarehouse]    Script Date: 26/11/2022 20:00:17 ******/
CREATE DATABASE [MapleWarehouse]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MapleWarehouse', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\MapleWarehouse.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MapleWarehouse_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\MapleWarehouse_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MapleWarehouse] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MapleWarehouse].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MapleWarehouse] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MapleWarehouse] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MapleWarehouse] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MapleWarehouse] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MapleWarehouse] SET ARITHABORT OFF 
GO
ALTER DATABASE [MapleWarehouse] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MapleWarehouse] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MapleWarehouse] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MapleWarehouse] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MapleWarehouse] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MapleWarehouse] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MapleWarehouse] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MapleWarehouse] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MapleWarehouse] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MapleWarehouse] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MapleWarehouse] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MapleWarehouse] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MapleWarehouse] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MapleWarehouse] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MapleWarehouse] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MapleWarehouse] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [MapleWarehouse] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MapleWarehouse] SET RECOVERY FULL 
GO
ALTER DATABASE [MapleWarehouse] SET  MULTI_USER 
GO
ALTER DATABASE [MapleWarehouse] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MapleWarehouse] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MapleWarehouse] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MapleWarehouse] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MapleWarehouse] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MapleWarehouse', N'ON'
GO
ALTER DATABASE [MapleWarehouse] SET QUERY_STORE = OFF
GO
USE [MapleWarehouse]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 26/11/2022 20:00:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[StockCount] [int] NOT NULL,
	[CostPrice] [decimal](18, 2) NOT NULL,
	[SalePrice] [decimal](18, 2) NOT NULL,
	[Created] [datetime2](7) NOT NULL,
	[LastUpdated] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [MapleWarehouse] SET  READ_WRITE 
GO


/****** Object:  Database [PorterInventorySolutions]    Script Date: 26/11/2022 20:01:08 ******/
CREATE DATABASE [PorterInventorySolutions]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PorterInventorySolutions', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\PorterInventorySolutions.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PorterInventorySolutions_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\PorterInventorySolutions_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PorterInventorySolutions] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PorterInventorySolutions].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PorterInventorySolutions] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET ARITHABORT OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PorterInventorySolutions] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PorterInventorySolutions] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PorterInventorySolutions] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PorterInventorySolutions] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [PorterInventorySolutions] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET RECOVERY FULL 
GO
ALTER DATABASE [PorterInventorySolutions] SET  MULTI_USER 
GO
ALTER DATABASE [PorterInventorySolutions] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PorterInventorySolutions] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PorterInventorySolutions] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PorterInventorySolutions] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PorterInventorySolutions] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PorterInventorySolutions', N'ON'
GO
ALTER DATABASE [PorterInventorySolutions] SET QUERY_STORE = OFF
GO
USE [PorterInventorySolutions]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 26/11/2022 20:01:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[StockCount] [int] NOT NULL,
	[CostPrice] [decimal](18, 2) NOT NULL,
	[SalePrice] [decimal](18, 2) NOT NULL,
	[Created] [datetime2](7) NOT NULL,
	[LastUpdated] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [PorterInventorySolutions] SET  READ_WRITE 
GO

/****** Object:  Database [WhetherlyStock]    Script Date: 26/11/2022 20:01:19 ******/
CREATE DATABASE [WhetherlyStock]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WhetherlyStock', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\WhetherlyStock.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WhetherlyStock_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\WhetherlyStock_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [WhetherlyStock] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WhetherlyStock].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WhetherlyStock] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WhetherlyStock] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WhetherlyStock] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WhetherlyStock] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WhetherlyStock] SET ARITHABORT OFF 
GO
ALTER DATABASE [WhetherlyStock] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WhetherlyStock] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WhetherlyStock] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WhetherlyStock] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WhetherlyStock] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WhetherlyStock] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WhetherlyStock] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WhetherlyStock] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WhetherlyStock] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WhetherlyStock] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WhetherlyStock] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WhetherlyStock] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WhetherlyStock] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WhetherlyStock] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WhetherlyStock] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WhetherlyStock] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [WhetherlyStock] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WhetherlyStock] SET RECOVERY FULL 
GO
ALTER DATABASE [WhetherlyStock] SET  MULTI_USER 
GO
ALTER DATABASE [WhetherlyStock] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WhetherlyStock] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WhetherlyStock] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WhetherlyStock] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WhetherlyStock] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WhetherlyStock', N'ON'
GO
ALTER DATABASE [WhetherlyStock] SET QUERY_STORE = OFF
GO
USE [WhetherlyStock]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 26/11/2022 20:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[StockCount] [int] NOT NULL,
	[CostPrice] [decimal](18, 2) NOT NULL,
	[SalePrice] [decimal](18, 2) NOT NULL,
	[Created] [datetime2](7) NOT NULL,
	[LastUpdated] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [WhetherlyStock] SET  READ_WRITE 
GO


------------------------Data Insert--------------------------
USE [MapleWarehouse]
GO
SET IDENTITY_INSERT [dbo].[Inventory] ON 
GO
INSERT [dbo].[Inventory] ([Id], [Name], [Description], [StockCount], [CostPrice], [SalePrice], [Created], [LastUpdated]) VALUES (1, N'HB Pencil', N'Lead pencil for writing', 1000, CAST(0.50 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), CAST(N'2023-01-03T00:00:00.0000000' AS DateTime2), CAST(N'2023-01-04T21:04:32.4851948' AS DateTime2))
GO
INSERT [dbo].[Inventory] ([Id], [Name], [Description], [StockCount], [CostPrice], [SalePrice], [Created], [LastUpdated]) VALUES (2, N'Ballpoint pen', N'Ballpoint writing', 150, CAST(0.75 AS Decimal(18, 2)), CAST(1.25 AS Decimal(18, 2)), CAST(N'2023-01-03T00:00:00.0000000' AS DateTime2), CAST(N'2023-01-03T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Inventory] ([Id], [Name], [Description], [StockCount], [CostPrice], [SalePrice], [Created], [LastUpdated]) VALUES (3, N'Ruler', N'Measuring tool', 50, CAST(0.35 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), CAST(N'2023-01-03T00:00:00.0000000' AS DateTime2), CAST(N'2023-01-03T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Inventory] OFF
GO

USE [PorterInventorySolutions]
GO
SET IDENTITY_INSERT [dbo].[Inventory] ON 
GO
INSERT [dbo].[Inventory] ([Id], [Name], [Description], [StockCount], [CostPrice], [SalePrice], [Created], [LastUpdated]) VALUES (1, N'A4 Paper', N'Deluxe A4 paper', 1000, CAST(0.08 AS Decimal(18, 2)), CAST(0.15 AS Decimal(18, 2)), CAST(N'2023-01-04T07:50:36.3800000' AS DateTime2), CAST(N'2023-01-04T07:52:21.3245323' AS DateTime2))
GO
INSERT [dbo].[Inventory] ([Id], [Name], [Description], [StockCount], [CostPrice], [SalePrice], [Created], [LastUpdated]) VALUES (2, N'A3 Paper', N'Plain A3 paper', 1050, CAST(0.07 AS Decimal(18, 2)), CAST(0.12 AS Decimal(18, 2)), CAST(N'2023-01-03T00:00:00.0000000' AS DateTime2), CAST(N'2023-01-03T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Inventory] ([Id], [Name], [Description], [StockCount], [CostPrice], [SalePrice], [Created], [LastUpdated]) VALUES (3, N'A2 Paper', N'Plain A2 paper', 850, CAST(0.09 AS Decimal(18, 2)), CAST(0.14 AS Decimal(18, 2)), CAST(N'2023-01-03T00:00:00.0000000' AS DateTime2), CAST(N'2023-01-03T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Inventory] OFF
GO

USE [WhetherlyStock]
GO
SET IDENTITY_INSERT [dbo].[Inventory] ON 
GO
INSERT [dbo].[Inventory] ([Id], [Name], [Description], [StockCount], [CostPrice], [SalePrice], [Created], [LastUpdated]) VALUES (1, N'Barometer', N'Measures atmospheric pressure', 50, CAST(25.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), CAST(N'2023-01-03T00:00:00.0000000' AS DateTime2), CAST(N'2023-01-04T21:07:35.1240570' AS DateTime2))
GO
INSERT [dbo].[Inventory] ([Id], [Name], [Description], [StockCount], [CostPrice], [SalePrice], [Created], [LastUpdated]) VALUES (2, N'Thermometer', N'Measures the temperature of liquid', 50, CAST(15.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), CAST(N'2023-01-03T00:00:00.0000000' AS DateTime2), CAST(N'2023-01-04T07:56:20.1702749' AS DateTime2))
GO
INSERT [dbo].[Inventory] ([Id], [Name], [Description], [StockCount], [CostPrice], [SalePrice], [Created], [LastUpdated]) VALUES (3, N'Anemometer', N'Measures wind speed', 150, CAST(40.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), CAST(N'2023-01-03T00:00:00.0000000' AS DateTime2), CAST(N'2023-01-03T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Inventory] OFF
GO
