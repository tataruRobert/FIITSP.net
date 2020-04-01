
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/01/2020 14:53:24
-- Generated from EDMX file: C:\Users\Robert\source\repos\proiect2_1\proiect2_1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Proiect2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PhotosId] int  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PhotosId] int  NOT NULL
);
GO

-- Creating table 'Features'
CREATE TABLE [dbo].[Features] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Desc] nvarchar(max)  NOT NULL,
    [PhotosId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Features'
ALTER TABLE [dbo].[Features]
ADD CONSTRAINT [PK_Features]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PhotosId] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [FK_PhotosLocations]
    FOREIGN KEY ([PhotosId])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotosLocations'
CREATE INDEX [IX_FK_PhotosLocations]
ON [dbo].[Locations]
    ([PhotosId]);
GO

-- Creating foreign key on [PhotosId] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [FK_PhotosPeople]
    FOREIGN KEY ([PhotosId])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotosPeople'
CREATE INDEX [IX_FK_PhotosPeople]
ON [dbo].[People]
    ([PhotosId]);
GO

-- Creating foreign key on [PhotosId] in table 'Features'
ALTER TABLE [dbo].[Features]
ADD CONSTRAINT [FK_PhotosFeatures]
    FOREIGN KEY ([PhotosId])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotosFeatures'
CREATE INDEX [IX_FK_PhotosFeatures]
ON [dbo].[Features]
    ([PhotosId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------