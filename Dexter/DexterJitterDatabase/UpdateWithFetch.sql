declare @MinTimes table (setupid int, starttime datetime)
Declare @time datetime, @id int
Insert into @MinTimes
Select TestSetupId, Max(SampleDatetime)
From Delays
Group By TestSetupId
Select * From @MinTimes

Declare time_cursor Cursor for
Select setupid, starttime
From @MinTimes

Open time_cursor

Fetch Next From time_cursor
Into @id, @time

While @@FETCH_STATUS = 0
Begin
Update DelayStatistics
Set EndTime = @time Where TestSetupId = @id
Fetch Next From time_cursor
Into @id, @time
End

