/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

USE [DmsAppDb]
GO

/******************************************** Start Script *******************************************/
/****** Object:  Table [dbo].[EmployeeDto]    Script Date: 8/9/2018 4:14:00 PM ******/
/****** Created By: Pranab Das ******/
/****** Object Type and Name: Table, EmployeeDto table ******/
/****** Description: The purpose of this table to create and maintain employee information ******/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EmployeeDto](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Dob] [datetime] NOT NULL,
	[PrimaryEmail] [nvarchar](max) NULL,
	[SecondaryEmail] [nvarchar](max) NULL,
	[AddedByUser] [nvarchar](max) NULL,
	[AddedOn] [datetime] NOT NULL,
	[UpdatedByUser] [nvarchar](max) NULL,
	[UpdatedOn] [datetime] NOT NULL,
	[DepId] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[ProjectRoleId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.EmployeeDto] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[EmployeeDto]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EmployeeDto_dbo.DepartmentDto_DepId] FOREIGN KEY([DepId])
REFERENCES [dbo].[DepartmentDto] ([DepId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[EmployeeDto] CHECK CONSTRAINT [FK_dbo.EmployeeDto_dbo.DepartmentDto_DepId]
GO
/******************************************** End Script *******************************************/
							/**        ~~        **/
							/**      /	   \     **/
							/**	    |  -  - |    **/
							/**	     \   ! /     **/
							/**		    --       **/

/******************************************** Start Script *******************************************/
/****** Object:  Table [dbo].[DepartmentDto]    Script Date: 8/9/2018 4:11:27 PM ******/
/****** Created By: Pranab Das ******/
/****** Object Type and Name: Table, DepartmentDto table ******/
/****** Description: The purpose of this table to create and maintain Department information ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DepartmentDto](
	[DepId] [int] IDENTITY(1,1) NOT NULL,
	[DepName] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.DepartmentDto] PRIMARY KEY CLUSTERED 
(
	[DepId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/******************************************** End Script *******************************************/
							/**        ~~        **/
							/**      /	   \     **/
							/**	    |  -  - |    **/
							/**	     \   ! /     **/
							/**		    --       **/

/******************************************** Start Script *******************************************/
/****** Object:  Table [dbo].[ProjectDto]    Script Date: 8/9/2018 4:16:08 PM ******/
/****** Created By: Pranab Das ******/
/****** Object Type and Name: Table, ProjectDto table ******/
/****** Description: The purpose of this table to create and maintain Project information ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProjectDto](
	[ProjectId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectName] [nvarchar](max) NULL,
	[EmployeeDto_EmpID] [int] NULL,
 CONSTRAINT [PK_dbo.ProjectDto] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ProjectDto]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ProjectDto_dbo.EmployeeDto_EmployeeDto_EmpID] FOREIGN KEY([EmployeeDto_EmpID])
REFERENCES [dbo].[EmployeeDto] ([EmpID])
GO

ALTER TABLE [dbo].[ProjectDto] CHECK CONSTRAINT [FK_dbo.ProjectDto_dbo.EmployeeDto_EmployeeDto_EmpID]
GO
/******************************************** End Script *******************************************/
                            /**        ~~        **/
							/**      /	   \     **/
							/**	    |  -  - |    **/
							/**	     \   ! /     **/
							/**		    --       **/

/******************************************** Start Script *******************************************/
/****** Object:  Table [dbo].[ProjectRoleDto]    Script Date: 8/9/2018 4:31:29 PM ******/
/****** Created By: Pranab Das ******/
/****** Object Type and Name: Table, ProjectDto table ******/
/****** Description: The purpose of this table to create and maintain Project Role information ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProjectRoleDto](
	[ProjectRoleId] [int] NOT NULL,
	[ProjectRoleName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProjectRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/******************************************** End Script *******************************************/


/************** Some test Script ***************/
/************** Put this all the way end *************/
use DmsAppDb

--try
--{
--Alter Table EmployeeDto
--Add Primary Key (EmpID), 

--Alter Table DepartmentDto
--Add Primary key (DepId);

--Alter Table ProjectDto
--Add Primary Key (ProjectId);

--Alter Table ProjectRoleDto
--Add Primary Key (ProjectRoleId);

--Alter Table EmployeeDto
--Add constraint Fk_DepId Foreign key (DepId) References  DepartmentDto(DepId),
--constraint Fk_ProjectId Foreign Key (ProjectId) References ProjectDto (ProjectId),
--Constraint Fk_ProjectRoleId Foreign Key (ProjectRoleId) References ProjectRoleDto (ProjectRoleId);


insert into DepartmentDto values ( 'Other Department');

Select * from DepartmentDto;

Insert into ProjectDto values (111, 'No Project');

Select * from ProjectDto;

Insert into ProjectRoleDto values (111, 'No Project Role');

Select * from ProjectRoleDto;
--}
--Catch {}

Select * from [dbo].[EmployeeDto];
Select * from DepartmentDto;
Select * from ProjectDto;
Select * from ProjectRoleDto;

SELECT [DepId]
FROM [dbo].[DepartmentDto]
WHERE @@ROWCOUNT > 0 AND [DepId] = scope_identity()
exec sp_executesql N'INSERT [dbo].[DepartmentDto]([DepName])
VALUES (@0)
SELECT [DepId]
FROM [dbo].[DepartmentDto]
WHERE @@ROWCOUNT > 0 AND [DepId] = scope_identity()',N'@0 nvarchar(max) ',@0=N'Next Blah Blah'