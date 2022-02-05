
/****** Object: Table [dbo].[Products] Script Date: 04.02.2022 21:29:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products] (
    [ProductId]   INT            IDENTITY (1, 1) NOT NULL,
    [CategoryId]  INT            NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Quantity]    INT            NULL,
    [Price]       FLOAT (53)     NULL,
    [BC]          NVARCHAR (MAX) NULL,
    [Sph]         NVARCHAR (MAX) NULL,
    [Cell]        NVARCHAR (MAX) NULL
);

CREATE TABLE [dbo].[Categories] (
    [CategoryId]  INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL
);

CREATE TABLE [dbo].[Customers] (
    [CustomerId]  INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Password]    NVARCHAR (MAX) NULL,
    [Fullname]    NVARCHAR (MAX) NULL,
    [Email]       NVARCHAR (MAX) NULL,
    [Company]     NVARCHAR (MAX) NULL,
    [Phone]       NVARCHAR (MAX) NULL
);

CREATE TABLE [dbo].[Vendors] (
    [VendorId]    INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Password]    NVARCHAR (MAX) NULL,
    [Fullname]    NVARCHAR (MAX) NULL,
    [Email]       NVARCHAR (MAX) NULL,
    [Company]     NVARCHAR (MAX) NULL,
    [Phone]       NVARCHAR (MAX) NULL
);

    CREATE TABLE [dbo].[OrderCustomers] (
    [OrderCustomerId] INT            IDENTITY (1, 1) NOT NULL,
    [CustomerId]      INT            NOT NULL,
    [ExcelFileId]     INT            NOT NULL,
    [Name]            NVARCHAR (MAX) NULL,
    [Description]     NVARCHAR (MAX) NULL,
    [Edited]          DATETIME2 (7)  NOT NULL
);

CREATE TABLE [dbo].[OrderVendors] (
    [OrderVendorId] INT            IDENTITY (1, 1) NOT NULL,
    [VendorId]      INT            NOT NULL,
    [Name]          NVARCHAR (MAX) NULL,
    [Description]   NVARCHAR (MAX) NULL,
    [Edited]        DATETIME2 (7)  NOT NULL
);

CREATE TABLE [dbo].[ItemOrders] (
    [ItemOrderId]     INT            IDENTITY (1, 1) NOT NULL,
    [Description]     NVARCHAR (MAX) NULL,
    [Quantity]        INT            NOT NULL,
    [Price]           FLOAT (53)     NOT NULL,
    [Edited]          DATETIME2 (7)  NOT NULL,
    [ProductId]       INT            NOT NULL,
    [OrderCustomerId] INT            NOT NULL,
    [OrderVendorId]   INT            NULL
);



GO
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId]
    ON [dbo].[Products]([CategoryId] ASC);


GO
ALTER TABLE [dbo].[Products]
    ADD CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([ProductId] ASC);


GO
ALTER TABLE [dbo].[Products]
    ADD CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([CategoryId]) ON DELETE SET NULL;





GO
CREATE NONCLUSTERED INDEX [IX_OrderCustomers_CustomerId]
    ON [dbo].[OrderCustomers]([CustomerId] ASC);


GO
ALTER TABLE [dbo].[OrderCustomers]
    ADD CONSTRAINT [PK_OrderCustomers] PRIMARY KEY CLUSTERED ([OrderCustomerId] ASC);


GO
ALTER TABLE [dbo].[OrderCustomers]
    ADD CONSTRAINT [FK_OrderCustomers_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId]) ON DELETE CASCADE;




GO
CREATE NONCLUSTERED INDEX [IX_OrderVendors_VendorId]
    ON [dbo].[OrderVendors]([VendorId] ASC);


GO
ALTER TABLE [dbo].[OrderVendors]
    ADD CONSTRAINT [PK_OrderVendors] PRIMARY KEY CLUSTERED ([OrderVendorId] ASC);


GO
ALTER TABLE [dbo].[OrderVendors]
    ADD CONSTRAINT [FK_OrderVendors_Vendors_VendorId] FOREIGN KEY ([VendorId]) REFERENCES [dbo].[Vendors] ([VendorId]) ON DELETE CASCADE;





GO
CREATE NONCLUSTERED INDEX [IX_ItemOrders_OrderCustomerId]
    ON [dbo].[ItemOrders]([OrderCustomerId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ItemOrders_OrderVendorId]
    ON [dbo].[ItemOrders]([OrderVendorId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ItemOrders_ProductId]
    ON [dbo].[ItemOrders]([ProductId] ASC);


GO
ALTER TABLE [dbo].[ItemOrders]
    ADD CONSTRAINT [PK_ItemOrders] PRIMARY KEY CLUSTERED ([ItemOrderId] ASC);


GO
ALTER TABLE [dbo].[ItemOrders]
    ADD CONSTRAINT [FK_ItemOrders_OrderCustomers_OrderCustomerId] FOREIGN KEY ([OrderCustomerId]) REFERENCES [dbo].[OrderCustomers] ([OrderCustomerId]) ON DELETE CASCADE;


GO
ALTER TABLE [dbo].[ItemOrders]
    ADD CONSTRAINT [FK_ItemOrders_OrderVendors_OrderVendorId] FOREIGN KEY ([OrderVendorId]) REFERENCES [dbo].[OrderVendors] ([OrderVendorId]) ON DELETE SET NULL;


GO
ALTER TABLE [dbo].[ItemOrders]
    ADD CONSTRAINT [FK_ItemOrders_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([ProductId]) ON DELETE CASCADE;


