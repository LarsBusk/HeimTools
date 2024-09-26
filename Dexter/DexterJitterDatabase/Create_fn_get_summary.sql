USE [DexterJitterData]
GO

/****** Object:  UserDefinedFunction [dbo].[fn_get_summary]    Script Date: 26-09-2024 10:51:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE FUNCTION [dbo].[fn_get_summary] ()
RETURNS TABLE 
AS
RETURN 
(
	Select		d.TestSetupId
			,	d.SampleCount
			,	d.MaxDelay
			,	d.MinDelay
			,	d.MeanDelay
			,	d.StdDevDelay
			,	d.MinTime
			,	d.MaxTime
			,	100.0 * (1.0 * Under.UnderLimit / d.SampleCount) as PercentUnder
			,	100.0 * (1.0 * InSide.InLimit / d.SampleCount) as PercentInLimit
			,	d.SampleCount - Under.UnderLimit as CountOverLimit
			,	under.UnderLimit
			,	InSide.InLimit
		
	From
	(
		SELECT 		Max(d.TestSetupId) as TestSetupId
				,	Count([Delay]) as [SampleCount] 
				,	Max([Delay]) as [MaxDelay]
				,	Min([Delay]) as [MinDelay]
				,	1.0*SUM(1.0*[Delay])/Count([Delay]) [MeanDelay]
				,	STDEV([Delay]) [StdDevDelay]
				,	Min(SampleDateTime) as MinTime
				,	Max(SampleDateTime) as MaxTime
		From Delays	d
		Inner Join TestSetup tse
		On tse.TestSetupId = d.TestSetupId
		Where tse.ExcludeFromSummary = 0
		Group By d.TestSetupId
	) as d
	Left Join
	(	
		Select		Count([Delay]) as UnderLimit
				,	Max(TestSetupId) as TestSetupId
		From		Delays
		Where		[Delay] < 1100
		Group By	TestSetupId
	) as Under
	On Under.TestSetupId = d.TestSetupId
	Left Join
	(
		Select		Count([Delay]) as InLimit
				,	d.TestSetupId as TestSetupId
			--	,   Max(700.0/tse.ConveyorSpeed*900) as mini
			--	,   Max(700.0/tse.ConveyorSpeed*1100) as maxi
			--	,	Max(tse.ConveyorSpeed) as speed
		From		Delays d
		Inner Join TestSetup tse
		On			tse.TestSetupId = d.TestSetupId
		Where		[Delay] Between 700.0/tse.ConveyorSpeed-200 And 700.0/tse.ConveyorSpeed+200
		Group By	d.TestSetupId
		) InSide
		On InSide.TestSetupId = d.TestSetupId	
)
GO


