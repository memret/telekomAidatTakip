USE [telekomAidat]
GO
/****** Object:  Table [dbo].[Adres]    Script Date: 17.07.2017 10:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adres](
	[sicilNo] [int] NOT NULL,
	[ev] [nvarchar](50) NOT NULL,
	[evilNo] [int] NOT NULL,
	[is] [nvarchar](50) NOT NULL,
	[isilNo] [int] NOT NULL,
	[evTel] [varchar](50) NOT NULL,
	[istel] [varchar](50) NOT NULL,
	[ceptel] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_Adres] PRIMARY KEY CLUSTERED 
(
	[sicilNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AidatLog]    Script Date: 17.07.2017 10:16:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AidatLog](
	[aidatLogNo] [int] IDENTITY(1,1) NOT NULL,
	[sicilNo] [int] NOT NULL,
	[miktar] [int] NOT NULL,
	[tarih] [date] NOT NULL,
 CONSTRAINT [PK_AidatLog] PRIMARY KEY CLUSTERED 
(
	[aidatLogNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AidatMiktar]    Script Date: 17.07.2017 10:16:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AidatMiktar](
	[birimNo] [int] NOT NULL,
	[aidat] [int] NOT NULL,
 CONSTRAINT [PK_AidatMiktar] PRIMARY KEY CLUSTERED 
(
	[birimNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Birim]    Script Date: 17.07.2017 10:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Birim](
	[birimNo] [int] NOT NULL,
	[birimAdi] [nvarchar](50) NOT NULL,
	[mudurlukNo] [int] NOT NULL,
 CONSTRAINT [PK_Birim] PRIMARY KEY CLUSTERED 
(
	[birimNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cron]    Script Date: 17.07.2017 10:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cron](
	[tarih] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[il]    Script Date: 17.07.2017 10:16:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[il](
	[ilNo] [int] NOT NULL,
	[ilAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_il] PRIMARY KEY CLUSTERED 
(
	[ilNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KanGrubu]    Script Date: 17.07.2017 10:16:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KanGrubu](
	[kanGrubuNo] [int] NOT NULL,
	[kanGrubu] [nchar](10) NOT NULL,
 CONSTRAINT [PK_KanGrubu] PRIMARY KEY CLUSTERED 
(
	[kanGrubuNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mudurluk]    Script Date: 17.07.2017 10:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mudurluk](
	[mudurlukNo] [int] NOT NULL,
	[mudurlukAdi] [nvarchar](50) NULL,
	[ilNo] [int] NULL,
 CONSTRAINT [PK_Mudurluk] PRIMARY KEY CLUSTERED 
(
	[mudurlukNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nufusBilgileri]    Script Date: 17.07.2017 10:16:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nufusBilgileri](
	[sicilNo] [int] NOT NULL,
	[baba] [nvarchar](50) NULL,
	[anne] [nvarchar](50) NULL,
	[dogumYeri] [nvarchar](50) NULL,
	[dogumTarihi] [date] NULL,
	[medeniHali] [int] NULL,
	[kanGrubuNo] [int] NULL,
	[ilNo] [int] NULL,
	[ilce] [nvarchar](50) NULL,
	[mahalle] [nvarchar](50) NULL,
	[ciltNo] [int] NULL,
	[aileSiraNo] [int] NULL,
	[siraNo] [int] NULL,
 CONSTRAINT [PK_nufusBilgileri] PRIMARY KEY CLUSTERED 
(
	[sicilNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OzelGunler]    Script Date: 17.07.2017 10:16:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OzelGunler](
	[ozelGunNo] [int] IDENTITY(1,1) NOT NULL,
	[baslik] [varchar](max) NOT NULL,
	[mesaj] [varchar](max) NOT NULL,
	[yorum] [varchar](max) NULL,
	[tarih] [date] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SilinmeNedeni]    Script Date: 17.07.2017 10:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SilinmeNedeni](
	[silinmeNedenNo] [int] NOT NULL,
	[silinmeNedeni] [nvarchar](50) NULL,
 CONSTRAINT [PK_SilinmeNedeni] PRIMARY KEY CLUSTERED 
(
	[silinmeNedenNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tahsil]    Script Date: 17.07.2017 10:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tahsil](
	[tahsilNo] [int] NOT NULL,
	[tahsilAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tahsil] PRIMARY KEY CLUSTERED 
(
	[tahsilNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unvan]    Script Date: 17.07.2017 10:17:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unvan](
	[unvanNo] [int] NOT NULL,
	[unvanAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Unvan] PRIMARY KEY CLUSTERED 
(
	[unvanNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UyeFotograf]    Script Date: 17.07.2017 10:17:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UyeFotograf](
	[sicilNo] [int] NULL,
	[fotograf] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uyeler]    Script Date: 17.07.2017 10:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uyeler](
	[sicilNo] [int] NOT NULL,
	[aktif] [bit] NOT NULL,
	[adSoyad] [nvarchar](50) NOT NULL,
	[tahsilNo] [int] NULL,
	[unvanNo] [int] NULL,
	[ilNo] [int] NULL,
	[mudurlukNo] [int] NULL,
	[birimNo] [int] NULL,
	[uyelikTipiNo] [int] NULL,
	[girisTarihi] [date] NOT NULL,
	[kayitTarihi] [date] NOT NULL,
	[not] [nvarchar](50) NULL,
	[silinmeNedeniNo] [int] NULL,
 CONSTRAINT [PK_Uyeler] PRIMARY KEY CLUSTERED 
(
	[sicilNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UyelikTipi]    Script Date: 17.07.2017 10:17:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UyelikTipi](
	[uyelikTipNo] [int] NOT NULL,
	[uyelikTipAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_UyelikTipi] PRIMARY KEY CLUSTERED 
(
	[uyelikTipNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Adres]  WITH CHECK ADD  CONSTRAINT [FK_Adres_Uyeler] FOREIGN KEY([sicilNo])
REFERENCES [dbo].[Uyeler] ([sicilNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Adres] CHECK CONSTRAINT [FK_Adres_Uyeler]
GO
ALTER TABLE [dbo].[AidatLog]  WITH CHECK ADD  CONSTRAINT [FK_AidatLog_Uyeler] FOREIGN KEY([sicilNo])
REFERENCES [dbo].[Uyeler] ([sicilNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AidatLog] CHECK CONSTRAINT [FK_AidatLog_Uyeler]
GO
ALTER TABLE [dbo].[AidatMiktar]  WITH CHECK ADD  CONSTRAINT [FK_AidatMiktar_Birim] FOREIGN KEY([birimNo])
REFERENCES [dbo].[Birim] ([birimNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AidatMiktar] CHECK CONSTRAINT [FK_AidatMiktar_Birim]
GO
ALTER TABLE [dbo].[Birim]  WITH CHECK ADD  CONSTRAINT [FK_Birim_Mudurluk] FOREIGN KEY([mudurlukNo])
REFERENCES [dbo].[Mudurluk] ([mudurlukNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Birim] CHECK CONSTRAINT [FK_Birim_Mudurluk]
GO
ALTER TABLE [dbo].[Mudurluk]  WITH CHECK ADD  CONSTRAINT [FK_Mudurluk_il] FOREIGN KEY([ilNo])
REFERENCES [dbo].[il] ([ilNo])
GO
ALTER TABLE [dbo].[Mudurluk] CHECK CONSTRAINT [FK_Mudurluk_il]
GO
ALTER TABLE [dbo].[nufusBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_nufusBilgileri_Uyeler] FOREIGN KEY([sicilNo])
REFERENCES [dbo].[Uyeler] ([sicilNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[nufusBilgileri] CHECK CONSTRAINT [FK_nufusBilgileri_Uyeler]
GO
ALTER TABLE [dbo].[UyeFotograf]  WITH CHECK ADD  CONSTRAINT [FK__UyeFotogr__fotog__151B244E] FOREIGN KEY([sicilNo])
REFERENCES [dbo].[Uyeler] ([sicilNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UyeFotograf] CHECK CONSTRAINT [FK__UyeFotogr__fotog__151B244E]
GO
ALTER TABLE [dbo].[Uyeler]  WITH CHECK ADD  CONSTRAINT [FK_Uyeler_Birim] FOREIGN KEY([birimNo])
REFERENCES [dbo].[Birim] ([birimNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Uyeler] CHECK CONSTRAINT [FK_Uyeler_Birim]
GO
ALTER TABLE [dbo].[Uyeler]  WITH CHECK ADD  CONSTRAINT [FK_Uyeler_il] FOREIGN KEY([ilNo])
REFERENCES [dbo].[il] ([ilNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Uyeler] CHECK CONSTRAINT [FK_Uyeler_il]
GO
ALTER TABLE [dbo].[Uyeler]  WITH CHECK ADD  CONSTRAINT [FK_Uyeler_SilinmeNedeni] FOREIGN KEY([silinmeNedeniNo])
REFERENCES [dbo].[SilinmeNedeni] ([silinmeNedenNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Uyeler] CHECK CONSTRAINT [FK_Uyeler_SilinmeNedeni]
GO
ALTER TABLE [dbo].[Uyeler]  WITH CHECK ADD  CONSTRAINT [FK_Uyeler_Tahsil1] FOREIGN KEY([tahsilNo])
REFERENCES [dbo].[Tahsil] ([tahsilNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Uyeler] CHECK CONSTRAINT [FK_Uyeler_Tahsil1]
GO
ALTER TABLE [dbo].[Uyeler]  WITH CHECK ADD  CONSTRAINT [FK_Uyeler_UyelikTipi] FOREIGN KEY([uyelikTipiNo])
REFERENCES [dbo].[UyelikTipi] ([uyelikTipNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Uyeler] CHECK CONSTRAINT [FK_Uyeler_UyelikTipi]
GO
