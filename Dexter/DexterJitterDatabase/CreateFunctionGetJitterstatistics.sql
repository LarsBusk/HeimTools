
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetJitterStatics ()
RETURNS TABLE 
AS
RETURN 
(
	SELECT	Top 25	tsy.SystemName
		,	tsy.SerialNumber
		,	tsy.[Type]
        ,   tsy.ChassisId
		,	tse.DexterVersion
		,	tse.PlatformVersion
		,	tse.TestTime
		,	tse.Comment
        ,   tse.PhysicalPC
		,	tse.Timecorrection
		,	stat.TestSetupId
		,	stat.SampleCount as [Count]
		,	stat.MaxDelay
		,	stat.MaxTBS
		,	stat.MeanDelay
		,	stat.MeanTBS
		,	stat.MinDelay
		,	stat.MinTBS
		,	stat.StdDevDelay
		,	stat.StdDevTBS
	FROM DelayStatistics stat
	INNER JOIN TestSetup tse 
	ON tse.TestSetupId = stat.TestSetupId
	INNER JOIN TestSystem tsy
	ON tsy.TestSystemId = tse.TestSystemId
	ORDER BY tse.TestSetupId DESC
)
GO
