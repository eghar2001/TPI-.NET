USE [TPISocios]
GO
BEGIN TRAN;
INSERT INTO [dbo].[Profesores]
           ([Nombre]
           ,[Apellido]
           ,[Salario])
     VALUES
           ('Andres'
           ,'Andresani'
           ,150000);
INSERT INTO [dbo].[Profesores]
           ([Nombre]
           ,[Apellido]
           ,[Salario])
     VALUES
           ('Marco Gastón'
           ,'Rúben'
           ,18890000);
INSERT INTO [dbo].[Profesores]
           ([Nombre]
           ,[Apellido]
           ,[Salario])
     VALUES
           ('Taco'
           ,'Herrera'
           ,01112018);
INSERT INTO [dbo].[Profesores]
           ([Nombre]
           ,[Apellido]
           ,[Salario])
     VALUES
           ('Marcelo'
           ,'Frielsa'
           ,2);
COMMIT;
GO


