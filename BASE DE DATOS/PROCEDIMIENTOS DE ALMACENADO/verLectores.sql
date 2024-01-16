CREATE DEFINER=`root`@`localhost` PROCEDURE `verLectores`(
)
BEGIN
	SELECT
		*
	FROM
		Lectores
	ORDER BY 
		IPLector ASC;
END