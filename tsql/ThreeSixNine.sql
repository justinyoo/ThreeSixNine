
CREATE PROCEDURE [dbo].[spThreeSixNine]
(
	@maxRange int
)
AS

DECLARE @seed INT = 1;
DECLARE @Numbers TABLE
(
	[Number] INT PRIMARY KEY
)

WHILE @seed < (@maxRange + 1)
BEGIN
	INSERT INTO @Numbers
	SELECT @seed;

	SELECT @seed = @seed + 1;
END

SELECT
	[Number],
	REPLICATE('X',
		LEN(CAST([Number] AS VARCHAR(12))) - LEN(REPLACE(CAST([Number] AS VARCHAR(12)),'3',''))
		+ LEN(CAST([Number] AS VARCHAR(12))) - LEN(REPLACE(CAST([Number] AS VARCHAR(12)),'6',''))
		+ LEN(CAST([Number] AS VARCHAR(12))) - LEN(REPLACE(CAST([Number] AS VARCHAR(12)),'9',''))
	) AS [Claps]
FROM @Numbers;

-- Execute:
EXEC [dbo].[spThreeSixNine] 100

/*
	Number      Clap
	----------- -----------------
	1           
	2           
	3           X
	4           
	5           
	6           X
	7           
	8           
	9           X
	10          
	11          
	12          
	13          X
	14          
	15          
	16          X
	17          
	18          
	19          X
	20          
	21          
	22          
	23          X
	24          
	25          
	26          X
	27          
	28          
	29          X
	30          X
	31          X
	32          X
	33          XX
	34          X
	35          X
	36          XX
	37          X
	38          X
	39          XX
	40          
	41          
	42          
	43          X
	44          
	45          
	46          X
	47          
	48          
	49          X
	50          
	51          
	52          
	53          X
	54          
	55          
	56          X
	57          
	58          
	59          X
	60          X
	61          X
	62          X
	63          XX
	64          X
	65          X
	66          XX
	67          X
	68          X
	69          XX
	70          
	71          
	72          
	73          X
	74          
	75          
	76          X
	77          
	78          
	79          X
	80          
	81          
	82          
	83          X
	84          
	85          
	86          X
	87          
	88          
	89          X
	90          X
	91          X
	92          X
	93          XX
	94          X
	95          X
	96          XX
	97          X
	98          X
	99          XX
	100         

(100 row(s) affected)
*/
