CREATE DEFINER=`root`@`localhost` PROCEDURE `modLector`(
	in lIdL int(11),
	in lNombre varchar(255),
    in lMAC varchar(20),
	in lDHCP varchar(45),
    in lIPL varchar(20),
    in lIPMS varchar(20),
    in lPE varchar(20),
    in lDNS varchar(20),
    in lEstado varchar(45),
    in lIdus int(11),
    in lIdS int(11)
)
BEGIN
	UPDATE Lectores
	SET 
		Nombre = lNombre,
		MAC = lMAC,
        DHCP = lDHCP,
        IPLector = lIPL,
        MascSubred = lIPMS,
        PuertaEnlace = lPE,
        DNS = lDNS,
        Estado = lEstado,
        Usuarios_idUsuarios = lIdus,
        Servidor_idServidor = lIdS
	WHERE 
		idLector = lIdL;
END