
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/01/2017 19:36:49
-- Generated from EDMX file: C:\Users\Grzegorz\Desktop\Bank_serwer\Bank_serwer\BazaEF.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [102];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Blokady_Administratorzy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Blokady] DROP CONSTRAINT [FK_Blokady_Administratorzy];
GO
IF OBJECT_ID(N'[dbo].[FK_Blokady_Rachunki]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Blokady] DROP CONSTRAINT [FK_Blokady_Rachunki];
GO
IF OBJECT_ID(N'[dbo].[FK_Historia_miedzybankowa_Rachunki]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Historia_miedzybankowa] DROP CONSTRAINT [FK_Historia_miedzybankowa_Rachunki];
GO
IF OBJECT_ID(N'[dbo].[FK_Historia_miedzybankowa_Status]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Historia_miedzybankowa] DROP CONSTRAINT [FK_Historia_miedzybankowa_Status];
GO
IF OBJECT_ID(N'[dbo].[FK_Historia_wewnatrzbankowa_Rachunki]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Historia_wewnatrzbankowa] DROP CONSTRAINT [FK_Historia_wewnatrzbankowa_Rachunki];
GO
IF OBJECT_ID(N'[dbo].[FK_Historia_wewnatrzbankowa_Rachunki2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Historia_wewnatrzbankowa] DROP CONSTRAINT [FK_Historia_wewnatrzbankowa_Rachunki2];
GO
IF OBJECT_ID(N'[dbo].[FK_Odbiorcy_zdefiniowani_Klienci]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Odbiorcy_zdefiniowani] DROP CONSTRAINT [FK_Odbiorcy_zdefiniowani_Klienci];
GO
IF OBJECT_ID(N'[dbo].[FK_Przelew_cykliczny_Rachunki]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Przelew_cykliczny] DROP CONSTRAINT [FK_Przelew_cykliczny_Rachunki];
GO
IF OBJECT_ID(N'[dbo].[FK_Rachunki_Klienci]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rachunki] DROP CONSTRAINT [FK_Rachunki_Klienci];
GO
IF OBJECT_ID(N'[dbo].[FK_Rachunki_Rodzaj]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rachunki] DROP CONSTRAINT [FK_Rachunki_Rodzaj];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Administratorzy]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Administratorzy];
GO
IF OBJECT_ID(N'[dbo].[Banki_numery]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Banki_numery];
GO
IF OBJECT_ID(N'[dbo].[Blokady]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Blokady];
GO
IF OBJECT_ID(N'[dbo].[Historia_miedzybankowa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Historia_miedzybankowa];
GO
IF OBJECT_ID(N'[dbo].[Historia_status]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Historia_status];
GO
IF OBJECT_ID(N'[dbo].[Historia_wewnatrzbankowa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Historia_wewnatrzbankowa];
GO
IF OBJECT_ID(N'[dbo].[Klienci]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Klienci];
GO
IF OBJECT_ID(N'[dbo].[Odbiorcy_zdefiniowani]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Odbiorcy_zdefiniowani];
GO
IF OBJECT_ID(N'[dbo].[Przelew_cykliczny]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Przelew_cykliczny];
GO
IF OBJECT_ID(N'[dbo].[Rachunki]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rachunki];
GO
IF OBJECT_ID(N'[dbo].[Rachunki_obce]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rachunki_obce];
GO
IF OBJECT_ID(N'[dbo].[Rachunki_rodzaj]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rachunki_rodzaj];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Administratorzy'
CREATE TABLE [dbo].[Administratorzy] (
    [id_administratora] int IDENTITY(1,1) NOT NULL,
    [imie] nvarchar(50)  NOT NULL,
    [nazwisko] nvarchar(50)  NOT NULL,
    [pesel] nchar(11)  NOT NULL,
    [nr_dowodu] nvarchar(15)  NOT NULL,
    [miasto] nvarchar(50)  NOT NULL,
    [ulica] nvarchar(50)  NULL,
    [nr_domu] nvarchar(10)  NOT NULL,
    [nr_mieszkania] nchar(10)  NULL,
    [login] nvarchar(20)  NOT NULL,
    [haslo] nchar(64)  NOT NULL,
    [nr_telefonu] nchar(15)  NOT NULL,
    [email] nvarchar(60)  NULL
);
GO

-- Creating table 'Blokady'
CREATE TABLE [dbo].[Blokady] (
    [id_blokady] int IDENTITY(1,1) NOT NULL,
    [id_administratora] int  NOT NULL,
    [id_rachunku] int  NOT NULL,
    [data] datetime  NOT NULL,
    [Informacja] varchar(max)  NOT NULL
);
GO

-- Creating table 'Historia_miedzybankowa'
CREATE TABLE [dbo].[Historia_miedzybankowa] (
    [id_transakcji] int IDENTITY(1,1) NOT NULL,
    [kwota] decimal(18,4)  NOT NULL,
    [data] datetime  NOT NULL,
    [kierunek_transakcji] int  NOT NULL,
    [id_rachunku] int  NOT NULL,
    [nr_rachunku_obcego] nchar(26)  NOT NULL,
    [status] int  NOT NULL,
    [tytul] nvarchar(50)  NOT NULL,
    [nazwa_odbiorcy] nvarchar(50)  NOT NULL,
    [adres_odbiorcy] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Historia_status'
CREATE TABLE [dbo].[Historia_status] (
    [id_status] int  NOT NULL,
    [nazwa] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Historia_wewnatrzbankowa'
CREATE TABLE [dbo].[Historia_wewnatrzbankowa] (
    [id_transakcji] int IDENTITY(1,1) NOT NULL,
    [kwota] decimal(18,4)  NOT NULL,
    [data] datetime  NOT NULL,
    [id_rachunku_nadawca] int  NOT NULL,
    [id_rachunku_odbiorca] int  NOT NULL,
    [status] int  NOT NULL,
    [tytul] nvarchar(50)  NULL,
    [nazwa_odbiorcy] nvarchar(50)  NULL,
    [adres_odbiorcy] nvarchar(50)  NULL
);
GO

-- Creating table 'Klienci'
CREATE TABLE [dbo].[Klienci] (
    [id_klienta] int IDENTITY(1,1) NOT NULL,
    [imie] nvarchar(50)  NOT NULL,
    [nazwisko] nvarchar(50)  NOT NULL,
    [pesel] nchar(11)  NOT NULL,
    [nr_dowodu] nvarchar(15)  NOT NULL,
    [miasto] nvarchar(50)  NOT NULL,
    [ulica] nvarchar(50)  NULL,
    [nr_domu] nvarchar(10)  NOT NULL,
    [nr_mieszkania] nchar(10)  NULL,
    [login] nvarchar(20)  NOT NULL,
    [haslo] nchar(64)  NOT NULL,
    [nr_telefonu] nchar(15)  NOT NULL,
    [email] nvarchar(60)  NULL,
    [data_ostatniego_logowania] datetime  NULL,
    [data_ostatniego_blednego_logowania] datetime  NULL,
    [login_blokada] bit  NOT NULL
);
GO

-- Creating table 'Odbiorcy_zdefiniowani'
CREATE TABLE [dbo].[Odbiorcy_zdefiniowani] (
    [id_odbiorcy_zdefiniowani] int  NOT NULL,
    [id_wlasciciela] int  NOT NULL,
    [nr_rachunku] nchar(26)  NOT NULL,
    [nazwa] nchar(256)  NOT NULL,
    [adres] nchar(256)  NOT NULL
);
GO

-- Creating table 'Przelew_cykliczny'
CREATE TABLE [dbo].[Przelew_cykliczny] (
    [id_przelewu_cyklicznego] int  NOT NULL,
    [id_rachunku_nadawcy] int  NOT NULL,
    [nr_rachunku_odbiorcy] int  NOT NULL,
    [kwota] decimal(18,4)  NOT NULL,
    [tytuł] nchar(256)  NOT NULL,
    [data_pierwszego_wykonania] datetime  NOT NULL,
    [Czestotliwosc_dni] int  NOT NULL,
    [data_ostatniego_wykonania] datetime  NOT NULL
);
GO

-- Creating table 'Rachunki'
CREATE TABLE [dbo].[Rachunki] (
    [id_rachunku] int IDENTITY(1,1) NOT NULL,
    [id_klienta] int  NOT NULL,
    [nr_rachunku] nchar(26)  NOT NULL,
    [rodzaj_rachunku] int  NOT NULL,
    [dostepne_srodki] decimal(18,4)  NOT NULL,
    [blokada] bit  NOT NULL
);
GO

-- Creating table 'Rachunki_rodzaj'
CREATE TABLE [dbo].[Rachunki_rodzaj] (
    [id_rodzaj] int  NOT NULL,
    [nazwa] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Rachunki_obce'
CREATE TABLE [dbo].[Rachunki_obce] (
    [id_rachunku] int  NOT NULL,
    [numer] nchar(26)  NOT NULL,
    [dostepne_srodki] decimal(18,4)  NOT NULL
);
GO

-- Creating table 'Banki_numery'
CREATE TABLE [dbo].[Banki_numery] (
    [numer] nchar(3)  NOT NULL,
    [nazwa_banku] nvarchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id_administratora] in table 'Administratorzy'
ALTER TABLE [dbo].[Administratorzy]
ADD CONSTRAINT [PK_Administratorzy]
    PRIMARY KEY CLUSTERED ([id_administratora] ASC);
GO

-- Creating primary key on [id_blokady] in table 'Blokady'
ALTER TABLE [dbo].[Blokady]
ADD CONSTRAINT [PK_Blokady]
    PRIMARY KEY CLUSTERED ([id_blokady] ASC);
GO

-- Creating primary key on [id_transakcji] in table 'Historia_miedzybankowa'
ALTER TABLE [dbo].[Historia_miedzybankowa]
ADD CONSTRAINT [PK_Historia_miedzybankowa]
    PRIMARY KEY CLUSTERED ([id_transakcji] ASC);
GO

-- Creating primary key on [id_status] in table 'Historia_status'
ALTER TABLE [dbo].[Historia_status]
ADD CONSTRAINT [PK_Historia_status]
    PRIMARY KEY CLUSTERED ([id_status] ASC);
GO

-- Creating primary key on [id_transakcji] in table 'Historia_wewnatrzbankowa'
ALTER TABLE [dbo].[Historia_wewnatrzbankowa]
ADD CONSTRAINT [PK_Historia_wewnatrzbankowa]
    PRIMARY KEY CLUSTERED ([id_transakcji] ASC);
GO

-- Creating primary key on [id_klienta] in table 'Klienci'
ALTER TABLE [dbo].[Klienci]
ADD CONSTRAINT [PK_Klienci]
    PRIMARY KEY CLUSTERED ([id_klienta] ASC);
GO

-- Creating primary key on [id_odbiorcy_zdefiniowani] in table 'Odbiorcy_zdefiniowani'
ALTER TABLE [dbo].[Odbiorcy_zdefiniowani]
ADD CONSTRAINT [PK_Odbiorcy_zdefiniowani]
    PRIMARY KEY CLUSTERED ([id_odbiorcy_zdefiniowani] ASC);
GO

-- Creating primary key on [id_przelewu_cyklicznego] in table 'Przelew_cykliczny'
ALTER TABLE [dbo].[Przelew_cykliczny]
ADD CONSTRAINT [PK_Przelew_cykliczny]
    PRIMARY KEY CLUSTERED ([id_przelewu_cyklicznego] ASC);
GO

-- Creating primary key on [id_rachunku] in table 'Rachunki'
ALTER TABLE [dbo].[Rachunki]
ADD CONSTRAINT [PK_Rachunki]
    PRIMARY KEY CLUSTERED ([id_rachunku] ASC);
GO

-- Creating primary key on [id_rodzaj] in table 'Rachunki_rodzaj'
ALTER TABLE [dbo].[Rachunki_rodzaj]
ADD CONSTRAINT [PK_Rachunki_rodzaj]
    PRIMARY KEY CLUSTERED ([id_rodzaj] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [id_rachunku] in table 'Rachunki_obce'
ALTER TABLE [dbo].[Rachunki_obce]
ADD CONSTRAINT [PK_Rachunki_obce]
    PRIMARY KEY CLUSTERED ([id_rachunku] ASC);
GO

-- Creating primary key on [numer], [nazwa_banku] in table 'Banki_numery'
ALTER TABLE [dbo].[Banki_numery]
ADD CONSTRAINT [PK_Banki_numery]
    PRIMARY KEY CLUSTERED ([numer], [nazwa_banku] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [id_administratora] in table 'Blokady'
ALTER TABLE [dbo].[Blokady]
ADD CONSTRAINT [FK_Blokady_Administratorzy]
    FOREIGN KEY ([id_administratora])
    REFERENCES [dbo].[Administratorzy]
        ([id_administratora])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Blokady_Administratorzy'
CREATE INDEX [IX_FK_Blokady_Administratorzy]
ON [dbo].[Blokady]
    ([id_administratora]);
GO

-- Creating foreign key on [id_rachunku] in table 'Blokady'
ALTER TABLE [dbo].[Blokady]
ADD CONSTRAINT [FK_Blokady_Rachunki]
    FOREIGN KEY ([id_rachunku])
    REFERENCES [dbo].[Rachunki]
        ([id_rachunku])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Blokady_Rachunki'
CREATE INDEX [IX_FK_Blokady_Rachunki]
ON [dbo].[Blokady]
    ([id_rachunku]);
GO

-- Creating foreign key on [id_rachunku] in table 'Historia_miedzybankowa'
ALTER TABLE [dbo].[Historia_miedzybankowa]
ADD CONSTRAINT [FK_Historia_miedzybankowa_Rachunki]
    FOREIGN KEY ([id_rachunku])
    REFERENCES [dbo].[Rachunki]
        ([id_rachunku])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Historia_miedzybankowa_Rachunki'
CREATE INDEX [IX_FK_Historia_miedzybankowa_Rachunki]
ON [dbo].[Historia_miedzybankowa]
    ([id_rachunku]);
GO

-- Creating foreign key on [status] in table 'Historia_miedzybankowa'
ALTER TABLE [dbo].[Historia_miedzybankowa]
ADD CONSTRAINT [FK_Historia_miedzybankowa_Status]
    FOREIGN KEY ([status])
    REFERENCES [dbo].[Historia_status]
        ([id_status])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Historia_miedzybankowa_Status'
CREATE INDEX [IX_FK_Historia_miedzybankowa_Status]
ON [dbo].[Historia_miedzybankowa]
    ([status]);
GO

-- Creating foreign key on [id_wlasciciela] in table 'Odbiorcy_zdefiniowani'
ALTER TABLE [dbo].[Odbiorcy_zdefiniowani]
ADD CONSTRAINT [FK_Odbiorcy_zdefiniowani_Klienci]
    FOREIGN KEY ([id_wlasciciela])
    REFERENCES [dbo].[Klienci]
        ([id_klienta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Odbiorcy_zdefiniowani_Klienci'
CREATE INDEX [IX_FK_Odbiorcy_zdefiniowani_Klienci]
ON [dbo].[Odbiorcy_zdefiniowani]
    ([id_wlasciciela]);
GO

-- Creating foreign key on [id_klienta] in table 'Rachunki'
ALTER TABLE [dbo].[Rachunki]
ADD CONSTRAINT [FK_Rachunki_Klienci]
    FOREIGN KEY ([id_klienta])
    REFERENCES [dbo].[Klienci]
        ([id_klienta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Rachunki_Klienci'
CREATE INDEX [IX_FK_Rachunki_Klienci]
ON [dbo].[Rachunki]
    ([id_klienta]);
GO

-- Creating foreign key on [id_rachunku_nadawcy] in table 'Przelew_cykliczny'
ALTER TABLE [dbo].[Przelew_cykliczny]
ADD CONSTRAINT [FK_Przelew_cykliczny_Rachunki]
    FOREIGN KEY ([id_rachunku_nadawcy])
    REFERENCES [dbo].[Rachunki]
        ([id_rachunku])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Przelew_cykliczny_Rachunki'
CREATE INDEX [IX_FK_Przelew_cykliczny_Rachunki]
ON [dbo].[Przelew_cykliczny]
    ([id_rachunku_nadawcy]);
GO

-- Creating foreign key on [rodzaj_rachunku] in table 'Rachunki'
ALTER TABLE [dbo].[Rachunki]
ADD CONSTRAINT [FK_Rachunki_Rodzaj]
    FOREIGN KEY ([rodzaj_rachunku])
    REFERENCES [dbo].[Rachunki_rodzaj]
        ([id_rodzaj])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Rachunki_Rodzaj'
CREATE INDEX [IX_FK_Rachunki_Rodzaj]
ON [dbo].[Rachunki]
    ([rodzaj_rachunku]);
GO

-- Creating foreign key on [id_rachunku_nadawca] in table 'Historia_wewnatrzbankowa'
ALTER TABLE [dbo].[Historia_wewnatrzbankowa]
ADD CONSTRAINT [FK_Historia_wewnatrzbankowa_Rachunki]
    FOREIGN KEY ([id_rachunku_nadawca])
    REFERENCES [dbo].[Rachunki]
        ([id_rachunku])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Historia_wewnatrzbankowa_Rachunki'
CREATE INDEX [IX_FK_Historia_wewnatrzbankowa_Rachunki]
ON [dbo].[Historia_wewnatrzbankowa]
    ([id_rachunku_nadawca]);
GO

-- Creating foreign key on [id_rachunku_odbiorca] in table 'Historia_wewnatrzbankowa'
ALTER TABLE [dbo].[Historia_wewnatrzbankowa]
ADD CONSTRAINT [FK_Historia_wewnatrzbankowa_Rachunki2]
    FOREIGN KEY ([id_rachunku_odbiorca])
    REFERENCES [dbo].[Rachunki]
        ([id_rachunku])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Historia_wewnatrzbankowa_Rachunki2'
CREATE INDEX [IX_FK_Historia_wewnatrzbankowa_Rachunki2]
ON [dbo].[Historia_wewnatrzbankowa]
    ([id_rachunku_odbiorca]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------