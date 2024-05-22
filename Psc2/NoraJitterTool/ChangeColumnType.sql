USE [NoraJitterData]
GO

ALTER TABLE [dbo].[TestSetup] DROP CONSTRAINT [FK_dbo.TestSetup_dbo.TestSystem_TestSystemId]
GO

USE [NoraJitterData]
GO

/****** Object:  Table [dbo].[TestSystem]    Script Date: 22-06-2023 13:49:00 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO


Insert Into TestSystemNew  (SerialNumber, Type, ChassisID, SystemName) Select SerialNumber, Type, ChassisID, SystemName From TestSystem

DROP TABLE [dbo].[TestSystem]

ALTER TABLE [dbo].[TestSetup]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TestSetup_dbo.TestSystem_TestSystemId] FOREIGN KEY([TestSystemId])
REFERENCES [dbo].[TestSystem] ([TestSystemId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[TestSetup] CHECK CONSTRAINT [FK_dbo.TestSetup_dbo.TestSystem_TestSystemId]
GO