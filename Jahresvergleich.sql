/****** Skript für SelectTopNRows-Befehl aus SSMS ******/
SELECT TOP (1000) [Id]
      ,[Date]
      ,[CustomerId]
      ,[IsInvoiceGenerated]
  FROM [SemesterarbeitDBS].[dbo].[Order]



SELECT 'Kategorie' as KATEGORIE, 'YOY' as YOY, CustomerId, Id,
CASE
	WHEN DATEPART(QUARTER, [Date]) = 1
	THEN (count(Id) OVER (Partition By CustomerId
						  Order By CustomerId))
		ELSE 0
END AS Q1, 
CASE
	WHEN DATEPART(QUARTER, [Date]) = 2
	THEN (count(Id) OVER (Partition By CustomerId
						  Order By CustomerId))
		ELSE 0
END AS Q2,
CASE
	WHEN DATEPART(QUARTER, [Date]) = 3
	THEN (count(Id) OVER (Partition By CustomerId
						  Order By CustomerId))
		ELSE 0
END AS Q3,
CASE
	WHEN DATEPART(QUARTER, [Date]) = 4
	THEN (count(Id) OVER (Partition By CustomerId
						  Order By CustomerId))
		ELSE 0
END AS Q4
FROM [dbo].[Order] as o
Group By CustomerId, Id, [Date];

-- SUM(DATEPART(QUARTER, [Date])