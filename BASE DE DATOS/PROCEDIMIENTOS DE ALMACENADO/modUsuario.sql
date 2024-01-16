CREATE DEFINER=`root`@`localhost` PROCEDURE `modUsuario`(
	in IdU int(11),
    in uNombre varchar(255),
    in uClave varchar(255),
    in uCargo varchar(45)
)
BEGIN
	UPDATE Usuarios
	SET 
		Nombre= uNombre,
		Clave = uClave,
        Cargo = uCargo
	WHERE 
		idUsuarios = IdU;
END