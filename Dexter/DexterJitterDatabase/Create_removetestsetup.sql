
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE RemoveTestSetup
	@TestSetupId int
AS
BEGIN
	Delete From TestSetup Where TestSetupId = @TestSetupId;
	Delete From Delays Where TestSetupId = @TestSetupId;
	Delete From DelayStatistics Where TestSetupId = @TestSetupId;
	Delete From Intervals Where TestSetupId = @TestSetupId;
	Delete From JitterTopTens Where TestSetupId = @TestSetupId
END
GO
