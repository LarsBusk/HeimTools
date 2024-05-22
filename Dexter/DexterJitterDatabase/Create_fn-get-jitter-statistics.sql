CREATE FUNCTION [dbo].[fn_get_jitter_statics] ()
RETURNS TABLE 
AS
RETURN 
(
	SELECT	Top 25	
			tsy.SystemName
		,	tsy.SerialNumber
		,	tsy.[Type]
        ,   tsy.ChassisId
		,	tse.DexterVersion
		,	tse.PlatformVersion
		,	tse.TestTime
		,	tse.Comment
		,	tse.ElementOnBelt
		,	tse.ConveyorSpeed
		,	tse.RejectorConfig
		,	tse.DistanceFromEdge
		,	tse.RejectionDelay
		,	tse.RejectionDuration
        ,   tse.PhysicalPC
		,	tse.MosaicSync
		,	tse.AutoExport
		,	tse.TicketPrint
		,	tse.ReposClean
		,	tse.Timecorrection
		,	stat.TestSetupId
		,	stat.SampleCount as [Count]
		,	stat.MaxDelay
		,	stat.MeanDelay
		,	stat.MinDelay
		,	stat.StdDevDelay
		,	stat.StartTime
		,	stat.EndTime
	FROM DelayStatistics stat
	INNER JOIN TestSetup tse 
	ON tse.TestSetupId = stat.TestSetupId
	INNER JOIN TestSystem tsy
	ON tsy.TestSystemId = tse.TestSystemId
	ORDER BY tse.TestSetupId DESC
)
GO


