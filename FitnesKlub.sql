USE [master]
GO
/****** Object:  Database [FitnesKlub]    Script Date: 29.8.2024. 21:21:16 ******/
CREATE DATABASE [FitnesKlub]
GO
ALTER DATABASE [FitnesKlub] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FitnesKlub] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FitnesKlub] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FitnesKlub] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FitnesKlub] SET ARITHABORT OFF 
GO
ALTER DATABASE [FitnesKlub] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FitnesKlub] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FitnesKlub] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FitnesKlub] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FitnesKlub] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FitnesKlub] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FitnesKlub] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FitnesKlub] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FitnesKlub] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FitnesKlub] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FitnesKlub] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FitnesKlub] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FitnesKlub] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FitnesKlub] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FitnesKlub] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FitnesKlub] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FitnesKlub] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FitnesKlub] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FitnesKlub] SET  MULTI_USER 
GO
ALTER DATABASE [FitnesKlub] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FitnesKlub] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FitnesKlub] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FitnesKlub] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FitnesKlub] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FitnesKlub] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [FitnesKlub] SET QUERY_STORE = OFF
GO
USE [FitnesKlub]
GO
/****** Object:  Table [dbo].[Clan]    Script Date: 29.8.2024. 21:21:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClanId] [int] NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[DatumRodjenja] [varchar](50) NOT NULL,
	[Zanimanje] [varchar](50) NOT NULL,
	[Telefon] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Clan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clanstvo]    Script Date: 29.8.2024. 21:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clanstvo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GrupaId] [int] NOT NULL,
	[ClanId] [int] NOT NULL,
	[DatumUclanjenja] [varchar](50) NOT NULL,
	[NeizmirenaDugovanja] [int] NOT NULL,
	[DatumPoslednjegPlacanja] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Clanstvo_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[GrupaId] ASC,
	[ClanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grupa]    Script Date: 29.8.2024. 21:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
	[BrojClanova] [int] NOT NULL,
	[TreningProgramId] [int] NOT NULL,
 CONSTRAINT [PK_Grupa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 29.8.2024. 21:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Termin]    Script Date: 29.8.2024. 21:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Termin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TerminId] [varchar](50) NOT NULL,
	[Datum] [varchar](50) NOT NULL,
	[Trajanje] [int] NOT NULL,
	[GrupaId] [int] NOT NULL,
 CONSTRAINT [PK_Termin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trener]    Script Date: 29.8.2024. 21:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trener](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KorisnickoIme] [varchar](50) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[Sifra] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Trener] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TreningProgram]    Script Date: 29.8.2024. 21:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TreningProgram](
	[Id] [int] NOT NULL,
	[Tezina] [int] NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
	[Cena] [int] NOT NULL,
 CONSTRAINT [PK_TreningProgram] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clan] ON 

INSERT [dbo].[Clan] ([Id], [ClanId], [Ime], [Prezime], [DatumRodjenja], [Zanimanje], [Telefon]) VALUES (21, 123122, N'Jovan', N'Jolovic', N'16.6.1994. 21:56:47', N'Džedaj', N'123')
INSERT [dbo].[Clan] ([Id], [ClanId], [Ime], [Prezime], [DatumRodjenja], [Zanimanje], [Telefon]) VALUES (22, 891222, N'Vojislavko', N'Vukovic', N'4.1.1989. 22:09:34', N'Džokej', N'12231')
INSERT [dbo].[Clan] ([Id], [ClanId], [Ime], [Prezime], [DatumRodjenja], [Zanimanje], [Telefon]) VALUES (23, 727272, N'Danilo?', N'Imcic', N'27.12.1988. 00:00:32', N'Vojskovodja', N'52')
INSERT [dbo].[Clan] ([Id], [ClanId], [Ime], [Prezime], [DatumRodjenja], [Zanimanje], [Telefon]) VALUES (24, 123129, N'David', N'Prezic', N'25.2.2001. 14:18:23', N'Stolar junior', N'123122')
INSERT [dbo].[Clan] ([Id], [ClanId], [Ime], [Prezime], [DatumRodjenja], [Zanimanje], [Telefon]) VALUES (25, 2, N'Jelena', N'Kukic', N'3.1.1989. 14:23:17', N'Student', N'1231231')
INSERT [dbo].[Clan] ([Id], [ClanId], [Ime], [Prezime], [DatumRodjenja], [Zanimanje], [Telefon]) VALUES (26, 990090, N'Mirko', N'Dobrica', N'31.1.1990. 20:19:19', N'Svestanik', N'129873')
INSERT [dbo].[Clan] ([Id], [ClanId], [Ime], [Prezime], [DatumRodjenja], [Zanimanje], [Telefon]) VALUES (27, 123333, N'Milojko', N'Tugickovic', N'16.2.1989. 20:30:38', N'Vodoinstalater senior', N'187232')
INSERT [dbo].[Clan] ([Id], [ClanId], [Ime], [Prezime], [DatumRodjenja], [Zanimanje], [Telefon]) VALUES (28, 141414, N'Mita', N'Aleksic', N'18.2.1997. 00:17:22', N'Menadzer', N'064853xxx')
INSERT [dbo].[Clan] ([Id], [ClanId], [Ime], [Prezime], [DatumRodjenja], [Zanimanje], [Telefon]) VALUES (29, 828282, N'Coske', N'Pupko', N'10.6.2004. 01:42:50', N'Vratar', N'1203')
INSERT [dbo].[Clan] ([Id], [ClanId], [Ime], [Prezime], [DatumRodjenja], [Zanimanje], [Telefon]) VALUES (30, 444444, N'asdf', N'aaa', N'26.8.2024. 23:13:57', N's', N'sdfs3')
INSERT [dbo].[Clan] ([Id], [ClanId], [Ime], [Prezime], [DatumRodjenja], [Zanimanje], [Telefon]) VALUES (31, 333311, N'Hajduk', N'Veljko', N'26.8.2024. 23:28:17', N'a', N'sd')
INSERT [dbo].[Clan] ([Id], [ClanId], [Ime], [Prezime], [DatumRodjenja], [Zanimanje], [Telefon]) VALUES (1027, 123121, N'Cupko', N'Alic', N'31.1.1990. 20:16:23', N'majstor', N'23')
INSERT [dbo].[Clan] ([Id], [ClanId], [Ime], [Prezime], [DatumRodjenja], [Zanimanje], [Telefon]) VALUES (2027, 654640, N'Kris', N'Can', N'29.8.2024. 21:15:03', N'dr', N'123')
SET IDENTITY_INSERT [dbo].[Clan] OFF
GO
SET IDENTITY_INSERT [dbo].[Clanstvo] ON 

INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (5, 8, 23, N'26.12.2023. 20:38:42', 1500, N'30.7.2024. 20:38:42')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (6, 8, 21, N'26.12.2023. 20:38:42', 1500, N'30.7.2024. 20:38:42')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (7, 9, 23, N'29.7.2024. 20:42:35', 0, N'25.8.2024. 20:42:35')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (8, 9, 25, N'29.7.2024. 20:42:35', 0, N'25.8.2024. 20:42:35')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (9, 10, 25, N'25.8.2024. 20:44:57', 0, N'25.8.2024. 20:44:57')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (10, 11, 22, N'25.8.2024. 20:46:11', 0, N'25.8.2024. 20:46:11')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (12, 12, 26, N'25.8.2024. 20:46:11', 0, N'25.8.2024. 20:46:11')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (13, 12, 23, N'25.8.2024. 20:46:11', 0, N'25.8.2024. 20:46:11')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (14, 12, 25, N'25.8.2024. 20:46:11', 0, N'25.8.2024. 20:46:11')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (16, 12, 21, N'30.7.2024. 20:45:11', 2500, N'31.7.2024. 20:44:11')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (20, 14, 22, N'2.1.2024. 23:26:24', 10000, N'15.3.2024. 23:26:24')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (21, 14, 23, N'2.1.2024. 23:26:24', 2000, N'26.7.2024. 23:26:24')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (22, 15, 22, N'7.2.2024. 23:28:49', 2000, N'25.7.2024. 23:28:49')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (23, 16, 26, N'27.8.2024. 17:52:25', 0, N'27.8.2024. 17:52:25')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (24, 17, 26, N'27.8.2024. 17:56:36', 0, N'27.8.2024. 17:56:36')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (25, 17, 24, N'27.8.2024. 17:56:36', 0, N'27.8.2024. 17:56:36')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (26, 18, 23, N'8.2.2024. 21:53:50', 2500, N'31.7.2024. 21:53:50')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (27, 18, 24, N'8.2.2024. 21:53:50', 2500, N'31.7.2024. 21:53:50')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (28, 18, 30, N'8.2.2024. 21:53:50', 5000, N'25.6.2024. 21:53:50')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (1002, 1018, 21, N'24.6.2024. 00:20:03', 2200, N'30.7.2024. 00:20:03')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (1003, 1018, 25, N'4.1.2024. 00:20:03', 6600, N'24.5.2024. 00:20:03')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (1004, 1018, 29, N'23.2.2024. 00:20:03', 11000, N'14.3.2024. 00:20:03')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (1005, 1019, 22, N'28.8.2024. 00:50:38', 0, N'28.8.2024. 00:50:38')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (1006, 1019, 27, N'25.6.2024. 00:50:38', 2000, N'30.7.2024. 00:50:38')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (1007, 1020, 24, N'31.7.2024. 01:24:48', 2200, N'31.7.2024. 01:24:48')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (1008, 1022, 24, N'28.8.2024. 02:04:40', 0, N'28.8.2024. 02:04:40')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (1011, 1023, 24, N'28.8.2024. 03:02:05', 0, N'28.8.2024. 03:02:05')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (1013, 13, 22, N'28.8.2024. 03:13:36', 0, N'28.8.2024. 03:13:36')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (1014, 13, 24, N'28.8.2024. 03:13:36', 0, N'28.8.2024. 03:13:36')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (1015, 13, 28, N'25.6.2024. 03:12:36', 1500, N'31.7.2024. 03:11:36')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (1016, 13, 31, N'28.8.2024. 03:13:36', 0, N'28.8.2024. 03:13:36')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (1017, 13, 21, N'28.8.2024. 03:13:36', 0, N'28.8.2024. 03:13:36')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (1018, 13, 23, N'28.8.2024. 03:13:36', 0, N'28.8.2024. 03:13:36')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (2009, 2018, 21, N'28.8.2024. 19:56:19', 0, N'28.8.2024. 19:56:19')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (2010, 2018, 27, N'26.6.2024. 19:55:19', 2200, N'29.7.2024. 19:54:19')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (2011, 2018, 31, N'28.8.2024. 19:56:19', 0, N'28.8.2024. 19:56:19')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (3009, 16, 29, N'28.8.2024. 21:04:18', 0, N'28.8.2024. 21:04:18')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (3010, 16, 25, N'24.6.2024. 21:23:12', 4400, N'25.6.2024. 21:22:12')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (3011, 16, 24, N'28.8.2024. 21:24:12', 0, N'28.8.2024. 21:24:12')
INSERT [dbo].[Clanstvo] ([Id], [GrupaId], [ClanId], [DatumUclanjenja], [NeizmirenaDugovanja], [DatumPoslednjegPlacanja]) VALUES (3012, 16, 23, N'24.6.2024. 21:23:12', 4400, N'25.6.2024. 21:22:12')
SET IDENTITY_INSERT [dbo].[Clanstvo] OFF
GO
SET IDENTITY_INSERT [dbo].[Grupa] ON 

INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (1, N'Test', 0, 2)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (3, N'Test2', 0, 1)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (7, N'Juniori', 0, 1)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (8, N'Seniori', 2, 4)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (9, N'Penzioneri', 2, 2)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (10, N'Deca', 1, 1)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (11, N'Elita', 1, 4)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (12, N'VELIKIM SLOVIMA GRUPA', 4, 1)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (13, N'Kukuuuu', 6, 4)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (14, N'GG', 2, 3)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (15, N'FG', 1, 3)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (16, N'Grupa Novi naziv', 5, 2)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (17, N'asdf', 2, 2)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (18, N'Izmenjena clanstva', 3, 1)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (1018, N'SSS', 3, 2)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (1019, N'PO kk', 2, 3)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (1020, N'Gorstaci', 1, 2)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (1021, N'eeee', 0, 4)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (1022, N'opo', 1, 3)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (1023, N'zxcv', 1, 3)
INSERT [dbo].[Grupa] ([Id], [Naziv], [BrojClanova], [TreningProgramId]) VALUES (2018, N'Grupa 23', 3, 2)
SET IDENTITY_INSERT [dbo].[Grupa] OFF
GO
SET IDENTITY_INSERT [dbo].[Termin] ON 

INSERT [dbo].[Termin] ([Id], [TerminId], [Datum], [Trajanje], [GrupaId]) VALUES (1, N't-1', N'27.8.2024. 00:27:38', 776, 1)
INSERT [dbo].[Termin] ([Id], [TerminId], [Datum], [Trajanje], [GrupaId]) VALUES (2, N't-2', N'27.8.2024. 00:27:38', 9090, 13)
INSERT [dbo].[Termin] ([Id], [TerminId], [Datum], [Trajanje], [GrupaId]) VALUES (3, N'123', N'27.8.2024. 19:06:46', 123, 9)
INSERT [dbo].[Termin] ([Id], [TerminId], [Datum], [Trajanje], [GrupaId]) VALUES (4, N'T-123', N'27.8.2024. 19:12:44', 1233, 3)
INSERT [dbo].[Termin] ([Id], [TerminId], [Datum], [Trajanje], [GrupaId]) VALUES (5, N'T-1q', N'27.8.2024. 19:37:00', 43, 10)
INSERT [dbo].[Termin] ([Id], [TerminId], [Datum], [Trajanje], [GrupaId]) VALUES (6, N'T-1', N'27.8.2024. 19:37:00', 12333, 3)
INSERT [dbo].[Termin] ([Id], [TerminId], [Datum], [Trajanje], [GrupaId]) VALUES (7, N'T-2', N'12.6.2024. 19:37:00', 525, 15)
INSERT [dbo].[Termin] ([Id], [TerminId], [Datum], [Trajanje], [GrupaId]) VALUES (1003, N'T-qwerty', N'17.8.2024. 01:04:44', 12, 18)
INSERT [dbo].[Termin] ([Id], [TerminId], [Datum], [Trajanje], [GrupaId]) VALUES (1004, N'T-tttt', N'9.8.2024. 01:16:42', 4343, 11)
INSERT [dbo].[Termin] ([Id], [TerminId], [Datum], [Trajanje], [GrupaId]) VALUES (1005, N'T-1232', N'28.8.2024. 01:58:42', 1222, 9)
INSERT [dbo].[Termin] ([Id], [TerminId], [Datum], [Trajanje], [GrupaId]) VALUES (2003, N'T-termin 45', N'28.8.2024. 22:02:03', 123, 11)
INSERT [dbo].[Termin] ([Id], [TerminId], [Datum], [Trajanje], [GrupaId]) VALUES (3003, N'T-00', N'29.8.2024. 21:15:36', 12, 3)
INSERT [dbo].[Termin] ([Id], [TerminId], [Datum], [Trajanje], [GrupaId]) VALUES (3004, N'T-002', N'29.8.2024. 21:15:36', 23, 11)
SET IDENTITY_INSERT [dbo].[Termin] OFF
GO
SET IDENTITY_INSERT [dbo].[Trener] ON 

INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (1, N'Vajss', N'Vasilije', N'Aleksic', N'asdf')
INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (2, N'Jula', N'Sof', N'Julic', N'123')
INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (3, N'asdfasdf', N'asdf', N'sdf', N'asdf')
INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (4, N'xxx', N'asdfasdf', N'xxx', N'xxx')
INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (5, N'mita', N'Mita', N'mitic', N'asds')
INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (6, N'vxc', N'vxc', N'vxc', N'vxc')
INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (7, N'RadeTuga123', N'Tugomir', N'Radic', N'123123')
INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (8, N'ssss', N'ssss', N'ssss', N'ssss')
INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (9, N'asdf', N'asdf', N'asdf', N'asdf')
INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (10, N'jole', N'jole', N'jolejole', N'vvvv')
INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (11, N'Krek', N'Ivko', N'Karbatic', N'1')
INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (1011, N'?????????', N'?????????', N'???????', N'123')
INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (1012, N'???', N'????', N'????????', N'123')
INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (1013, N'vasa', N'Vasilije', N'Aleksic', N'123')
INSERT [dbo].[Trener] ([Id], [KorisnickoIme], [Ime], [Prezime], [Sifra]) VALUES (2011, N'1', N'1', N'1', N'1')
SET IDENTITY_INSERT [dbo].[Trener] OFF
GO
INSERT [dbo].[TreningProgram] ([Id], [Tezina], [Naziv], [Cena]) VALUES (1, 4, N'Kick Box  ', 2500)
INSERT [dbo].[TreningProgram] ([Id], [Tezina], [Naziv], [Cena]) VALUES (2, 5, N'Crossfit  ', 2200)
INSERT [dbo].[TreningProgram] ([Id], [Tezina], [Naziv], [Cena]) VALUES (3, 3, N'Pilates   ', 2000)
INSERT [dbo].[TreningProgram] ([Id], [Tezina], [Naziv], [Cena]) VALUES (4, 3, N'Kardio    ', 1500)
GO
ALTER TABLE [dbo].[Clanstvo]  WITH CHECK ADD  CONSTRAINT [FK_Clanstvo_Clan] FOREIGN KEY([ClanId])
REFERENCES [dbo].[Clan] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Clanstvo] CHECK CONSTRAINT [FK_Clanstvo_Clan]
GO
ALTER TABLE [dbo].[Clanstvo]  WITH CHECK ADD  CONSTRAINT [FK_Clanstvo_Grupa] FOREIGN KEY([GrupaId])
REFERENCES [dbo].[Grupa] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Clanstvo] CHECK CONSTRAINT [FK_Clanstvo_Grupa]
GO
ALTER TABLE [dbo].[Grupa]  WITH CHECK ADD  CONSTRAINT [FK_Grupa_TreningProgram] FOREIGN KEY([TreningProgramId])
REFERENCES [dbo].[TreningProgram] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Grupa] CHECK CONSTRAINT [FK_Grupa_TreningProgram]
GO
ALTER TABLE [dbo].[Termin]  WITH CHECK ADD  CONSTRAINT [FK_Termin_Grupa] FOREIGN KEY([GrupaId])
REFERENCES [dbo].[Grupa] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Termin] CHECK CONSTRAINT [FK_Termin_Grupa]
GO
USE [master]
GO
ALTER DATABASE [FitnesKlub] SET  READ_WRITE 
GO
