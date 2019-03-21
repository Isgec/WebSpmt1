SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spSPMTerpDCIPendingSelectListSearch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spSPMTerpDCIPendingSelectListSearch]
GO
 
CREATE PROCEDURE [dbo].[spSPMTerpDCIPendingSelectListSearch]
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
 ,ChallanID NVarChar(20) NOT NULL
 ,SerialNo Int NOT NULL
  )
  INSERT INTO #PageIndex (ChallanID, SerialNo)
  SELECT [SPMT_erpDCInventory].[ChallanID], [SPMT_erpDCInventory].[SerialNo] FROM [SPMT_erpDCInventory]
  LEFT OUTER JOIN [IDM_Projects] AS [IDM_Projects1]
    ON [SPMT_erpDCInventory].[ProjectID] = [IDM_Projects1].[ProjectID]
  LEFT OUTER JOIN [SPMT_BillTypes] AS [SPMT_BillTypes2]
    ON [SPMT_erpDCInventory].[BillTypeID] = [SPMT_BillTypes2].[BillType]
  INNER JOIN [SPMT_erpDCH] AS [SPMT_erpDCH3]
    ON [SPMT_erpDCInventory].[ChallanID] = [SPMT_erpDCH3].[ChallanID]
  LEFT OUTER JOIN [SPMT_ERPStates] AS [SPMT_ERPStates4]
    ON [SPMT_erpDCInventory].[ConsignerStateID] = [SPMT_ERPStates4].[StateID]
  LEFT OUTER JOIN [SPMT_ERPUnits] AS [SPMT_ERPUnits5]
    ON [SPMT_erpDCInventory].[UOM] = [SPMT_ERPUnits5].[UOM]
  LEFT OUTER JOIN [SPMT_HSNSACCodes] AS [SPMT_HSNSACCodes6]
    ON [SPMT_erpDCInventory].[BillTypeID] = [SPMT_HSNSACCodes6].[BillType]
    AND [SPMT_erpDCInventory].[HSNSACCode] = [SPMT_HSNSACCodes6].[HSNSACCode]
  LEFT OUTER JOIN [SPMT_IsgecGSTIN] AS [SPMT_IsgecGSTIN7]
    ON [SPMT_erpDCInventory].[ConsignerIsgecID] = [SPMT_IsgecGSTIN7].[GSTID]
  LEFT OUTER JOIN [VR_BPGSTIN] AS [VR_BPGSTIN8]
    ON [SPMT_erpDCInventory].[ConsignerBPID] = [VR_BPGSTIN8].[BPID]
    AND [SPMT_erpDCInventory].[ConsignerGSTIN] = [VR_BPGSTIN8].[GSTIN]
  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner9]
    ON [SPMT_erpDCInventory].[ConsignerBPID] = [VR_BusinessPartner9].[BPID]
  INNER JOIN [SPMT_erpDCD] AS [SPMT_erpDCD10]
    ON [SPMT_erpDCInventory].[ChallanID] = [SPMT_erpDCD10].[ChallanID]
    AND [SPMT_erpDCInventory].[SerialNo] = [SPMT_erpDCD10].[SerialNo]
 WHERE  
   ( 
         LOWER(ISNULL([SPMT_erpDCInventory].[ChallanID],'')) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[SerialNo], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_erpDCInventory].[ItemDescription],'')) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[BaseRate], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[BillTypeID], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_erpDCInventory].[HSNSACCode],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_erpDCInventory].[UOM],'')) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[Quantity], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[Price], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[AssessableValue], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[IGSTRate], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[IGSTAmount], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[SGSTRate], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[SGSTAmount], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[CGSTRate], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[CGSTAmount], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[CessRate], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[CessAmount], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[TotalGST], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[TotalAmount], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[FinalRate], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[FinalAmount], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[ConsignerIsgecID], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_erpDCInventory].[ConsignerBPID],'')) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[ConsignerGSTIN], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_erpDCInventory].[ConsignerName],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_erpDCInventory].[ConsignerGSTINNo],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_erpDCInventory].[ConsignerStateID],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_erpDCInventory].[ProjectID],'')) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_erpDCInventory].[QuantityUsed], 0)) LIKE @KeyWord1
   ) 
  ORDER BY
     CASE @OrderBy WHEN 'ChallanID' THEN [SPMT_erpDCInventory].[ChallanID] END,
     CASE @OrderBy WHEN 'ChallanID DESC' THEN [SPMT_erpDCInventory].[ChallanID] END DESC,
     CASE @OrderBy WHEN 'SerialNo' THEN [SPMT_erpDCInventory].[SerialNo] END,
     CASE @OrderBy WHEN 'SerialNo DESC' THEN [SPMT_erpDCInventory].[SerialNo] END DESC,
     CASE @OrderBy WHEN 'ItemDescription' THEN [SPMT_erpDCInventory].[ItemDescription] END,
     CASE @OrderBy WHEN 'ItemDescription DESC' THEN [SPMT_erpDCInventory].[ItemDescription] END DESC,
     CASE @OrderBy WHEN 'BaseRate' THEN [SPMT_erpDCInventory].[BaseRate] END,
     CASE @OrderBy WHEN 'BaseRate DESC' THEN [SPMT_erpDCInventory].[BaseRate] END DESC,
     CASE @OrderBy WHEN 'BillTypeID' THEN [SPMT_erpDCInventory].[BillTypeID] END,
     CASE @OrderBy WHEN 'BillTypeID DESC' THEN [SPMT_erpDCInventory].[BillTypeID] END DESC,
     CASE @OrderBy WHEN 'HSNSACCode' THEN [SPMT_erpDCInventory].[HSNSACCode] END,
     CASE @OrderBy WHEN 'HSNSACCode DESC' THEN [SPMT_erpDCInventory].[HSNSACCode] END DESC,
     CASE @OrderBy WHEN 'UOM' THEN [SPMT_erpDCInventory].[UOM] END,
     CASE @OrderBy WHEN 'UOM DESC' THEN [SPMT_erpDCInventory].[UOM] END DESC,
     CASE @OrderBy WHEN 'Quantity' THEN [SPMT_erpDCInventory].[Quantity] END,
     CASE @OrderBy WHEN 'Quantity DESC' THEN [SPMT_erpDCInventory].[Quantity] END DESC,
     CASE @OrderBy WHEN 'Price' THEN [SPMT_erpDCInventory].[Price] END,
     CASE @OrderBy WHEN 'Price DESC' THEN [SPMT_erpDCInventory].[Price] END DESC,
     CASE @OrderBy WHEN 'AssessableValue' THEN [SPMT_erpDCInventory].[AssessableValue] END,
     CASE @OrderBy WHEN 'AssessableValue DESC' THEN [SPMT_erpDCInventory].[AssessableValue] END DESC,
     CASE @OrderBy WHEN 'IGSTRate' THEN [SPMT_erpDCInventory].[IGSTRate] END,
     CASE @OrderBy WHEN 'IGSTRate DESC' THEN [SPMT_erpDCInventory].[IGSTRate] END DESC,
     CASE @OrderBy WHEN 'IGSTAmount' THEN [SPMT_erpDCInventory].[IGSTAmount] END,
     CASE @OrderBy WHEN 'IGSTAmount DESC' THEN [SPMT_erpDCInventory].[IGSTAmount] END DESC,
     CASE @OrderBy WHEN 'SGSTRate' THEN [SPMT_erpDCInventory].[SGSTRate] END,
     CASE @OrderBy WHEN 'SGSTRate DESC' THEN [SPMT_erpDCInventory].[SGSTRate] END DESC,
     CASE @OrderBy WHEN 'SGSTAmount' THEN [SPMT_erpDCInventory].[SGSTAmount] END,
     CASE @OrderBy WHEN 'SGSTAmount DESC' THEN [SPMT_erpDCInventory].[SGSTAmount] END DESC,
     CASE @OrderBy WHEN 'CGSTRate' THEN [SPMT_erpDCInventory].[CGSTRate] END,
     CASE @OrderBy WHEN 'CGSTRate DESC' THEN [SPMT_erpDCInventory].[CGSTRate] END DESC,
     CASE @OrderBy WHEN 'CGSTAmount' THEN [SPMT_erpDCInventory].[CGSTAmount] END,
     CASE @OrderBy WHEN 'CGSTAmount DESC' THEN [SPMT_erpDCInventory].[CGSTAmount] END DESC,
     CASE @OrderBy WHEN 'CessRate' THEN [SPMT_erpDCInventory].[CessRate] END,
     CASE @OrderBy WHEN 'CessRate DESC' THEN [SPMT_erpDCInventory].[CessRate] END DESC,
     CASE @OrderBy WHEN 'CessAmount' THEN [SPMT_erpDCInventory].[CessAmount] END,
     CASE @OrderBy WHEN 'CessAmount DESC' THEN [SPMT_erpDCInventory].[CessAmount] END DESC,
     CASE @OrderBy WHEN 'TotalGST' THEN [SPMT_erpDCInventory].[TotalGST] END,
     CASE @OrderBy WHEN 'TotalGST DESC' THEN [SPMT_erpDCInventory].[TotalGST] END DESC,
     CASE @OrderBy WHEN 'TotalAmount' THEN [SPMT_erpDCInventory].[TotalAmount] END,
     CASE @OrderBy WHEN 'TotalAmount DESC' THEN [SPMT_erpDCInventory].[TotalAmount] END DESC,
     CASE @OrderBy WHEN 'FinalRate' THEN [SPMT_erpDCInventory].[FinalRate] END,
     CASE @OrderBy WHEN 'FinalRate DESC' THEN [SPMT_erpDCInventory].[FinalRate] END DESC,
     CASE @OrderBy WHEN 'FinalAmount' THEN [SPMT_erpDCInventory].[FinalAmount] END,
     CASE @OrderBy WHEN 'FinalAmount DESC' THEN [SPMT_erpDCInventory].[FinalAmount] END DESC,
     CASE @OrderBy WHEN 'ConsignerIsgecID' THEN [SPMT_erpDCInventory].[ConsignerIsgecID] END,
     CASE @OrderBy WHEN 'ConsignerIsgecID DESC' THEN [SPMT_erpDCInventory].[ConsignerIsgecID] END DESC,
     CASE @OrderBy WHEN 'ConsignerBPID' THEN [SPMT_erpDCInventory].[ConsignerBPID] END,
     CASE @OrderBy WHEN 'ConsignerBPID DESC' THEN [SPMT_erpDCInventory].[ConsignerBPID] END DESC,
     CASE @OrderBy WHEN 'ConsignerGSTIN' THEN [SPMT_erpDCInventory].[ConsignerGSTIN] END,
     CASE @OrderBy WHEN 'ConsignerGSTIN DESC' THEN [SPMT_erpDCInventory].[ConsignerGSTIN] END DESC,
     CASE @OrderBy WHEN 'ConsignerName' THEN [SPMT_erpDCInventory].[ConsignerName] END,
     CASE @OrderBy WHEN 'ConsignerName DESC' THEN [SPMT_erpDCInventory].[ConsignerName] END DESC,
     CASE @OrderBy WHEN 'ConsignerGSTINNo' THEN [SPMT_erpDCInventory].[ConsignerGSTINNo] END,
     CASE @OrderBy WHEN 'ConsignerGSTINNo DESC' THEN [SPMT_erpDCInventory].[ConsignerGSTINNo] END DESC,
     CASE @OrderBy WHEN 'ConsignerStateID' THEN [SPMT_erpDCInventory].[ConsignerStateID] END,
     CASE @OrderBy WHEN 'ConsignerStateID DESC' THEN [SPMT_erpDCInventory].[ConsignerStateID] END DESC,
     CASE @OrderBy WHEN 'ProjectID' THEN [SPMT_erpDCInventory].[ProjectID] END,
     CASE @OrderBy WHEN 'ProjectID DESC' THEN [SPMT_erpDCInventory].[ProjectID] END DESC,
     CASE @OrderBy WHEN 'QuantityUsed' THEN [SPMT_erpDCInventory].[QuantityUsed] END,
     CASE @OrderBy WHEN 'QuantityUsed DESC' THEN [SPMT_erpDCInventory].[QuantityUsed] END DESC,
     CASE @OrderBy WHEN 'IDM_Projects1_Description' THEN [IDM_Projects1].[Description] END,
     CASE @OrderBy WHEN 'IDM_Projects1_Description DESC' THEN [IDM_Projects1].[Description] END DESC,
     CASE @OrderBy WHEN 'SPMT_BillTypes2_Description' THEN [SPMT_BillTypes2].[Description] END,
     CASE @OrderBy WHEN 'SPMT_BillTypes2_Description DESC' THEN [SPMT_BillTypes2].[Description] END DESC,
     CASE @OrderBy WHEN 'SPMT_erpDCH3_PlaceOfDelivery' THEN [SPMT_erpDCH3].[PlaceOfDelivery] END,
     CASE @OrderBy WHEN 'SPMT_erpDCH3_PlaceOfDelivery DESC' THEN [SPMT_erpDCH3].[PlaceOfDelivery] END DESC,
     CASE @OrderBy WHEN 'SPMT_ERPStates4_Description' THEN [SPMT_ERPStates4].[Description] END,
     CASE @OrderBy WHEN 'SPMT_ERPStates4_Description DESC' THEN [SPMT_ERPStates4].[Description] END DESC,
     CASE @OrderBy WHEN 'SPMT_ERPUnits5_Description' THEN [SPMT_ERPUnits5].[Description] END,
     CASE @OrderBy WHEN 'SPMT_ERPUnits5_Description DESC' THEN [SPMT_ERPUnits5].[Description] END DESC,
     CASE @OrderBy WHEN 'SPMT_HSNSACCodes6_HSNSACCode' THEN [SPMT_HSNSACCodes6].[HSNSACCode] END,
     CASE @OrderBy WHEN 'SPMT_HSNSACCodes6_HSNSACCode DESC' THEN [SPMT_HSNSACCodes6].[HSNSACCode] END DESC,
     CASE @OrderBy WHEN 'SPMT_IsgecGSTIN7_Description' THEN [SPMT_IsgecGSTIN7].[Description] END,
     CASE @OrderBy WHEN 'SPMT_IsgecGSTIN7_Description DESC' THEN [SPMT_IsgecGSTIN7].[Description] END DESC,
     CASE @OrderBy WHEN 'VR_BPGSTIN8_Description' THEN [VR_BPGSTIN8].[Description] END,
     CASE @OrderBy WHEN 'VR_BPGSTIN8_Description DESC' THEN [VR_BPGSTIN8].[Description] END DESC,
     CASE @OrderBy WHEN 'VR_BusinessPartner9_BPName' THEN [VR_BusinessPartner9].[BPName] END,
     CASE @OrderBy WHEN 'VR_BusinessPartner9_BPName DESC' THEN [VR_BusinessPartner9].[BPName] END DESC,
     CASE @OrderBy WHEN 'SPMT_erpDCD10_ItemDescription' THEN [SPMT_erpDCD10].[ItemDescription] END,
     CASE @OrderBy WHEN 'SPMT_erpDCD10_ItemDescription DESC' THEN [SPMT_erpDCD10].[ItemDescription] END DESC 

    SET @RecordCount = @@RowCount

  SELECT
    [SPMT_erpDCInventory].* ,
    [IDM_Projects1].[Description] AS IDM_Projects1_Description,
    [SPMT_BillTypes2].[Description] AS SPMT_BillTypes2_Description,
    [SPMT_erpDCH3].[PlaceOfDelivery] AS SPMT_erpDCH3_PlaceOfDelivery,
    [SPMT_ERPStates4].[Description] AS SPMT_ERPStates4_Description,
    [SPMT_ERPUnits5].[Description] AS SPMT_ERPUnits5_Description,
    [SPMT_HSNSACCodes6].[HSNSACCode] AS SPMT_HSNSACCodes6_HSNSACCode,
    [SPMT_IsgecGSTIN7].[Description] AS SPMT_IsgecGSTIN7_Description,
    [VR_BPGSTIN8].[Description] AS VR_BPGSTIN8_Description,
    [VR_BusinessPartner9].[BPName] AS VR_BusinessPartner9_BPName,
    [SPMT_erpDCD10].[ItemDescription] AS SPMT_erpDCD10_ItemDescription 
  FROM [SPMT_erpDCInventory] 
      INNER JOIN #PageIndex
          ON [SPMT_erpDCInventory].[ChallanID] = #PageIndex.ChallanID
          AND [SPMT_erpDCInventory].[SerialNo] = #PageIndex.SerialNo
  LEFT OUTER JOIN [IDM_Projects] AS [IDM_Projects1]
    ON [SPMT_erpDCInventory].[ProjectID] = [IDM_Projects1].[ProjectID]
  LEFT OUTER JOIN [SPMT_BillTypes] AS [SPMT_BillTypes2]
    ON [SPMT_erpDCInventory].[BillTypeID] = [SPMT_BillTypes2].[BillType]
  INNER JOIN [SPMT_erpDCH] AS [SPMT_erpDCH3]
    ON [SPMT_erpDCInventory].[ChallanID] = [SPMT_erpDCH3].[ChallanID]
  LEFT OUTER JOIN [SPMT_ERPStates] AS [SPMT_ERPStates4]
    ON [SPMT_erpDCInventory].[ConsignerStateID] = [SPMT_ERPStates4].[StateID]
  LEFT OUTER JOIN [SPMT_ERPUnits] AS [SPMT_ERPUnits5]
    ON [SPMT_erpDCInventory].[UOM] = [SPMT_ERPUnits5].[UOM]
  LEFT OUTER JOIN [SPMT_HSNSACCodes] AS [SPMT_HSNSACCodes6]
    ON [SPMT_erpDCInventory].[BillTypeID] = [SPMT_HSNSACCodes6].[BillType]
    AND [SPMT_erpDCInventory].[HSNSACCode] = [SPMT_HSNSACCodes6].[HSNSACCode]
  LEFT OUTER JOIN [SPMT_IsgecGSTIN] AS [SPMT_IsgecGSTIN7]
    ON [SPMT_erpDCInventory].[ConsignerIsgecID] = [SPMT_IsgecGSTIN7].[GSTID]
  LEFT OUTER JOIN [VR_BPGSTIN] AS [VR_BPGSTIN8]
    ON [SPMT_erpDCInventory].[ConsignerBPID] = [VR_BPGSTIN8].[BPID]
    AND [SPMT_erpDCInventory].[ConsignerGSTIN] = [VR_BPGSTIN8].[GSTIN]
  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner9]
    ON [SPMT_erpDCInventory].[ConsignerBPID] = [VR_BusinessPartner9].[BPID]
  INNER JOIN [SPMT_erpDCD] AS [SPMT_erpDCD10]
    ON [SPMT_erpDCInventory].[ChallanID] = [SPMT_erpDCD10].[ChallanID]
    AND [SPMT_erpDCInventory].[SerialNo] = [SPMT_erpDCD10].[SerialNo]
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spSPMTerpDCIPendingSelectListFilteres]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spSPMTerpDCIPendingSelectListFilteres]
GO
 
CREATE PROCEDURE [dbo].[spSPMTerpDCIPendingSelectListFilteres]
  @Filter_ChallanID NVarChar(20),
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
 ,ChallanID NVarChar(20) NOT NULL
 ,SerialNo Int NOT NULL
  )
  SET @LGSQL = 'INSERT INTO #PageIndex (' 
  SET @LGSQL = @LGSQL + 'ChallanID'
  SET @LGSQL = @LGSQL + ', SerialNo'
  SET @LGSQL = @LGSQL + ')'
  SET @LGSQL = @LGSQL + ' SELECT '
  SET @LGSQL = @LGSQL + '[SPMT_erpDCInventory].[ChallanID]'
  SET @LGSQL = @LGSQL + ', [SPMT_erpDCInventory].[SerialNo]'
  SET @LGSQL = @LGSQL + ' FROM [SPMT_erpDCInventory] '
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [IDM_Projects] AS [IDM_Projects1]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_erpDCInventory].[ProjectID] = [IDM_Projects1].[ProjectID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [SPMT_BillTypes] AS [SPMT_BillTypes2]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_erpDCInventory].[BillTypeID] = [SPMT_BillTypes2].[BillType]'
  SET @LGSQL = @LGSQL + '  INNER JOIN [SPMT_erpDCH] AS [SPMT_erpDCH3]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_erpDCInventory].[ChallanID] = [SPMT_erpDCH3].[ChallanID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [SPMT_ERPStates] AS [SPMT_ERPStates4]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_erpDCInventory].[ConsignerStateID] = [SPMT_ERPStates4].[StateID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [SPMT_ERPUnits] AS [SPMT_ERPUnits5]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_erpDCInventory].[UOM] = [SPMT_ERPUnits5].[UOM]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [SPMT_HSNSACCodes] AS [SPMT_HSNSACCodes6]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_erpDCInventory].[BillTypeID] = [SPMT_HSNSACCodes6].[BillType]'
  SET @LGSQL = @LGSQL + '    AND [SPMT_erpDCInventory].[HSNSACCode] = [SPMT_HSNSACCodes6].[HSNSACCode]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [SPMT_IsgecGSTIN] AS [SPMT_IsgecGSTIN7]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_erpDCInventory].[ConsignerIsgecID] = [SPMT_IsgecGSTIN7].[GSTID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [VR_BPGSTIN] AS [VR_BPGSTIN8]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_erpDCInventory].[ConsignerBPID] = [VR_BPGSTIN8].[BPID]'
  SET @LGSQL = @LGSQL + '    AND [SPMT_erpDCInventory].[ConsignerGSTIN] = [VR_BPGSTIN8].[GSTIN]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner9]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_erpDCInventory].[ConsignerBPID] = [VR_BusinessPartner9].[BPID]'
  SET @LGSQL = @LGSQL + '  INNER JOIN [SPMT_erpDCD] AS [SPMT_erpDCD10]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_erpDCInventory].[ChallanID] = [SPMT_erpDCD10].[ChallanID]'
  SET @LGSQL = @LGSQL + '    AND [SPMT_erpDCInventory].[SerialNo] = [SPMT_erpDCD10].[SerialNo]'
  SET @LGSQL = @LGSQL + '  WHERE 1 = 1 '
  IF (@Filter_ChallanID > '') 
    SET @LGSQL = @LGSQL + ' AND [SPMT_erpDCInventory].[ChallanID] = ''' + @Filter_ChallanID + ''''
  SET @LGSQL = @LGSQL + '  ORDER BY '
  SET @LGSQL = @LGSQL + CASE @OrderBy
                        WHEN 'ChallanID' THEN '[SPMT_erpDCInventory].[ChallanID]'
                        WHEN 'ChallanID DESC' THEN '[SPMT_erpDCInventory].[ChallanID] DESC'
                        WHEN 'SerialNo' THEN '[SPMT_erpDCInventory].[SerialNo]'
                        WHEN 'SerialNo DESC' THEN '[SPMT_erpDCInventory].[SerialNo] DESC'
                        WHEN 'ItemDescription' THEN '[SPMT_erpDCInventory].[ItemDescription]'
                        WHEN 'ItemDescription DESC' THEN '[SPMT_erpDCInventory].[ItemDescription] DESC'
                        WHEN 'BaseRate' THEN '[SPMT_erpDCInventory].[BaseRate]'
                        WHEN 'BaseRate DESC' THEN '[SPMT_erpDCInventory].[BaseRate] DESC'
                        WHEN 'BillTypeID' THEN '[SPMT_erpDCInventory].[BillTypeID]'
                        WHEN 'BillTypeID DESC' THEN '[SPMT_erpDCInventory].[BillTypeID] DESC'
                        WHEN 'HSNSACCode' THEN '[SPMT_erpDCInventory].[HSNSACCode]'
                        WHEN 'HSNSACCode DESC' THEN '[SPMT_erpDCInventory].[HSNSACCode] DESC'
                        WHEN 'UOM' THEN '[SPMT_erpDCInventory].[UOM]'
                        WHEN 'UOM DESC' THEN '[SPMT_erpDCInventory].[UOM] DESC'
                        WHEN 'Quantity' THEN '[SPMT_erpDCInventory].[Quantity]'
                        WHEN 'Quantity DESC' THEN '[SPMT_erpDCInventory].[Quantity] DESC'
                        WHEN 'Price' THEN '[SPMT_erpDCInventory].[Price]'
                        WHEN 'Price DESC' THEN '[SPMT_erpDCInventory].[Price] DESC'
                        WHEN 'AssessableValue' THEN '[SPMT_erpDCInventory].[AssessableValue]'
                        WHEN 'AssessableValue DESC' THEN '[SPMT_erpDCInventory].[AssessableValue] DESC'
                        WHEN 'IGSTRate' THEN '[SPMT_erpDCInventory].[IGSTRate]'
                        WHEN 'IGSTRate DESC' THEN '[SPMT_erpDCInventory].[IGSTRate] DESC'
                        WHEN 'IGSTAmount' THEN '[SPMT_erpDCInventory].[IGSTAmount]'
                        WHEN 'IGSTAmount DESC' THEN '[SPMT_erpDCInventory].[IGSTAmount] DESC'
                        WHEN 'SGSTRate' THEN '[SPMT_erpDCInventory].[SGSTRate]'
                        WHEN 'SGSTRate DESC' THEN '[SPMT_erpDCInventory].[SGSTRate] DESC'
                        WHEN 'SGSTAmount' THEN '[SPMT_erpDCInventory].[SGSTAmount]'
                        WHEN 'SGSTAmount DESC' THEN '[SPMT_erpDCInventory].[SGSTAmount] DESC'
                        WHEN 'CGSTRate' THEN '[SPMT_erpDCInventory].[CGSTRate]'
                        WHEN 'CGSTRate DESC' THEN '[SPMT_erpDCInventory].[CGSTRate] DESC'
                        WHEN 'CGSTAmount' THEN '[SPMT_erpDCInventory].[CGSTAmount]'
                        WHEN 'CGSTAmount DESC' THEN '[SPMT_erpDCInventory].[CGSTAmount] DESC'
                        WHEN 'CessRate' THEN '[SPMT_erpDCInventory].[CessRate]'
                        WHEN 'CessRate DESC' THEN '[SPMT_erpDCInventory].[CessRate] DESC'
                        WHEN 'CessAmount' THEN '[SPMT_erpDCInventory].[CessAmount]'
                        WHEN 'CessAmount DESC' THEN '[SPMT_erpDCInventory].[CessAmount] DESC'
                        WHEN 'TotalGST' THEN '[SPMT_erpDCInventory].[TotalGST]'
                        WHEN 'TotalGST DESC' THEN '[SPMT_erpDCInventory].[TotalGST] DESC'
                        WHEN 'TotalAmount' THEN '[SPMT_erpDCInventory].[TotalAmount]'
                        WHEN 'TotalAmount DESC' THEN '[SPMT_erpDCInventory].[TotalAmount] DESC'
                        WHEN 'FinalRate' THEN '[SPMT_erpDCInventory].[FinalRate]'
                        WHEN 'FinalRate DESC' THEN '[SPMT_erpDCInventory].[FinalRate] DESC'
                        WHEN 'FinalAmount' THEN '[SPMT_erpDCInventory].[FinalAmount]'
                        WHEN 'FinalAmount DESC' THEN '[SPMT_erpDCInventory].[FinalAmount] DESC'
                        WHEN 'ConsignerIsgecID' THEN '[SPMT_erpDCInventory].[ConsignerIsgecID]'
                        WHEN 'ConsignerIsgecID DESC' THEN '[SPMT_erpDCInventory].[ConsignerIsgecID] DESC'
                        WHEN 'ConsignerBPID' THEN '[SPMT_erpDCInventory].[ConsignerBPID]'
                        WHEN 'ConsignerBPID DESC' THEN '[SPMT_erpDCInventory].[ConsignerBPID] DESC'
                        WHEN 'ConsignerGSTIN' THEN '[SPMT_erpDCInventory].[ConsignerGSTIN]'
                        WHEN 'ConsignerGSTIN DESC' THEN '[SPMT_erpDCInventory].[ConsignerGSTIN] DESC'
                        WHEN 'ConsignerName' THEN '[SPMT_erpDCInventory].[ConsignerName]'
                        WHEN 'ConsignerName DESC' THEN '[SPMT_erpDCInventory].[ConsignerName] DESC'
                        WHEN 'ConsignerGSTINNo' THEN '[SPMT_erpDCInventory].[ConsignerGSTINNo]'
                        WHEN 'ConsignerGSTINNo DESC' THEN '[SPMT_erpDCInventory].[ConsignerGSTINNo] DESC'
                        WHEN 'ConsignerStateID' THEN '[SPMT_erpDCInventory].[ConsignerStateID]'
                        WHEN 'ConsignerStateID DESC' THEN '[SPMT_erpDCInventory].[ConsignerStateID] DESC'
                        WHEN 'ProjectID' THEN '[SPMT_erpDCInventory].[ProjectID]'
                        WHEN 'ProjectID DESC' THEN '[SPMT_erpDCInventory].[ProjectID] DESC'
                        WHEN 'QuantityUsed' THEN '[SPMT_erpDCInventory].[QuantityUsed]'
                        WHEN 'QuantityUsed DESC' THEN '[SPMT_erpDCInventory].[QuantityUsed] DESC'
                        WHEN 'IDM_Projects1_Description' THEN '[IDM_Projects1].[Description]'
                        WHEN 'IDM_Projects1_Description DESC' THEN '[IDM_Projects1].[Description] DESC'
                        WHEN 'SPMT_BillTypes2_Description' THEN '[SPMT_BillTypes2].[Description]'
                        WHEN 'SPMT_BillTypes2_Description DESC' THEN '[SPMT_BillTypes2].[Description] DESC'
                        WHEN 'SPMT_erpDCH3_PlaceOfDelivery' THEN '[SPMT_erpDCH3].[PlaceOfDelivery]'
                        WHEN 'SPMT_erpDCH3_PlaceOfDelivery DESC' THEN '[SPMT_erpDCH3].[PlaceOfDelivery] DESC'
                        WHEN 'SPMT_ERPStates4_Description' THEN '[SPMT_ERPStates4].[Description]'
                        WHEN 'SPMT_ERPStates4_Description DESC' THEN '[SPMT_ERPStates4].[Description] DESC'
                        WHEN 'SPMT_ERPUnits5_Description' THEN '[SPMT_ERPUnits5].[Description]'
                        WHEN 'SPMT_ERPUnits5_Description DESC' THEN '[SPMT_ERPUnits5].[Description] DESC'
                        WHEN 'SPMT_HSNSACCodes6_HSNSACCode' THEN '[SPMT_HSNSACCodes6].[HSNSACCode]'
                        WHEN 'SPMT_HSNSACCodes6_HSNSACCode DESC' THEN '[SPMT_HSNSACCodes6].[HSNSACCode] DESC'
                        WHEN 'SPMT_IsgecGSTIN7_Description' THEN '[SPMT_IsgecGSTIN7].[Description]'
                        WHEN 'SPMT_IsgecGSTIN7_Description DESC' THEN '[SPMT_IsgecGSTIN7].[Description] DESC'
                        WHEN 'VR_BPGSTIN8_Description' THEN '[VR_BPGSTIN8].[Description]'
                        WHEN 'VR_BPGSTIN8_Description DESC' THEN '[VR_BPGSTIN8].[Description] DESC'
                        WHEN 'VR_BusinessPartner9_BPName' THEN '[VR_BusinessPartner9].[BPName]'
                        WHEN 'VR_BusinessPartner9_BPName DESC' THEN '[VR_BusinessPartner9].[BPName] DESC'
                        WHEN 'SPMT_erpDCD10_ItemDescription' THEN '[SPMT_erpDCD10].[ItemDescription]'
                        WHEN 'SPMT_erpDCD10_ItemDescription DESC' THEN '[SPMT_erpDCD10].[ItemDescription] DESC'
                        ELSE '[SPMT_erpDCInventory].[ChallanID],[SPMT_erpDCInventory].[SerialNo]'
                    END
  EXEC (@LGSQL)

  SET @RecordCount = @@RowCount

  SELECT
    [SPMT_erpDCInventory].* ,
    [IDM_Projects1].[Description] AS IDM_Projects1_Description,
    [SPMT_BillTypes2].[Description] AS SPMT_BillTypes2_Description,
    [SPMT_erpDCH3].[PlaceOfDelivery] AS SPMT_erpDCH3_PlaceOfDelivery,
    [SPMT_ERPStates4].[Description] AS SPMT_ERPStates4_Description,
    [SPMT_ERPUnits5].[Description] AS SPMT_ERPUnits5_Description,
    [SPMT_HSNSACCodes6].[HSNSACCode] AS SPMT_HSNSACCodes6_HSNSACCode,
    [SPMT_IsgecGSTIN7].[Description] AS SPMT_IsgecGSTIN7_Description,
    [VR_BPGSTIN8].[Description] AS VR_BPGSTIN8_Description,
    [VR_BusinessPartner9].[BPName] AS VR_BusinessPartner9_BPName,
    [SPMT_erpDCD10].[ItemDescription] AS SPMT_erpDCD10_ItemDescription 
  FROM [SPMT_erpDCInventory] 
      INNER JOIN #PageIndex
          ON [SPMT_erpDCInventory].[ChallanID] = #PageIndex.ChallanID
          AND [SPMT_erpDCInventory].[SerialNo] = #PageIndex.SerialNo
  LEFT OUTER JOIN [IDM_Projects] AS [IDM_Projects1]
    ON [SPMT_erpDCInventory].[ProjectID] = [IDM_Projects1].[ProjectID]
  LEFT OUTER JOIN [SPMT_BillTypes] AS [SPMT_BillTypes2]
    ON [SPMT_erpDCInventory].[BillTypeID] = [SPMT_BillTypes2].[BillType]
  INNER JOIN [SPMT_erpDCH] AS [SPMT_erpDCH3]
    ON [SPMT_erpDCInventory].[ChallanID] = [SPMT_erpDCH3].[ChallanID]
  LEFT OUTER JOIN [SPMT_ERPStates] AS [SPMT_ERPStates4]
    ON [SPMT_erpDCInventory].[ConsignerStateID] = [SPMT_ERPStates4].[StateID]
  LEFT OUTER JOIN [SPMT_ERPUnits] AS [SPMT_ERPUnits5]
    ON [SPMT_erpDCInventory].[UOM] = [SPMT_ERPUnits5].[UOM]
  LEFT OUTER JOIN [SPMT_HSNSACCodes] AS [SPMT_HSNSACCodes6]
    ON [SPMT_erpDCInventory].[BillTypeID] = [SPMT_HSNSACCodes6].[BillType]
    AND [SPMT_erpDCInventory].[HSNSACCode] = [SPMT_HSNSACCodes6].[HSNSACCode]
  LEFT OUTER JOIN [SPMT_IsgecGSTIN] AS [SPMT_IsgecGSTIN7]
    ON [SPMT_erpDCInventory].[ConsignerIsgecID] = [SPMT_IsgecGSTIN7].[GSTID]
  LEFT OUTER JOIN [VR_BPGSTIN] AS [VR_BPGSTIN8]
    ON [SPMT_erpDCInventory].[ConsignerBPID] = [VR_BPGSTIN8].[BPID]
    AND [SPMT_erpDCInventory].[ConsignerGSTIN] = [VR_BPGSTIN8].[GSTIN]
  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner9]
    ON [SPMT_erpDCInventory].[ConsignerBPID] = [VR_BusinessPartner9].[BPID]
  INNER JOIN [SPMT_erpDCD] AS [SPMT_erpDCD10]
    ON [SPMT_erpDCInventory].[ChallanID] = [SPMT_erpDCD10].[ChallanID]
    AND [SPMT_erpDCInventory].[SerialNo] = [SPMT_erpDCD10].[SerialNo]
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
