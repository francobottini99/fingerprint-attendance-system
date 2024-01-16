<?php
	include "ConexionBD.php";

	$fila = mysqli_fetch_row(mysqli_query($Conn, "SELECT * FROM Conexion WHERE idConexion = 1"));

	echo "<p>" .  $fila[2];

	mysqli_close($Conn);
?>