USE [TPISocios]
GO
BEGIN TRAN;
INSERT INTO [dbo].[Instalaciones]
           ([Titulo]
           ,[Descripcion]
           ,[cupo])
     VALUES
           ('Cancha de Futbol 11 - 1'
           ,'Cancha de futbol re piola'
           ,22);
INSERT INTO [dbo].[Instalaciones]
           ([Titulo]
           ,[Descripcion]
           ,[cupo])
     VALUES
           ('Cancha de Futbol 11 - 2'
           ,'Cancha de futbol medio chota'
           ,22);

INSERT INTO [dbo].[Instalaciones]
           ([Titulo]
           ,[Descripcion]
           ,[cupo])
     VALUES
           ('Cancha de Futbol 7 - 1'
           ,'Fulbo'
           ,14);

INSERT INTO [dbo].[Instalaciones]
           ([Titulo]
           ,[Descripcion]
           ,[cupo])
     VALUES
           ('Cancha de Tenis - 1'
           ,'Como vas a jugar al tenis man'
           ,4);

           INSERT INTO [dbo].[Instalaciones]
           ([Titulo]
           ,[Descripcion]
           ,[Cupo])
     VALUES
           ('Cancha de tenis - 2'
           ,'Cancha de tenis para los pechos que llevan 17 clasicos abajo'
           ,4)
COMMIT;
GO


