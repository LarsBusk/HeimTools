USE [DexterJitterData]
GO

CREATE TABLE [dbo].[DelayStatistics](
	[TestTetupId] [int] NOT NULL PRIMARY KEY,
	[SampleCount] [int] NULL,
	[MaxDelay] [int] NULL,
	[Mindelay] [int] NULL,
	[StdDevDelay] [float] NULL,
	[MinTbs] [int] NULL,
	[MaxTbs] [int] NULL,
	[StdDevTbs] [float] NULL
) ON [PRIMARY]
GO


