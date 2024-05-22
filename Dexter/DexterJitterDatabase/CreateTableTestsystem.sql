USE [DexterJitterData]
GO

/****** Object:  Table [dbo].[TestSystem]    Script Date: 12-02-2024 11:40:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestSystem](
	[TestSystemId] [int] IDENTITY(1,1) NOT NULL,
	[SerialNumber] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[ChassisId] [bigint] NOT NULL,
	[SystemName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dbo.TestSystem] PRIMARY KEY CLUSTERED 
(
	[TestSystemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


