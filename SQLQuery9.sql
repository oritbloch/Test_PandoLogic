USE [C:\USERS\ADMINISTRATOR\SOURCE\REPOS\WEBAPPLICATION7\CLASSTEST\DATABASE1.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[get_data_to_chart]
		@fromdate = N'2022-07-20',
		@todate = N'2022-07-27'

SELECT	@return_value as 'Return Value'

GO
