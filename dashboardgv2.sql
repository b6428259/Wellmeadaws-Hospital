CREATE VIEW NEW_REQUIT AS
SELECT W.WardName,CONCAT(S.Firstname,' ',S.LastName) AS Requitsition_BY,P.Name,P.Quantity,P.Requisitioned_Date
FROM RequitsitionPhama P
INNER JOIN  Wards W ON P.WardNumber = W.WardID
INNER JOIN  Staff S ON P.Requisitioned_By = S.StaffID;


SELECT * FROM NEW_REQUIT
ORDER BY Requisitioned_Date DESC;

DROP VIEW NEW_REQUIT;
