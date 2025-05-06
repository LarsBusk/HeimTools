With Fallouts as
(
	Select		SampleNumber
			,	TestSetupId
			,	MAX(OpcServerTimeStamp) as MaxTime
			,	MIN(OpcServerTimeStamp) as MinTime
			,	COUNT(delaysid) as Cnt
	From Delays
--	Where TestSetupId = 1180
	Group By TestSetupId, SampleNumber
	Having COUNT(delaysid) > 1
)
Select		SUM(1.0* DATEDIFF(SECOND, MinTime, MaxTime)) /3600 as FallOutTime
		,	COUNT(*) #Fallouts
		,	TestSetupId
From		Fallouts
Group by	TestSetupId
Order by	TestSetupId Desc
