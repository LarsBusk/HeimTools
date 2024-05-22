
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_add_intervals
	@TestSetupId int
AS
BEGIN
	Insert Into Intervals
	Select  TestSetupId
		,	Interval
		,	[Count]
	From	dbo.fn_get_intervals(@TestSetupId)
END
GO
