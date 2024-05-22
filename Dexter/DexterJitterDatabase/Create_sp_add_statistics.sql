CREATE PROCEDURE [dbo].[sp_add_statistitics] 
	@TestSetupId int
AS
BEGIN

	SET NOCOUNT ON;

    INSERT INTO DelayStatistics
	SELECT 		Max(TestSetupId) as TestSetupId
			,	Count([Delay]) as [SampleCount] 
			,	Max([Delay]) as [MaxDelay]
			,	Min([Delay]) as [MinDelay]
			,	1.0*SUM(1.0*[Delay])/Count([Delay]) [MeanDelay]
			,	STDEV([Delay]) [StdDevDelay]
			,	Max(TimeBetweenSamples) as [MaxTBS]
			,	Min(TimeBetweenSamples) as [MinTBS]
			,	1.0*SUM(1.0*TimeBetweenSamples)/Count(TimeBetweenSamples) [MeanTBS]
			,	STDEV(TimeBetweenSamples) [StdDevTBS]
			,	Min(SampleDateTime)
			,	Max(SampleDateTime)
	From Delays 
	WHERE TestSetupId = @TestSetupId
END
GO


