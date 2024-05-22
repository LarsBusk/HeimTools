Select		d.TestSetupId
		,	d.SampleCount
		,	d.MaxDelay
		,	d.MinDelay
		,	d.MeanDelay
		,	d.StdDevDelay
		,	d.MinTime
		,	d.MaxTime
		,	100.0 * (1.0 * Under.UnderLimit / d.SampleCount) as PercentUnder
		,	d.SampleCount - Under.UnderLimit as CountOverLimit
		,	under.UnderLimit
		
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
	Group By d.TestSetupId
) as d
Inner Join
(	
	Select		Count([Delay]) as UnderLimit
			,	Max(TestSetupId) as TestSetupId
	From		Delays
	Where		[Delay] < 1100
	Group By	TestSetupId
) as Under
On Under.TestSetupId = d.TestSetupId
Order By TestSetupId