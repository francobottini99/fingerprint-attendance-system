CREATE DEFINER=`root`@`localhost` PROCEDURE `modServidor`(
	in IdS int(11),
	in sIP varchar(20),
    in sIdUs int(11)
)
BEGIN
	UPDATE Servidor
	SET 
		IP = sIP,
        Usuarios_idUsuarios = sIdUs
	WHERE 
		idServidor = IdS;
END