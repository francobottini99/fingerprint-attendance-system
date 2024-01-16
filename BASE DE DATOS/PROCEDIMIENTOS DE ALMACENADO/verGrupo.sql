CREATE DEFINER=`root`@`localhost` PROCEDURE `verGrupo`(
)
BEGIN
	SELECT
		*
	FROM
		Grupo
	ORDER BY 
		Grupo ASC;
END