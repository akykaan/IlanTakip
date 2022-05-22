
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/02/2022 22:08:46
-- Generated from EDMX file: C:\Users\kaana\source\repos\IlanTakip\DataAccessLayer\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [IlanTakipDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dbo_Cvs_dbo_Candidates_Candidate_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cvs] DROP CONSTRAINT [FK_dbo_Cvs_dbo_Candidates_Candidate_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Events_dbo_Candidates_Candidate_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Events] DROP CONSTRAINT [FK_dbo_Events_dbo_Candidates_Candidate_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_JobAdverts_dbo_Cities_City_CityId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JobAdverts] DROP CONSTRAINT [FK_dbo_JobAdverts_dbo_Cities_City_CityId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_JobAdverts_dbo_Employers_Employer_EmployersId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JobAdverts] DROP CONSTRAINT [FK_dbo_JobAdverts_dbo_Employers_Employer_EmployersId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_JobExperiences_dbo_Cvs_CvId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JobExperiences] DROP CONSTRAINT [FK_dbo_JobExperiences_dbo_Cvs_CvId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Languages_dbo_Cvs_Cv_id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Languages] DROP CONSTRAINT [FK_dbo_Languages_dbo_Cvs_Cv_id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Schools_dbo_Cvs_cv_id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Schools] DROP CONSTRAINT [FK_dbo_Schools_dbo_Cvs_cv_id];
GO
IF OBJECT_ID(N'[dbo].[FK_SubMenu_ToMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubMenu] DROP CONSTRAINT [FK_SubMenu_ToMenu];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[__MigrationHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[__MigrationHistory];
GO
IF OBJECT_ID(N'[dbo].[Candidates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Candidates];
GO
IF OBJECT_ID(N'[dbo].[Cities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cities];
GO
IF OBJECT_ID(N'[dbo].[Cvs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cvs];
GO
IF OBJECT_ID(N'[dbo].[Employers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employers];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[JobAdverts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JobAdverts];
GO
IF OBJECT_ID(N'[dbo].[JobExperiences]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JobExperiences];
GO
IF OBJECT_ID(N'[dbo].[Languages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Languages];
GO
IF OBJECT_ID(N'[dbo].[Menu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menu];
GO
IF OBJECT_ID(N'[dbo].[Schools]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Schools];
GO
IF OBJECT_ID(N'[dbo].[SubMenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubMenu];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'C__MigrationHistory'
CREATE TABLE [dbo].[C__MigrationHistory] (
    [MigrationId] nvarchar(150)  NOT NULL,
    [ContextKey] nvarchar(300)  NOT NULL,
    [Model] varbinary(max)  NOT NULL,
    [ProductVersion] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'Candidates'
CREATE TABLE [dbo].[Candidates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdentityNumber] nvarchar(11)  NULL,
    [BirthYear] int  NOT NULL,
    [CvId] int  NOT NULL,
    [UserId] int  NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL,
    [Password] int  NOT NULL,
    [Authority] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [CityId] int IDENTITY(1,1) NOT NULL,
    [CityName] nvarchar(max)  NULL
);
GO

-- Creating table 'Cvs'
CREATE TABLE [dbo].[Cvs] (
    [id] int IDENTITY(1,1) NOT NULL,
    [GitHubLink] nvarchar(max)  NULL,
    [CoverLetter] nvarchar(max)  NULL,
    [Active] bit  NOT NULL,
    [Candidate_Id] int  NULL
);
GO

-- Creating table 'Employers'
CREATE TABLE [dbo].[Employers] (
    [EmployersId] int IDENTITY(1,1) NOT NULL,
    [Phone] int  NOT NULL,
    [CompanyName] nvarchar(50)  NULL,
    [UserId] int  NULL,
    [Name] nvarchar(max)  NULL,
    [CompanyMailAddress] nvarchar(50)  NULL,
    [Password] int  NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [EventId] int IDENTITY(1,1) NOT NULL,
    [EventTitle] nvarchar(max)  NULL,
    [EventOwner] nvarchar(max)  NULL,
    [EventDay] datetime  NOT NULL,
    [Candidate_Id] int  NULL
);
GO

-- Creating table 'JobAdverts'
CREATE TABLE [dbo].[JobAdverts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [JobDescription] nvarchar(max)  NULL,
    [JobTitle] nvarchar(max)  NULL,
    [CityName] nvarchar(max)  NULL,
    [OpenPosition] nvarchar(max)  NULL,
    [IsActive] bit  NOT NULL,
    [EmployerId] int  NOT NULL,
    [Employer_EmployersId] int  NULL,
    [City_CityId] int  NULL
);
GO

-- Creating table 'JobExperiences'
CREATE TABLE [dbo].[JobExperiences] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [WorkPlaceName] nvarchar(max)  NULL,
    [Position] nvarchar(max)  NULL,
    [StartYear] datetime  NOT NULL,
    [EndYear] datetime  NOT NULL,
    [CvId] int  NOT NULL
);
GO

-- Creating table 'Languages'
CREATE TABLE [dbo].[Languages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LanguageLevel] int  NOT NULL,
    [LanguageName] nvarchar(max)  NULL,
    [ProgrammingLanguageLevel] int  NOT NULL,
    [ProgrammingLanguageName] nvarchar(max)  NULL,
    [Cv_id] int  NULL
);
GO

-- Creating table 'Menu'
CREATE TABLE [dbo].[Menu] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MenuName] varchar(50)  NULL
);
GO

-- Creating table 'Schools'
CREATE TABLE [dbo].[Schools] (
    [SchoolId] int IDENTITY(1,1) NOT NULL,
    [SchoolName] nvarchar(max)  NULL,
    [DepartmentName] nvarchar(max)  NULL,
    [StartYear] nvarchar(max)  NULL,
    [StartEnd] nvarchar(max)  NULL,
    [cv_id] int  NULL
);
GO

-- Creating table 'SubMenu'
CREATE TABLE [dbo].[SubMenu] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MenuId] int  NULL,
    [MenuName] varchar(50)  NULL,
    [Url] varchar(255)  NULL
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

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MigrationId], [ContextKey] in table 'C__MigrationHistory'
ALTER TABLE [dbo].[C__MigrationHistory]
ADD CONSTRAINT [PK_C__MigrationHistory]
    PRIMARY KEY CLUSTERED ([MigrationId], [ContextKey] ASC);
GO

-- Creating primary key on [Id] in table 'Candidates'
ALTER TABLE [dbo].[Candidates]
ADD CONSTRAINT [PK_Candidates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [CityId] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([CityId] ASC);
GO

-- Creating primary key on [id] in table 'Cvs'
ALTER TABLE [dbo].[Cvs]
ADD CONSTRAINT [PK_Cvs]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [EmployersId] in table 'Employers'
ALTER TABLE [dbo].[Employers]
ADD CONSTRAINT [PK_Employers]
    PRIMARY KEY CLUSTERED ([EmployersId] ASC);
GO

-- Creating primary key on [EventId] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([EventId] ASC);
GO

-- Creating primary key on [Id] in table 'JobAdverts'
ALTER TABLE [dbo].[JobAdverts]
ADD CONSTRAINT [PK_JobAdverts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JobExperiences'
ALTER TABLE [dbo].[JobExperiences]
ADD CONSTRAINT [PK_JobExperiences]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Languages'
ALTER TABLE [dbo].[Languages]
ADD CONSTRAINT [PK_Languages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Menu'
ALTER TABLE [dbo].[Menu]
ADD CONSTRAINT [PK_Menu]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [SchoolId] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [PK_Schools]
    PRIMARY KEY CLUSTERED ([SchoolId] ASC);
GO

-- Creating primary key on [Id] in table 'SubMenu'
ALTER TABLE [dbo].[SubMenu]
ADD CONSTRAINT [PK_SubMenu]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Candidate_Id] in table 'Cvs'
ALTER TABLE [dbo].[Cvs]
ADD CONSTRAINT [FK_dbo_Cvs_dbo_Candidates_Candidate_Id]
    FOREIGN KEY ([Candidate_Id])
    REFERENCES [dbo].[Candidates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Cvs_dbo_Candidates_Candidate_Id'
CREATE INDEX [IX_FK_dbo_Cvs_dbo_Candidates_Candidate_Id]
ON [dbo].[Cvs]
    ([Candidate_Id]);
GO

-- Creating foreign key on [Candidate_Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [FK_dbo_Events_dbo_Candidates_Candidate_Id]
    FOREIGN KEY ([Candidate_Id])
    REFERENCES [dbo].[Candidates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Events_dbo_Candidates_Candidate_Id'
CREATE INDEX [IX_FK_dbo_Events_dbo_Candidates_Candidate_Id]
ON [dbo].[Events]
    ([Candidate_Id]);
GO

-- Creating foreign key on [City_CityId] in table 'JobAdverts'
ALTER TABLE [dbo].[JobAdverts]
ADD CONSTRAINT [FK_dbo_JobAdverts_dbo_Cities_City_CityId]
    FOREIGN KEY ([City_CityId])
    REFERENCES [dbo].[Cities]
        ([CityId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_JobAdverts_dbo_Cities_City_CityId'
CREATE INDEX [IX_FK_dbo_JobAdverts_dbo_Cities_City_CityId]
ON [dbo].[JobAdverts]
    ([City_CityId]);
GO

-- Creating foreign key on [CvId] in table 'JobExperiences'
ALTER TABLE [dbo].[JobExperiences]
ADD CONSTRAINT [FK_dbo_JobExperiences_dbo_Cvs_CvId]
    FOREIGN KEY ([CvId])
    REFERENCES [dbo].[Cvs]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_JobExperiences_dbo_Cvs_CvId'
CREATE INDEX [IX_FK_dbo_JobExperiences_dbo_Cvs_CvId]
ON [dbo].[JobExperiences]
    ([CvId]);
GO

-- Creating foreign key on [Cv_id] in table 'Languages'
ALTER TABLE [dbo].[Languages]
ADD CONSTRAINT [FK_dbo_Languages_dbo_Cvs_Cv_id]
    FOREIGN KEY ([Cv_id])
    REFERENCES [dbo].[Cvs]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Languages_dbo_Cvs_Cv_id'
CREATE INDEX [IX_FK_dbo_Languages_dbo_Cvs_Cv_id]
ON [dbo].[Languages]
    ([Cv_id]);
GO

-- Creating foreign key on [cv_id] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [FK_dbo_Schools_dbo_Cvs_cv_id]
    FOREIGN KEY ([cv_id])
    REFERENCES [dbo].[Cvs]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Schools_dbo_Cvs_cv_id'
CREATE INDEX [IX_FK_dbo_Schools_dbo_Cvs_cv_id]
ON [dbo].[Schools]
    ([cv_id]);
GO

-- Creating foreign key on [Employer_EmployersId] in table 'JobAdverts'
ALTER TABLE [dbo].[JobAdverts]
ADD CONSTRAINT [FK_dbo_JobAdverts_dbo_Employers_Employer_EmployersId]
    FOREIGN KEY ([Employer_EmployersId])
    REFERENCES [dbo].[Employers]
        ([EmployersId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_JobAdverts_dbo_Employers_Employer_EmployersId'
CREATE INDEX [IX_FK_dbo_JobAdverts_dbo_Employers_Employer_EmployersId]
ON [dbo].[JobAdverts]
    ([Employer_EmployersId]);
GO

-- Creating foreign key on [MenuId] in table 'SubMenu'
ALTER TABLE [dbo].[SubMenu]
ADD CONSTRAINT [FK_SubMenu_ToMenu]
    FOREIGN KEY ([MenuId])
    REFERENCES [dbo].[Menu]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SubMenu_ToMenu'
CREATE INDEX [IX_FK_SubMenu_ToMenu]
ON [dbo].[SubMenu]
    ([MenuId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------