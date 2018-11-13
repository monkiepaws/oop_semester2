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

DELETE FROM [dbo].[Pet];
DELETE FROM [dbo].[Owner];

INSERT INTO [dbo].[Owner] (OwnerId, FirstName, Surname, Phone) VALUES
(1, 'Fred', 'Flintstone', '1800-FREDDY'),
(2, 'Barney', 'Rubble', '1800-RUBBLE'),
(3, 'BamBam', 'Rubble', NULL);

INSERT INTO [dbo].[Pet] (Id, PName, [Type], Age, OwnerId) VALUES
(1, 'Albert', 'Mongrel', 13, 2),
(2, 'Dino', 'Dinosaur sorta', 15, 1),
(3, 'Club', 'Not a pet', 1, 3);
