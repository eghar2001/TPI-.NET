USE [TPISocios]
GO

BEGIN TRAN;
INSERT INTO [dbo].[Actividades]
           ([Nombre]
           ,[Descripcion]
           ,[UltimoPrecio])
     VALUES
           ('Tenis'
           ,'Deporte individual o en pareja'
           ,10000);
INSERT INTO [dbo].[Actividades]
           ([Nombre]
           ,[Descripcion]
           ,[UltimoPrecio])
     VALUES
           ('Rugby'
           ,'Deporte de equipos de 22 personas muy violento'
           ,10000);
INSERT INTO [dbo].[Actividades]
           ([Nombre]
           ,[Descripcion]
           ,[UltimoPrecio])
     VALUES
           ('Practica Futbol 5- Junior'
           ,'Practica de futbol 5 para los peques'
           ,10000);

INSERT INTO [dbo].[Actividades]
           ([Nombre]
           ,[Descripcion]
           ,[UltimoPrecio])
     VALUES
           ('Practica Futbol 5- Grandes'
           ,'Practica de futbol 5 para los viejos'
           ,10000);

INSERT INTO [dbo].[Actividades]
           ([Nombre]
           ,[Descripcion]
           ,[UltimoPrecio])
     VALUES
           ('Practica Futbol 7- Adolescentes'
           ,'Practica de futbol 5 para los chicos adolescentes'
           ,10000);

INSERT INTO [dbo].[Actividades]
           ([Nombre]
           ,[Descripcion]
           ,[UltimoPrecio])
     VALUES
           ('Practica Futbol 11'
           ,'Practica de futbol 11 re piola'
           ,10000);
COMMIT;
GO


