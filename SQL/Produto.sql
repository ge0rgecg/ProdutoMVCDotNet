﻿CREATE TABLE [dbo].[Produto]
(
	[Id_Produto] INT NOT NULL IDENTITY(1,1) ,
	[Descricao] VARCHAR(255) NOT NULL,
	[Valor]	DECIMAL(10,2)	NOT NULL,
	CONSTRAINT	[PK_Produto]				PRIMARY KEY ([Id_Produto]),
)
