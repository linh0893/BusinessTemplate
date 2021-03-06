USE [CoreDB]
GO
/****** Object:  Table [dbo].[KeyWord]    Script Date: 02/02/2016 14:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KeyWord](
	[Key_id] [int] NOT NULL,
	[Keyword] [nvarchar](100) NULL,
	[KeywordEN] [varchar](100) NULL,
 CONSTRAINT [PK_KeyWord] PRIMARY KEY CLUSTERED 
(
	[Key_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Image]    Script Date: 02/02/2016 14:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Image](
	[Image_Id] [int] NOT NULL,
	[Image_link] [varchar](50) NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[Image_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CompanyInfor]    Script Date: 02/02/2016 14:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CompanyInfor](
	[Company_name] [nvarchar](100) NOT NULL,
	[Phone] [varchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[Account_Admin] [varchar](50) NULL,
	[Account_password] [varchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[location_lat] [float] NULL,
	[lacation_lng] [float] NULL,
	[link_logo] [varchar](100) NULL,
	[About] [nvarchar](4000) NULL,
	[Company_image] [varchar](100) NULL,
	[Company_video] [varchar](100) NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_CompanyInfor] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Category]    Script Date: 02/02/2016 14:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Category_id] [int] NOT NULL,
	[Category_name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Category_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Topic]    Script Date: 02/02/2016 14:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topic](
	[Topic_id] [int] NOT NULL,
	[Topic_Title] [nvarchar](200) NULL,
	[Topic_Content] [nvarchar](3500) NULL,
	[Created] [datetime] NULL,
 CONSTRAINT [PK_Topic] PRIMARY KEY CLUSTERED 
(
	[Topic_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Topic_Keyword]    Script Date: 02/02/2016 14:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topic_Keyword](
	[Topic_Id] [int] NOT NULL,
	[Keyword_id] [int] NOT NULL,
 CONSTRAINT [PK_Topic_Keyword] PRIMARY KEY CLUSTERED 
(
	[Topic_Id] ASC,
	[Keyword_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 02/02/2016 14:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[Product_id] [int] NOT NULL,
	[Product_name] [nvarchar](100) NULL,
	[Price] [int] NULL,
	[Status] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[Descriptions] [nvarchar](1000) NULL,
	[Image_id] [int] NULL,
	[IsDisplay] [varchar](50) NULL,
	[TopView] [int] NULL,
	[Discount] [int] NULL,
	[Discount_Start] [date] NULL,
	[Category_Id] [int] NULL,
	[Discount_End] [date] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Product_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product_Keyword]    Script Date: 02/02/2016 14:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Keyword](
	[Key_Id] [int] NOT NULL,
	[Product_Id] [int] NOT NULL,
 CONSTRAINT [PK_Product_Keyword] PRIMARY KEY CLUSTERED 
(
	[Key_Id] ASC,
	[Product_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Image]    Script Date: 02/02/2016 14:09:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Image](
	[Product_id] [int] NOT NULL,
	[Image_Id] [int] NOT NULL,
 CONSTRAINT [PK_Product_Image] PRIMARY KEY CLUSTERED 
(
	[Product_id] ASC,
	[Image_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Product_Category]    Script Date: 02/02/2016 14:09:49 ******/
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([Category_Id])
REFERENCES [dbo].[Category] ([Category_id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
/****** Object:  ForeignKey [FK_Product_Image]    Script Date: 02/02/2016 14:09:49 ******/
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Image] FOREIGN KEY([Image_id])
REFERENCES [dbo].[Image] ([Image_Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Image]
GO
/****** Object:  ForeignKey [FK_Product_Image_Image]    Script Date: 02/02/2016 14:09:49 ******/
ALTER TABLE [dbo].[Product_Image]  WITH CHECK ADD  CONSTRAINT [FK_Product_Image_Image] FOREIGN KEY([Image_Id])
REFERENCES [dbo].[Image] ([Image_Id])
GO
ALTER TABLE [dbo].[Product_Image] CHECK CONSTRAINT [FK_Product_Image_Image]
GO
/****** Object:  ForeignKey [FK_Product_Image_Product]    Script Date: 02/02/2016 14:09:49 ******/
ALTER TABLE [dbo].[Product_Image]  WITH CHECK ADD  CONSTRAINT [FK_Product_Image_Product] FOREIGN KEY([Product_id])
REFERENCES [dbo].[Product] ([Product_id])
GO
ALTER TABLE [dbo].[Product_Image] CHECK CONSTRAINT [FK_Product_Image_Product]
GO
/****** Object:  ForeignKey [FK_Product_Keyword_KeyWord]    Script Date: 02/02/2016 14:09:49 ******/
ALTER TABLE [dbo].[Product_Keyword]  WITH CHECK ADD  CONSTRAINT [FK_Product_Keyword_KeyWord] FOREIGN KEY([Key_Id])
REFERENCES [dbo].[KeyWord] ([Key_id])
GO
ALTER TABLE [dbo].[Product_Keyword] CHECK CONSTRAINT [FK_Product_Keyword_KeyWord]
GO
/****** Object:  ForeignKey [FK_Product_Keyword_Product]    Script Date: 02/02/2016 14:09:49 ******/
ALTER TABLE [dbo].[Product_Keyword]  WITH CHECK ADD  CONSTRAINT [FK_Product_Keyword_Product] FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Product] ([Product_id])
GO
ALTER TABLE [dbo].[Product_Keyword] CHECK CONSTRAINT [FK_Product_Keyword_Product]
GO
/****** Object:  ForeignKey [FK_Topic_Keyword_KeyWord]    Script Date: 02/02/2016 14:09:49 ******/
ALTER TABLE [dbo].[Topic_Keyword]  WITH CHECK ADD  CONSTRAINT [FK_Topic_Keyword_KeyWord] FOREIGN KEY([Keyword_id])
REFERENCES [dbo].[KeyWord] ([Key_id])
GO
ALTER TABLE [dbo].[Topic_Keyword] CHECK CONSTRAINT [FK_Topic_Keyword_KeyWord]
GO
/****** Object:  ForeignKey [FK_Topic_Keyword_Topic]    Script Date: 02/02/2016 14:09:49 ******/
ALTER TABLE [dbo].[Topic_Keyword]  WITH CHECK ADD  CONSTRAINT [FK_Topic_Keyword_Topic] FOREIGN KEY([Topic_Id])
REFERENCES [dbo].[Topic] ([Topic_id])
GO
ALTER TABLE [dbo].[Topic_Keyword] CHECK CONSTRAINT [FK_Topic_Keyword_Topic]
GO
