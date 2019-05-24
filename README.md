# Project
Code Stored Procedure 
Untuk code yang saya gunakan pada stored procedure : 
1. Untuk Insert Data

USE [LOS_KALBAR_DATA]
GO
/****** Object:  StoredProcedure [dbo].[stp_InsertMember]    Script Date: 24/05/2019 09:37:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[stp_InsertMember]  
@OTHERCOLDETAILS_ID uniqueidentifier,  
@SEQ int,  
@AP_REGNO varchar(20),
@COL_NAMEORMERK varchar(100),
@COL_TOTAL int, 
@COL_MARKETVALUE float,
@COL_LTV float,
@COL_VALUELIQUIDATION float,
@COL_DESC varchar(255),
@COLIND_ID varchar(100)
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    Insert into dbo.APP_OTHERCOLDETAILS (OTHERCOLDETAILS_ID,SEQ,AP_REGNO,COL_NAMEORMERK,COL_TOTAL,
				COL_MARKETVALUE, COL_LTV,COL_VALUELIQUIDATION,COL_DESC,COLIND_ID)   
           Values (@OTHERCOLDETAILS_ID,@SEQ, @AP_REGNO,@COL_NAMEORMERK,@COL_TOTAL,@COL_MARKETVALUE,
				@COL_LTV,@COL_VALUELIQUIDATION,@COL_DESC,@COLIND_ID)  

	select * from dbo.APP_OTHERCOLDETAILS
  
END  

2. Untuk Get Data 
USE [LOS_KALBAR_DATA]
GO
/****** Object:  StoredProcedure [dbo].[stpGetAll]    Script Date: 24/05/2019 09:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Store procedure name is --> stpGetAllMembers  
ALTER PROCEDURE [dbo].[stpGetAll]  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    -- Select statements for procedure here  
    Select * from dbo.APP_OTHERCOLDETAILS  
END  

