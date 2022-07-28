USE [C:\USERS\ADMINISTRATOR\SOURCE\REPOS\WEBAPPLICATION7\CLASSTEST\DATABASE1.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[get_data_to_chart]
		@fromdate = N'2022-20-07',
		@todate = N'2022-26-07'

SELECT	@return_value as 'Return Value'

GO
