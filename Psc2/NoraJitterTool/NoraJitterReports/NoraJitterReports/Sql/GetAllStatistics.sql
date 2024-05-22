With stat as
(
	Select		TestSetupId
			,	Count([Delay]) as [Count] 
			,	Max([Delay]) as [MaxDelay]
			,	Min([Delay]) as [MinDelay]
			,	1.0*SUM(1.0*[Delay])/Count([Delay]) [MeanDelay]
			,	STDEV([Delay]) [StdDevDelay]
			,	Max(TimeBetweenSamples) as [MaxTBS]
			,	Min(TimeBetweenSamples) as [MinTBS]
			,	1.0*SUM(1.0*TimeBetweenSamples)/Count(TimeBetweenSamples) [MeanTBS]
			,	STDEV(TimeBetweenSamples) [StdDevTBS]
	From Delays
	Where TimeBetweenSamples < 35000
	Group By TestSetupId
)
Select		tsy.SystemName
		,	tsy.SerialNumber
		,	tsy.[Type]
        ,   tsy.ChassisId
		,	tse.NoraVersion
		,	tse.PlatformVersion
		,	tse.TestTime
		,	tse.Comment
		,   tse.NoDelayedResults
		,	stat.TestSetupId
		,	stat.[Count]
		,	stat.[MaxDelay]
		,	stat.[MinDelay]
		,	stat.[MeanDelay]
		,	stat.[StdDevDelay]
		,	stat.[MaxTBS]
		,	stat.[MinTBS]
		,	stat.[MeanTBS]
		,	stat.[StdDevTBS]
From stat
Inner Join TestSetup tse on
	tse.TestSetupId = stat.TestSetupId
Inner Join TestSystem tsy on
	tsy.TestSystemId = tse.TestSystemId
Order By stat.TestSetupId