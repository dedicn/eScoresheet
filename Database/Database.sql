USE [seminarski]
GO
/****** Object:  Table [dbo].[Igrac]    Script Date: 11/3/2024 11:48:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Igrac](
	[IgracID] [int] NOT NULL,
	[ImePrezime] [varchar](50) NULL,
	[BrojDresa] [varchar](3) NOT NULL,
	[IDTima] [int] NOT NULL,
 CONSTRAINT [PK_Igrac] PRIMARY KEY CLUSTERED 
(
	[IgracID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RezultatCetvrtine]    Script Date: 11/3/2024 11:48:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RezultatCetvrtine](
	[BrojCetvrtine] [int] NOT NULL,
	[BrojPoenaDomaci] [int] NOT NULL,
	[BrojPoenaGosti] [int] NOT NULL,
	[BrojTajmautaDomaci] [int] NOT NULL,
	[BrojTajmautaGosti] [int] NOT NULL,
	[BrojGresakaDomaci] [int] NOT NULL,
	[BrojGresakaGosti] [int] NOT NULL,
	[UtakmicaID] [int] NOT NULL,
 CONSTRAINT [PK_RezultatCetvrtine] PRIMARY KEY CLUSTERED 
(
	[BrojCetvrtine] ASC,
	[UtakmicaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RezultatIgraca]    Script Date: 11/3/2024 11:48:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RezultatIgraca](
	[IgracID] [int] NOT NULL,
	[UtakmicaID] [int] NOT NULL,
	[BrojPoena] [int] NOT NULL,
	[BrojLicnihGresaka] [int] NOT NULL,
 CONSTRAINT [PK_RezultatIgraca] PRIMARY KEY CLUSTERED 
(
	[IgracID] ASC,
	[UtakmicaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tim]    Script Date: 11/3/2024 11:48:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tim](
	[TimID] [int] IDENTITY(1,1) NOT NULL,
	[NazivTima] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tim] PRIMARY KEY CLUSTERED 
(
	[TimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipUtakmice]    Script Date: 11/3/2024 11:48:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipUtakmice](
	[TipID] [int] IDENTITY(0,1) NOT NULL,
	[NazivTipa] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipUtakmice] PRIMARY KEY CLUSTERED 
(
	[TipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utakmica]    Script Date: 11/3/2024 11:48:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utakmica](
	[UtakmicaID] [int] NOT NULL,
	[VremePocetka] [datetime] NOT NULL,
	[VremeZavrsetka] [datetime] NULL,
	[Mesto] [varchar](20) NOT NULL,
	[Domacin] [int] NOT NULL,
	[Gost] [int] NOT NULL,
	[IDTipa] [int] NOT NULL,
 CONSTRAINT [PK_Utakmica] PRIMARY KEY CLUSTERED 
(
	[UtakmicaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zapisnicar]    Script Date: 11/3/2024 11:48:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zapisnicar](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
 CONSTRAINT [PK_Zapisnicar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Igrac]  WITH CHECK ADD  CONSTRAINT [FK_Igrac_Tim] FOREIGN KEY([IDTima])
REFERENCES [dbo].[Tim] ([TimID])
GO
ALTER TABLE [dbo].[Igrac] CHECK CONSTRAINT [FK_Igrac_Tim]
GO
ALTER TABLE [dbo].[RezultatCetvrtine]  WITH CHECK ADD  CONSTRAINT [FK_Utakmica] FOREIGN KEY([UtakmicaID])
REFERENCES [dbo].[Utakmica] ([UtakmicaID])
GO
ALTER TABLE [dbo].[RezultatCetvrtine] CHECK CONSTRAINT [FK_Utakmica]
GO
ALTER TABLE [dbo].[RezultatIgraca]  WITH CHECK ADD  CONSTRAINT [FK_Igrac] FOREIGN KEY([IgracID])
REFERENCES [dbo].[Igrac] ([IgracID])
GO
ALTER TABLE [dbo].[RezultatIgraca] CHECK CONSTRAINT [FK_Igrac]
GO
ALTER TABLE [dbo].[RezultatIgraca]  WITH CHECK ADD  CONSTRAINT [FK_RezUtakmica] FOREIGN KEY([UtakmicaID])
REFERENCES [dbo].[Utakmica] ([UtakmicaID])
GO
ALTER TABLE [dbo].[RezultatIgraca] CHECK CONSTRAINT [FK_RezUtakmica]
GO
ALTER TABLE [dbo].[Utakmica]  WITH CHECK ADD  CONSTRAINT [FK_Domacin] FOREIGN KEY([Domacin])
REFERENCES [dbo].[Tim] ([TimID])
GO
ALTER TABLE [dbo].[Utakmica] CHECK CONSTRAINT [FK_Domacin]
GO
ALTER TABLE [dbo].[Utakmica]  WITH CHECK ADD  CONSTRAINT [FK_Gost] FOREIGN KEY([Gost])
REFERENCES [dbo].[Tim] ([TimID])
GO
ALTER TABLE [dbo].[Utakmica] CHECK CONSTRAINT [FK_Gost]
GO
ALTER TABLE [dbo].[Utakmica]  WITH CHECK ADD  CONSTRAINT [FK_Tip_Utakmice] FOREIGN KEY([IDTipa])
REFERENCES [dbo].[TipUtakmice] ([TipID])
GO
ALTER TABLE [dbo].[Utakmica] CHECK CONSTRAINT [FK_Tip_Utakmice]
GO
