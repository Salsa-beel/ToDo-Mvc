SELECT * from Categories;
UPDATE Categories
SET Name = 'Programming Tasks', Description= 'coding'
WHERE Id = 5;

INSERT INTO MyTask(Id, Title, [Date], CategoryId)
VALUES ( 5,'Clean house', '', 2);

INSERT INTO MyTask(Id, Title, [Date], CategoryId)
VALUES ( 6,'cook lunch', '', 2);

INSERT INTO MyTask(Id, Title, [Date], CategoryId)
VALUES ( 7,'watering flowers', '', 2);



SELECT * from MyTask;
SELECT * from Contacts;

-- SET IDENTITY_INSERT [dbo].[MyTask] ON
