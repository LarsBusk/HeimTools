Select	  tse.ConveyorSpeed
		, tse.RejectorConfig
		, Case tse.RejectorConfig
			When 'Auto On Conv' Then 'Distance from edge: ' + CAST(tse.DistanceFromEdge as nvarchar)
			When 'Auto Off Conv' Then CAST(RejectionDelay as nvarchar) + ';' + CAST(RejectionDuration as nvarchar)
			Else ''
			End as RejectionSettings
		,*
From TestSetup tse
Inner Join DelayStatistics dst
On dst.TestSetupId = tse.TestSetupId

