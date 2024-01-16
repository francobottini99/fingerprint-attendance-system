<?php
	include "ConexionBD.php";

	mysqli_query($Conn, "UPDATE Conexion SET Lector = 'ABIERTO' WHERE idConexion = 1");

	mysqli_close($Conn);
?>