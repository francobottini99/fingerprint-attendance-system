CREATE DEFINER=`root`@`localhost` PROCEDURE `verUltmIdHuella`(
)
BEGIN
	SELECT
		Max(Alumnos.idHuella_Digital) as UltmIDHuella
	FROM
		Alumnos
	ORDER BY 
		idHuella_Digital ASC;
END