USE ITPM



	SELECT 
			ProjectKey
		,	ProjectName
		,	ProjectConcept
		,	StatusName
	 FROM Project P
	INNER JOIN Status S
		ON P.StatusKey = S.StatusKey
	--ORDER BY ProjectKey DESC
	   -- Break on some condition




/*

SELECT * FROM Scope
SELECT * FROM Purpose
SELECT * FROM Project
SELECT * FROM Status
SELECT * FROM Stage

*/