CREATE DEFINER=`root`@`localhost` PROCEDURE `verCicloLectivoAño`(
	in cicA varchar(45)
)
BEGIN
	SELECT
		*
	FROM
		CicloLectivo
	WHERE
		Año = cicA;
END