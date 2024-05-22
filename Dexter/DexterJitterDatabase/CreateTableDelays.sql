USE [DexterJitterData]
GO

/****** Object:  Table [dbo].[Delays]    Script Date: 12-02-2024 11:40:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Delays](
	[DelaysId] [int] IDENTITY(1,1) NOT NULL,
	[Delay] [int] NOT NULL,
	[TimeBetweenSamples] [int] NOT NULL,
	[BatchCounter] [int] NOT NULL,
	[TestSetupId] [int] NOT NULL,
	[SampleNumber] [nvarchar](50) NULL,
	[SampleDateTime] [datetime2](7) NOT NULL,
	[OpcServerTimeStamp] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_dbo.Delays] PRIMARY KEY CLUSTERED 
(
	[DelaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Delays]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Delays_dbo.TestSetup_TestSetupId] FOREIGN KEY([TestSetupId])
REFERENCES [dbo].[TestSetup] ([TestSetupId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Delays] CHECK CONSTRAINT [FK_dbo.Delays_dbo.TestSetup_TestSetupId]
GO


