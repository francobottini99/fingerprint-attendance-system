CREATE DEFINER=`root`@`localhost` PROCEDURE `verLector_MAC`(
	in lMAC varchar(20)
)
BEGIN
	SELECT
		*
	FROM
		Lectores
	WHERE
		MAC = lMAC;
END