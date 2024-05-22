
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION fn_get_intervals
(	
	@SetupId int
)
RETURNS TABLE 
AS
RETURN 
(
	With Intervals as
(
Select	tse.TestSetupId
	,	Case
			When TimeBetweenSamples <=800 Then 1
			When TimeBetweenSamples  Between 800 and 1200 Then 2
			When TimeBetweenSamples  Between 1200 and 1500 Then 3
			When TimeBetweenSamples >= 1500 Then 4
		End As Interval
From	Delays d
Inner Join TestSetup tse
On tse.TestSetupId = d.TestSetupId
Where	tse.TestSetupId = 4-- @SetupId
)
Select	MAX(TestSetupId) as TestSetupId
	,	Interval
	,	Count(Interval) [Count]
From Intervals
Group By Interval
)
GO
