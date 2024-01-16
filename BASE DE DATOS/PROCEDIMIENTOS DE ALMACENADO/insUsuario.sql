CREATE DEFINER=`root`@`localhost` PROCEDURE `insUsuario`(
	in uNombre varchar(255),
	in uClave varchar(255),
    in uCargo varchar(45)
)
BEGIN
	INSERT INTO Usuarios (
		Nombre,
		Clave,
        Cargo
)
	VALUES (uNombre, uClave, uCargo);
END