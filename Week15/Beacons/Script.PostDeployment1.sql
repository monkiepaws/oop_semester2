/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

DELETE FROM BEACON;

INSERT INTO BEACON (Username, Game, StartTime, EndTime) VALUES
('hax0rz', 'Alpha2', GETDATE(), DATEADD(minute, 30, GETUTCDATE())),
('l33t', 'MK2', GETDATE(), DATEADD(MINUTE, 45, GETUTCDATE())),
('booot', '3rdStrike', GETDATE(), DATEADD(MINUTE, 55, GETUTCDATE())),
('Harry', 'Alpha2', GETDATE(), DATEADD(MINUTE, 80, GETUTCDATE()));