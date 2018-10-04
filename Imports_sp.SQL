SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtBTADetailsSelectList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtBTADetailsSelectList]
GO
 
CREATE PROCEDURE [dbo].[spspmtBTADetailsSelectList]
  @LoginID NVarChar(8),
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  SELECT
    [SPMT_BTADetails].* ,
    [aspnet_Users1].[UserFullName] AS aspnet_Users1_UserFullName,
    [SPMT_BTAStatus2].[Descriptions] AS SPMT_BTAStatus2_Descriptions 
  FROM [SPMT_BTADetails] 
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [SPMT_BTADetails].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [SPMT_BTAStatus] AS [SPMT_BTAStatus2]
    ON [SPMT_BTADetails].[StatusID] = [SPMT_BTAStatus2].[StatusID]
  WHERE 1 = 1  
  ORDER BY
     CASE @OrderBy WHEN 'SerialNo' THEN [SPMT_BTADetails].[SerialNo] END,
     CASE @OrderBy WHEN 'SerialNo DESC' THEN [SPMT_BTADetails].[SerialNo] END DESC,
     CASE @OrderBy WHEN 'CORP_2' THEN [SPMT_BTADetails].[CORP_2] END,
     CASE @OrderBy WHEN 'CORP_2 DESC' THEN [SPMT_BTADetails].[CORP_2] END DESC,
     CASE @OrderBy WHEN 'CORP_1' THEN [SPMT_BTADetails].[CORP_1] END,
     CASE @OrderBy WHEN 'CORP_1 DESC' THEN [SPMT_BTADetails].[CORP_1] END DESC,
     CASE @OrderBy WHEN 'BTA_ACCT' THEN [SPMT_BTADetails].[BTA_ACCT] END,
     CASE @OrderBy WHEN 'BTA_ACCT DESC' THEN [SPMT_BTADetails].[BTA_ACCT] END DESC,
     CASE @OrderBy WHEN 'STMT_DT' THEN [SPMT_BTADetails].[STMT_DT] END,
     CASE @OrderBy WHEN 'STMT_DT DESC' THEN [SPMT_BTADetails].[STMT_DT] END DESC,
     CASE @OrderBy WHEN 'STMT_REF_NO' THEN [SPMT_BTADetails].[STMT_REF_NO] END,
     CASE @OrderBy WHEN 'STMT_REF_NO DESC' THEN [SPMT_BTADetails].[STMT_REF_NO] END DESC,
     CASE @OrderBy WHEN 'CUST_REF' THEN [SPMT_BTADetails].[CUST_REF] END,
     CASE @OrderBy WHEN 'CUST_REF DESC' THEN [SPMT_BTADetails].[CUST_REF] END DESC,
     CASE @OrderBy WHEN 'TRIP_REQ' THEN [SPMT_BTADetails].[TRIP_REQ] END,
     CASE @OrderBy WHEN 'TRIP_REQ DESC' THEN [SPMT_BTADetails].[TRIP_REQ] END DESC,
     CASE @OrderBy WHEN 'JOB_NO' THEN [SPMT_BTADetails].[JOB_NO] END,
     CASE @OrderBy WHEN 'JOB_NO DESC' THEN [SPMT_BTADetails].[JOB_NO] END DESC,
     CASE @OrderBy WHEN 'PAX_NM' THEN [SPMT_BTADetails].[PAX_NM] END,
     CASE @OrderBy WHEN 'PAX_NM DESC' THEN [SPMT_BTADetails].[PAX_NM] END DESC,
     CASE @OrderBy WHEN 'AMOUNT_EX_GST' THEN [SPMT_BTADetails].[AMOUNT_EX_GST] END,
     CASE @OrderBy WHEN 'AMOUNT_EX_GST DESC' THEN [SPMT_BTADetails].[AMOUNT_EX_GST] END DESC,
     CASE @OrderBy WHEN 'GST' THEN [SPMT_BTADetails].[GST] END,
     CASE @OrderBy WHEN 'GST DESC' THEN [SPMT_BTADetails].[GST] END DESC,
     CASE @OrderBy WHEN 'UNPAID_AMT' THEN [SPMT_BTADetails].[UNPAID_AMT] END,
     CASE @OrderBy WHEN 'UNPAID_AMT DESC' THEN [SPMT_BTADetails].[UNPAID_AMT] END DESC,
     CASE @OrderBy WHEN 'CHARGE_DTE' THEN [SPMT_BTADetails].[CHARGE_DTE] END,
     CASE @OrderBy WHEN 'CHARGE_DTE DESC' THEN [SPMT_BTADetails].[CHARGE_DTE] END DESC,
     CASE @OrderBy WHEN 'BKNG_DATE' THEN [SPMT_BTADetails].[BKNG_DATE] END,
     CASE @OrderBy WHEN 'BKNG_DATE DESC' THEN [SPMT_BTADetails].[BKNG_DATE] END DESC,
     CASE @OrderBy WHEN 'DEPT_DATE' THEN [SPMT_BTADetails].[DEPT_DATE] END,
     CASE @OrderBy WHEN 'DEPT_DATE DESC' THEN [SPMT_BTADetails].[DEPT_DATE] END DESC,
     CASE @OrderBy WHEN 'TICKET_NO' THEN [SPMT_BTADetails].[TICKET_NO] END,
     CASE @OrderBy WHEN 'TICKET_NO DESC' THEN [SPMT_BTADetails].[TICKET_NO] END DESC,
     CASE @OrderBy WHEN 'CARRIER' THEN [SPMT_BTADetails].[CARRIER] END,
     CASE @OrderBy WHEN 'CARRIER DESC' THEN [SPMT_BTADetails].[CARRIER] END DESC,
     CASE @OrderBy WHEN 'CLASS' THEN [SPMT_BTADetails].[CLASS] END,
     CASE @OrderBy WHEN 'CLASS DESC' THEN [SPMT_BTADetails].[CLASS] END DESC,
     CASE @OrderBy WHEN 'DI' THEN [SPMT_BTADetails].[DI] END,
     CASE @OrderBy WHEN 'DI DESC' THEN [SPMT_BTADetails].[DI] END DESC,
     CASE @OrderBy WHEN 'ROUTING' THEN [SPMT_BTADetails].[ROUTING] END,
     CASE @OrderBy WHEN 'ROUTING DESC' THEN [SPMT_BTADetails].[ROUTING] END DESC,
     CASE @OrderBy WHEN 'TXN_DATE' THEN [SPMT_BTADetails].[TXN_DATE] END,
     CASE @OrderBy WHEN 'TXN_DATE DESC' THEN [SPMT_BTADetails].[TXN_DATE] END DESC,
     CASE @OrderBy WHEN 'Merchant_ABN' THEN [SPMT_BTADetails].[Merchant_ABN] END,
     CASE @OrderBy WHEN 'Merchant_ABN DESC' THEN [SPMT_BTADetails].[Merchant_ABN] END DESC,
     CASE @OrderBy WHEN 'Book_Ref' THEN [SPMT_BTADetails].[Book_Ref] END,
     CASE @OrderBy WHEN 'Book_Ref DESC' THEN [SPMT_BTADetails].[Book_Ref] END DESC,
     CASE @OrderBy WHEN 'COMMENT1' THEN [SPMT_BTADetails].[COMMENT1] END,
     CASE @OrderBy WHEN 'COMMENT1 DESC' THEN [SPMT_BTADetails].[COMMENT1] END DESC,
     CASE @OrderBy WHEN 'COMMENT2' THEN [SPMT_BTADetails].[COMMENT2] END,
     CASE @OrderBy WHEN 'COMMENT2 DESC' THEN [SPMT_BTADetails].[COMMENT2] END DESC,
     CASE @OrderBy WHEN 'COMMENT3' THEN [SPMT_BTADetails].[COMMENT3] END,
     CASE @OrderBy WHEN 'COMMENT3 DESC' THEN [SPMT_BTADetails].[COMMENT3] END DESC,
     CASE @OrderBy WHEN 'MERCHANT_NAME' THEN [SPMT_BTADetails].[MERCHANT_NAME] END,
     CASE @OrderBy WHEN 'MERCHANT_NAME DESC' THEN [SPMT_BTADetails].[MERCHANT_NAME] END DESC,
     CASE @OrderBy WHEN 'BatchNo' THEN [SPMT_BTADetails].[BatchNo] END,
     CASE @OrderBy WHEN 'BatchNo DESC' THEN [SPMT_BTADetails].[BatchNo] END DESC,
     CASE @OrderBy WHEN 'StatusID' THEN [SPMT_BTADetails].[StatusID] END,
     CASE @OrderBy WHEN 'StatusID DESC' THEN [SPMT_BTADetails].[StatusID] END DESC,
     CASE @OrderBy WHEN 'CreatedBy' THEN [SPMT_BTADetails].[CreatedBy] END,
     CASE @OrderBy WHEN 'CreatedBy DESC' THEN [SPMT_BTADetails].[CreatedBy] END DESC,
     CASE @OrderBy WHEN 'CreatedOn' THEN [SPMT_BTADetails].[CreatedOn] END,
     CASE @OrderBy WHEN 'CreatedOn DESC' THEN [SPMT_BTADetails].[CreatedOn] END DESC,
     CASE @OrderBy WHEN 'aspnet_Users1_UserFullName' THEN [aspnet_Users1].[UserFullName] END,
     CASE @OrderBy WHEN 'aspnet_Users1_UserFullName DESC' THEN [aspnet_Users1].[UserFullName] END DESC,
     CASE @OrderBy WHEN 'SPMT_BTAStatus2_Descriptions' THEN [SPMT_BTAStatus2].[Descriptions] END,
     CASE @OrderBy WHEN 'SPMT_BTAStatus2_Descriptions DESC' THEN [SPMT_BTAStatus2].[Descriptions] END DESC 
  SET @RecordCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtBTADetailsAutoCompleteList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtBTADetailsAutoCompleteList]
GO
 
CREATE PROCEDURE [dbo].[spspmtBTADetailsAutoCompleteList]
  @LoginID NVarChar(8),
  @Prefix NVarChar(250),
  @Records Int,
  @ByCode Int 
  AS 
  BEGIN 
  DECLARE @Prefix1 VarChar(260)
  SET @Prefix1 = LOWER(@Prefix) + '%'
  DECLARE @LGSQL VarChar(8000)
  SET @LGSQL = 'SELECT TOP (' + STR(@Records) + ') ' 
  SET @LGSQL = @LGSQL + ' [SPMT_BTADetails].[TICKET_NO]' 
  SET @LGSQL = @LGSQL + ',[SPMT_BTADetails].[SerialNo]' 
  SET @LGSQL = @LGSQL + ' FROM [SPMT_BTADetails] ' 
  SET @LGSQL = @LGSQL + ' WHERE 1 = 1 ' 
  SET @LGSQL = @LGSQL + ' AND (LTRIM(STR(ISNULL([SPMT_BTADetails].[SerialNo],0))) LIKE ''' + @Prefix1 + ''''
  SET @LGSQL = @LGSQL + ' OR LOWER(ISNULL([SPMT_BTADetails].[TICKET_NO],'''')) LIKE ''' + @Prefix1 + ''''
  SET @LGSQL = @LGSQL + ')' 
  
  EXEC (@LGSQL)
  END 
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtBTADetailsSelectByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtBTADetailsSelectByID]
GO
 
CREATE PROCEDURE [dbo].[spspmtBTADetailsSelectByID]
  @LoginID NVarChar(8),
  @SerialNo Int 
  AS
  SELECT
    [SPMT_BTADetails].* ,
    [aspnet_Users1].[UserFullName] AS aspnet_Users1_UserFullName,
    [SPMT_BTAStatus2].[Descriptions] AS SPMT_BTAStatus2_Descriptions 
  FROM [SPMT_BTADetails] 
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [SPMT_BTADetails].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [SPMT_BTAStatus] AS [SPMT_BTAStatus2]
    ON [SPMT_BTADetails].[StatusID] = [SPMT_BTAStatus2].[StatusID]
  WHERE
  [SPMT_BTADetails].[SerialNo] = @SerialNo
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtBTADetailsSelectListSearch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtBTADetailsSelectListSearch]
GO
 
CREATE PROCEDURE [dbo].[spspmtBTADetailsSelectListSearch]
  @LoginID NVarChar(8),
  @StartRowIndex int,
  @MaximumRows int,
  @KeyWord VarChar(250),
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  BEGIN
    DECLARE @KeyWord1 VarChar(260)
    SET @KeyWord1 = '%' + LOWER(@KeyWord) + '%'
  CREATE TABLE #PageIndex (
  IndexID INT IDENTITY (1, 1) NOT NULL
 ,SerialNo Int NOT NULL
  )
  INSERT INTO #PageIndex (SerialNo)
  SELECT [SPMT_BTADetails].[SerialNo] FROM [SPMT_BTADetails]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [SPMT_BTADetails].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [SPMT_BTAStatus] AS [SPMT_BTAStatus2]
    ON [SPMT_BTADetails].[StatusID] = [SPMT_BTAStatus2].[StatusID]
 WHERE  
   ( 
         STR(ISNULL([SPMT_BTADetails].[SerialNo], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[CORP_2],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[CORP_1],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[BTA_ACCT],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[STMT_REF_NO],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[CUST_REF],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[TRIP_REQ],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[JOB_NO],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[PAX_NM],'')) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_BTADetails].[AMOUNT_EX_GST], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_BTADetails].[GST], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_BTADetails].[UNPAID_AMT], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[TICKET_NO],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[CARRIER],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[CLASS],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[DI],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[ROUTING],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[Merchant_ABN],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[Book_Ref],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[COMMENT1],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[COMMENT2],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[COMMENT3],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[MERCHANT_NAME],'')) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_BTADetails].[BatchNo], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_BTADetails].[StatusID], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTADetails].[CreatedBy],'')) LIKE @KeyWord1
   ) 
  ORDER BY
     CASE @OrderBy WHEN 'SerialNo' THEN [SPMT_BTADetails].[SerialNo] END,
     CASE @OrderBy WHEN 'SerialNo DESC' THEN [SPMT_BTADetails].[SerialNo] END DESC,
     CASE @OrderBy WHEN 'CORP_2' THEN [SPMT_BTADetails].[CORP_2] END,
     CASE @OrderBy WHEN 'CORP_2 DESC' THEN [SPMT_BTADetails].[CORP_2] END DESC,
     CASE @OrderBy WHEN 'CORP_1' THEN [SPMT_BTADetails].[CORP_1] END,
     CASE @OrderBy WHEN 'CORP_1 DESC' THEN [SPMT_BTADetails].[CORP_1] END DESC,
     CASE @OrderBy WHEN 'BTA_ACCT' THEN [SPMT_BTADetails].[BTA_ACCT] END,
     CASE @OrderBy WHEN 'BTA_ACCT DESC' THEN [SPMT_BTADetails].[BTA_ACCT] END DESC,
     CASE @OrderBy WHEN 'STMT_DT' THEN [SPMT_BTADetails].[STMT_DT] END,
     CASE @OrderBy WHEN 'STMT_DT DESC' THEN [SPMT_BTADetails].[STMT_DT] END DESC,
     CASE @OrderBy WHEN 'STMT_REF_NO' THEN [SPMT_BTADetails].[STMT_REF_NO] END,
     CASE @OrderBy WHEN 'STMT_REF_NO DESC' THEN [SPMT_BTADetails].[STMT_REF_NO] END DESC,
     CASE @OrderBy WHEN 'CUST_REF' THEN [SPMT_BTADetails].[CUST_REF] END,
     CASE @OrderBy WHEN 'CUST_REF DESC' THEN [SPMT_BTADetails].[CUST_REF] END DESC,
     CASE @OrderBy WHEN 'TRIP_REQ' THEN [SPMT_BTADetails].[TRIP_REQ] END,
     CASE @OrderBy WHEN 'TRIP_REQ DESC' THEN [SPMT_BTADetails].[TRIP_REQ] END DESC,
     CASE @OrderBy WHEN 'JOB_NO' THEN [SPMT_BTADetails].[JOB_NO] END,
     CASE @OrderBy WHEN 'JOB_NO DESC' THEN [SPMT_BTADetails].[JOB_NO] END DESC,
     CASE @OrderBy WHEN 'PAX_NM' THEN [SPMT_BTADetails].[PAX_NM] END,
     CASE @OrderBy WHEN 'PAX_NM DESC' THEN [SPMT_BTADetails].[PAX_NM] END DESC,
     CASE @OrderBy WHEN 'AMOUNT_EX_GST' THEN [SPMT_BTADetails].[AMOUNT_EX_GST] END,
     CASE @OrderBy WHEN 'AMOUNT_EX_GST DESC' THEN [SPMT_BTADetails].[AMOUNT_EX_GST] END DESC,
     CASE @OrderBy WHEN 'GST' THEN [SPMT_BTADetails].[GST] END,
     CASE @OrderBy WHEN 'GST DESC' THEN [SPMT_BTADetails].[GST] END DESC,
     CASE @OrderBy WHEN 'UNPAID_AMT' THEN [SPMT_BTADetails].[UNPAID_AMT] END,
     CASE @OrderBy WHEN 'UNPAID_AMT DESC' THEN [SPMT_BTADetails].[UNPAID_AMT] END DESC,
     CASE @OrderBy WHEN 'CHARGE_DTE' THEN [SPMT_BTADetails].[CHARGE_DTE] END,
     CASE @OrderBy WHEN 'CHARGE_DTE DESC' THEN [SPMT_BTADetails].[CHARGE_DTE] END DESC,
     CASE @OrderBy WHEN 'BKNG_DATE' THEN [SPMT_BTADetails].[BKNG_DATE] END,
     CASE @OrderBy WHEN 'BKNG_DATE DESC' THEN [SPMT_BTADetails].[BKNG_DATE] END DESC,
     CASE @OrderBy WHEN 'DEPT_DATE' THEN [SPMT_BTADetails].[DEPT_DATE] END,
     CASE @OrderBy WHEN 'DEPT_DATE DESC' THEN [SPMT_BTADetails].[DEPT_DATE] END DESC,
     CASE @OrderBy WHEN 'TICKET_NO' THEN [SPMT_BTADetails].[TICKET_NO] END,
     CASE @OrderBy WHEN 'TICKET_NO DESC' THEN [SPMT_BTADetails].[TICKET_NO] END DESC,
     CASE @OrderBy WHEN 'CARRIER' THEN [SPMT_BTADetails].[CARRIER] END,
     CASE @OrderBy WHEN 'CARRIER DESC' THEN [SPMT_BTADetails].[CARRIER] END DESC,
     CASE @OrderBy WHEN 'CLASS' THEN [SPMT_BTADetails].[CLASS] END,
     CASE @OrderBy WHEN 'CLASS DESC' THEN [SPMT_BTADetails].[CLASS] END DESC,
     CASE @OrderBy WHEN 'DI' THEN [SPMT_BTADetails].[DI] END,
     CASE @OrderBy WHEN 'DI DESC' THEN [SPMT_BTADetails].[DI] END DESC,
     CASE @OrderBy WHEN 'ROUTING' THEN [SPMT_BTADetails].[ROUTING] END,
     CASE @OrderBy WHEN 'ROUTING DESC' THEN [SPMT_BTADetails].[ROUTING] END DESC,
     CASE @OrderBy WHEN 'TXN_DATE' THEN [SPMT_BTADetails].[TXN_DATE] END,
     CASE @OrderBy WHEN 'TXN_DATE DESC' THEN [SPMT_BTADetails].[TXN_DATE] END DESC,
     CASE @OrderBy WHEN 'Merchant_ABN' THEN [SPMT_BTADetails].[Merchant_ABN] END,
     CASE @OrderBy WHEN 'Merchant_ABN DESC' THEN [SPMT_BTADetails].[Merchant_ABN] END DESC,
     CASE @OrderBy WHEN 'Book_Ref' THEN [SPMT_BTADetails].[Book_Ref] END,
     CASE @OrderBy WHEN 'Book_Ref DESC' THEN [SPMT_BTADetails].[Book_Ref] END DESC,
     CASE @OrderBy WHEN 'COMMENT1' THEN [SPMT_BTADetails].[COMMENT1] END,
     CASE @OrderBy WHEN 'COMMENT1 DESC' THEN [SPMT_BTADetails].[COMMENT1] END DESC,
     CASE @OrderBy WHEN 'COMMENT2' THEN [SPMT_BTADetails].[COMMENT2] END,
     CASE @OrderBy WHEN 'COMMENT2 DESC' THEN [SPMT_BTADetails].[COMMENT2] END DESC,
     CASE @OrderBy WHEN 'COMMENT3' THEN [SPMT_BTADetails].[COMMENT3] END,
     CASE @OrderBy WHEN 'COMMENT3 DESC' THEN [SPMT_BTADetails].[COMMENT3] END DESC,
     CASE @OrderBy WHEN 'MERCHANT_NAME' THEN [SPMT_BTADetails].[MERCHANT_NAME] END,
     CASE @OrderBy WHEN 'MERCHANT_NAME DESC' THEN [SPMT_BTADetails].[MERCHANT_NAME] END DESC,
     CASE @OrderBy WHEN 'BatchNo' THEN [SPMT_BTADetails].[BatchNo] END,
     CASE @OrderBy WHEN 'BatchNo DESC' THEN [SPMT_BTADetails].[BatchNo] END DESC,
     CASE @OrderBy WHEN 'StatusID' THEN [SPMT_BTADetails].[StatusID] END,
     CASE @OrderBy WHEN 'StatusID DESC' THEN [SPMT_BTADetails].[StatusID] END DESC,
     CASE @OrderBy WHEN 'CreatedBy' THEN [SPMT_BTADetails].[CreatedBy] END,
     CASE @OrderBy WHEN 'CreatedBy DESC' THEN [SPMT_BTADetails].[CreatedBy] END DESC,
     CASE @OrderBy WHEN 'CreatedOn' THEN [SPMT_BTADetails].[CreatedOn] END,
     CASE @OrderBy WHEN 'CreatedOn DESC' THEN [SPMT_BTADetails].[CreatedOn] END DESC,
     CASE @OrderBy WHEN 'aspnet_Users1_UserFullName' THEN [aspnet_Users1].[UserFullName] END,
     CASE @OrderBy WHEN 'aspnet_Users1_UserFullName DESC' THEN [aspnet_Users1].[UserFullName] END DESC,
     CASE @OrderBy WHEN 'SPMT_BTAStatus2_Descriptions' THEN [SPMT_BTAStatus2].[Descriptions] END,
     CASE @OrderBy WHEN 'SPMT_BTAStatus2_Descriptions DESC' THEN [SPMT_BTAStatus2].[Descriptions] END DESC 

    SET @RecordCount = @@RowCount

  SELECT
    [SPMT_BTADetails].* ,
    [aspnet_Users1].[UserFullName] AS aspnet_Users1_UserFullName,
    [SPMT_BTAStatus2].[Descriptions] AS SPMT_BTAStatus2_Descriptions 
  FROM [SPMT_BTADetails] 
      INNER JOIN #PageIndex
          ON [SPMT_BTADetails].[SerialNo] = #PageIndex.SerialNo
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [SPMT_BTADetails].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [SPMT_BTAStatus] AS [SPMT_BTAStatus2]
    ON [SPMT_BTADetails].[StatusID] = [SPMT_BTAStatus2].[StatusID]
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtBTADetailsSelectListFilteres]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtBTADetailsSelectListFilteres]
GO
 
CREATE PROCEDURE [dbo].[spspmtBTADetailsSelectListFilteres]
  @LoginID NVarChar(8),
  @StartRowIndex int,
  @MaximumRows int,
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  BEGIN
  DECLARE @LGSQL VarChar(8000)
  CREATE TABLE #PageIndex (
  IndexID INT IDENTITY (1, 1) NOT NULL
 ,SerialNo Int NOT NULL
  )
  SET @LGSQL = 'INSERT INTO #PageIndex (' 
  SET @LGSQL = @LGSQL + 'SerialNo'
  SET @LGSQL = @LGSQL + ')'
  SET @LGSQL = @LGSQL + ' SELECT '
  SET @LGSQL = @LGSQL + '[SPMT_BTADetails].[SerialNo]'
  SET @LGSQL = @LGSQL + ' FROM [SPMT_BTADetails] '
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_BTADetails].[CreatedBy] = [aspnet_users1].[LoginID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [SPMT_BTAStatus] AS [SPMT_BTAStatus2]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_BTADetails].[StatusID] = [SPMT_BTAStatus2].[StatusID]'
  SET @LGSQL = @LGSQL + '  WHERE 1 = 1 '
  SET @LGSQL = @LGSQL + '  ORDER BY '
  SET @LGSQL = @LGSQL + CASE @OrderBy
                        WHEN 'SerialNo' THEN '[SPMT_BTADetails].[SerialNo]'
                        WHEN 'SerialNo DESC' THEN '[SPMT_BTADetails].[SerialNo] DESC'
                        WHEN 'CORP_2' THEN '[SPMT_BTADetails].[CORP_2]'
                        WHEN 'CORP_2 DESC' THEN '[SPMT_BTADetails].[CORP_2] DESC'
                        WHEN 'CORP_1' THEN '[SPMT_BTADetails].[CORP_1]'
                        WHEN 'CORP_1 DESC' THEN '[SPMT_BTADetails].[CORP_1] DESC'
                        WHEN 'BTA_ACCT' THEN '[SPMT_BTADetails].[BTA_ACCT]'
                        WHEN 'BTA_ACCT DESC' THEN '[SPMT_BTADetails].[BTA_ACCT] DESC'
                        WHEN 'STMT_DT' THEN '[SPMT_BTADetails].[STMT_DT]'
                        WHEN 'STMT_DT DESC' THEN '[SPMT_BTADetails].[STMT_DT] DESC'
                        WHEN 'STMT_REF_NO' THEN '[SPMT_BTADetails].[STMT_REF_NO]'
                        WHEN 'STMT_REF_NO DESC' THEN '[SPMT_BTADetails].[STMT_REF_NO] DESC'
                        WHEN 'CUST_REF' THEN '[SPMT_BTADetails].[CUST_REF]'
                        WHEN 'CUST_REF DESC' THEN '[SPMT_BTADetails].[CUST_REF] DESC'
                        WHEN 'TRIP_REQ' THEN '[SPMT_BTADetails].[TRIP_REQ]'
                        WHEN 'TRIP_REQ DESC' THEN '[SPMT_BTADetails].[TRIP_REQ] DESC'
                        WHEN 'JOB_NO' THEN '[SPMT_BTADetails].[JOB_NO]'
                        WHEN 'JOB_NO DESC' THEN '[SPMT_BTADetails].[JOB_NO] DESC'
                        WHEN 'PAX_NM' THEN '[SPMT_BTADetails].[PAX_NM]'
                        WHEN 'PAX_NM DESC' THEN '[SPMT_BTADetails].[PAX_NM] DESC'
                        WHEN 'AMOUNT_EX_GST' THEN '[SPMT_BTADetails].[AMOUNT_EX_GST]'
                        WHEN 'AMOUNT_EX_GST DESC' THEN '[SPMT_BTADetails].[AMOUNT_EX_GST] DESC'
                        WHEN 'GST' THEN '[SPMT_BTADetails].[GST]'
                        WHEN 'GST DESC' THEN '[SPMT_BTADetails].[GST] DESC'
                        WHEN 'UNPAID_AMT' THEN '[SPMT_BTADetails].[UNPAID_AMT]'
                        WHEN 'UNPAID_AMT DESC' THEN '[SPMT_BTADetails].[UNPAID_AMT] DESC'
                        WHEN 'CHARGE_DTE' THEN '[SPMT_BTADetails].[CHARGE_DTE]'
                        WHEN 'CHARGE_DTE DESC' THEN '[SPMT_BTADetails].[CHARGE_DTE] DESC'
                        WHEN 'BKNG_DATE' THEN '[SPMT_BTADetails].[BKNG_DATE]'
                        WHEN 'BKNG_DATE DESC' THEN '[SPMT_BTADetails].[BKNG_DATE] DESC'
                        WHEN 'DEPT_DATE' THEN '[SPMT_BTADetails].[DEPT_DATE]'
                        WHEN 'DEPT_DATE DESC' THEN '[SPMT_BTADetails].[DEPT_DATE] DESC'
                        WHEN 'TICKET_NO' THEN '[SPMT_BTADetails].[TICKET_NO]'
                        WHEN 'TICKET_NO DESC' THEN '[SPMT_BTADetails].[TICKET_NO] DESC'
                        WHEN 'CARRIER' THEN '[SPMT_BTADetails].[CARRIER]'
                        WHEN 'CARRIER DESC' THEN '[SPMT_BTADetails].[CARRIER] DESC'
                        WHEN 'CLASS' THEN '[SPMT_BTADetails].[CLASS]'
                        WHEN 'CLASS DESC' THEN '[SPMT_BTADetails].[CLASS] DESC'
                        WHEN 'DI' THEN '[SPMT_BTADetails].[DI]'
                        WHEN 'DI DESC' THEN '[SPMT_BTADetails].[DI] DESC'
                        WHEN 'ROUTING' THEN '[SPMT_BTADetails].[ROUTING]'
                        WHEN 'ROUTING DESC' THEN '[SPMT_BTADetails].[ROUTING] DESC'
                        WHEN 'TXN_DATE' THEN '[SPMT_BTADetails].[TXN_DATE]'
                        WHEN 'TXN_DATE DESC' THEN '[SPMT_BTADetails].[TXN_DATE] DESC'
                        WHEN 'Merchant_ABN' THEN '[SPMT_BTADetails].[Merchant_ABN]'
                        WHEN 'Merchant_ABN DESC' THEN '[SPMT_BTADetails].[Merchant_ABN] DESC'
                        WHEN 'Book_Ref' THEN '[SPMT_BTADetails].[Book_Ref]'
                        WHEN 'Book_Ref DESC' THEN '[SPMT_BTADetails].[Book_Ref] DESC'
                        WHEN 'COMMENT1' THEN '[SPMT_BTADetails].[COMMENT1]'
                        WHEN 'COMMENT1 DESC' THEN '[SPMT_BTADetails].[COMMENT1] DESC'
                        WHEN 'COMMENT2' THEN '[SPMT_BTADetails].[COMMENT2]'
                        WHEN 'COMMENT2 DESC' THEN '[SPMT_BTADetails].[COMMENT2] DESC'
                        WHEN 'COMMENT3' THEN '[SPMT_BTADetails].[COMMENT3]'
                        WHEN 'COMMENT3 DESC' THEN '[SPMT_BTADetails].[COMMENT3] DESC'
                        WHEN 'MERCHANT_NAME' THEN '[SPMT_BTADetails].[MERCHANT_NAME]'
                        WHEN 'MERCHANT_NAME DESC' THEN '[SPMT_BTADetails].[MERCHANT_NAME] DESC'
                        WHEN 'BatchNo' THEN '[SPMT_BTADetails].[BatchNo]'
                        WHEN 'BatchNo DESC' THEN '[SPMT_BTADetails].[BatchNo] DESC'
                        WHEN 'StatusID' THEN '[SPMT_BTADetails].[StatusID]'
                        WHEN 'StatusID DESC' THEN '[SPMT_BTADetails].[StatusID] DESC'
                        WHEN 'CreatedBy' THEN '[SPMT_BTADetails].[CreatedBy]'
                        WHEN 'CreatedBy DESC' THEN '[SPMT_BTADetails].[CreatedBy] DESC'
                        WHEN 'CreatedOn' THEN '[SPMT_BTADetails].[CreatedOn]'
                        WHEN 'CreatedOn DESC' THEN '[SPMT_BTADetails].[CreatedOn] DESC'
                        WHEN 'aspnet_Users1_UserFullName' THEN '[aspnet_Users1].[UserFullName]'
                        WHEN 'aspnet_Users1_UserFullName DESC' THEN '[aspnet_Users1].[UserFullName] DESC'
                        WHEN 'SPMT_BTAStatus2_Descriptions' THEN '[SPMT_BTAStatus2].[Descriptions]'
                        WHEN 'SPMT_BTAStatus2_Descriptions DESC' THEN '[SPMT_BTAStatus2].[Descriptions] DESC'
                        ELSE '[SPMT_BTADetails].[SerialNo]'
                    END
  EXEC (@LGSQL)

  SET @RecordCount = @@RowCount

  SELECT
    [SPMT_BTADetails].* ,
    [aspnet_Users1].[UserFullName] AS aspnet_Users1_UserFullName,
    [SPMT_BTAStatus2].[Descriptions] AS SPMT_BTAStatus2_Descriptions 
  FROM [SPMT_BTADetails] 
      INNER JOIN #PageIndex
          ON [SPMT_BTADetails].[SerialNo] = #PageIndex.SerialNo
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [SPMT_BTADetails].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [SPMT_BTAStatus] AS [SPMT_BTAStatus2]
    ON [SPMT_BTADetails].[StatusID] = [SPMT_BTAStatus2].[StatusID]
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtBTADetailsInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtBTADetailsInsert]
GO
 
CREATE PROCEDURE [dbo].[spspmtBTADetailsInsert]
  @CORP_2 NVarChar(15),
  @CORP_1 NVarChar(15),
  @BTA_ACCT NVarChar(15),
  @STMT_DT DateTime,
  @STMT_REF_NO NVarChar(15),
  @CUST_REF NVarChar(20),
  @TRIP_REQ NVarChar(20),
  @JOB_NO NVarChar(20),
  @PAX_NM NVarChar(30),
  @AMOUNT_EX_GST Decimal(18,2),
  @GST Decimal(18,2),
  @UNPAID_AMT Decimal(18,2),
  @CHARGE_DTE DateTime,
  @BKNG_DATE DateTime,
  @DEPT_DATE DateTime,
  @TICKET_NO NVarChar(10),
  @CARRIER NVarChar(30),
  @CLASS NVarChar(10),
  @DI NVarChar(2),
  @ROUTING NVarChar(80),
  @TXN_DATE DateTime,
  @Merchant_ABN NVarChar(16),
  @Book_Ref NVarChar(9),
  @COMMENT1 NVarChar(45),
  @COMMENT2 NVarChar(45),
  @COMMENT3 NVarChar(450),
  @MERCHANT_NAME NVarChar(31),
  @BatchNo Int,
  @StatusID Int,
  @CreatedBy NVarChar(8),
  @CreatedOn DateTime,
  @Return_SerialNo Int = null OUTPUT 
  AS
  INSERT [SPMT_BTADetails]
  (
   [CORP_2]
  ,[CORP_1]
  ,[BTA_ACCT]
  ,[STMT_DT]
  ,[STMT_REF_NO]
  ,[CUST_REF]
  ,[TRIP_REQ]
  ,[JOB_NO]
  ,[PAX_NM]
  ,[AMOUNT_EX_GST]
  ,[GST]
  ,[UNPAID_AMT]
  ,[CHARGE_DTE]
  ,[BKNG_DATE]
  ,[DEPT_DATE]
  ,[TICKET_NO]
  ,[CARRIER]
  ,[CLASS]
  ,[DI]
  ,[ROUTING]
  ,[TXN_DATE]
  ,[Merchant_ABN]
  ,[Book_Ref]
  ,[COMMENT1]
  ,[COMMENT2]
  ,[COMMENT3]
  ,[MERCHANT_NAME]
  ,[BatchNo]
  ,[StatusID]
  ,[CreatedBy]
  ,[CreatedOn]
  )
  VALUES
  (
   @CORP_2
  ,@CORP_1
  ,@BTA_ACCT
  ,@STMT_DT
  ,@STMT_REF_NO
  ,@CUST_REF
  ,@TRIP_REQ
  ,@JOB_NO
  ,@PAX_NM
  ,@AMOUNT_EX_GST
  ,@GST
  ,@UNPAID_AMT
  ,@CHARGE_DTE
  ,@BKNG_DATE
  ,@DEPT_DATE
  ,@TICKET_NO
  ,@CARRIER
  ,@CLASS
  ,@DI
  ,@ROUTING
  ,@TXN_DATE
  ,@Merchant_ABN
  ,@Book_Ref
  ,@COMMENT1
  ,@COMMENT2
  ,@COMMENT3
  ,@MERCHANT_NAME
  ,@BatchNo
  ,@StatusID
  ,@CreatedBy
  ,@CreatedOn
  )
  SET @Return_SerialNo = Scope_Identity()
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtBTADetailsUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtBTADetailsUpdate]
GO
 
CREATE PROCEDURE [dbo].[spspmtBTADetailsUpdate]
  @Original_SerialNo Int, 
  @CORP_2 NVarChar(15),
  @CORP_1 NVarChar(15),
  @BTA_ACCT NVarChar(15),
  @STMT_DT DateTime,
  @STMT_REF_NO NVarChar(15),
  @CUST_REF NVarChar(20),
  @TRIP_REQ NVarChar(20),
  @JOB_NO NVarChar(20),
  @PAX_NM NVarChar(30),
  @AMOUNT_EX_GST Decimal(18,2),
  @GST Decimal(18,2),
  @UNPAID_AMT Decimal(18,2),
  @CHARGE_DTE DateTime,
  @BKNG_DATE DateTime,
  @DEPT_DATE DateTime,
  @TICKET_NO NVarChar(10),
  @CARRIER NVarChar(30),
  @CLASS NVarChar(10),
  @DI NVarChar(2),
  @ROUTING NVarChar(80),
  @TXN_DATE DateTime,
  @Merchant_ABN NVarChar(16),
  @Book_Ref NVarChar(9),
  @COMMENT1 NVarChar(45),
  @COMMENT2 NVarChar(45),
  @COMMENT3 NVarChar(450),
  @MERCHANT_NAME NVarChar(31),
  @BatchNo Int,
  @StatusID Int,
  @CreatedBy NVarChar(8),
  @CreatedOn DateTime,
  @RowCount int = null OUTPUT
  AS
  UPDATE [SPMT_BTADetails] SET 
   [CORP_2] = @CORP_2
  ,[CORP_1] = @CORP_1
  ,[BTA_ACCT] = @BTA_ACCT
  ,[STMT_DT] = @STMT_DT
  ,[STMT_REF_NO] = @STMT_REF_NO
  ,[CUST_REF] = @CUST_REF
  ,[TRIP_REQ] = @TRIP_REQ
  ,[JOB_NO] = @JOB_NO
  ,[PAX_NM] = @PAX_NM
  ,[AMOUNT_EX_GST] = @AMOUNT_EX_GST
  ,[GST] = @GST
  ,[UNPAID_AMT] = @UNPAID_AMT
  ,[CHARGE_DTE] = @CHARGE_DTE
  ,[BKNG_DATE] = @BKNG_DATE
  ,[DEPT_DATE] = @DEPT_DATE
  ,[TICKET_NO] = @TICKET_NO
  ,[CARRIER] = @CARRIER
  ,[CLASS] = @CLASS
  ,[DI] = @DI
  ,[ROUTING] = @ROUTING
  ,[TXN_DATE] = @TXN_DATE
  ,[Merchant_ABN] = @Merchant_ABN
  ,[Book_Ref] = @Book_Ref
  ,[COMMENT1] = @COMMENT1
  ,[COMMENT2] = @COMMENT2
  ,[COMMENT3] = @COMMENT3
  ,[MERCHANT_NAME] = @MERCHANT_NAME
  ,[BatchNo] = @BatchNo
  ,[StatusID] = @StatusID
  ,[CreatedBy] = @CreatedBy
  ,[CreatedOn] = @CreatedOn
  WHERE
  [SerialNo] = @Original_SerialNo
  SET @RowCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtBTADetailsDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtBTADetailsDelete]
GO
 
CREATE PROCEDURE [dbo].[spspmtBTADetailsDelete]
  @Original_SerialNo Int,
  @RowCount int = null OUTPUT
  AS
  DELETE [SPMT_BTADetails]
  WHERE
  [SPMT_BTADetails].[SerialNo] = @Original_SerialNo
  SET @RowCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtBTAStatusSelectList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtBTAStatusSelectList]
GO
 
CREATE PROCEDURE [dbo].[spspmtBTAStatusSelectList]
  @LoginID NVarChar(8),
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  SELECT
    [SPMT_BTAStatus].*  
  FROM [SPMT_BTAStatus] 
  WHERE 1 = 1  
  ORDER BY
     CASE @OrderBy WHEN 'StatusID' THEN [SPMT_BTAStatus].[StatusID] END,
     CASE @OrderBy WHEN 'StatusID DESC' THEN [SPMT_BTAStatus].[StatusID] END DESC,
     CASE @OrderBy WHEN 'Descriptions' THEN [SPMT_BTAStatus].[Descriptions] END,
     CASE @OrderBy WHEN 'Descriptions DESC' THEN [SPMT_BTAStatus].[Descriptions] END DESC 
  SET @RecordCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtBTAStatusAutoCompleteList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtBTAStatusAutoCompleteList]
GO
 
CREATE PROCEDURE [dbo].[spspmtBTAStatusAutoCompleteList]
  @LoginID NVarChar(8),
  @Prefix NVarChar(250),
  @Records Int,
  @ByCode Int 
  AS 
  BEGIN 
  DECLARE @Prefix1 VarChar(260)
  SET @Prefix1 = LOWER(@Prefix) + '%'
  DECLARE @LGSQL VarChar(8000)
  SET @LGSQL = 'SELECT TOP (' + STR(@Records) + ') ' 
  SET @LGSQL = @LGSQL + ' [SPMT_BTAStatus].[Descriptions]' 
  SET @LGSQL = @LGSQL + ',[SPMT_BTAStatus].[StatusID]' 
  SET @LGSQL = @LGSQL + ' FROM [SPMT_BTAStatus] ' 
  SET @LGSQL = @LGSQL + ' WHERE 1 = 1 ' 
  SET @LGSQL = @LGSQL + ' AND (LTRIM(STR(ISNULL([SPMT_BTAStatus].[StatusID],0))) LIKE ''' + @Prefix1 + ''''
  SET @LGSQL = @LGSQL + ' OR LOWER(ISNULL([SPMT_BTAStatus].[Descriptions],'''')) LIKE ''' + @Prefix1 + ''''
  SET @LGSQL = @LGSQL + ')' 
  
  EXEC (@LGSQL)
  END 
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtBTAStatusSelectByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtBTAStatusSelectByID]
GO
 
CREATE PROCEDURE [dbo].[spspmtBTAStatusSelectByID]
  @LoginID NVarChar(8),
  @StatusID Int 
  AS
  SELECT
    [SPMT_BTAStatus].*  
  FROM [SPMT_BTAStatus] 
  WHERE
  [SPMT_BTAStatus].[StatusID] = @StatusID
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtBTAStatusSelectListSearch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtBTAStatusSelectListSearch]
GO
 
CREATE PROCEDURE [dbo].[spspmtBTAStatusSelectListSearch]
  @LoginID NVarChar(8),
  @StartRowIndex int,
  @MaximumRows int,
  @KeyWord VarChar(250),
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  BEGIN
    DECLARE @KeyWord1 VarChar(260)
    SET @KeyWord1 = '%' + LOWER(@KeyWord) + '%'
  CREATE TABLE #PageIndex (
  IndexID INT IDENTITY (1, 1) NOT NULL
 ,StatusID Int NOT NULL
  )
  INSERT INTO #PageIndex (StatusID)
  SELECT [SPMT_BTAStatus].[StatusID] FROM [SPMT_BTAStatus]
 WHERE  
   ( 
         STR(ISNULL([SPMT_BTAStatus].[StatusID], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_BTAStatus].[Descriptions],'')) LIKE @KeyWord1
   ) 
  ORDER BY
     CASE @OrderBy WHEN 'StatusID' THEN [SPMT_BTAStatus].[StatusID] END,
     CASE @OrderBy WHEN 'StatusID DESC' THEN [SPMT_BTAStatus].[StatusID] END DESC,
     CASE @OrderBy WHEN 'Descriptions' THEN [SPMT_BTAStatus].[Descriptions] END,
     CASE @OrderBy WHEN 'Descriptions DESC' THEN [SPMT_BTAStatus].[Descriptions] END DESC 

    SET @RecordCount = @@RowCount

  SELECT
    [SPMT_BTAStatus].*  
  FROM [SPMT_BTAStatus] 
      INNER JOIN #PageIndex
          ON [SPMT_BTAStatus].[StatusID] = #PageIndex.StatusID
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtBTAStatusSelectListFilteres]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtBTAStatusSelectListFilteres]
GO
 
CREATE PROCEDURE [dbo].[spspmtBTAStatusSelectListFilteres]
  @LoginID NVarChar(8),
  @StartRowIndex int,
  @MaximumRows int,
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  BEGIN
  DECLARE @LGSQL VarChar(8000)
  CREATE TABLE #PageIndex (
  IndexID INT IDENTITY (1, 1) NOT NULL
 ,StatusID Int NOT NULL
  )
  SET @LGSQL = 'INSERT INTO #PageIndex (' 
  SET @LGSQL = @LGSQL + 'StatusID'
  SET @LGSQL = @LGSQL + ')'
  SET @LGSQL = @LGSQL + ' SELECT '
  SET @LGSQL = @LGSQL + '[SPMT_BTAStatus].[StatusID]'
  SET @LGSQL = @LGSQL + ' FROM [SPMT_BTAStatus] '
  SET @LGSQL = @LGSQL + '  WHERE 1 = 1 '
  SET @LGSQL = @LGSQL + '  ORDER BY '
  SET @LGSQL = @LGSQL + CASE @OrderBy
                        WHEN 'StatusID' THEN '[SPMT_BTAStatus].[StatusID]'
                        WHEN 'StatusID DESC' THEN '[SPMT_BTAStatus].[StatusID] DESC'
                        WHEN 'Descriptions' THEN '[SPMT_BTAStatus].[Descriptions]'
                        WHEN 'Descriptions DESC' THEN '[SPMT_BTAStatus].[Descriptions] DESC'
                        ELSE '[SPMT_BTAStatus].[StatusID]'
                    END
  EXEC (@LGSQL)

  SET @RecordCount = @@RowCount

  SELECT
    [SPMT_BTAStatus].*  
  FROM [SPMT_BTAStatus] 
      INNER JOIN #PageIndex
          ON [SPMT_BTAStatus].[StatusID] = #PageIndex.StatusID
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

SET QUOTED_IDENTIFIER OFF
GO
SET ANSI_NULLS ON
GO
