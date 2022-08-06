IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220805222739_FirstMigration')
BEGIN
    CREATE TABLE [Client] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(150) NOT NULL,
        [Cep] NVARCHAR(14) NOT NULL,
        [Cidade] NVARCHAR(100) NOT NULL,
        [Estado] NVARCHAR(50) NOT NULL,
        CONSTRAINT [PK_Client] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220805222739_FirstMigration')
BEGIN
    CREATE TABLE [Produto] (
        [Id] int NOT NULL IDENTITY,
        [CodigoDeBarras] NVARCHAR(150) NOT NULL,
        [Descricao] NVARCHAR(300) NOT NULL,
        [Valor] float NOT NULL,
        [TipoDoProduto] nvarchar(max) NOT NULL,
        [Ativo] bit NOT NULL,
        CONSTRAINT [PK_Produto] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220805222739_FirstMigration')
BEGIN
    CREATE TABLE [Pedido] (
        [Id] int NOT NULL IDENTITY,
        [ClientID] int NOT NULL,
        [IniciandoEm] datetime2 NOT NULL DEFAULT (GETDATE()),
        [FinalizandoEm] datetime2 NOT NULL DEFAULT (GETDATE()),
        [TipoDeFrete] nvarchar(max) NOT NULL,
        [Status] int NOT NULL,
        [Observacao] NVARCHAR(200) NOT NULL,
        CONSTRAINT [PK_Pedido] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Pedido_Client_ClientID] FOREIGN KEY ([ClientID]) REFERENCES [Client] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220805222739_FirstMigration')
BEGIN
    CREATE TABLE [PedidoItem] (
        [Id] int NOT NULL IDENTITY,
        [PedidoId] int NOT NULL,
        [ProdutoId] int NOT NULL,
        [Quantidade] int NOT NULL DEFAULT 1,
        [Valor] float NOT NULL DEFAULT 1.0E0,
        [Desconto] float NOT NULL DEFAULT 1.0E0,
        CONSTRAINT [PK_PedidoItem] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_PedidoItem_Pedido_PedidoId] FOREIGN KEY ([PedidoId]) REFERENCES [Pedido] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_PedidoItem_Produto_ProdutoId] FOREIGN KEY ([ProdutoId]) REFERENCES [Produto] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220805222739_FirstMigration')
BEGIN
    CREATE INDEX [Id_Cliente] ON [Client] ([Name]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220805222739_FirstMigration')
BEGIN
    CREATE INDEX [IX_Pedido_ClientID] ON [Pedido] ([ClientID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220805222739_FirstMigration')
BEGIN
    CREATE INDEX [IX_PedidoItem_PedidoId] ON [PedidoItem] ([PedidoId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220805222739_FirstMigration')
BEGIN
    CREATE INDEX [IX_PedidoItem_ProdutoId] ON [PedidoItem] ([ProdutoId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220805222739_FirstMigration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220805222739_FirstMigration', N'6.0.7');
END;
GO

COMMIT;
GO

