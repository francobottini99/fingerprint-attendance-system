CREATE DEFINER=`root`@`localhost` PROCEDURE `insLector`(
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
	INSERT INTO Lectores (
		Nombre,
		MAC,
        DHCP,
        IPLector,
        MascSubred,
        PuertaEnlace,
        DNS,
        Estado,
        Usuarios_idUsuarios,
        Servidor_idServidor
)
	VALUES (lNombre, lMAC, lDHCP, lIPL, lIPMS, lPE, lDNS, lEstado, lIdus, lIdS);
END