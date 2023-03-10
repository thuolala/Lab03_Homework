USE [QLThucTap]
GO
/****** Object:  Table [dbo].[DeTai]    Script Date: 21/2/2023 5:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeTai](
	[MSDT] [nchar](10) NOT NULL,
	[TenDT] [nvarchar](50) NULL,
	[ChuNhiem] [nvarchar](70) NULL,
	[KinhPhi] [int] NULL,
 CONSTRAINT [PK_DeTai] PRIMARY KEY CLUSTERED 
(
	[MSDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SVDT]    Script Date: 21/2/2023 5:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SVDT](
	[MSSV] [nchar](10) NULL,
	[MSDT] [nchar](10) NULL,
	[NoiTT] [nvarchar](50) NULL,
	[QuangDuong] [int] NULL,
	[KetQua] [nvarchar](15) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SVien]    Script Date: 21/2/2023 5:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SVien](
	[MSSV] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](70) NULL,
	[QueQuan] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[HocLuc] [nvarchar](10) NULL,
 CONSTRAINT [PK_SVien] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[SVDT]  WITH CHECK ADD FOREIGN KEY([MSDT])
REFERENCES [dbo].[DeTai] ([MSDT])
GO
ALTER TABLE [dbo].[SVDT]  WITH CHECK ADD FOREIGN KEY([MSSV])
REFERENCES [dbo].[SVien] ([MSSV])
GO
