USE [DexterJitterData]
GO

/****** Object:  StoredProcedure [dbo].[sp_add_toptenvalues]    Script Date: 14-02-2024 12:26:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[sp_add_toptenvalues]
	@TestSetupId int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO JitterTopTens
	SELECT TOP 10 TestSetupId
	,	BatchCounter
	,	'Delay'
	,	[Delay]
	,	SampleDateTime
	FROM Delays
	WHERE TestSetupId = @TestSetupId
	ORDER BY [Delay] DESC

	INSERT INTO JitterTopTens
	SELECT TOP 10 TestSetupId
	,	BatchCounter
	,	'TimeBetweenSamples'
	,	TimeBetweenSamples
	,	SampleDateTime
	FROM Delays
	WHERE TestSetupId = @TestSetupId
	ORDER BY TimeBetweenSamples DESC
END
GO


