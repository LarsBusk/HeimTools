
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION fn_get_compressed_delays 
(	
	@TestSetupId int
)
RETURNS TABLE 
AS
RETURN 
(
	With Tiles as
(
	Select		NTILE(1000) OVER (Order By DelaysId) as Tile
			,	[Delay]
			,	BatchCounter
			,	SampleDateTime
			,	DelaysId
	From Delays
	Where TestSetupId = @TestSetupId
)
Select	Tile
	,	AVG(Delay) as [Delay]
	,	MIN(BatchCounter) as BatchCounter
	,	MIN(SampleDateTime) as SampleDateTime
From Tiles
Group By Tile
)
GO
