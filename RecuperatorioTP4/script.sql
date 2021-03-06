USE [master]
GO
/****** Object:  Database [INSTITUTOZOONOSIS]    Script Date: 15/6/2022 17:17:43 ******/
CREATE DATABASE [INSTITUTOZOONOSIS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'INSTITUTOZOONOSIS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\INSTITUTOZOONOSIS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'INSTITUTOZOONOSIS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\INSTITUTOZOONOSIS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [INSTITUTOZOONOSIS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET ARITHABORT OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET RECOVERY FULL 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET  MULTI_USER 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'INSTITUTOZOONOSIS', N'ON'
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET QUERY_STORE = OFF
GO
USE [INSTITUTOZOONOSIS]
GO
/****** Object:  Table [dbo].[VacunasAntirrabicas]    Script Date: 15/6/2022 17:17:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VacunasAntirrabicas](
	[id_veterinaria] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[antirrabicaPerros] [int] NOT NULL,
	[antirrabicaGatos] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Veterinarias]    Script Date: 15/6/2022 17:17:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veterinarias](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (1, CAST(N'2022-06-01' AS Date), 8, 12)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (2, CAST(N'2022-06-01' AS Date), 8, 3)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (3, CAST(N'2022-06-01' AS Date), 2, 8)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (4, CAST(N'2022-06-01' AS Date), 5, 2)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (2, CAST(N'2022-06-02' AS Date), 2, 5)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (2, CAST(N'2022-06-03' AS Date), 0, 10)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (2, CAST(N'2022-06-04' AS Date), 5, 9)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (3, CAST(N'2022-06-02' AS Date), 1, 7)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (3, CAST(N'2022-06-03' AS Date), 6, 3)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (3, CAST(N'2022-06-04' AS Date), 3, 5)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (4, CAST(N'2022-06-02' AS Date), 7, 1)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (4, CAST(N'2022-06-03' AS Date), 8, 0)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (4, CAST(N'2022-06-04' AS Date), 10, 0)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (1, CAST(N'2022-06-01' AS Date), 2, 1)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (1, CAST(N'2022-06-04' AS Date), 2, 2)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (1, CAST(N'2022-06-12' AS Date), 0, 0)
INSERT [dbo].[VacunasAntirrabicas] ([id_veterinaria], [fecha], [antirrabicaPerros], [antirrabicaGatos]) VALUES (1, CAST(N'2022-06-15' AS Date), 1, 0)
GO
INSERT [dbo].[Veterinarias] ([id], [nombre]) VALUES (1, N'Pequeñas Patitas')
INSERT [dbo].[Veterinarias] ([id], [nombre]) VALUES (2, N'Puppis')
INSERT [dbo].[Veterinarias] ([id], [nombre]) VALUES (3, N'Trust me I´m a Dogtor')
INSERT [dbo].[Veterinarias] ([id], [nombre]) VALUES (4, N'Peluches de Amor')
GO
USE [master]
GO
ALTER DATABASE [INSTITUTOZOONOSIS] SET  READ_WRITE 
GO
