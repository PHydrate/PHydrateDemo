USE [AdventureWorksLT2008]
GO

/****** Object:  StoredProcedure [dbo].[GetProduct]    Script Date: 03/01/2011 16:43:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetProduct]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetProduct]
GO

USE [AdventureWorksLT2008]
GO

/****** Object:  StoredProcedure [dbo].[GetProduct]    Script Date: 03/01/2011 16:43:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Stephen Czetty
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[GetProduct] 
	-- Add the parameters for the stored procedure here
	@ProductNumber NVARCHAR(25) = NULL, 
	@Name NVARCHAR(50) = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	DECLARE @ProductId INT
	DECLARE @ProductCategoryId INT
	DECLARE @ProductModelId INT
	DECLARE @ProductTable TABLE
	       (ProductId INT NOT NULL
	       ,ProductCategoryId INT NOT NULL
	       ,ProductModelId INT NOT NULL
	       )

    -- Insert statements for procedure here
	IF (@ProductNumber IS NOT NULL)
	BEGIN
		SELECT @ProductId = ProductID, @ProductCategoryId = ProductCategoryID, @ProductModelId = ProductModelID
		  FROM AdventureWorksLT2008.SalesLT.Product
		 WHERE ProductNumber = @ProductNumber
    END
	ELSE BEGIN
		IF (@Name IS NOT NULL)
		    INSERT INTO @ProductTable
			SELECT ProductID, ProductCategoryID, ProductModelID
			  FROM AdventureWorksLT2008.SalesLT.Product
			 WHERE Name like @Name
		ELSE
		    INSERT INTO @ProductTable
			SELECT ProductID, ProductCategoryId, ProductModelId
			  FROM AdventureWorksLT2008.SalesLT.Product
	END
	
	SELECT * FROM AdventureWorksLT2008.SalesLT.Product
	 WHERE ProductID = @ProductId
	    OR ProductID IN (SELECT ProductID FROM @ProductTable)
	 
	SELECT * FROM AdventureWorksLT2008.SalesLT.ProductCategory
	 WHERE ProductCategoryID = @ProductCategoryId
	    OR ProductCategoryID IN (SELECT ProductCategoryID FROM @ProductTable)
	 
	SELECT * FROM AdventureWorksLT2008.SalesLT.ProductModel
	 WHERE ProductModelID = @ProductModelId
	    OR ProductModelID IN (SELECT ProductModelID FROM @ProductTable)
END

GO


