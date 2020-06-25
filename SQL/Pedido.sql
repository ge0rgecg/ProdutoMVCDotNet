CREATE TABLE [dbo].[Pedido]
(
	[Id_Pedido] INT NOT NULL IDENTITY(1,1),
	[DataEntrega]	DATETIME	NOT NULL,
	[Cliente_Id]	INT				NULL,
	[ValorTotal]	DECIMAL(10,2)	NULL,
	CONSTRAINT	[PK_Pedido]				PRIMARY KEY ([Id_Pedido]),
	CONSTRAINT	[PK_Pedido_Cliente]	    FOREIGN KEY ([Cliente_Id])	REFERENCES [dbo].[Cliente]	([Id_Cliente])	ON	DELETE NO ACTION ON UPDATE NO ACTION,
)
