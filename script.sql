USE [master]
GO
/****** Object:  Database [DB_Universidad]    Script Date: 01/08/2021 3:14:16 ******/
CREATE DATABASE [DB_Universidad]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'universidad', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DB_Universidad.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'universidad_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DB_Universidad_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DB_Universidad] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Universidad].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Universidad] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_Universidad] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_Universidad] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_Universidad] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_Universidad] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_Universidad] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DB_Universidad] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_Universidad] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_Universidad] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_Universidad] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_Universidad] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_Universidad] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_Universidad] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_Universidad] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_Universidad] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_Universidad] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_Universidad] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_Universidad] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_Universidad] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_Universidad] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_Universidad] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_Universidad] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_Universidad] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_Universidad] SET  MULTI_USER 
GO
ALTER DATABASE [DB_Universidad] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_Universidad] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_Universidad] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_Universidad] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_Universidad] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_Universidad] SET QUERY_STORE = OFF
GO
USE [DB_Universidad]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 01/08/2021 3:14:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[Matricula] [int] IDENTITY(1,1) NOT NULL,
	[NombreYApellido] [varchar](45) NULL,
	[Direccion] [varchar](45) NULL,
	[Telefono] [char](10) NULL,
 CONSTRAINT [PK4] PRIMARY KEY NONCLUSTERED 
(
	[Matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aula]    Script Date: 01/08/2021 3:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aula](
	[idAula] [int] IDENTITY(1,1) NOT NULL,
	[NombreAula] [nchar](10) NULL,
	[ConexionRed] [bit] NULL,
	[Proyector] [bit] NULL,
	[Capacidad] [int] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[idAula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Correlativa]    Script Date: 01/08/2021 3:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Correlativa](
	[idCorrelativa] [int] IDENTITY(1,1) NOT NULL,
	[idMateria] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Requisito] [varchar](50) NULL,
 CONSTRAINT [PK_Correlativa] PRIMARY KEY CLUSTERED 
(
	[idCorrelativa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 01/08/2021 3:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[idCurso] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [char](20) NULL,
	[idAula] [int] NOT NULL,
 CONSTRAINT [PK1] PRIMARY KEY NONCLUSTERED 
(
	[idCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CursoMateria]    Script Date: 01/08/2021 3:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CursoMateria](
	[idCursoMateria] [int] IDENTITY(1,1) NOT NULL,
	[idDivision] [int] NULL,
	[idMateria] [int] NOT NULL,
	[Matricula] [int] NOT NULL,
	[PrimerParcial] [int] NULL,
	[SegundoParcial] [int] NULL,
	[TercerParcial] [int] NULL,
	[PrimerRecuperatorio] [int] NULL,
	[SegundoRecuperatorio] [int] NULL,
	[Estado] [varchar](50) NULL,
	[NotaFinal] [int] NULL,
	[Inscripcion_EFinal] [varchar](50) NULL,
 CONSTRAINT [PK7] PRIMARY KEY NONCLUSTERED 
(
	[idCursoMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Division]    Script Date: 01/08/2021 3:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Division](
	[idDivision] [int] IDENTITY(1,1) NOT NULL,
	[NombreDivision] [char](10) NULL,
	[idCurso] [int] NOT NULL,
 CONSTRAINT [PK_Division] PRIMARY KEY CLUSTERED 
(
	[idDivision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Final]    Script Date: 01/08/2021 3:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Final](
	[intIdFinal] [int] IDENTITY(1,1) NOT NULL,
	[idCursoMateria] [int] NOT NULL,
	[NotaExamen] [int] NULL,
	[EstadoEFinal] [varchar](50) NULL,
 CONSTRAINT [PK_Final] PRIMARY KEY CLUSTERED 
(
	[intIdFinal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 01/08/2021 3:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia](
	[idMateria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](25) NULL,
	[Legajo] [int] NOT NULL,
	[IdCurso] [int] NOT NULL,
 CONSTRAINT [PK5] PRIMARY KEY NONCLUSTERED 
(
	[idMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 01/08/2021 3:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[Legajo] [int] IDENTITY(1,1) NOT NULL,
	[NombreYApellido] [varchar](55) NULL,
	[Direccion] [varchar](45) NULL,
	[Telefono] [char](10) NULL,
	[DNI] [varchar](50) NULL,
 CONSTRAINT [PK4_1] PRIMARY KEY NONCLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Correlativa]  WITH CHECK ADD  CONSTRAINT [FK_Correlativa_Materia] FOREIGN KEY([idMateria])
REFERENCES [dbo].[Materia] ([idMateria])
GO
ALTER TABLE [dbo].[Correlativa] CHECK CONSTRAINT [FK_Correlativa_Materia]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Aula] FOREIGN KEY([idAula])
REFERENCES [dbo].[Aula] ([idAula])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Aula]
GO
ALTER TABLE [dbo].[CursoMateria]  WITH CHECK ADD  CONSTRAINT [FK_CursoMateria_Division] FOREIGN KEY([idDivision])
REFERENCES [dbo].[Division] ([idDivision])
GO
ALTER TABLE [dbo].[CursoMateria] CHECK CONSTRAINT [FK_CursoMateria_Division]
GO
ALTER TABLE [dbo].[CursoMateria]  WITH CHECK ADD  CONSTRAINT [FK_CursoMateria_Materia] FOREIGN KEY([idMateria])
REFERENCES [dbo].[Materia] ([idMateria])
GO
ALTER TABLE [dbo].[CursoMateria] CHECK CONSTRAINT [FK_CursoMateria_Materia]
GO
ALTER TABLE [dbo].[CursoMateria]  WITH CHECK ADD  CONSTRAINT [RefAlumno5] FOREIGN KEY([Matricula])
REFERENCES [dbo].[Alumno] ([Matricula])
GO
ALTER TABLE [dbo].[CursoMateria] CHECK CONSTRAINT [RefAlumno5]
GO
ALTER TABLE [dbo].[Division]  WITH CHECK ADD  CONSTRAINT [FK_Division_Curso] FOREIGN KEY([idCurso])
REFERENCES [dbo].[Curso] ([idCurso])
GO
ALTER TABLE [dbo].[Division] CHECK CONSTRAINT [FK_Division_Curso]
GO
ALTER TABLE [dbo].[Final]  WITH CHECK ADD  CONSTRAINT [FK_Final_CursoMateria] FOREIGN KEY([idCursoMateria])
REFERENCES [dbo].[CursoMateria] ([idCursoMateria])
GO
ALTER TABLE [dbo].[Final] CHECK CONSTRAINT [FK_Final_CursoMateria]
GO
ALTER TABLE [dbo].[Materia]  WITH CHECK ADD  CONSTRAINT [FK_Materia_Curso] FOREIGN KEY([IdCurso])
REFERENCES [dbo].[Curso] ([idCurso])
GO
ALTER TABLE [dbo].[Materia] CHECK CONSTRAINT [FK_Materia_Curso]
GO
ALTER TABLE [dbo].[Materia]  WITH CHECK ADD  CONSTRAINT [RefProfesor10] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Profesor] ([Legajo])
GO
ALTER TABLE [dbo].[Materia] CHECK CONSTRAINT [RefProfesor10]
GO
/****** Object:  StoredProcedure [dbo].[ComprobanteAlta]    Script Date: 01/08/2021 3:14:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ComprobanteAlta] @Matricula int 
as
select a.NombreYApellido Alumno,  mat.Nombre Materia , p.NombreYApellido Profesor,cm.Estado from CursoMateria cm inner join Alumno a on a.Matricula=@Matricula and cm.Matricula=@Matricula inner join Materia mat
on cm.idMateria=mat.idMateria inner join Profesor p on p.Legajo=mat.Legajo
GO
USE [master]
GO
ALTER DATABASE [DB_Universidad] SET  READ_WRITE 
GO
