USE [NoraJitterDataOld]
GO

/****** Object:  Table [dbo].[TestSystem]    Script Date: 22-06-2023 13:15:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestSystemNew](
	[TestSystemId] [int] IDENTITY(1,1) NOT NULL,
	[SerialNumber] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[ChassisId] [bigint] NOT NULL,
	[SystemName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dbo.TestSystemNew] PRIMARY KEY CLUSTERED 
(
	[TestSystemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


