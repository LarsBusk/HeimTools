Use NoraJitterData;

Declare @TestSetupId int = 17

Declare @Intervals table (StartInterval int, EndInterval int);

Declare @Lower int  
Select @Lower = Min(TimeBetweenSamples) From Delays Where TestSetupId = @TestSetupId
Declare @Upper int
Select @Upper = Max(TimeBetweenSamples) From Delays Where TestSetupId = @TestSetupId

While (@Lower < @Upper)
Begin
	Insert Into @Intervals (StartInterval, EndInterval)
	Values (@Lower, @Lower + 100)
	Set @Lower = @Lower + 100
End

Select		i.StartInterval
		,	COUNT(DelaysId)
From		Delays d
Inner Join	@Intervals i
on			d.TimeBetweenSamples Between i.StartInterval and i.EndInterval

Where		d.TestSetupId = @TestSetupId
Group By	i.StartInterval
Order By	i.StartInterval
