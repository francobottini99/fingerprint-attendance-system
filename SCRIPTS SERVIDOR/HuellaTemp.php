<?php
	include "ConexionBD.php";

	$idHuella = $_GET['id'];
	$Modelo = $_GET['model'];

	mysqli_query($Conn, "INSERT INTO Huellas(idHuellas, Modelo, Proceso) VALUES ('$idHuella', '$Modelo', 'Esperando VB')");

	mysqli_close($Conn);
?>